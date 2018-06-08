'TODO
'Ref Status auswerten
'Schieberegler für Servo
'Servo Prozentwert anpassen: Berechnung
'Wartezeit für Sequenz (WAI-Telegramm)
'Seq. Servo und Wartezeit dazu

'Jede Achse und jeder Servo als Objekt mit allen Einstellungen und Funktionen

Option Strict On

Public Class RoboTest
    Dim WithEvents roboControl As New classRobotControl
    Dim logger As classLogger
    Dim comLogger As classLogger
    Dim initOkay As Boolean = False
    Dim settingsChanged, progChanged As Boolean
    Dim SrvWaitForFIN As Boolean = False

    Private Sub eERR_Received(sender As Object, e As ERR_ReceivedEventArgs)
        enableControls(True)
        roboControl.stopProgram()
    End Sub

    Private Sub eFIN_Received(sender As Object, e As EventArgs)
        If Not roboControl.isProgRunning() Then
            enableControls(True)
        End If
        SrvWaitForFIN = False
    End Sub
    Private Sub eLSS_Received(sender As Object, e As LSS_ReceivedEventArgs)
        If InvokeRequired Then
            Invoke(Sub() eLSS_Received(sender, e))
            Return
        End If

        panJ1Limit.BackColor = If(e.lssState(0), Color.LightGreen, Color.Red)
        panJ2Limit.BackColor = If(e.lssState(1), Color.LightGreen, Color.Red)
        panJ3Limit.BackColor = If(e.lssState(2), Color.LightGreen, Color.Red)
        panJ4Limit.BackColor = If(e.lssState(3), Color.LightGreen, Color.Red)
        panJ5Limit.BackColor = If(e.lssState(4), Color.LightGreen, Color.Red)
        panJ6Limit.BackColor = If(e.lssState(5), Color.LightGreen, Color.Red)
    End Sub
    Private Sub eESS_Received(sender As Object, e As ESS_ReceivedEventArgs)
        If InvokeRequired Then
            Invoke(Sub() eESS_Received(sender, e))
            Return
        End If

        panEmergencyStop.BackColor = If(e.essState, Color.LightGreen, Color.Red)
    End Sub
    Private Sub eRES_Received(sender As Object, e As EventArgs)
        panJ1Ref.BackColor = Color.Red
        panJ2Ref.BackColor = Color.Red
        panJ3Ref.BackColor = Color.Red
        panJ4Ref.BackColor = Color.Red
        panJ5Ref.BackColor = Color.Red
        panJ6Ref.BackColor = Color.Red
    End Sub
    Private Sub roboControl_newPos(sender As Object, e As NewPosEventArgs) Handles roboControl.NewPos
        If InvokeRequired Then
            Invoke(Sub() roboControl_newPos(sender, e))
            Return
        End If

        If e.refOkay(0) Then
            If CDec(e.posDeg(0)) > numJ1Target.Maximum Or CDec(e.posDeg(0)) < numJ1Target.Minimum Then
                logger.doLog("J1 Achsenlimit prüfen!", classLogger.errLvl.WARN)
            Else
                panJ1Ref.BackColor = Color.LightGreen
                numJ1Target.Value = CDec(e.posDeg(0))
            End If
        Else panJ1Ref.BackColor = Color.Red
        End If
        If e.refOkay(1) Then
            If CDec(e.posDeg(1)) > numJ2Target.Maximum Or CDec(e.posDeg(1)) < numJ2Target.Minimum Then
                logger.doLog("J2 Achsenlimit prüfen!", classLogger.errLvl.WARN)
            Else
                panJ2Ref.BackColor = Color.LightGreen
                numJ2Target.Value = CDec(e.posDeg(1))
            End If
        Else panJ2Ref.BackColor = Color.Red
        End If
        If e.refOkay(2) Then
            If CDec(e.posDeg(2)) > numJ3Target.Maximum Or CDec(e.posDeg(2)) < numJ3Target.Minimum Then
                logger.doLog("J3 Achsenlimit prüfen!", classLogger.errLvl.WARN)
            Else
                panJ3Ref.BackColor = Color.LightGreen
                numJ3Target.Value = CDec(e.posDeg(2))
            End If
        Else panJ3Ref.BackColor = Color.Red
        End If
        If e.refOkay(3) Then
            If CDec(e.posDeg(3)) > numJ4Target.Maximum Or CDec(e.posDeg(3)) < numJ4Target.Minimum Then
                logger.doLog("J4 Achsenlimit prüfen!", classLogger.errLvl.WARN)
            Else
                panJ4Ref.BackColor = Color.LightGreen
                numJ4Target.Value = CDec(e.posDeg(3))
            End If
        Else panJ4Ref.BackColor = Color.Red
        End If
        If e.refOkay(4) Then
            If CDec(e.posDeg(4)) > numJ5Target.Maximum Or CDec(e.posDeg(4)) < numJ5Target.Minimum Then
                logger.doLog("J5 Achsenlimit prüfen!", classLogger.errLvl.WARN)
            Else
                panJ5Ref.BackColor = Color.LightGreen
                numJ5Target.Value = CDec(e.posDeg(4))
            End If
        Else panJ5Ref.BackColor = Color.Red
        End If
        If e.refOkay(5) Then
            If CDec(e.posDeg(5)) > numJ6Target.Maximum Or CDec(e.posDeg(5)) < numJ6Target.Minimum Then
                logger.doLog("J6 Achsenlimit prüfen!", classLogger.errLvl.WARN)
            Else
                panJ6Ref.BackColor = Color.LightGreen
                numJ6Target.Value = CDec(e.posDeg(5))
            End If
        Else panJ6Ref.BackColor = Color.Red
        End If
    End Sub
    Private Sub eSerialConnected(sender As Object, e As EventArgs)
        If InvokeRequired Then
            Invoke(Sub() eSerialConnected(sender, e))
            Return
        End If
        btnDisconnect.Enabled = True
        cmbPort.Enabled = False
        enableControls(True)
    End Sub
    Private Sub eSerialDisconnected(sender As Object, e As EventArgs)
        If InvokeRequired Then
            Invoke(Sub() eSerialDisconnected(sender, e))
            Return
        End If
        btnDisconnect.Enabled = False
        If cmbPort.Items.Count > 0 Then
            btnConnect.Enabled = True
        End If
        btnDisconnect.Enabled = False
        cmbPort.Enabled = True
        enableControls(False)
        panJ1Limit.BackColor = Color.Gray
        panJ2Limit.BackColor = Color.Gray
        panJ3Limit.BackColor = Color.Gray
        panJ4Limit.BackColor = Color.Gray
        panJ5Limit.BackColor = Color.Gray
        panJ6Limit.BackColor = Color.Gray
        panJ1Ref.BackColor = Color.Gray
        panJ2Ref.BackColor = Color.Gray
        panJ3Ref.BackColor = Color.Gray
        panJ4Ref.BackColor = Color.Gray
        panJ5Ref.BackColor = Color.Gray
        panJ6Ref.BackColor = Color.Gray
        panEmergencyStop.BackColor = Color.Gray
    End Sub
    Private Sub eComPortChanged(sender As Object, e As ComPortChangeEventArgs)
        If InvokeRequired Then
            Invoke(Sub() eComPortChanged(sender, e))
            Return
        End If

        cmbPort.Items.Clear()
        If e.Ports.Count > 0 Then
            For i = 0 To e.Ports.Count - 1
                cmbPort.Items.Add(e.Ports(i))
            Next
            cmbPort.SelectedIndex = 0
            btnConnect.Enabled = True
        Else
            btnConnect.Enabled = False
        End If
    End Sub
    Private Sub eLog(sender As Object, e As LogEventArgs)
        If e.LogLvl = classLogger.errLvl.COMIN Or e.LogLvl = classLogger.errLvl.COMOUT Then
            comLogger.doLog(e.LogMsg, e.LogLvl)
        Else
            logger.doLog(e.LogMsg, e.LogLvl)
        End If
    End Sub
    Private Sub eProgChanged(sender As Object, e As ProgChangedEventArgs)
        If InvokeRequired Then
            Invoke(Sub() eProgChanged(sender, e))
            Return
        End If
        If e.running Then
            enableControls(False)
            btnProgStop.Enabled = True
        Else
            enableControls(True)
            btnProgStop.Enabled = False
        End If
        'TeachPunkt
        If e.tp Then
            lbTeachPoints.Items.Clear()
            For Each x As TeachPoint In roboControl.teachPoints
                lbTeachPoints.Items.Add($"{x.nr}: {x.name}")
            Next
        End If
        'Program
        If e.prog Then
            lbProgramm.Items.Clear()
            Dim tmpString As String
            For Each x As ProgramEntry In roboControl.progList
                If x.func = "pos" Then
                    tmpString = $"{If(x.sync, "Sync", "Async")} Move ({roboControl.getTeachPointName(x.tpnr)}; Speed: {x.speed}; Acc: {x.acc}) ##{x.comment}"
                ElseIf x.func = "srv" Then
                    tmpString = $"Greifer bewegen (Nummer: {x.servoNum}; Winkel: {x.servoVal}) ##{x.comment}"
                ElseIf x.func = "wai" Then
                    tmpString = $"Warten (Dauer: {x.waitTimeMS} ms) ##{x.comment}"
                Else
                    tmpString = "ERROR!"
                End If
                lbProgramm.Items.Add(tmpString)
            Next
            If e.actProgIndex >= 0 Then
                lbProgramm.SelectedIndex = e.actProgIndex
            End If
        End If
    End Sub

    '##########################
    ' Formsteuerung
    '##########################
    Private Sub RoboTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Prüfen ob Konfigdatei geladen wurde
        If Not roboControl.pref.configFileLoaded Then
            Application.Exit()
            Return
        End If

        KeyPreview = True
        'Event Handler
        AddHandler roboControl.com.ComPortChange, AddressOf eComPortChanged
        AddHandler roboControl.com.SerialConnected, AddressOf eSerialConnected
        AddHandler roboControl.com.SerialDisconnected, AddressOf eSerialDisconnected
        AddHandler roboControl.Log, AddressOf eLog
        AddHandler roboControl.com.Log, AddressOf eLog
        AddHandler roboControl.com.LSS_Received, AddressOf eLSS_Received
        AddHandler roboControl.com.ESS_Received, AddressOf eESS_Received
        AddHandler roboControl.com.RES_Received, AddressOf eRES_Received
        AddHandler roboControl.com.FIN_Received, AddressOf eFIN_Received
        AddHandler roboControl.com.ERR_Received, AddressOf eERR_Received
        AddHandler roboControl.SeqListChanged, AddressOf eProgChanged

        'Logger
        logger = New classLogger(rtbLog)
        comLogger = New classLogger(rtbComLog)
        enableControls(False)

        cbAxisSelect.SelectedIndex = 0 'J1 auswählen
        cbServoSelect.SelectedIndex = 0 'Servo 1 auswählen
        cbProgFunc.SelectedIndex = 0 'Position auswählen

        initOkay = True
        recalcFormValues(False)
    End Sub
    Private Sub RoboTest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If settingsChanged Or progChanged Then
            If MessageBox.Show($"{If(settingsChanged, "Einstellungen", "")}{If(settingsChanged And progChanged, " und ", "")}{If(progChanged, "Programm/Teachpunkte", "")} wurden geändert und nicht gespeichert. Wollen sie trotzdem schließen?", "Ungespeicherte Änderungen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
             = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
    '-----------------------------------
    ' Buttons
    '-----------------------------------
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        roboControl.fastStop()
        enableControls(True)
    End Sub
    Private Sub RoboTest_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            roboControl.fastStop()
            enableControls(True)
        End If
    End Sub
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        btnConnect.Enabled = False
        roboControl.com.connect(cmbPort.Text)
    End Sub
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        roboControl.stopProgram()
        roboControl.com.disconnect()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If roboControl.doHome(cbSyncAxis.Checked, cbJ1Sel.Checked, cbJ2Sel.Checked, cbJ3Sel.Checked, cbJ4Sel.Checked, cbJ5Sel.Checked, cbJ6Sel.Checked) Then
            enableControls(False)
        End If
    End Sub
    Private Sub btnPark_Click(sender As Object, e As EventArgs) Handles btnPark.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If roboControl.doPark(cbSyncAxis.Checked, cbJ1Sel.Checked, cbJ2Sel.Checked, cbJ3Sel.Checked, cbJ4Sel.Checked, cbJ5Sel.Checked, cbJ6Sel.Checked) Then
            enableControls(False)
        End If
    End Sub
    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        If roboControl.doRef(cbJ1Sel.Checked, cbJ2Sel.Checked, cbJ3Sel.Checked, cbJ4Sel.Checked, cbJ5Sel.Checked, cbJ6Sel.Checked) Then
            enableControls(False)
        End If
    End Sub
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If roboControl.doMov(cbSyncAxis.Checked, cbJ1Sel.Checked, numJ1Target.Value, cbJ2Sel.Checked, numJ2Target.Value, cbJ3Sel.Checked, numJ3Target.Value, cbJ4Sel.Checked, numJ4Target.Value, cbJ5Sel.Checked, numJ5Target.Value, cbJ6Sel.Checked, numJ6Target.Value) Then
            enableControls(False)
        End If
    End Sub
    Private Sub btnJ1JogPos_Click(sender As Object, e As EventArgs) Handles btnJ1JogPos.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ1Steps.Checked Then
            roboControl.doJog(1, CInt(numJ1JogInterval.Value))
        Else
            roboControl.doJog(1, numJ1JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ1JogNeg_Click(sender As Object, e As EventArgs) Handles btnJ1JogNeg.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ1Steps.Checked Then
            roboControl.doJog(1, CInt(-numJ1JogInterval.Value))
        Else
            roboControl.doJog(1, -numJ1JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ2JogPos_Click(sender As Object, e As EventArgs) Handles btnJ2JogPos.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ2Steps.Checked Then
            roboControl.doJog(2, CInt(numJ2JogInterval.Value))
        Else
            roboControl.doJog(2, numJ2JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ2JogNeg_Click(sender As Object, e As EventArgs) Handles btnJ2JogNeg.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ2Steps.Checked Then
            roboControl.doJog(2, CInt(-numJ2JogInterval.Value))
        Else
            roboControl.doJog(2, -numJ2JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ3JogPos_Click(sender As Object, e As EventArgs) Handles btnJ3JogPos.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ3Steps.Checked Then
            roboControl.doJog(3, CInt(numJ3JogInterval.Value))
        Else
            roboControl.doJog(3, numJ3JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ3JogNeg_Click(sender As Object, e As EventArgs) Handles btnJ3JogNeg.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ3Steps.Checked Then
            roboControl.doJog(3, CInt(-numJ3JogInterval.Value))
        Else
            roboControl.doJog(3, -numJ3JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ4JogPos_Click(sender As Object, e As EventArgs) Handles btnJ4JogPos.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ4Steps.Checked Then
            roboControl.doJog(4, CInt(numJ4JogInterval.Value))
        Else
            roboControl.doJog(4, numJ4JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ4JogNeg_Click(sender As Object, e As EventArgs) Handles btnJ4JogNeg.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ4Steps.Checked Then
            roboControl.doJog(4, CInt(-numJ4JogInterval.Value))
        Else
            roboControl.doJog(4, -numJ4JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ5JogPos_Click(sender As Object, e As EventArgs) Handles btnJ5JogPos.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ5Steps.Checked Then
            roboControl.doJog(5, CInt(numJ5JogInterval.Value))
        Else
            roboControl.doJog(5, numJ5JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ5JogNeg_Click(sender As Object, e As EventArgs) Handles btnJ5JogNeg.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ5Steps.Checked Then
            roboControl.doJog(5, CInt(-numJ5JogInterval.Value))
        Else
            roboControl.doJog(5, -numJ5JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ6JogPos_Click(sender As Object, e As EventArgs) Handles btnJ6JogPos.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ6Steps.Checked Then
            roboControl.doJog(6, CInt(numJ6JogInterval.Value))
        Else
            roboControl.doJog(6, numJ6JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnJ6JogNeg_Click(sender As Object, e As EventArgs) Handles btnJ6JogNeg.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If radJ6Steps.Checked Then
            roboControl.doJog(6, CInt(-numJ6JogInterval.Value))
        Else
            roboControl.doJog(6, -numJ6JogInterval.Value)
        End If
        enableControls(False)
    End Sub
    Private Sub btnServo1Open_Click(sender As Object, e As EventArgs) Handles btnServo1Open.Click
        roboControl.movServo(1, roboControl.calcServoAngle(1, numServo1Open.Value))
    End Sub
    Private Sub btnServo1Close_Click(sender As Object, e As EventArgs) Handles btnServo1Close.Click
        roboControl.movServo(1, roboControl.calcServoAngle(1, numServo1Close.Value))
    End Sub
    Private Sub btnServo2Open_Click(sender As Object, e As EventArgs) Handles btnServo2Open.Click
        roboControl.movServo(2, roboControl.calcServoAngle(2, numServo2Open.Value))
    End Sub
    Private Sub btnServo2Close_Click(sender As Object, e As EventArgs) Handles btnServo2Close.Click
        roboControl.movServo(2, roboControl.calcServoAngle(2, numServo2Close.Value))
    End Sub
    Private Sub btnServo3Open_Click(sender As Object, e As EventArgs) Handles btnServo3Open.Click
        roboControl.movServo(3, roboControl.calcServoAngle(3, numServo3Open.Value))
    End Sub
    Private Sub btnServo3Close_Click(sender As Object, e As EventArgs) Handles btnServo3Close.Click
        roboControl.movServo(3, roboControl.calcServoAngle(3, numServo3Close.Value))
    End Sub
    Private Sub trbServo_Scroll(sender As Object, e As EventArgs) Handles trbServo.Scroll
        If Not SrvWaitForFIN Then
            If radSrv1.Checked Then
                numServo1Close.Value = trbServo.Value
                roboControl.movServo(1, roboControl.calcServoAngle(1, numServo1Close.Value))
            ElseIf radSrv2.Checked Then
                numServo2Close.Value = trbServo.Value
                roboControl.movServo(2, roboControl.calcServoAngle(2, numServo2Close.Value))
            ElseIf radSrv3.Checked Then
                numServo3Close.Value = trbServo.Value
                roboControl.movServo(3, roboControl.calcServoAngle(3, numServo3Close.Value))
            End If
            SrvWaitForFIN = True
        End If
    End Sub

    'TEACHPUNKTE
    Private Sub btnTpAdd_Click(sender As Object, e As EventArgs) Handles btnTpAdd.Click
        Dim item As New TeachPoint
        item.name = tbTeachPointName.Text
        item.nr = CInt(numTeachPointNum.Value)
        item.jointAngles(0) = numJ1Target.Value
        item.jointAngles(1) = numJ2Target.Value
        item.jointAngles(2) = numJ3Target.Value
        item.jointAngles(3) = numJ4Target.Value
        item.jointAngles(4) = numJ5Target.Value
        item.jointAngles(5) = numJ6Target.Value
        roboControl.addTeachPoint(item, CInt(numTeachPointNum.Value))
        numTeachPointNum.Value += 1
        progChanged = True
        tbTeachPointName.Text = ""
    End Sub
    Private Sub btnTpDel_Click(sender As Object, e As EventArgs) Handles btnTpDel.Click
        roboControl.deleteTeachPoint(lbTeachPoints.SelectedIndex)
        progChanged = True
    End Sub
    Private Sub btnTpCopy_Click(sender As Object, e As EventArgs) Handles btnTpCopy.Click

    End Sub
    Private Sub btnTpMoveTo_Click(sender As Object, e As EventArgs) Handles btnTpMoveTo.Click
        roboControl.setSpeedAndAcc(numSpeed.Value, numAcc.Value)
        If roboControl.moveToTeachPoint(lbTeachPoints.SelectedIndex, cbSyncAxis.Checked) Then
            enableControls(False)
        End If
    End Sub
    'PROGRAMM
    Private Sub cbProgFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgFunc.SelectedIndexChanged
        Select Case cbProgFunc.SelectedIndex
            Case 0 'Sync Move
                numSeqFuncValue.Enabled = False
                lblSeqFunc.Text = ""
            Case 1 'Async Move
                numSeqFuncValue.Enabled = False
                lblSeqFunc.Text = ""
            Case 2 To 3 'Greifer Öffnen / Schließen
                numSeqFuncValue.Minimum = 1
                numSeqFuncValue.Maximum = 3
                numSeqFuncValue.Value = 1
                numSeqFuncValue.Enabled = True
                lblSeqFunc.Text = "Nummer"
            Case 4 'Warten
                numSeqFuncValue.Minimum = 100
                numSeqFuncValue.Maximum = 60000
                numSeqFuncValue.Value = 500
                numSeqFuncValue.Enabled = True
                lblSeqFunc.Text = "ms"
        End Select
    End Sub
    Private Sub btnProgAddReplace_Click(sender As Object, e As EventArgs) Handles btnProgAdd.Click, btnProgReplace.Click
        Dim add As Boolean = True
        Dim item As New ProgramEntry
        item.comment = tbProgComment.Text
        Select Case cbProgFunc.SelectedIndex
            Case 0 To 1
                If lbTeachPoints.SelectedIndex >= 0 Then
                    item.func = "pos"
                    item.tpnr = roboControl.teachPoints(lbTeachPoints.SelectedIndex).nr
                    item.speed = numSpeed.Value
                    item.acc = numAcc.Value
                    item.sync = cbProgFunc.SelectedIndex = 0
                Else
                    logger.doLog("Bitte Teachpunkt auswählen!", classLogger.errLvl.WARN)
                    add = False
                End If
            Case 2
                item.func = "srv"
                item.servoNum = CInt(numSeqFuncValue.Value)
                item.servoVal = If(numSeqFuncValue.Value = 1, roboControl.calcServoAngle(1, numServo1Open.Value), If(numSeqFuncValue.Value = 2, roboControl.calcServoAngle(2, numServo2Open.Value), roboControl.calcServoAngle(3, numServo3Open.Value)))
            Case 3
                item.func = "srv"
                item.servoNum = CInt(numSeqFuncValue.Value)
                item.servoVal = If(numSeqFuncValue.Value = 1, roboControl.calcServoAngle(1, numServo1Close.Value), If(numSeqFuncValue.Value = 2, roboControl.calcServoAngle(2, numServo2Close.Value), roboControl.calcServoAngle(3, numServo3Close.Value)))
            Case 4
                item.func = "wai"
                item.waitTimeMS = CInt(numSeqFuncValue.Value)
        End Select
        If add Then
            Dim btnSender As Button = DirectCast(sender, Button)
            If btnSender.Name = btnProgAdd.Name Then
                roboControl.addProgItem(item, lbProgramm.SelectedIndex)
            ElseIf btnSender.Name = btnProgReplace.Name Then
                roboControl.replaceProgItem(item, lbProgramm.SelectedIndex)
            End If
            progChanged = True
            tbProgComment.Text = ""
        End If
    End Sub
    Private Sub btnProgCopy_Click(sender As Object, e As EventArgs) Handles btnProgCopy.Click
        Static copied As Boolean = False
        If copied Then
            roboControl.pasteProgItem(lbProgramm.SelectedIndex)
            btnProgCopy.Text = "Kopieren"
            copied = False
            progChanged = True
        Else
            If roboControl.copyProgItem(lbProgramm.SelectedIndex) Then
                btnProgCopy.Text = "Einfügen"
                copied = True
            Else
                logger.doLog("Erst Programmzeile auswählen!", classLogger.errLvl.WARN)
            End If
        End If
    End Sub
    Private Sub btnProgDel_Click(sender As Object, e As EventArgs) Handles btnProgDel.Click
        roboControl.delProgItem(lbProgramm.SelectedIndex)
        progChanged = True
    End Sub
    Private Sub btnProgExecuteLine_Click(sender As Object, e As EventArgs) Handles btnProgExecuteLine.Click
        If roboControl.executeProgItem(lbProgramm.SelectedIndex) Then
            enableControls(False)
        End If
    End Sub
    Private Sub btnProgExecute_Click(sender As Object, e As EventArgs) Handles btnProgExecute.Click
        roboControl.executeProgramm(cbSeqLoop.Checked)
        If roboControl.isProgRunning() Then
            btnProgStop.Enabled = True
        End If
    End Sub
    Private Sub btnProgStop_Click(sender As Object, e As EventArgs) Handles btnProgStop.Click
        If roboControl.isProgRunning() Then
            roboControl.stopProgram()
            btnProgStop.Enabled = False
        End If
    End Sub
    Private Sub btnProgTpSave_Click(sender As Object, e As EventArgs) Handles btnProgTpSave.Click
        If roboControl.saveProgram() Then
            progChanged = False
        End If
    End Sub
    Private Sub btnProgTpLoad_Click(sender As Object, e As EventArgs) Handles btnProgTpLoad.Click
        If Not roboControl.loadProgram() Then
            logger.doLog("Fehler beim Laden des Programms!", classLogger.errLvl.ERR)
        Else
            logger.doLog("Programm geladen!", classLogger.errLvl.INFO)
            progChanged = False
            numTeachPointNum.Value = roboControl.teachPoints(roboControl.teachPoints.Count - 1).nr + 1
        End If
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnSetLoad.Click
        If Not roboControl.pref.loadSettings() Then
            logger.doLog("Fehler beim Laden der Einstellungen!", classLogger.errLvl.ERR)
        Else
            logger.doLog("Einstellungen geladen!", classLogger.errLvl.INFO)
            lblNotSaved.Visible = False
            settingsChanged = False
        End If
        recalcFormValues(False)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSetSave.Click
        If Not roboControl.pref.saveSettings() Then
            logger.doLog("Fehler beim Speichern der Einstellungen!", classLogger.errLvl.ERR)
        Else
            logger.doLog("Einstellungen gespeichert!", classLogger.errLvl.INFO)
            lblNotSaved.Visible = False
            settingsChanged = False
        End If
    End Sub
    Private Sub btnDefaults_Click(sender As Object, e As EventArgs) Handles btnSetDefaults.Click
        If Not roboControl.pref.loadDefaulSettings() Then
            logger.doLog("Fehler beim Laden der Standardeinstellungen!", classLogger.errLvl.ERR)
        Else
            logger.doLog("Standardeinstellungen geladen!", classLogger.errLvl.INFO)
            lblNotSaved.Visible = False
            settingsChanged = False
        End If
        recalcFormValues(False)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnLogClear.Click
        rtbLog.Clear()
    End Sub
    Private Sub btnComLogClear_Click(sender As Object, e As EventArgs) Handles btnComLogClear.Click
        rtbComLog.Clear()
    End Sub
    '-----------------------------------
    ' Settings changed
    '-----------------------------------
    Private Sub settings_ValueChanged(sender As Object, e As EventArgs) Handles numStepsPerRot.Leave, numMotGear.Leave,
        cbMode.Leave, cbDir.Leave, numMechGear.Leave, numMaxAngle.Leave, numMinAngle.Leave,
        cbCalDir.Leave, numMaxSpeed.Leave, numMaxAcc.Leave, numStopAcc.Leave, numHome.Leave, numPark.Leave, numRefSpeedFast.Leave,
        numRefSpeedSlow.Leave, numRefAcc.Leave, numServoMin.Leave, numServoMax.Leave
        If initOkay Then
            recalcFormValues(True)
        End If
    End Sub
    Private Sub AxisOrServoSelector_IndexChanged(sender As Object, e As EventArgs) Handles cbAxisSelect.SelectedIndexChanged, cbServoSelect.SelectedIndexChanged
        If initOkay Then
            recalcFormValues(False)
        End If
    End Sub

    '-----------------------------------
    ' Autoscroll Logging Box
    '-----------------------------------
    Private Sub rtbLog_TextChanged(sender As Object, e As EventArgs) Handles rtbLog.TextChanged
        rtbLog.SelectionStart = rtbLog.Text.Length
        rtbLog.ScrollToCaret()
    End Sub
    '-----------------------------------
    ' Target Scrollbars
    '-----------------------------------
    Private Sub tbJ1Target_Scroll(sender As Object, e As EventArgs) Handles trbJ1Target.Scroll
        numJ1Target.Value = CDec(trbJ1Target.Value) / CDec(100)
    End Sub
    Private Sub numJ1Target_ValueChanged(sender As Object, e As EventArgs) Handles numJ1Target.ValueChanged
        If InvokeRequired Then
            Invoke(Sub() numJ1Target_ValueChanged(sender, e))
            Return
        End If

        trbJ1Target.Value = CInt(numJ1Target.Value * 100.0)
    End Sub
    Private Sub tbJ2Target_Scroll(sender As Object, e As EventArgs) Handles trbJ2Target.Scroll
        numJ2Target.Value = CDec(trbJ2Target.Value) / CDec(100)
    End Sub
    Private Sub numJ2Target_ValueChanged(sender As Object, e As EventArgs) Handles numJ2Target.ValueChanged
        If InvokeRequired Then
            Invoke(Sub() numJ2Target_ValueChanged(sender, e))
            Return
        End If

        trbJ2Target.Value = CInt(numJ2Target.Value * 100.0)
    End Sub
    Private Sub tbJ3Target_Scroll(sender As Object, e As EventArgs) Handles trbJ3Target.Scroll
        numJ3Target.Value = CDec(trbJ3Target.Value) / CDec(100)
    End Sub
    Private Sub numJ3Target_ValueChanged(sender As Object, e As EventArgs) Handles numJ3Target.ValueChanged
        If InvokeRequired Then
            Invoke(Sub() numJ3Target_ValueChanged(sender, e))
            Return
        End If

        trbJ3Target.Value = CInt(numJ3Target.Value * 100.0)
    End Sub
    Private Sub tbJ4Target_Scroll(sender As Object, e As EventArgs) Handles trbJ4Target.Scroll
        numJ4Target.Value = CDec(trbJ4Target.Value) / CDec(100)
    End Sub
    Private Sub numJ4Target_ValueChanged(sender As Object, e As EventArgs) Handles numJ4Target.ValueChanged
        If InvokeRequired Then
            Invoke(Sub() numJ4Target_ValueChanged(sender, e))
            Return
        End If

        trbJ4Target.Value = CInt(numJ4Target.Value * 100.0)
    End Sub
    Private Sub tbJ5Target_Scroll(sender As Object, e As EventArgs) Handles trbJ5Target.Scroll
        numJ5Target.Value = CDec(trbJ5Target.Value) / CDec(100)
    End Sub
    Private Sub numJ5Target_ValueChanged(sender As Object, e As EventArgs) Handles numJ5Target.ValueChanged
        If InvokeRequired Then
            Invoke(Sub() numJ5Target_ValueChanged(sender, e))
            Return
        End If

        trbJ5Target.Value = CInt(numJ5Target.Value * 100.0)
    End Sub
    Private Sub tbJ6Target_Scroll(sender As Object, e As EventArgs) Handles trbJ6Target.Scroll
        numJ6Target.Value = CDec(trbJ6Target.Value) / CDec(100)
    End Sub
    Private Sub numJ6Target_ValueChanged(sender As Object, e As EventArgs) Handles numJ6Target.ValueChanged
        If InvokeRequired Then
            Invoke(Sub() numJ6Target_ValueChanged(sender, e))
            Return
        End If


        trbJ6Target.Value = CInt(numJ6Target.Value * 100.0)
    End Sub
    '-----------------------------------
    ' Form help methods
    '-----------------------------------
    Private Sub enableControls(enabled As Boolean)
        'Handle Invoke
        If InvokeRequired Then
            Invoke(Sub() enableControls(enabled))
            Return
        End If
        btnProgExecute.Enabled = enabled
        btnProgAdd.Enabled = enabled
        btnProgReplace.Enabled = enabled
        btnProgDel.Enabled = enabled
        btnProgCopy.Enabled = enabled
        btnProgExecuteLine.Enabled = enabled
        btnTpAdd.Enabled = enabled
        btnTpCopy.Enabled = enabled
        btnTpDel.Enabled = enabled
        btnTpMoveTo.Enabled = enabled
        btnGo.Enabled = enabled
        btnRef.Enabled = enabled
        btnHome.Enabled = enabled
        btnPark.Enabled = enabled
        btnJ1JogPos.Enabled = enabled
        btnJ1JogNeg.Enabled = enabled
        btnJ2JogPos.Enabled = enabled
        btnJ2JogNeg.Enabled = enabled
        btnJ3JogPos.Enabled = enabled
        btnJ3JogNeg.Enabled = enabled
        btnJ4JogPos.Enabled = enabled
        btnJ4JogNeg.Enabled = enabled
        btnJ5JogPos.Enabled = enabled
        btnJ5JogNeg.Enabled = enabled
        btnJ6JogPos.Enabled = enabled
        btnJ6JogNeg.Enabled = enabled
        btnServo1Open.Enabled = enabled
        btnServo2Open.Enabled = enabled
        btnServo3Open.Enabled = enabled
        btnServo1Close.Enabled = enabled
        btnServo2Close.Enabled = enabled
        btnServo3Close.Enabled = enabled
    End Sub
    Private Sub recalcFormValues(changed As Boolean)
        With roboControl.pref
            'Try
            If changed Then
                .jointSettings(cbAxisSelect.SelectedIndex).mot.stepsPerRot = CInt(numStepsPerRot.Value)
                .jointSettings(cbAxisSelect.SelectedIndex).mot.gear = numMotGear.Value
                .jointSettings(cbAxisSelect.SelectedIndex).mot.mode = cbMode.SelectedIndex
                .jointSettings(cbAxisSelect.SelectedIndex).mot.dir = cbDir.SelectedIndex

                .jointSettings(cbAxisSelect.SelectedIndex).mech.gear = numMechGear.Value
                .jointSettings(cbAxisSelect.SelectedIndex).mech.minAngle = numMinAngle.Value
                .jointSettings(cbAxisSelect.SelectedIndex).mech.maxAngle = numMaxAngle.Value
                .jointSettings(cbAxisSelect.SelectedIndex).mech.homePosAngle = numHome.Value
                .jointSettings(cbAxisSelect.SelectedIndex).mech.parkPosAngle = numPark.Value

                .jointSettings(cbAxisSelect.SelectedIndex).profile.maxSpeed = numMaxSpeed.Value
                .jointSettings(cbAxisSelect.SelectedIndex).profile.maxAcc = numMaxAcc.Value
                .jointSettings(cbAxisSelect.SelectedIndex).profile.stopAcc = numStopAcc.Value

                .jointSettings(cbAxisSelect.SelectedIndex).cal.dir = cbCalDir.SelectedIndex
                .jointSettings(cbAxisSelect.SelectedIndex).cal.speedFast = numRefSpeedFast.Value
                .jointSettings(cbAxisSelect.SelectedIndex).cal.speedSlow = numRefSpeedSlow.Value
                .jointSettings(cbAxisSelect.SelectedIndex).cal.acc = numRefAcc.Value

                'Servos
                .servoSettings(cbServoSelect.SelectedIndex).minAngle = numServoMin.Value
                .servoSettings(cbServoSelect.SelectedIndex).maxAngle = numServoMax.Value

                lblNotSaved.Visible = True
                settingsChanged = True
            Else
                numStepsPerRot.Value = .jointSettings(cbAxisSelect.SelectedIndex).mot.stepsPerRot
                numMotGear.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).mot.gear)
                cbMode.SelectedIndex = .jointSettings(cbAxisSelect.SelectedIndex).mot.mode
                cbDir.SelectedIndex = .jointSettings(cbAxisSelect.SelectedIndex).mot.dir

                numMechGear.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).mech.gear)
                numMinAngle.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).mech.minAngle)
                numMaxAngle.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).mech.maxAngle)
                numHome.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).mech.homePosAngle)
                numPark.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).mech.parkPosAngle)

                numMaxSpeed.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).profile.maxSpeed)
                numMaxAcc.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).profile.maxAcc)
                numStopAcc.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).profile.stopAcc)

                cbCalDir.SelectedIndex = .jointSettings(cbAxisSelect.SelectedIndex).cal.dir
                numRefSpeedFast.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).cal.speedFast)
                numRefSpeedSlow.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).cal.speedSlow)
                numRefAcc.Value = CDec(.jointSettings(cbAxisSelect.SelectedIndex).cal.acc)

                'Servos
                numServoMin.Value = CDec(.servoSettings(cbServoSelect.SelectedIndex).minAngle)
                numServoMax.Value = CDec(.servoSettings(cbServoSelect.SelectedIndex).maxAngle)
            End If
            'Catch ex As Exception
            'End Try

            recalcMaxMinValues()
            Dim tmpSplit As String() = .getActFilename().Split("\"c)
            lblFilename.Text = tmpSplit(UBound(tmpSplit))
        End With
    End Sub
    Private Sub recalcMaxMinValues()
        With roboControl.pref
            setNumMaxMin(numJ1Target, CDec(.jointSettings(0).mech.maxAngle), CDec(.jointSettings(0).mech.minAngle))
            setTbMaxMin(trbJ1Target, CInt(.jointSettings(0).mech.maxAngle * 100.0), CInt(.jointSettings(0).mech.minAngle * 100.0))
            setNumMaxMin(numJ2Target, CDec(.jointSettings(1).mech.maxAngle), CDec(.jointSettings(1).mech.minAngle))
            setTbMaxMin(trbJ2Target, CInt(.jointSettings(1).mech.maxAngle * 100.0), CInt(.jointSettings(1).mech.minAngle * 100.0))
            setNumMaxMin(numJ3Target, CDec(.jointSettings(2).mech.maxAngle), CDec(.jointSettings(2).mech.minAngle))
            setTbMaxMin(trbJ3Target, CInt(.jointSettings(2).mech.maxAngle * 100.0), CInt(.jointSettings(2).mech.minAngle * 100.0))
            setNumMaxMin(numJ4Target, CDec(.jointSettings(3).mech.maxAngle), CDec(.jointSettings(3).mech.minAngle))
            setTbMaxMin(trbJ4Target, CInt(.jointSettings(3).mech.maxAngle * 100.0), CInt(.jointSettings(3).mech.minAngle * 100.0))
            setNumMaxMin(numJ5Target, CDec(.jointSettings(4).mech.maxAngle), CDec(.jointSettings(4).mech.minAngle))
            setTbMaxMin(trbJ5Target, CInt(.jointSettings(4).mech.maxAngle * 100.0), CInt(.jointSettings(4).mech.minAngle * 100.0))
            setNumMaxMin(numJ6Target, CDec(.jointSettings(5).mech.maxAngle), CDec(.jointSettings(5).mech.minAngle))
            setTbMaxMin(trbJ6Target, CInt(.jointSettings(5).mech.maxAngle * 100.0), CInt(.jointSettings(5).mech.minAngle * 100.0))
        End With
    End Sub
    Private Sub setNumMaxMin(ByRef num As NumericUpDown, max As Decimal, min As Decimal)
        If num.Value < min Then
            num.Value = min
        End If
        num.Minimum = min
        If num.Value > max Then
            num.Value = max
        End If
        num.Maximum = max
    End Sub
    Private Sub setTbMaxMin(ByRef tb As TrackBar, max As Int32, min As Int32)
        If tb.Value < min Then
            tb.Value = min
        End If
        tb.Minimum = min
        If tb.Value > max Then
            tb.Value = max
        End If
        tb.Maximum = max
    End Sub
End Class