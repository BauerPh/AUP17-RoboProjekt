Option Strict On
Public Class classCalculations
    Public Shared Function angleToSteps(angle As Double, motGear As Double, mechGear As Double, stepsPerRot As Int32, angleZeroOff As Double) As Int32
        Return CInt(Math.Truncate(stepsPerRot * motGear * mechGear * (angle + angleZeroOff) / 360.0))
    End Function

    Public Shared Function stepsToAngle(steps As Int32, motGear As Double, mechGear As Double, stepsPerRot As Int32, angleZeroOff As Double) As Double
        Return Math.Round((CDec(steps) / stepsPerRot * 360.0 / motGear / mechGear - angleZeroOff) * 100.0) / 100.0
    End Function

    Public Shared Function roundUp(ByVal d As Double, ByVal digits As UInt16) As Double
        Dim retval As Double = Math.Round(d, digits)
        If retval < d Then
            If digits > 0 Then
                Return retval + (1 / (10 ^ digits))
            Else
                Return retval + 1
            End If
        Else
            Return retval
        End If
    End Function

    Public Shared Function roundDown(ByVal d As Double, ByVal digits As UInt16) As Double
        Dim retval As Double = Math.Round(d, digits)
        If retval > d Then
            If digits > 0 Then
                Return retval - (1 / (10 ^ digits))
            Else
                Return retval - 1
            End If
        Else
            Return retval
        End If
    End Function

    Public Shared Function constrain(ByVal x As Double, ByVal min As Double, ByVal max As Double) As Double
        If (x >= max) Then Return max
        If (x <= min) Then Return min
        Return x
    End Function
End Class