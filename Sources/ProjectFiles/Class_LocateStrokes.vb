Imports System
Imports System.Collections.Generic
Imports System.Numerics
Imports MathNet.Numerics.LinearAlgebra
Imports Theremino_AudioInput.NetTransfer
Imports Theremino_AudioInput.SpectrumBands

Public Class LocateStrokes

    Friend Shared Property NormalizedTemplateWave As Double()
    Friend Shared Property TemplateWave As Int16()
    Friend Shared Property CurrentWave As Int16()
    Friend Shared CorrelationWithTemplate As Double
    Friend Shared DelayInSamples As Double
    Friend Shared CorrelationWithOtherWave As Double

    Private m_netTransfer As NetTransfer_Tcp
    Private m_netTransferUdp As NetTransfer_Udp

    Friend Shared Function WaitForSound(wave As WaveReader) As Int16()
        While (Not wave.isOverThreshold)
        End While
        Dim waveData As Int16() = New Int16(wave.outBuffer.Length - 1) {}
        Array.Copy(wave.outBuffer, waveData, wave.outBuffer.Length)
        Return waveData
    End Function

    Friend Shared Function GetTemplateWave(wave As WaveReader) As Double()
        ' wait for the first detected stroke
        TemplateWave = WaitForSound(wave)
        ' normalize the Template Wave
        NormalizedTemplateWave = NormalizeWave(TemplateWave)
        Return NormalizedTemplateWave
    End Function

    Friend Shared exitLocateStrokes = False
    Friend Shared Function GetStroke(waveReader As WaveReader,
                                          runningOnServer As Boolean)
        While (Not exitLocateStrokes)
            ' get the next sound big enough
            CurrentWave = WaitForSound(waveReader)
            ' check if this sound il similar enough to the template sound
            CorrelationWithTemplate = MaxCrossCorrelationNormalized(
                CurrentWave, NormalizedTemplateWave)
            exitLocateStrokes = False
            If (CorrelationWithTemplate < 0.3) Then
                ' stroke detected
                ' if it isn't connected, do nothing
                ' !!!! TODO !!!!
                If (True) Then
                    ' if it is a server, compare the waveReader data with other
                    ' received from clients
                    If runningOnServer Then
                        If CurrentWave IsNot Nothing AndAlso CurrentWave.Length > 0 Then

                        End If
                    Else
                        ' it is a client: send data to the server
                    End If
                End If
            End If
            If Not exitLocateStrokes Then
                Return CurrentWave
            Else
                Return Nothing
            End If
        End While
    End Function
    ' Calculate the delay (in samples) between two audio signals using cross-correlation
    Friend Shared Function CalculateDelayWithCrossCorrelation(a() As Double,
                                                b() As Double) As Integer
        Dim n As Integer = a.Length
        Dim maxCorr As Double = Double.MinValue
        Dim bestShift As Integer = 0
        For shift As Integer = -n + 1 To n - 1
            Dim sum As Double = 0
            For i As Integer = 0 To n - 1
                Dim j As Integer = i + shift
                If j >= 0 AndAlso j < n Then
                    sum += a(i) * b(j)
                End If
            Next
            If sum > maxCorr Then
                maxCorr = sum
                bestShift = shift
            End If
        Next
        DelayInSamples = bestShift
        CorrelationWithOtherWave = maxCorr / n

        Return bestShift ' positivo: normalizedTemplate è in ritardo di bestShift campioni rispetto ad waveReader
    End Function

    ' Per ottenere il ritardo in secondi:
    ' ritardoSecondi = bestShift / frequenzaCampionamento

    ' take a waveReader in Int16 array, converts it to double and normalize it
    ' such that the maximum absolute value is 1
    Public Shared Function NormalizeWave(wave() As Int16) As Double()
        ' convert Int16 to Double if necessary
        If wave Is Nothing OrElse wave.Length = 0 Then Return New Double() {}
        If wave.Length = 1 Then Return New Double() {CDbl(wave(0))}
        ' Normalizza il vettore
        Dim doubleWave As Double() = wave.Select(Function(x) CDbl(x)).ToArray()
        Dim maxVal As Double = doubleWave.Max(Function(x) Math.Abs(x))
        If maxVal = 0 Then Return doubleWave
        Return doubleWave.Select(Function(x) x / maxVal).ToArray()
    End Function

    ' Calcola la correlazione incrociata normalizzata
    'Public Shared Function MaxCrossCorrelationNormalized(
    '            Wave() As Int16, normalizedTemplate() As Double) As Double
    '    Dim normalizedWave As Double() = NormalizeWave(Wave)
    '    Dim n As Integer = normalizedWave.Length
    '    Dim maxCorr As Double = Double.MinValue

    '    For shift As Integer = -n + 1 To n - 1
    '        Dim sum As Double = 0
    '        For i As Integer = 0 To n - 1
    '            Dim j As Integer = i + shift
    '            If j >= 0 AndAlso j < n Then
    '                sum += normalizedWave(i) * normalizedTemplate(j)
    '            End If
    '        Next
    '        If sum > maxCorr Then
    '            maxCorr = sum
    '        End If
    '    Next
    '    Return maxCorr / n ' Media rispetto al numero di campioni
    'End Function

    Public Shared Function MaxCrossCorrelationNormalized(Wave() As Int16, normalizedTemplate() As Double) As Double
        Dim normalizedWave As Double() = NormalizeWave(Wave)
        Dim n As Integer = normalizedWave.Length

        ' Rimuovi l'offset (media) dai segnali
        Dim waveMean As Double = normalizedWave.Average()
        Dim templateMean As Double = normalizedTemplate.Average()

        For i As Integer = 0 To n - 1
            normalizedWave(i) -= waveMean
        Next

        Dim tempNormTemplate As Double() = normalizedTemplate.ToArray()
        For i As Integer = 0 To tempNormTemplate.Length - 1
            tempNormTemplate(i) -= templateMean
        Next

        ' Calcola l'energia dei segnali per normalizzazione
        Dim waveEnergy As Double = Math.Sqrt(normalizedWave.Sum(Function(x) x * x))
        Dim templateEnergy As Double = Math.Sqrt(tempNormTemplate.Sum(Function(x) x * x))

        If waveEnergy = 0 Or templateEnergy = 0 Then Return 0

        Dim maxCorr As Double = Double.MinValue

        For shift As Integer = -n + 1 To n - 1
            Dim sum As Double = 0
            Dim count As Integer = 0

            For i As Integer = 0 To n - 1
                Dim j As Integer = i + shift
                If j >= 0 AndAlso j < normalizedTemplate.Length Then
                    sum += normalizedWave(i) * tempNormTemplate(j)
                    count += 1
                End If
            Next

            ' Normalizza per la lunghezza effettiva della sovrapposizione
            If count > 0 Then
                sum = sum / (waveEnergy * templateEnergy)
                If sum > maxCorr Then
                    maxCorr = sum
                End If
            End If
        Next

        Return maxCorr ' Ora sarà un valore tra -1 e 1, con 1 indicante perfetta correlazione
    End Function

    ' Ritorna True se il suono è un "colpo" simile al template
    Public Function IsSimilar(wave() As Int16, template() As Double,
                                Optional threshold As Double = 0.7) As Boolean
        Dim maxCorr As Double = MaxCrossCorrelationNormalized(wave, template)
        Return maxCorr > threshold
    End Function
    Public Class GaussNewtonLocalization

        Public Structure Microphone
            Public X As Double
            Public Y As Double
            Public Time As Double

            Public Sub New(x As Double, y As Double, time As Double)
                Me.X = x
                Me.Y = y
                Me.Time = time
            End Sub
        End Structure

        Public Shared Function EstimateSource(mics As List(Of Microphone),
                            soundSpeed As Double,
                            Optional maxIterations As Integer = 100,
                            Optional tolerance As Double = 0.000001) As (x As Double, y As Double)
            If mics.Count < 4 Then
                Throw New ArgumentException("Servono almeno 4 microfoni per una stima robusta.")
            End If

            ' Stima iniziale: centroide dei microfoni
            Dim x As Double = 0, y As Double = 0
            For Each mic In mics
                x += mic.X
                y += mic.Y
            Next
            x /= mics.Count
            y /= mics.Count

            For iter As Integer = 0 To maxIterations - 1
                Dim J = Matrix(Of Double).Build.Dense(mics.Count, 2) ' Jacobiano
                Dim r = MathNet.Numerics.LinearAlgebra.Vector(Of Double).Build.Dense(mics.Count)     ' Residui

                For i As Integer = 0 To mics.Count - 1
                    Dim mic = mics(i)
                    Dim dx = x - mic.X
                    Dim dy = y - mic.Y
                    Dim dist = Math.Sqrt(dx * dx + dy * dy)
                    Dim predictedTime = dist / soundSpeed
                    Dim residual = mic.Time - predictedTime

                    r(i) = residual

                    If dist > 0.000001 Then
                        J(i, 0) = -dx / (soundSpeed * dist)
                        J(i, 1) = -dy / (soundSpeed * dist)
                    End If
                Next

                Dim JT = J.Transpose()
                Dim H = JT * J ' Hessiana approssimata
                Dim g = JT * r ' Gradiente

                Dim delta = H.Solve(g)

                x += delta(0)
                y += delta(1)

                If delta.L2Norm() < tolerance Then
                    Exit For
                End If
            Next

            Return (x, y)
        End Function

        'Public Shared Sub Main()
        '    Dim v As Double = 3000 ' velocità del suono nel muro (m/s)

        '    Dim microfoni As New List(Of Microphone) From {
        '        New Microphone(0, 0, 0.00000),
        '        New Microphone(1, 0, 0.00032),
        '        New Microphone(0, 1, 0.00028),
        '        New Microphone(1, 1, 0.00045)
        '    }

        '    Dim risultato = EstimateSource(microfoni, v)
        '    Console.WriteLine($"Sorgente stimata in: ({risultato.x:F4}, {risultato.y:F4}) metri")
        'End Sub

    End Class
End Class
