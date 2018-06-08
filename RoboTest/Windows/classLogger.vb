Public Class classLogger
    Private _logBox As RichTextBox

    Public Structure errLvl
        Public Const ERR As String = " ERROR "
        Public Const WARN As String = "WARNING"
        Public Const INFO As String = " INFO  "
        Public Const COMIN As String = " COM IN"
        Public Const COMOUT As String = "COM OUT"
    End Structure

    Public Sub New(ByRef LoggingBox As RichTextBox)
        _logBox = LoggingBox
    End Sub


    Public Sub doLog(msg As String, lvl As String)
        'Handle Invoke
        If _logBox.InvokeRequired Then
            _logBox.Invoke(Sub() doLog(msg, lvl))
            Return
        End If

        _logBox.Text &= Now().ToString("HH:mm:ss.fff") & " [" & lvl.ToUpper() & "] " & msg & vbCrLf
    End Sub
    Public Sub showErrMsg(msg As String)
        doLog(msg, errLvl.ERR)
        MsgBox(msg, vbCritical)
    End Sub
End Class
