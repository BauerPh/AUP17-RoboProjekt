<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoboTest
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoboTest))
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.timerCheckConnection = New System.Windows.Forms.Timer(Me.components)
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnRef = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.radJ1Steps = New System.Windows.Forms.RadioButton()
        Me.radJ1Degree = New System.Windows.Forms.RadioButton()
        Me.numJ1JogInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnJ1JogPos = New System.Windows.Forms.Button()
        Me.btnJ1JogNeg = New System.Windows.Forms.Button()
        Me.panJ1Ref = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.numJ1Target = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.trbJ1Target = New System.Windows.Forms.TrackBar()
        Me.cbJ1Sel = New System.Windows.Forms.CheckBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.numRefAcc = New System.Windows.Forms.NumericUpDown()
        Me.numRefSpeedSlow = New System.Windows.Forms.NumericUpDown()
        Me.numRefSpeedFast = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.numStopAcc = New System.Windows.Forms.NumericUpDown()
        Me.numMaxAcc = New System.Windows.Forms.NumericUpDown()
        Me.numMaxSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.numHome = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.numMinAngle = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbCalDir = New System.Windows.Forms.ComboBox()
        Me.numMaxAngle = New System.Windows.Forms.NumericUpDown()
        Me.numMechGear = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbDir = New System.Windows.Forms.ComboBox()
        Me.numMotGear = New System.Windows.Forms.NumericUpDown()
        Me.numStepsPerRot = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbMode = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnLogClear = New System.Windows.Forms.Button()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.btnPark = New System.Windows.Forms.Button()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.numAcc = New System.Windows.Forms.NumericUpDown()
        Me.numSpeed = New System.Windows.Forms.NumericUpDown()
        Me.cbSyncAxis = New System.Windows.Forms.CheckBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.btnServo3Open = New System.Windows.Forms.Button()
        Me.btnServo3Close = New System.Windows.Forms.Button()
        Me.numServo3Close = New System.Windows.Forms.NumericUpDown()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.numServo3Open = New System.Windows.Forms.NumericUpDown()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.btnServo2Open = New System.Windows.Forms.Button()
        Me.btnServo2Close = New System.Windows.Forms.Button()
        Me.numServo2Close = New System.Windows.Forms.NumericUpDown()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.numServo2Open = New System.Windows.Forms.NumericUpDown()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.btnServo1Open = New System.Windows.Forms.Button()
        Me.btnServo1Close = New System.Windows.Forms.Button()
        Me.numServo1Close = New System.Windows.Forms.NumericUpDown()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.numServo1Open = New System.Windows.Forms.NumericUpDown()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.radJ6Steps = New System.Windows.Forms.RadioButton()
        Me.radJ6Degree = New System.Windows.Forms.RadioButton()
        Me.numJ6JogInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnJ6JogPos = New System.Windows.Forms.Button()
        Me.btnJ6JogNeg = New System.Windows.Forms.Button()
        Me.panJ6Ref = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.numJ6Target = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.trbJ6Target = New System.Windows.Forms.TrackBar()
        Me.cbJ6Sel = New System.Windows.Forms.CheckBox()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.radJ5Steps = New System.Windows.Forms.RadioButton()
        Me.radJ5Degree = New System.Windows.Forms.RadioButton()
        Me.numJ5JogInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnJ5JogPos = New System.Windows.Forms.Button()
        Me.btnJ5JogNeg = New System.Windows.Forms.Button()
        Me.panJ5Ref = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.numJ5Target = New System.Windows.Forms.NumericUpDown()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.trbJ5Target = New System.Windows.Forms.TrackBar()
        Me.cbJ5Sel = New System.Windows.Forms.CheckBox()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.radJ4Steps = New System.Windows.Forms.RadioButton()
        Me.radJ4Degree = New System.Windows.Forms.RadioButton()
        Me.numJ4JogInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnJ4JogPos = New System.Windows.Forms.Button()
        Me.btnJ4JogNeg = New System.Windows.Forms.Button()
        Me.panJ4Ref = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.numJ4Target = New System.Windows.Forms.NumericUpDown()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.trbJ4Target = New System.Windows.Forms.TrackBar()
        Me.cbJ4Sel = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.radJ3Steps = New System.Windows.Forms.RadioButton()
        Me.radJ3Degree = New System.Windows.Forms.RadioButton()
        Me.numJ3JogInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnJ3JogPos = New System.Windows.Forms.Button()
        Me.btnJ3JogNeg = New System.Windows.Forms.Button()
        Me.panJ3Ref = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numJ3Target = New System.Windows.Forms.NumericUpDown()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.trbJ3Target = New System.Windows.Forms.TrackBar()
        Me.cbJ3Sel = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radJ2Steps = New System.Windows.Forms.RadioButton()
        Me.radJ2Degree = New System.Windows.Forms.RadioButton()
        Me.numJ2JogInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnJ2JogPos = New System.Windows.Forms.Button()
        Me.btnJ2JogNeg = New System.Windows.Forms.Button()
        Me.panJ2Ref = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numJ2Target = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.trbJ2Target = New System.Windows.Forms.TrackBar()
        Me.cbJ2Sel = New System.Windows.Forms.CheckBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.numPark = New System.Windows.Forms.NumericUpDown()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cbAxisSelect = New System.Windows.Forms.ComboBox()
        Me.GroupBox50 = New System.Windows.Forms.GroupBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.numServoMin = New System.Windows.Forms.NumericUpDown()
        Me.numServoMax = New System.Windows.Forms.NumericUpDown()
        Me.cbServoSelect = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.lblNotSaved = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSetSave = New System.Windows.Forms.Button()
        Me.btnSetLoad = New System.Windows.Forms.Button()
        Me.btnSetDefaults = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.panEmergencyStop = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.panJ1Limit = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.panJ2Limit = New System.Windows.Forms.Panel()
        Me.panJ6Limit = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.panJ3Limit = New System.Windows.Forms.Panel()
        Me.panJ4Limit = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.panJ5Limit = New System.Windows.Forms.Panel()
        Me.btnProgCopy = New System.Windows.Forms.Button()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.tbProgComment = New System.Windows.Forms.TextBox()
        Me.cbProgFunc = New System.Windows.Forms.ComboBox()
        Me.lblSeqFunc = New System.Windows.Forms.Label()
        Me.numSeqFuncValue = New System.Windows.Forms.NumericUpDown()
        Me.btnProgReplace = New System.Windows.Forms.Button()
        Me.btnProgTpLoad = New System.Windows.Forms.Button()
        Me.btnProgTpSave = New System.Windows.Forms.Button()
        Me.btnProgExecuteLine = New System.Windows.Forms.Button()
        Me.btnProgStop = New System.Windows.Forms.Button()
        Me.cbSeqLoop = New System.Windows.Forms.CheckBox()
        Me.btnProgExecute = New System.Windows.Forms.Button()
        Me.btnProgDel = New System.Windows.Forms.Button()
        Me.btnProgAdd = New System.Windows.Forms.Button()
        Me.lbProgramm = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Steuerung = New System.Windows.Forms.TabPage()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.btnTpDown = New System.Windows.Forms.Button()
        Me.btnTpUp = New System.Windows.Forms.Button()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.numTeachPointNum = New System.Windows.Forms.NumericUpDown()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.tbTeachPointName = New System.Windows.Forms.TextBox()
        Me.btnTpMoveTo = New System.Windows.Forms.Button()
        Me.btnTpAdd = New System.Windows.Forms.Button()
        Me.btnTpDel = New System.Windows.Forms.Button()
        Me.lbTeachPoints = New System.Windows.Forms.ListBox()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.radSrv3 = New System.Windows.Forms.RadioButton()
        Me.radSrv2 = New System.Windows.Forms.RadioButton()
        Me.radSrv1 = New System.Windows.Forms.RadioButton()
        Me.trbServo = New System.Windows.Forms.TrackBar()
        Me.Einstellungen = New System.Windows.Forms.TabPage()
        Me.ComLog = New System.Windows.Forms.TabPage()
        Me.btnComLogClear = New System.Windows.Forms.Button()
        Me.rtbComLog = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.numJ1JogInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJ1Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbJ1Target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.numRefAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRefSpeedSlow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRefSpeedFast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.numStopAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.numMinAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMechGear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.numMotGear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStepsPerRot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.numAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        CType(Me.numServo3Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numServo3Open, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox26.SuspendLayout()
        CType(Me.numServo2Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numServo2Open, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox25.SuspendLayout()
        CType(Me.numServo1Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numServo1Open, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        CType(Me.numJ6JogInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJ6Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbJ6Target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        CType(Me.numJ5JogInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJ5Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbJ5Target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        CType(Me.numJ4JogInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJ4Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbJ4Target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.numJ3JogInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJ3Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbJ3Target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numJ2JogInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJ2Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbJ2Target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        CType(Me.numPark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox50.SuspendLayout()
        CType(Me.numServoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numServoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.numSeqFuncValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Steuerung.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        CType(Me.numTeachPointNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.trbServo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Einstellungen.SuspendLayout()
        Me.ComLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbPort
        '
        Me.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(89, 19)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbPort.TabIndex = 1
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(316, 17)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 3
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Enabled = False
        Me.btnConnect.Location = New System.Drawing.Point(235, 17)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 1000000
        Me.SerialPort1.ReadTimeout = 1000
        Me.SerialPort1.ReceivedBytesThreshold = 3
        '
        'timerCheckConnection
        '
        Me.timerCheckConnection.Enabled = True
        Me.timerCheckConnection.Interval = 1000
        '
        'btnHome
        '
        Me.btnHome.Enabled = False
        Me.btnHome.Location = New System.Drawing.Point(515, 367)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(50, 23)
        Me.btnHome.TabIndex = 72
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnRef
        '
        Me.btnRef.Enabled = False
        Me.btnRef.Location = New System.Drawing.Point(434, 367)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(75, 23)
        Me.btnRef.TabIndex = 73
        Me.btnRef.Text = "Referenz"
        Me.btnRef.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox17)
        Me.GroupBox1.Controls.Add(Me.panJ1Ref)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.numJ1Target)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.trbJ1Target)
        Me.GroupBox1.Controls.Add(Me.cbJ1Sel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 168)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "J1"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.Label31)
        Me.GroupBox17.Controls.Add(Me.radJ1Steps)
        Me.GroupBox17.Controls.Add(Me.radJ1Degree)
        Me.GroupBox17.Controls.Add(Me.numJ1JogInterval)
        Me.GroupBox17.Controls.Add(Me.btnJ1JogPos)
        Me.GroupBox17.Controls.Add(Me.btnJ1JogNeg)
        Me.GroupBox17.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(189, 67)
        Me.GroupBox17.TabIndex = 37
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Jog"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 21)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 13)
        Me.Label31.TabIndex = 39
        Me.Label31.Text = "Interval:"
        '
        'radJ1Steps
        '
        Me.radJ1Steps.AutoSize = True
        Me.radJ1Steps.Location = New System.Drawing.Point(95, 44)
        Me.radJ1Steps.Name = "radJ1Steps"
        Me.radJ1Steps.Size = New System.Drawing.Size(52, 17)
        Me.radJ1Steps.TabIndex = 41
        Me.radJ1Steps.Text = "Steps"
        Me.radJ1Steps.UseVisualStyleBackColor = True
        '
        'radJ1Degree
        '
        Me.radJ1Degree.AutoSize = True
        Me.radJ1Degree.Checked = True
        Me.radJ1Degree.Location = New System.Drawing.Point(41, 44)
        Me.radJ1Degree.Name = "radJ1Degree"
        Me.radJ1Degree.Size = New System.Drawing.Size(48, 17)
        Me.radJ1Degree.TabIndex = 40
        Me.radJ1Degree.TabStop = True
        Me.radJ1Degree.Text = "Grad"
        Me.radJ1Degree.UseVisualStyleBackColor = True
        '
        'numJ1JogInterval
        '
        Me.numJ1JogInterval.DecimalPlaces = 2
        Me.numJ1JogInterval.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ1JogInterval.Location = New System.Drawing.Point(57, 17)
        Me.numJ1JogInterval.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ1JogInterval.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ1JogInterval.Name = "numJ1JogInterval"
        Me.numJ1JogInterval.Size = New System.Drawing.Size(68, 20)
        Me.numJ1JogInterval.TabIndex = 20
        Me.numJ1JogInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnJ1JogPos
        '
        Me.btnJ1JogPos.Enabled = False
        Me.btnJ1JogPos.Location = New System.Drawing.Point(160, 16)
        Me.btnJ1JogPos.Name = "btnJ1JogPos"
        Me.btnJ1JogPos.Size = New System.Drawing.Size(23, 23)
        Me.btnJ1JogPos.TabIndex = 22
        Me.btnJ1JogPos.Text = "+"
        Me.btnJ1JogPos.UseVisualStyleBackColor = True
        '
        'btnJ1JogNeg
        '
        Me.btnJ1JogNeg.Enabled = False
        Me.btnJ1JogNeg.Location = New System.Drawing.Point(131, 16)
        Me.btnJ1JogNeg.Name = "btnJ1JogNeg"
        Me.btnJ1JogNeg.Size = New System.Drawing.Size(23, 23)
        Me.btnJ1JogNeg.TabIndex = 21
        Me.btnJ1JogNeg.Text = "-"
        Me.btnJ1JogNeg.UseVisualStyleBackColor = True
        '
        'panJ1Ref
        '
        Me.panJ1Ref.BackColor = System.Drawing.Color.Gray
        Me.panJ1Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ1Ref.Location = New System.Drawing.Point(174, 19)
        Me.panJ1Ref.Name = "panJ1Ref"
        Me.panJ1Ref.Size = New System.Drawing.Size(15, 15)
        Me.panJ1Ref.TabIndex = 38
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(115, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(53, 13)
        Me.Label30.TabIndex = 33
        Me.Label30.Text = "Referenz:"
        '
        'numJ1Target
        '
        Me.numJ1Target.DecimalPlaces = 2
        Me.numJ1Target.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ1Target.Location = New System.Drawing.Point(121, 41)
        Me.numJ1Target.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ1Target.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ1Target.Name = "numJ1Target"
        Me.numJ1Target.Size = New System.Drawing.Size(68, 20)
        Me.numJ1Target.TabIndex = 11
        Me.numJ1Target.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ziel (in Grad):"
        '
        'trbJ1Target
        '
        Me.trbJ1Target.AutoSize = False
        Me.trbJ1Target.BackColor = System.Drawing.SystemColors.Window
        Me.trbJ1Target.LargeChange = 10
        Me.trbJ1Target.Location = New System.Drawing.Point(7, 67)
        Me.trbJ1Target.Maximum = 100000
        Me.trbJ1Target.Minimum = -100000
        Me.trbJ1Target.Name = "trbJ1Target"
        Me.trbJ1Target.Size = New System.Drawing.Size(188, 20)
        Me.trbJ1Target.TabIndex = 12
        Me.trbJ1Target.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cbJ1Sel
        '
        Me.cbJ1Sel.AutoSize = True
        Me.cbJ1Sel.Checked = True
        Me.cbJ1Sel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbJ1Sel.Location = New System.Drawing.Point(7, 20)
        Me.cbJ1Sel.Name = "cbJ1Sel"
        Me.cbJ1Sel.Size = New System.Drawing.Size(81, 17)
        Me.cbJ1Sel.TabIndex = 10
        Me.cbJ1Sel.Text = "Ausgewählt"
        Me.cbJ1Sel.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Enabled = False
        Me.btnGo.Location = New System.Drawing.Point(353, 367)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 71
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.numRefAcc)
        Me.GroupBox10.Controls.Add(Me.numRefSpeedSlow)
        Me.GroupBox10.Controls.Add(Me.numRefSpeedFast)
        Me.GroupBox10.Controls.Add(Me.Label18)
        Me.GroupBox10.Controls.Add(Me.Label22)
        Me.GroupBox10.Controls.Add(Me.Label23)
        Me.GroupBox10.Location = New System.Drawing.Point(194, 195)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(180, 98)
        Me.GroupBox10.TabIndex = 13
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Referenz"
        '
        'numRefAcc
        '
        Me.numRefAcc.DecimalPlaces = 2
        Me.numRefAcc.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numRefAcc.Location = New System.Drawing.Point(114, 72)
        Me.numRefAcc.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numRefAcc.Name = "numRefAcc"
        Me.numRefAcc.Size = New System.Drawing.Size(60, 20)
        Me.numRefAcc.TabIndex = 15
        Me.numRefAcc.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'numRefSpeedSlow
        '
        Me.numRefSpeedSlow.DecimalPlaces = 2
        Me.numRefSpeedSlow.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numRefSpeedSlow.Location = New System.Drawing.Point(114, 46)
        Me.numRefSpeedSlow.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numRefSpeedSlow.Name = "numRefSpeedSlow"
        Me.numRefSpeedSlow.Size = New System.Drawing.Size(60, 20)
        Me.numRefSpeedSlow.TabIndex = 14
        Me.numRefSpeedSlow.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'numRefSpeedFast
        '
        Me.numRefSpeedFast.DecimalPlaces = 2
        Me.numRefSpeedFast.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numRefSpeedFast.Location = New System.Drawing.Point(114, 20)
        Me.numRefSpeedFast.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numRefSpeedFast.Name = "numRefSpeedFast"
        Me.numRefSpeedFast.Size = New System.Drawing.Size(60, 20)
        Me.numRefSpeedFast.TabIndex = 13
        Me.numRefSpeedFast.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Beschl. (°/s²):"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Ref-Geschw. (°/s):"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(98, 13)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Suchgeschw. (°/s):"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label55)
        Me.GroupBox9.Controls.Add(Me.numStopAcc)
        Me.GroupBox9.Controls.Add(Me.numMaxAcc)
        Me.GroupBox9.Controls.Add(Me.numMaxSpeed)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 195)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(180, 98)
        Me.GroupBox9.TabIndex = 12
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Profil"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(6, 74)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(96, 13)
        Me.Label55.TabIndex = 24
        Me.Label55.Text = "Stop Beschl. (°/s²):"
        '
        'numStopAcc
        '
        Me.numStopAcc.DecimalPlaces = 2
        Me.numStopAcc.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numStopAcc.Location = New System.Drawing.Point(114, 72)
        Me.numStopAcc.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numStopAcc.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numStopAcc.Name = "numStopAcc"
        Me.numStopAcc.Size = New System.Drawing.Size(60, 20)
        Me.numStopAcc.TabIndex = 23
        Me.numStopAcc.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'numMaxAcc
        '
        Me.numMaxAcc.DecimalPlaces = 2
        Me.numMaxAcc.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numMaxAcc.Location = New System.Drawing.Point(114, 46)
        Me.numMaxAcc.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numMaxAcc.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numMaxAcc.Name = "numMaxAcc"
        Me.numMaxAcc.Size = New System.Drawing.Size(60, 20)
        Me.numMaxAcc.TabIndex = 11
        Me.numMaxAcc.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'numMaxSpeed
        '
        Me.numMaxSpeed.DecimalPlaces = 2
        Me.numMaxSpeed.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numMaxSpeed.Location = New System.Drawing.Point(114, 20)
        Me.numMaxSpeed.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numMaxSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numMaxSpeed.Name = "numMaxSpeed"
        Me.numMaxSpeed.Size = New System.Drawing.Size(60, 20)
        Me.numMaxSpeed.TabIndex = 10
        Me.numMaxSpeed.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Beschl. (°/s²):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Geschwindigkeit (°/s):"
        '
        'numHome
        '
        Me.numHome.DecimalPlaces = 2
        Me.numHome.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numHome.Location = New System.Drawing.Point(114, 19)
        Me.numHome.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numHome.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numHome.Name = "numHome"
        Me.numHome.Size = New System.Drawing.Size(60, 20)
        Me.numHome.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Home (in °):"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.numMinAngle)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.cbCalDir)
        Me.GroupBox8.Controls.Add(Me.numMaxAngle)
        Me.GroupBox8.Controls.Add(Me.numMechGear)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Location = New System.Drawing.Point(194, 64)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(180, 125)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Mechanik"
        '
        'numMinAngle
        '
        Me.numMinAngle.Location = New System.Drawing.Point(114, 45)
        Me.numMinAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numMinAngle.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numMinAngle.Name = "numMinAngle"
        Me.numMinAngle.Size = New System.Drawing.Size(60, 20)
        Me.numMinAngle.TabIndex = 7
        Me.numMinAngle.Value = New Decimal(New Integer() {170, 0, 0, -2147483648})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Ref. Richtung:"
        '
        'cbCalDir
        '
        Me.cbCalDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCalDir.FormattingEnabled = True
        Me.cbCalDir.Items.AddRange(New Object() {"min", "max"})
        Me.cbCalDir.Location = New System.Drawing.Point(114, 98)
        Me.cbCalDir.Name = "cbCalDir"
        Me.cbCalDir.Size = New System.Drawing.Size(60, 21)
        Me.cbCalDir.TabIndex = 9
        '
        'numMaxAngle
        '
        Me.numMaxAngle.Location = New System.Drawing.Point(114, 72)
        Me.numMaxAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numMaxAngle.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numMaxAngle.Name = "numMaxAngle"
        Me.numMaxAngle.Size = New System.Drawing.Size(60, 20)
        Me.numMaxAngle.TabIndex = 8
        Me.numMaxAngle.Value = New Decimal(New Integer() {170, 0, 0, 0})
        '
        'numMechGear
        '
        Me.numMechGear.DecimalPlaces = 3
        Me.numMechGear.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numMechGear.Location = New System.Drawing.Point(114, 19)
        Me.numMechGear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMechGear.Name = "numMechGear"
        Me.numMechGear.Size = New System.Drawing.Size(60, 20)
        Me.numMechGear.TabIndex = 6
        Me.numMechGear.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "min Winkel:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "max Winkel:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Übersetzung:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.cbDir)
        Me.GroupBox7.Controls.Add(Me.numMotGear)
        Me.GroupBox7.Controls.Add(Me.numStepsPerRot)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.cbMode)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(180, 125)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Motordaten"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Drehrichtung:"
        '
        'cbDir
        '
        Me.cbDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDir.FormattingEnabled = True
        Me.cbDir.Items.AddRange(New Object() {"normal", "invertiert"})
        Me.cbDir.Location = New System.Drawing.Point(114, 98)
        Me.cbDir.Name = "cbDir"
        Me.cbDir.Size = New System.Drawing.Size(60, 21)
        Me.cbDir.TabIndex = 5
        '
        'numMotGear
        '
        Me.numMotGear.DecimalPlaces = 3
        Me.numMotGear.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numMotGear.Location = New System.Drawing.Point(114, 45)
        Me.numMotGear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMotGear.Name = "numMotGear"
        Me.numMotGear.Size = New System.Drawing.Size(60, 20)
        Me.numMotGear.TabIndex = 3
        Me.numMotGear.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'numStepsPerRot
        '
        Me.numStepsPerRot.Location = New System.Drawing.Point(114, 19)
        Me.numStepsPerRot.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numStepsPerRot.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numStepsPerRot.Name = "numStepsPerRot"
        Me.numStepsPerRot.Size = New System.Drawing.Size(60, 20)
        Me.numStepsPerRot.TabIndex = 2
        Me.numStepsPerRot.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Betriebsart:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Getriebe:"
        '
        'cbMode
        '
        Me.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMode.FormattingEnabled = True
        Me.cbMode.Items.AddRange(New Object() {"FULL", "HALF", "MIC_4", "MIC_8", "MIC_16"})
        Me.cbMode.Location = New System.Drawing.Point(114, 71)
        Me.cbMode.Name = "cbMode"
        Me.cbMode.Size = New System.Drawing.Size(60, 21)
        Me.cbMode.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Schritte/U:"
        '
        'btnLogClear
        '
        Me.btnLogClear.Location = New System.Drawing.Point(958, 135)
        Me.btnLogClear.Name = "btnLogClear"
        Me.btnLogClear.Size = New System.Drawing.Size(75, 23)
        Me.btnLogClear.TabIndex = 2
        Me.btnLogClear.Text = "Clear"
        Me.btnLogClear.UseVisualStyleBackColor = True
        '
        'rtbLog
        '
        Me.rtbLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLog.Location = New System.Drawing.Point(6, 19)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.rtbLog.Size = New System.Drawing.Size(946, 139)
        Me.rtbLog.TabIndex = 0
        Me.rtbLog.Text = ""
        Me.rtbLog.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Port:"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label3)
        Me.GroupBox11.Controls.Add(Me.cmbPort)
        Me.GroupBox11.Controls.Add(Me.btnConnect)
        Me.GroupBox11.Controls.Add(Me.btnDisconnect)
        Me.GroupBox11.Location = New System.Drawing.Point(501, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(397, 52)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Verbindung"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.btnPark)
        Me.GroupBox12.Controls.Add(Me.Label53)
        Me.GroupBox12.Controls.Add(Me.Label52)
        Me.GroupBox12.Controls.Add(Me.numAcc)
        Me.GroupBox12.Controls.Add(Me.numSpeed)
        Me.GroupBox12.Controls.Add(Me.cbSyncAxis)
        Me.GroupBox12.Controls.Add(Me.GroupBox24)
        Me.GroupBox12.Controls.Add(Me.GroupBox6)
        Me.GroupBox12.Controls.Add(Me.GroupBox20)
        Me.GroupBox12.Controls.Add(Me.GroupBox22)
        Me.GroupBox12.Controls.Add(Me.GroupBox4)
        Me.GroupBox12.Controls.Add(Me.GroupBox2)
        Me.GroupBox12.Controls.Add(Me.GroupBox1)
        Me.GroupBox12.Controls.Add(Me.btnGo)
        Me.GroupBox12.Controls.Add(Me.btnRef)
        Me.GroupBox12.Controls.Add(Me.btnHome)
        Me.GroupBox12.Location = New System.Drawing.Point(501, 64)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(852, 399)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Steuerung"
        '
        'btnPark
        '
        Me.btnPark.Enabled = False
        Me.btnPark.Location = New System.Drawing.Point(571, 367)
        Me.btnPark.Name = "btnPark"
        Me.btnPark.Size = New System.Drawing.Size(50, 23)
        Me.btnPark.TabIndex = 82
        Me.btnPark.Text = "Park"
        Me.btnPark.UseVisualStyleBackColor = True
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(157, 372)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(68, 13)
        Me.Label53.TabIndex = 81
        Me.Label53.Text = "Beschl. (°/s):"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(10, 372)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(75, 13)
        Me.Label52.TabIndex = 24
        Me.Label52.Text = "Geschw. (°/s):"
        '
        'numAcc
        '
        Me.numAcc.DecimalPlaces = 2
        Me.numAcc.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numAcc.Location = New System.Drawing.Point(231, 368)
        Me.numAcc.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numAcc.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numAcc.Name = "numAcc"
        Me.numAcc.Size = New System.Drawing.Size(60, 20)
        Me.numAcc.TabIndex = 24
        Me.numAcc.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'numSpeed
        '
        Me.numSpeed.DecimalPlaces = 2
        Me.numSpeed.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numSpeed.Location = New System.Drawing.Point(91, 368)
        Me.numSpeed.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numSpeed.Name = "numSpeed"
        Me.numSpeed.Size = New System.Drawing.Size(60, 20)
        Me.numSpeed.TabIndex = 24
        Me.numSpeed.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'cbSyncAxis
        '
        Me.cbSyncAxis.AutoSize = True
        Me.cbSyncAxis.Checked = True
        Me.cbSyncAxis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSyncAxis.Location = New System.Drawing.Point(297, 370)
        Me.cbSyncAxis.Name = "cbSyncAxis"
        Me.cbSyncAxis.Size = New System.Drawing.Size(50, 17)
        Me.cbSyncAxis.TabIndex = 70
        Me.cbSyncAxis.Text = "Sync"
        Me.cbSyncAxis.UseVisualStyleBackColor = True
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.GroupBox27)
        Me.GroupBox24.Controls.Add(Me.GroupBox26)
        Me.GroupBox24.Controls.Add(Me.GroupBox25)
        Me.GroupBox24.Location = New System.Drawing.Point(627, 19)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(215, 371)
        Me.GroupBox24.TabIndex = 80
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Servos"
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.btnServo3Open)
        Me.GroupBox27.Controls.Add(Me.btnServo3Close)
        Me.GroupBox27.Controls.Add(Me.numServo3Close)
        Me.GroupBox27.Controls.Add(Me.Label47)
        Me.GroupBox27.Controls.Add(Me.numServo3Open)
        Me.GroupBox27.Controls.Add(Me.Label48)
        Me.GroupBox27.Location = New System.Drawing.Point(6, 253)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(201, 111)
        Me.GroupBox27.TabIndex = 3
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "Nr. 3"
        '
        'btnServo3Open
        '
        Me.btnServo3Open.Enabled = False
        Me.btnServo3Open.Location = New System.Drawing.Point(22, 74)
        Me.btnServo3Open.Name = "btnServo3Open"
        Me.btnServo3Open.Size = New System.Drawing.Size(75, 23)
        Me.btnServo3Open.TabIndex = 3
        Me.btnServo3Open.Text = "Öffnen"
        Me.btnServo3Open.UseVisualStyleBackColor = True
        '
        'btnServo3Close
        '
        Me.btnServo3Close.Enabled = False
        Me.btnServo3Close.Location = New System.Drawing.Point(103, 74)
        Me.btnServo3Close.Name = "btnServo3Close"
        Me.btnServo3Close.Size = New System.Drawing.Size(75, 23)
        Me.btnServo3Close.TabIndex = 4
        Me.btnServo3Close.Text = "Schließen"
        Me.btnServo3Close.UseVisualStyleBackColor = True
        '
        'numServo3Close
        '
        Me.numServo3Close.DecimalPlaces = 2
        Me.numServo3Close.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numServo3Close.Location = New System.Drawing.Point(121, 43)
        Me.numServo3Close.Name = "numServo3Close"
        Me.numServo3Close.Size = New System.Drawing.Size(68, 20)
        Me.numServo3Close.TabIndex = 2
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(12, 46)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(95, 13)
        Me.Label47.TabIndex = 33
        Me.Label47.Text = "Pos Geschl. (in %):"
        '
        'numServo3Open
        '
        Me.numServo3Open.DecimalPlaces = 2
        Me.numServo3Open.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numServo3Open.Location = New System.Drawing.Point(121, 17)
        Me.numServo3Open.Name = "numServo3Open"
        Me.numServo3Open.Size = New System.Drawing.Size(68, 20)
        Me.numServo3Open.TabIndex = 1
        Me.numServo3Open.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(12, 21)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(85, 13)
        Me.Label48.TabIndex = 12
        Me.Label48.Text = "Pos Offen (in %):"
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.btnServo2Open)
        Me.GroupBox26.Controls.Add(Me.btnServo2Close)
        Me.GroupBox26.Controls.Add(Me.numServo2Close)
        Me.GroupBox26.Controls.Add(Me.Label44)
        Me.GroupBox26.Controls.Add(Me.numServo2Open)
        Me.GroupBox26.Controls.Add(Me.Label46)
        Me.GroupBox26.Location = New System.Drawing.Point(6, 136)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(201, 111)
        Me.GroupBox26.TabIndex = 2
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "Nr. 2"
        '
        'btnServo2Open
        '
        Me.btnServo2Open.Enabled = False
        Me.btnServo2Open.Location = New System.Drawing.Point(22, 74)
        Me.btnServo2Open.Name = "btnServo2Open"
        Me.btnServo2Open.Size = New System.Drawing.Size(75, 23)
        Me.btnServo2Open.TabIndex = 3
        Me.btnServo2Open.Text = "Öffnen"
        Me.btnServo2Open.UseVisualStyleBackColor = True
        '
        'btnServo2Close
        '
        Me.btnServo2Close.Enabled = False
        Me.btnServo2Close.Location = New System.Drawing.Point(103, 74)
        Me.btnServo2Close.Name = "btnServo2Close"
        Me.btnServo2Close.Size = New System.Drawing.Size(75, 23)
        Me.btnServo2Close.TabIndex = 4
        Me.btnServo2Close.Text = "Schließen"
        Me.btnServo2Close.UseVisualStyleBackColor = True
        '
        'numServo2Close
        '
        Me.numServo2Close.DecimalPlaces = 2
        Me.numServo2Close.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numServo2Close.Location = New System.Drawing.Point(121, 43)
        Me.numServo2Close.Name = "numServo2Close"
        Me.numServo2Close.Size = New System.Drawing.Size(68, 20)
        Me.numServo2Close.TabIndex = 2
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(12, 46)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(95, 13)
        Me.Label44.TabIndex = 33
        Me.Label44.Text = "Pos Geschl. (in %):"
        '
        'numServo2Open
        '
        Me.numServo2Open.DecimalPlaces = 2
        Me.numServo2Open.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numServo2Open.Location = New System.Drawing.Point(121, 17)
        Me.numServo2Open.Name = "numServo2Open"
        Me.numServo2Open.Size = New System.Drawing.Size(68, 20)
        Me.numServo2Open.TabIndex = 1
        Me.numServo2Open.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(12, 21)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(85, 13)
        Me.Label46.TabIndex = 12
        Me.Label46.Text = "Pos Offen (in %):"
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.btnServo1Open)
        Me.GroupBox25.Controls.Add(Me.btnServo1Close)
        Me.GroupBox25.Controls.Add(Me.numServo1Close)
        Me.GroupBox25.Controls.Add(Me.Label43)
        Me.GroupBox25.Controls.Add(Me.numServo1Open)
        Me.GroupBox25.Controls.Add(Me.Label45)
        Me.GroupBox25.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(201, 111)
        Me.GroupBox25.TabIndex = 1
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Nr. 1"
        '
        'btnServo1Open
        '
        Me.btnServo1Open.Enabled = False
        Me.btnServo1Open.Location = New System.Drawing.Point(22, 74)
        Me.btnServo1Open.Name = "btnServo1Open"
        Me.btnServo1Open.Size = New System.Drawing.Size(75, 23)
        Me.btnServo1Open.TabIndex = 3
        Me.btnServo1Open.Text = "Öffnen"
        Me.btnServo1Open.UseVisualStyleBackColor = True
        '
        'btnServo1Close
        '
        Me.btnServo1Close.Enabled = False
        Me.btnServo1Close.Location = New System.Drawing.Point(103, 74)
        Me.btnServo1Close.Name = "btnServo1Close"
        Me.btnServo1Close.Size = New System.Drawing.Size(75, 23)
        Me.btnServo1Close.TabIndex = 4
        Me.btnServo1Close.Text = "Schließen"
        Me.btnServo1Close.UseVisualStyleBackColor = True
        '
        'numServo1Close
        '
        Me.numServo1Close.DecimalPlaces = 2
        Me.numServo1Close.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numServo1Close.Location = New System.Drawing.Point(121, 43)
        Me.numServo1Close.Name = "numServo1Close"
        Me.numServo1Close.Size = New System.Drawing.Size(68, 20)
        Me.numServo1Close.TabIndex = 2
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(12, 46)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(95, 13)
        Me.Label43.TabIndex = 33
        Me.Label43.Text = "Pos Geschl. (in %):"
        '
        'numServo1Open
        '
        Me.numServo1Open.DecimalPlaces = 2
        Me.numServo1Open.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numServo1Open.Location = New System.Drawing.Point(121, 17)
        Me.numServo1Open.Name = "numServo1Open"
        Me.numServo1Open.Size = New System.Drawing.Size(68, 20)
        Me.numServo1Open.TabIndex = 1
        Me.numServo1Open.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(12, 21)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(85, 13)
        Me.Label45.TabIndex = 12
        Me.Label45.Text = "Pos Offen (in %):"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox19)
        Me.GroupBox6.Controls.Add(Me.panJ6Ref)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Controls.Add(Me.numJ6Target)
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Controls.Add(Me.trbJ6Target)
        Me.GroupBox6.Controls.Add(Me.cbJ6Sel)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox6.Location = New System.Drawing.Point(420, 193)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(201, 168)
        Me.GroupBox6.TabIndex = 60
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "J6"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.Label33)
        Me.GroupBox19.Controls.Add(Me.radJ6Steps)
        Me.GroupBox19.Controls.Add(Me.radJ6Degree)
        Me.GroupBox19.Controls.Add(Me.numJ6JogInterval)
        Me.GroupBox19.Controls.Add(Me.btnJ6JogPos)
        Me.GroupBox19.Controls.Add(Me.btnJ6JogNeg)
        Me.GroupBox19.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(189, 67)
        Me.GroupBox19.TabIndex = 37
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Jog"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 21)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 13)
        Me.Label33.TabIndex = 39
        Me.Label33.Text = "Interval:"
        '
        'radJ6Steps
        '
        Me.radJ6Steps.AutoSize = True
        Me.radJ6Steps.Location = New System.Drawing.Point(95, 44)
        Me.radJ6Steps.Name = "radJ6Steps"
        Me.radJ6Steps.Size = New System.Drawing.Size(52, 17)
        Me.radJ6Steps.TabIndex = 41
        Me.radJ6Steps.Text = "Steps"
        Me.radJ6Steps.UseVisualStyleBackColor = True
        '
        'radJ6Degree
        '
        Me.radJ6Degree.AutoSize = True
        Me.radJ6Degree.Checked = True
        Me.radJ6Degree.Location = New System.Drawing.Point(41, 44)
        Me.radJ6Degree.Name = "radJ6Degree"
        Me.radJ6Degree.Size = New System.Drawing.Size(48, 17)
        Me.radJ6Degree.TabIndex = 40
        Me.radJ6Degree.TabStop = True
        Me.radJ6Degree.Text = "Grad"
        Me.radJ6Degree.UseVisualStyleBackColor = True
        '
        'numJ6JogInterval
        '
        Me.numJ6JogInterval.DecimalPlaces = 2
        Me.numJ6JogInterval.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ6JogInterval.Location = New System.Drawing.Point(57, 17)
        Me.numJ6JogInterval.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ6JogInterval.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ6JogInterval.Name = "numJ6JogInterval"
        Me.numJ6JogInterval.Size = New System.Drawing.Size(68, 20)
        Me.numJ6JogInterval.TabIndex = 20
        Me.numJ6JogInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnJ6JogPos
        '
        Me.btnJ6JogPos.Enabled = False
        Me.btnJ6JogPos.Location = New System.Drawing.Point(160, 16)
        Me.btnJ6JogPos.Name = "btnJ6JogPos"
        Me.btnJ6JogPos.Size = New System.Drawing.Size(23, 23)
        Me.btnJ6JogPos.TabIndex = 22
        Me.btnJ6JogPos.Text = "+"
        Me.btnJ6JogPos.UseVisualStyleBackColor = True
        '
        'btnJ6JogNeg
        '
        Me.btnJ6JogNeg.Enabled = False
        Me.btnJ6JogNeg.Location = New System.Drawing.Point(131, 16)
        Me.btnJ6JogNeg.Name = "btnJ6JogNeg"
        Me.btnJ6JogNeg.Size = New System.Drawing.Size(23, 23)
        Me.btnJ6JogNeg.TabIndex = 21
        Me.btnJ6JogNeg.Text = "-"
        Me.btnJ6JogNeg.UseVisualStyleBackColor = True
        '
        'panJ6Ref
        '
        Me.panJ6Ref.BackColor = System.Drawing.Color.Gray
        Me.panJ6Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ6Ref.Location = New System.Drawing.Point(174, 19)
        Me.panJ6Ref.Name = "panJ6Ref"
        Me.panJ6Ref.Size = New System.Drawing.Size(15, 15)
        Me.panJ6Ref.TabIndex = 38
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(115, 21)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 13)
        Me.Label34.TabIndex = 33
        Me.Label34.Text = "Referenz:"
        '
        'numJ6Target
        '
        Me.numJ6Target.DecimalPlaces = 2
        Me.numJ6Target.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ6Target.Location = New System.Drawing.Point(121, 41)
        Me.numJ6Target.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ6Target.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ6Target.Name = "numJ6Target"
        Me.numJ6Target.Size = New System.Drawing.Size(68, 20)
        Me.numJ6Target.TabIndex = 11
        Me.numJ6Target.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(12, 43)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(70, 13)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "Ziel (in Grad):"
        '
        'trbJ6Target
        '
        Me.trbJ6Target.AutoSize = False
        Me.trbJ6Target.BackColor = System.Drawing.SystemColors.Window
        Me.trbJ6Target.LargeChange = 10
        Me.trbJ6Target.Location = New System.Drawing.Point(7, 67)
        Me.trbJ6Target.Maximum = 100000
        Me.trbJ6Target.Minimum = -100000
        Me.trbJ6Target.Name = "trbJ6Target"
        Me.trbJ6Target.Size = New System.Drawing.Size(188, 20)
        Me.trbJ6Target.TabIndex = 12
        Me.trbJ6Target.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cbJ6Sel
        '
        Me.cbJ6Sel.AutoSize = True
        Me.cbJ6Sel.Checked = True
        Me.cbJ6Sel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbJ6Sel.Location = New System.Drawing.Point(7, 20)
        Me.cbJ6Sel.Name = "cbJ6Sel"
        Me.cbJ6Sel.Size = New System.Drawing.Size(81, 17)
        Me.cbJ6Sel.TabIndex = 10
        Me.cbJ6Sel.Text = "Ausgewählt"
        Me.cbJ6Sel.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.GroupBox21)
        Me.GroupBox20.Controls.Add(Me.panJ5Ref)
        Me.GroupBox20.Controls.Add(Me.Label38)
        Me.GroupBox20.Controls.Add(Me.numJ5Target)
        Me.GroupBox20.Controls.Add(Me.Label39)
        Me.GroupBox20.Controls.Add(Me.trbJ5Target)
        Me.GroupBox20.Controls.Add(Me.cbJ5Sel)
        Me.GroupBox20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox20.Location = New System.Drawing.Point(213, 193)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(201, 168)
        Me.GroupBox20.TabIndex = 50
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "J5"
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.Label37)
        Me.GroupBox21.Controls.Add(Me.radJ5Steps)
        Me.GroupBox21.Controls.Add(Me.radJ5Degree)
        Me.GroupBox21.Controls.Add(Me.numJ5JogInterval)
        Me.GroupBox21.Controls.Add(Me.btnJ5JogPos)
        Me.GroupBox21.Controls.Add(Me.btnJ5JogNeg)
        Me.GroupBox21.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(189, 67)
        Me.GroupBox21.TabIndex = 37
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Jog"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 21)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(45, 13)
        Me.Label37.TabIndex = 39
        Me.Label37.Text = "Interval:"
        '
        'radJ5Steps
        '
        Me.radJ5Steps.AutoSize = True
        Me.radJ5Steps.Location = New System.Drawing.Point(95, 44)
        Me.radJ5Steps.Name = "radJ5Steps"
        Me.radJ5Steps.Size = New System.Drawing.Size(52, 17)
        Me.radJ5Steps.TabIndex = 41
        Me.radJ5Steps.Text = "Steps"
        Me.radJ5Steps.UseVisualStyleBackColor = True
        '
        'radJ5Degree
        '
        Me.radJ5Degree.AutoSize = True
        Me.radJ5Degree.Checked = True
        Me.radJ5Degree.Location = New System.Drawing.Point(41, 44)
        Me.radJ5Degree.Name = "radJ5Degree"
        Me.radJ5Degree.Size = New System.Drawing.Size(48, 17)
        Me.radJ5Degree.TabIndex = 40
        Me.radJ5Degree.TabStop = True
        Me.radJ5Degree.Text = "Grad"
        Me.radJ5Degree.UseVisualStyleBackColor = True
        '
        'numJ5JogInterval
        '
        Me.numJ5JogInterval.DecimalPlaces = 2
        Me.numJ5JogInterval.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ5JogInterval.Location = New System.Drawing.Point(57, 17)
        Me.numJ5JogInterval.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ5JogInterval.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ5JogInterval.Name = "numJ5JogInterval"
        Me.numJ5JogInterval.Size = New System.Drawing.Size(68, 20)
        Me.numJ5JogInterval.TabIndex = 20
        Me.numJ5JogInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnJ5JogPos
        '
        Me.btnJ5JogPos.Enabled = False
        Me.btnJ5JogPos.Location = New System.Drawing.Point(160, 16)
        Me.btnJ5JogPos.Name = "btnJ5JogPos"
        Me.btnJ5JogPos.Size = New System.Drawing.Size(23, 23)
        Me.btnJ5JogPos.TabIndex = 22
        Me.btnJ5JogPos.Text = "+"
        Me.btnJ5JogPos.UseVisualStyleBackColor = True
        '
        'btnJ5JogNeg
        '
        Me.btnJ5JogNeg.Enabled = False
        Me.btnJ5JogNeg.Location = New System.Drawing.Point(131, 16)
        Me.btnJ5JogNeg.Name = "btnJ5JogNeg"
        Me.btnJ5JogNeg.Size = New System.Drawing.Size(23, 23)
        Me.btnJ5JogNeg.TabIndex = 21
        Me.btnJ5JogNeg.Text = "-"
        Me.btnJ5JogNeg.UseVisualStyleBackColor = True
        '
        'panJ5Ref
        '
        Me.panJ5Ref.BackColor = System.Drawing.Color.Gray
        Me.panJ5Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ5Ref.Location = New System.Drawing.Point(174, 19)
        Me.panJ5Ref.Name = "panJ5Ref"
        Me.panJ5Ref.Size = New System.Drawing.Size(15, 15)
        Me.panJ5Ref.TabIndex = 38
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(115, 21)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(53, 13)
        Me.Label38.TabIndex = 33
        Me.Label38.Text = "Referenz:"
        '
        'numJ5Target
        '
        Me.numJ5Target.DecimalPlaces = 2
        Me.numJ5Target.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ5Target.Location = New System.Drawing.Point(121, 41)
        Me.numJ5Target.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ5Target.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ5Target.Name = "numJ5Target"
        Me.numJ5Target.Size = New System.Drawing.Size(68, 20)
        Me.numJ5Target.TabIndex = 11
        Me.numJ5Target.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(12, 43)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(70, 13)
        Me.Label39.TabIndex = 12
        Me.Label39.Text = "Ziel (in Grad):"
        '
        'trbJ5Target
        '
        Me.trbJ5Target.AutoSize = False
        Me.trbJ5Target.BackColor = System.Drawing.SystemColors.Window
        Me.trbJ5Target.LargeChange = 10
        Me.trbJ5Target.Location = New System.Drawing.Point(7, 67)
        Me.trbJ5Target.Maximum = 100000
        Me.trbJ5Target.Minimum = -100000
        Me.trbJ5Target.Name = "trbJ5Target"
        Me.trbJ5Target.Size = New System.Drawing.Size(188, 20)
        Me.trbJ5Target.TabIndex = 12
        Me.trbJ5Target.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cbJ5Sel
        '
        Me.cbJ5Sel.AutoSize = True
        Me.cbJ5Sel.Checked = True
        Me.cbJ5Sel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbJ5Sel.Location = New System.Drawing.Point(7, 20)
        Me.cbJ5Sel.Name = "cbJ5Sel"
        Me.cbJ5Sel.Size = New System.Drawing.Size(81, 17)
        Me.cbJ5Sel.TabIndex = 10
        Me.cbJ5Sel.Text = "Ausgewählt"
        Me.cbJ5Sel.UseVisualStyleBackColor = True
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.GroupBox23)
        Me.GroupBox22.Controls.Add(Me.panJ4Ref)
        Me.GroupBox22.Controls.Add(Me.Label41)
        Me.GroupBox22.Controls.Add(Me.numJ4Target)
        Me.GroupBox22.Controls.Add(Me.Label42)
        Me.GroupBox22.Controls.Add(Me.trbJ4Target)
        Me.GroupBox22.Controls.Add(Me.cbJ4Sel)
        Me.GroupBox22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox22.Location = New System.Drawing.Point(6, 193)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(201, 168)
        Me.GroupBox22.TabIndex = 40
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "J4"
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.Label40)
        Me.GroupBox23.Controls.Add(Me.radJ4Steps)
        Me.GroupBox23.Controls.Add(Me.radJ4Degree)
        Me.GroupBox23.Controls.Add(Me.numJ4JogInterval)
        Me.GroupBox23.Controls.Add(Me.btnJ4JogPos)
        Me.GroupBox23.Controls.Add(Me.btnJ4JogNeg)
        Me.GroupBox23.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(189, 67)
        Me.GroupBox23.TabIndex = 37
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Jog"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(6, 21)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(45, 13)
        Me.Label40.TabIndex = 39
        Me.Label40.Text = "Interval:"
        '
        'radJ4Steps
        '
        Me.radJ4Steps.AutoSize = True
        Me.radJ4Steps.Location = New System.Drawing.Point(95, 44)
        Me.radJ4Steps.Name = "radJ4Steps"
        Me.radJ4Steps.Size = New System.Drawing.Size(52, 17)
        Me.radJ4Steps.TabIndex = 41
        Me.radJ4Steps.Text = "Steps"
        Me.radJ4Steps.UseVisualStyleBackColor = True
        '
        'radJ4Degree
        '
        Me.radJ4Degree.AutoSize = True
        Me.radJ4Degree.Checked = True
        Me.radJ4Degree.Location = New System.Drawing.Point(41, 44)
        Me.radJ4Degree.Name = "radJ4Degree"
        Me.radJ4Degree.Size = New System.Drawing.Size(48, 17)
        Me.radJ4Degree.TabIndex = 40
        Me.radJ4Degree.TabStop = True
        Me.radJ4Degree.Text = "Grad"
        Me.radJ4Degree.UseVisualStyleBackColor = True
        '
        'numJ4JogInterval
        '
        Me.numJ4JogInterval.DecimalPlaces = 2
        Me.numJ4JogInterval.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ4JogInterval.Location = New System.Drawing.Point(57, 17)
        Me.numJ4JogInterval.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ4JogInterval.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ4JogInterval.Name = "numJ4JogInterval"
        Me.numJ4JogInterval.Size = New System.Drawing.Size(68, 20)
        Me.numJ4JogInterval.TabIndex = 20
        Me.numJ4JogInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnJ4JogPos
        '
        Me.btnJ4JogPos.Enabled = False
        Me.btnJ4JogPos.Location = New System.Drawing.Point(160, 16)
        Me.btnJ4JogPos.Name = "btnJ4JogPos"
        Me.btnJ4JogPos.Size = New System.Drawing.Size(23, 23)
        Me.btnJ4JogPos.TabIndex = 22
        Me.btnJ4JogPos.Text = "+"
        Me.btnJ4JogPos.UseVisualStyleBackColor = True
        '
        'btnJ4JogNeg
        '
        Me.btnJ4JogNeg.Enabled = False
        Me.btnJ4JogNeg.Location = New System.Drawing.Point(131, 16)
        Me.btnJ4JogNeg.Name = "btnJ4JogNeg"
        Me.btnJ4JogNeg.Size = New System.Drawing.Size(23, 23)
        Me.btnJ4JogNeg.TabIndex = 21
        Me.btnJ4JogNeg.Text = "-"
        Me.btnJ4JogNeg.UseVisualStyleBackColor = True
        '
        'panJ4Ref
        '
        Me.panJ4Ref.BackColor = System.Drawing.Color.Gray
        Me.panJ4Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ4Ref.Location = New System.Drawing.Point(174, 19)
        Me.panJ4Ref.Name = "panJ4Ref"
        Me.panJ4Ref.Size = New System.Drawing.Size(15, 15)
        Me.panJ4Ref.TabIndex = 38
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(115, 21)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(53, 13)
        Me.Label41.TabIndex = 33
        Me.Label41.Text = "Referenz:"
        '
        'numJ4Target
        '
        Me.numJ4Target.DecimalPlaces = 2
        Me.numJ4Target.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ4Target.Location = New System.Drawing.Point(121, 41)
        Me.numJ4Target.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ4Target.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ4Target.Name = "numJ4Target"
        Me.numJ4Target.Size = New System.Drawing.Size(68, 20)
        Me.numJ4Target.TabIndex = 11
        Me.numJ4Target.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(12, 43)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(70, 13)
        Me.Label42.TabIndex = 12
        Me.Label42.Text = "Ziel (in Grad):"
        '
        'trbJ4Target
        '
        Me.trbJ4Target.AutoSize = False
        Me.trbJ4Target.BackColor = System.Drawing.SystemColors.Window
        Me.trbJ4Target.LargeChange = 10
        Me.trbJ4Target.Location = New System.Drawing.Point(7, 67)
        Me.trbJ4Target.Maximum = 100000
        Me.trbJ4Target.Minimum = -100000
        Me.trbJ4Target.Name = "trbJ4Target"
        Me.trbJ4Target.Size = New System.Drawing.Size(188, 20)
        Me.trbJ4Target.TabIndex = 12
        Me.trbJ4Target.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cbJ4Sel
        '
        Me.cbJ4Sel.AutoSize = True
        Me.cbJ4Sel.Checked = True
        Me.cbJ4Sel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbJ4Sel.Location = New System.Drawing.Point(7, 20)
        Me.cbJ4Sel.Name = "cbJ4Sel"
        Me.cbJ4Sel.Size = New System.Drawing.Size(81, 17)
        Me.cbJ4Sel.TabIndex = 10
        Me.cbJ4Sel.Text = "Ausgewählt"
        Me.cbJ4Sel.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.panJ3Ref)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.numJ3Target)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.trbJ3Target)
        Me.GroupBox4.Controls.Add(Me.cbJ3Sel)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Location = New System.Drawing.Point(420, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(201, 168)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "J3"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.radJ3Steps)
        Me.GroupBox5.Controls.Add(Me.radJ3Degree)
        Me.GroupBox5.Controls.Add(Me.numJ3JogInterval)
        Me.GroupBox5.Controls.Add(Me.btnJ3JogPos)
        Me.GroupBox5.Controls.Add(Me.btnJ3JogNeg)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(189, 67)
        Me.GroupBox5.TabIndex = 37
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Jog"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Interval:"
        '
        'radJ3Steps
        '
        Me.radJ3Steps.AutoSize = True
        Me.radJ3Steps.Location = New System.Drawing.Point(95, 44)
        Me.radJ3Steps.Name = "radJ3Steps"
        Me.radJ3Steps.Size = New System.Drawing.Size(52, 17)
        Me.radJ3Steps.TabIndex = 41
        Me.radJ3Steps.Text = "Steps"
        Me.radJ3Steps.UseVisualStyleBackColor = True
        '
        'radJ3Degree
        '
        Me.radJ3Degree.AutoSize = True
        Me.radJ3Degree.Checked = True
        Me.radJ3Degree.Location = New System.Drawing.Point(41, 44)
        Me.radJ3Degree.Name = "radJ3Degree"
        Me.radJ3Degree.Size = New System.Drawing.Size(48, 17)
        Me.radJ3Degree.TabIndex = 40
        Me.radJ3Degree.TabStop = True
        Me.radJ3Degree.Text = "Grad"
        Me.radJ3Degree.UseVisualStyleBackColor = True
        '
        'numJ3JogInterval
        '
        Me.numJ3JogInterval.DecimalPlaces = 2
        Me.numJ3JogInterval.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ3JogInterval.Location = New System.Drawing.Point(57, 17)
        Me.numJ3JogInterval.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ3JogInterval.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ3JogInterval.Name = "numJ3JogInterval"
        Me.numJ3JogInterval.Size = New System.Drawing.Size(68, 20)
        Me.numJ3JogInterval.TabIndex = 20
        Me.numJ3JogInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnJ3JogPos
        '
        Me.btnJ3JogPos.Enabled = False
        Me.btnJ3JogPos.Location = New System.Drawing.Point(160, 16)
        Me.btnJ3JogPos.Name = "btnJ3JogPos"
        Me.btnJ3JogPos.Size = New System.Drawing.Size(23, 23)
        Me.btnJ3JogPos.TabIndex = 22
        Me.btnJ3JogPos.Text = "+"
        Me.btnJ3JogPos.UseVisualStyleBackColor = True
        '
        'btnJ3JogNeg
        '
        Me.btnJ3JogNeg.Enabled = False
        Me.btnJ3JogNeg.Location = New System.Drawing.Point(131, 16)
        Me.btnJ3JogNeg.Name = "btnJ3JogNeg"
        Me.btnJ3JogNeg.Size = New System.Drawing.Size(23, 23)
        Me.btnJ3JogNeg.TabIndex = 21
        Me.btnJ3JogNeg.Text = "-"
        Me.btnJ3JogNeg.UseVisualStyleBackColor = True
        '
        'panJ3Ref
        '
        Me.panJ3Ref.BackColor = System.Drawing.Color.Gray
        Me.panJ3Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ3Ref.Location = New System.Drawing.Point(174, 19)
        Me.panJ3Ref.Name = "panJ3Ref"
        Me.panJ3Ref.Size = New System.Drawing.Size(15, 15)
        Me.panJ3Ref.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Referenz:"
        '
        'numJ3Target
        '
        Me.numJ3Target.DecimalPlaces = 2
        Me.numJ3Target.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ3Target.Location = New System.Drawing.Point(121, 41)
        Me.numJ3Target.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ3Target.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ3Target.Name = "numJ3Target"
        Me.numJ3Target.Size = New System.Drawing.Size(68, 20)
        Me.numJ3Target.TabIndex = 11
        Me.numJ3Target.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(12, 43)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 13)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "Ziel (in Grad):"
        '
        'trbJ3Target
        '
        Me.trbJ3Target.AutoSize = False
        Me.trbJ3Target.BackColor = System.Drawing.SystemColors.Window
        Me.trbJ3Target.LargeChange = 10
        Me.trbJ3Target.Location = New System.Drawing.Point(7, 67)
        Me.trbJ3Target.Maximum = 100000
        Me.trbJ3Target.Minimum = -100000
        Me.trbJ3Target.Name = "trbJ3Target"
        Me.trbJ3Target.Size = New System.Drawing.Size(188, 20)
        Me.trbJ3Target.TabIndex = 12
        Me.trbJ3Target.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cbJ3Sel
        '
        Me.cbJ3Sel.AutoSize = True
        Me.cbJ3Sel.Checked = True
        Me.cbJ3Sel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbJ3Sel.Location = New System.Drawing.Point(7, 20)
        Me.cbJ3Sel.Name = "cbJ3Sel"
        Me.cbJ3Sel.Size = New System.Drawing.Size(81, 17)
        Me.cbJ3Sel.TabIndex = 10
        Me.cbJ3Sel.Text = "Ausgewählt"
        Me.cbJ3Sel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.panJ2Ref)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.numJ2Target)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.trbJ2Target)
        Me.GroupBox2.Controls.Add(Me.cbJ2Sel)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(213, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 168)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "J2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.radJ2Steps)
        Me.GroupBox3.Controls.Add(Me.radJ2Degree)
        Me.GroupBox3.Controls.Add(Me.numJ2JogInterval)
        Me.GroupBox3.Controls.Add(Me.btnJ2JogPos)
        Me.GroupBox3.Controls.Add(Me.btnJ2JogNeg)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 67)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Jog"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Interval:"
        '
        'radJ2Steps
        '
        Me.radJ2Steps.AutoSize = True
        Me.radJ2Steps.Location = New System.Drawing.Point(95, 44)
        Me.radJ2Steps.Name = "radJ2Steps"
        Me.radJ2Steps.Size = New System.Drawing.Size(52, 17)
        Me.radJ2Steps.TabIndex = 41
        Me.radJ2Steps.Text = "Steps"
        Me.radJ2Steps.UseVisualStyleBackColor = True
        '
        'radJ2Degree
        '
        Me.radJ2Degree.AutoSize = True
        Me.radJ2Degree.Checked = True
        Me.radJ2Degree.Location = New System.Drawing.Point(41, 44)
        Me.radJ2Degree.Name = "radJ2Degree"
        Me.radJ2Degree.Size = New System.Drawing.Size(48, 17)
        Me.radJ2Degree.TabIndex = 40
        Me.radJ2Degree.TabStop = True
        Me.radJ2Degree.Text = "Grad"
        Me.radJ2Degree.UseVisualStyleBackColor = True
        '
        'numJ2JogInterval
        '
        Me.numJ2JogInterval.DecimalPlaces = 2
        Me.numJ2JogInterval.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ2JogInterval.Location = New System.Drawing.Point(57, 17)
        Me.numJ2JogInterval.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ2JogInterval.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ2JogInterval.Name = "numJ2JogInterval"
        Me.numJ2JogInterval.Size = New System.Drawing.Size(68, 20)
        Me.numJ2JogInterval.TabIndex = 20
        Me.numJ2JogInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnJ2JogPos
        '
        Me.btnJ2JogPos.Enabled = False
        Me.btnJ2JogPos.Location = New System.Drawing.Point(160, 16)
        Me.btnJ2JogPos.Name = "btnJ2JogPos"
        Me.btnJ2JogPos.Size = New System.Drawing.Size(23, 23)
        Me.btnJ2JogPos.TabIndex = 22
        Me.btnJ2JogPos.Text = "+"
        Me.btnJ2JogPos.UseVisualStyleBackColor = True
        '
        'btnJ2JogNeg
        '
        Me.btnJ2JogNeg.Enabled = False
        Me.btnJ2JogNeg.Location = New System.Drawing.Point(131, 16)
        Me.btnJ2JogNeg.Name = "btnJ2JogNeg"
        Me.btnJ2JogNeg.Size = New System.Drawing.Size(23, 23)
        Me.btnJ2JogNeg.TabIndex = 21
        Me.btnJ2JogNeg.Text = "-"
        Me.btnJ2JogNeg.UseVisualStyleBackColor = True
        '
        'panJ2Ref
        '
        Me.panJ2Ref.BackColor = System.Drawing.Color.Gray
        Me.panJ2Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ2Ref.Location = New System.Drawing.Point(174, 19)
        Me.panJ2Ref.Name = "panJ2Ref"
        Me.panJ2Ref.Size = New System.Drawing.Size(15, 15)
        Me.panJ2Ref.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Referenz:"
        '
        'numJ2Target
        '
        Me.numJ2Target.DecimalPlaces = 2
        Me.numJ2Target.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numJ2Target.Location = New System.Drawing.Point(121, 41)
        Me.numJ2Target.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numJ2Target.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numJ2Target.Name = "numJ2Target"
        Me.numJ2Target.Size = New System.Drawing.Size(68, 20)
        Me.numJ2Target.TabIndex = 11
        Me.numJ2Target.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ziel (in Grad):"
        '
        'trbJ2Target
        '
        Me.trbJ2Target.AutoSize = False
        Me.trbJ2Target.BackColor = System.Drawing.SystemColors.Window
        Me.trbJ2Target.LargeChange = 10
        Me.trbJ2Target.Location = New System.Drawing.Point(7, 67)
        Me.trbJ2Target.Maximum = 100000
        Me.trbJ2Target.Minimum = -100000
        Me.trbJ2Target.Name = "trbJ2Target"
        Me.trbJ2Target.Size = New System.Drawing.Size(188, 20)
        Me.trbJ2Target.TabIndex = 12
        Me.trbJ2Target.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cbJ2Sel
        '
        Me.cbJ2Sel.AutoSize = True
        Me.cbJ2Sel.Checked = True
        Me.cbJ2Sel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbJ2Sel.Location = New System.Drawing.Point(7, 20)
        Me.cbJ2Sel.Name = "cbJ2Sel"
        Me.cbJ2Sel.Size = New System.Drawing.Size(81, 17)
        Me.cbJ2Sel.TabIndex = 10
        Me.cbJ2Sel.Text = "Ausgewählt"
        Me.cbJ2Sel.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.numPark)
        Me.GroupBox15.Controls.Add(Me.Label54)
        Me.GroupBox15.Controls.Add(Me.numHome)
        Me.GroupBox15.Controls.Add(Me.Label19)
        Me.GroupBox15.Location = New System.Drawing.Point(8, 299)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(180, 98)
        Me.GroupBox15.TabIndex = 14
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Positionen"
        '
        'numPark
        '
        Me.numPark.DecimalPlaces = 2
        Me.numPark.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numPark.Location = New System.Drawing.Point(114, 46)
        Me.numPark.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.numPark.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.numPark.Name = "numPark"
        Me.numPark.Size = New System.Drawing.Size(60, 20)
        Me.numPark.TabIndex = 2
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(6, 50)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(56, 13)
        Me.Label54.TabIndex = 25
        Me.Label54.Text = "Park (in °):"
        '
        'cbAxisSelect
        '
        Me.cbAxisSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAxisSelect.FormattingEnabled = True
        Me.cbAxisSelect.Items.AddRange(New Object() {"J1", "J2", "J3", "J4", "J5", "J6"})
        Me.cbAxisSelect.Location = New System.Drawing.Point(122, 35)
        Me.cbAxisSelect.Name = "cbAxisSelect"
        Me.cbAxisSelect.Size = New System.Drawing.Size(60, 21)
        Me.cbAxisSelect.TabIndex = 1
        '
        'GroupBox50
        '
        Me.GroupBox50.Controls.Add(Me.Label51)
        Me.GroupBox50.Controls.Add(Me.Label50)
        Me.GroupBox50.Controls.Add(Me.numServoMin)
        Me.GroupBox50.Controls.Add(Me.numServoMax)
        Me.GroupBox50.Controls.Add(Me.cbServoSelect)
        Me.GroupBox50.Controls.Add(Me.Label49)
        Me.GroupBox50.Location = New System.Drawing.Point(194, 299)
        Me.GroupBox50.Name = "GroupBox50"
        Me.GroupBox50.Size = New System.Drawing.Size(180, 98)
        Me.GroupBox50.TabIndex = 15
        Me.GroupBox50.TabStop = False
        Me.GroupBox50.Text = "Servos"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(12, 76)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(30, 13)
        Me.Label51.TabIndex = 32
        Me.Label51.Text = "Max:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(12, 50)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(27, 13)
        Me.Label50.TabIndex = 31
        Me.Label50.Text = "Min:"
        '
        'numServoMin
        '
        Me.numServoMin.Location = New System.Drawing.Point(114, 46)
        Me.numServoMin.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.numServoMin.Name = "numServoMin"
        Me.numServoMin.Size = New System.Drawing.Size(60, 20)
        Me.numServoMin.TabIndex = 2
        '
        'numServoMax
        '
        Me.numServoMax.Location = New System.Drawing.Point(114, 72)
        Me.numServoMax.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.numServoMax.Name = "numServoMax"
        Me.numServoMax.Size = New System.Drawing.Size(60, 20)
        Me.numServoMax.TabIndex = 3
        Me.numServoMax.Value = New Decimal(New Integer() {180, 0, 0, 0})
        '
        'cbServoSelect
        '
        Me.cbServoSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServoSelect.FormattingEnabled = True
        Me.cbServoSelect.Items.AddRange(New Object() {"Servo 1", "Servo 2", "Servo 3"})
        Me.cbServoSelect.Location = New System.Drawing.Point(114, 19)
        Me.cbServoSelect.Name = "cbServoSelect"
        Me.cbServoSelect.Size = New System.Drawing.Size(60, 21)
        Me.cbServoSelect.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(12, 23)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(38, 13)
        Me.Label49.TabIndex = 28
        Me.Label49.Text = "Servo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Gelenk:"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(55, 456)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(47, 13)
        Me.lblFilename.TabIndex = 35
        Me.lblFilename.Text = "File........"
        '
        'lblNotSaved
        '
        Me.lblNotSaved.AutoSize = True
        Me.lblNotSaved.ForeColor = System.Drawing.Color.Red
        Me.lblNotSaved.Location = New System.Drawing.Point(29, 416)
        Me.lblNotSaved.Name = "lblNotSaved"
        Me.lblNotSaved.Size = New System.Drawing.Size(93, 13)
        Me.lblNotSaved.TabIndex = 29
        Me.lblNotSaved.Text = "Nicht gespeichert!"
        Me.lblNotSaved.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Datei:"
        '
        'btnSetSave
        '
        Me.btnSetSave.Location = New System.Drawing.Point(128, 411)
        Me.btnSetSave.Name = "btnSetSave"
        Me.btnSetSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSetSave.TabIndex = 3
        Me.btnSetSave.Text = "Speichern"
        Me.btnSetSave.UseVisualStyleBackColor = True
        '
        'btnSetLoad
        '
        Me.btnSetLoad.Location = New System.Drawing.Point(209, 411)
        Me.btnSetLoad.Name = "btnSetLoad"
        Me.btnSetLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnSetLoad.TabIndex = 4
        Me.btnSetLoad.Text = "Laden"
        Me.btnSetLoad.UseVisualStyleBackColor = True
        '
        'btnSetDefaults
        '
        Me.btnSetDefaults.Location = New System.Drawing.Point(290, 411)
        Me.btnSetDefaults.Name = "btnSetDefaults"
        Me.btnSetDefaults.Size = New System.Drawing.Size(84, 23)
        Me.btnSetDefaults.TabIndex = 5
        Me.btnSetDefaults.Text = "Standardwerte"
        Me.btnSetDefaults.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.rtbLog)
        Me.GroupBox14.Controls.Add(Me.btnLogClear)
        Me.GroupBox14.Location = New System.Drawing.Point(501, 469)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(1039, 164)
        Me.GroupBox14.TabIndex = 100
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Log"
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Yellow
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Red
        Me.btnStop.Location = New System.Drawing.Point(904, 6)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(449, 52)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "STOP (LEERTASTE)"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.panEmergencyStop)
        Me.GroupBox16.Controls.Add(Me.Label35)
        Me.GroupBox16.Controls.Add(Me.panJ1Limit)
        Me.GroupBox16.Controls.Add(Me.Label28)
        Me.GroupBox16.Controls.Add(Me.Label24)
        Me.GroupBox16.Controls.Add(Me.Label26)
        Me.GroupBox16.Controls.Add(Me.panJ2Limit)
        Me.GroupBox16.Controls.Add(Me.panJ6Limit)
        Me.GroupBox16.Controls.Add(Me.Label25)
        Me.GroupBox16.Controls.Add(Me.Label29)
        Me.GroupBox16.Controls.Add(Me.panJ3Limit)
        Me.GroupBox16.Controls.Add(Me.panJ4Limit)
        Me.GroupBox16.Controls.Add(Me.Label27)
        Me.GroupBox16.Controls.Add(Me.panJ5Limit)
        Me.GroupBox16.Location = New System.Drawing.Point(1359, 347)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(181, 116)
        Me.GroupBox16.TabIndex = 110
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Eingänge"
        '
        'panEmergencyStop
        '
        Me.panEmergencyStop.BackColor = System.Drawing.Color.Gray
        Me.panEmergencyStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panEmergencyStop.Location = New System.Drawing.Point(148, 88)
        Me.panEmergencyStop.Name = "panEmergencyStop"
        Me.panEmergencyStop.Size = New System.Drawing.Size(15, 15)
        Me.panEmergencyStop.TabIndex = 37
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(93, 89)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 13)
        Me.Label35.TabIndex = 38
        Me.Label35.Text = "Not-Halt:"
        '
        'panJ1Limit
        '
        Me.panJ1Limit.BackColor = System.Drawing.Color.Gray
        Me.panJ1Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ1Limit.Location = New System.Drawing.Point(67, 24)
        Me.panJ1Limit.Name = "panJ1Limit"
        Me.panJ1Limit.Size = New System.Drawing.Size(15, 15)
        Me.panJ1Limit.TabIndex = 37
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(97, 68)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 13)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "J6 Limit:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "J1 Limit:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(97, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "J4 Limit:"
        '
        'panJ2Limit
        '
        Me.panJ2Limit.BackColor = System.Drawing.Color.Gray
        Me.panJ2Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ2Limit.Location = New System.Drawing.Point(148, 25)
        Me.panJ2Limit.Name = "panJ2Limit"
        Me.panJ2Limit.Size = New System.Drawing.Size(15, 15)
        Me.panJ2Limit.TabIndex = 39
        '
        'panJ6Limit
        '
        Me.panJ6Limit.BackColor = System.Drawing.Color.Gray
        Me.panJ6Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ6Limit.Location = New System.Drawing.Point(148, 67)
        Me.panJ6Limit.Name = "panJ6Limit"
        Me.panJ6Limit.Size = New System.Drawing.Size(15, 15)
        Me.panJ6Limit.TabIndex = 43
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(97, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "J2 Limit:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 68)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 42
        Me.Label29.Text = "J5 Limit:"
        '
        'panJ3Limit
        '
        Me.panJ3Limit.BackColor = System.Drawing.Color.Gray
        Me.panJ3Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ3Limit.Location = New System.Drawing.Point(67, 46)
        Me.panJ3Limit.Name = "panJ3Limit"
        Me.panJ3Limit.Size = New System.Drawing.Size(15, 15)
        Me.panJ3Limit.TabIndex = 41
        '
        'panJ4Limit
        '
        Me.panJ4Limit.BackColor = System.Drawing.Color.Gray
        Me.panJ4Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ4Limit.Location = New System.Drawing.Point(148, 46)
        Me.panJ4Limit.Name = "panJ4Limit"
        Me.panJ4Limit.Size = New System.Drawing.Size(15, 15)
        Me.panJ4Limit.TabIndex = 43
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 47)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 13)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "J3 Limit:"
        '
        'panJ5Limit
        '
        Me.panJ5Limit.BackColor = System.Drawing.Color.Gray
        Me.panJ5Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panJ5Limit.Location = New System.Drawing.Point(67, 66)
        Me.panJ5Limit.Name = "panJ5Limit"
        Me.panJ5Limit.Size = New System.Drawing.Size(15, 15)
        Me.panJ5Limit.TabIndex = 41
        '
        'btnProgCopy
        '
        Me.btnProgCopy.Enabled = False
        Me.btnProgCopy.Location = New System.Drawing.Point(87, 376)
        Me.btnProgCopy.Name = "btnProgCopy"
        Me.btnProgCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnProgCopy.TabIndex = 116
        Me.btnProgCopy.Text = "Kopieren"
        Me.btnProgCopy.UseVisualStyleBackColor = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(168, 360)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(63, 13)
        Me.Label56.TabIndex = 115
        Me.Label56.Text = "Kommentar:"
        '
        'tbProgComment
        '
        Me.tbProgComment.Location = New System.Drawing.Point(168, 376)
        Me.tbProgComment.Name = "tbProgComment"
        Me.tbProgComment.Size = New System.Drawing.Size(151, 20)
        Me.tbProgComment.TabIndex = 114
        '
        'cbProgFunc
        '
        Me.cbProgFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgFunc.FormattingEnabled = True
        Me.cbProgFunc.Items.AddRange(New Object() {"Sync Move", "Async Move", "Greifer Öffnen", "Greifer Schließen", "Warten"})
        Me.cbProgFunc.Location = New System.Drawing.Point(6, 320)
        Me.cbProgFunc.Name = "cbProgFunc"
        Me.cbProgFunc.Size = New System.Drawing.Size(156, 21)
        Me.cbProgFunc.TabIndex = 13
        '
        'lblSeqFunc
        '
        Me.lblSeqFunc.AutoSize = True
        Me.lblSeqFunc.Location = New System.Drawing.Point(226, 323)
        Me.lblSeqFunc.Name = "lblSeqFunc"
        Me.lblSeqFunc.Size = New System.Drawing.Size(20, 13)
        Me.lblSeqFunc.TabIndex = 113
        Me.lblSeqFunc.Text = "ms"
        '
        'numSeqFuncValue
        '
        Me.numSeqFuncValue.Enabled = False
        Me.numSeqFuncValue.Location = New System.Drawing.Point(168, 319)
        Me.numSeqFuncValue.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numSeqFuncValue.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numSeqFuncValue.Name = "numSeqFuncValue"
        Me.numSeqFuncValue.Size = New System.Drawing.Size(52, 20)
        Me.numSeqFuncValue.TabIndex = 112
        Me.numSeqFuncValue.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'btnProgReplace
        '
        Me.btnProgReplace.Enabled = False
        Me.btnProgReplace.Location = New System.Drawing.Point(87, 347)
        Me.btnProgReplace.Name = "btnProgReplace"
        Me.btnProgReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnProgReplace.TabIndex = 108
        Me.btnProgReplace.Text = "Ersetzen"
        Me.btnProgReplace.UseVisualStyleBackColor = True
        '
        'btnProgTpLoad
        '
        Me.btnProgTpLoad.Location = New System.Drawing.Point(412, 604)
        Me.btnProgTpLoad.Name = "btnProgTpLoad"
        Me.btnProgTpLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnProgTpLoad.TabIndex = 107
        Me.btnProgTpLoad.Text = "Laden"
        Me.btnProgTpLoad.UseVisualStyleBackColor = True
        '
        'btnProgTpSave
        '
        Me.btnProgTpSave.Location = New System.Drawing.Point(412, 575)
        Me.btnProgTpSave.Name = "btnProgTpSave"
        Me.btnProgTpSave.Size = New System.Drawing.Size(75, 23)
        Me.btnProgTpSave.TabIndex = 106
        Me.btnProgTpSave.Text = "Speichern"
        Me.btnProgTpSave.UseVisualStyleBackColor = True
        '
        'btnProgExecuteLine
        '
        Me.btnProgExecuteLine.Enabled = False
        Me.btnProgExecuteLine.Location = New System.Drawing.Point(406, 377)
        Me.btnProgExecuteLine.Name = "btnProgExecuteLine"
        Me.btnProgExecuteLine.Size = New System.Drawing.Size(75, 23)
        Me.btnProgExecuteLine.TabIndex = 105
        Me.btnProgExecuteLine.Text = "Zeile ausf."
        Me.btnProgExecuteLine.UseVisualStyleBackColor = True
        '
        'btnProgStop
        '
        Me.btnProgStop.Enabled = False
        Me.btnProgStop.Location = New System.Drawing.Point(406, 348)
        Me.btnProgStop.Name = "btnProgStop"
        Me.btnProgStop.Size = New System.Drawing.Size(75, 23)
        Me.btnProgStop.TabIndex = 104
        Me.btnProgStop.Text = "Stop"
        Me.btnProgStop.UseVisualStyleBackColor = True
        '
        'cbSeqLoop
        '
        Me.cbSeqLoop.AutoSize = True
        Me.cbSeqLoop.Location = New System.Drawing.Point(350, 325)
        Me.cbSeqLoop.Name = "cbSeqLoop"
        Me.cbSeqLoop.Size = New System.Drawing.Size(50, 17)
        Me.cbSeqLoop.TabIndex = 103
        Me.cbSeqLoop.Text = "Loop"
        Me.cbSeqLoop.UseVisualStyleBackColor = True
        '
        'btnProgExecute
        '
        Me.btnProgExecute.Enabled = False
        Me.btnProgExecute.Location = New System.Drawing.Point(406, 319)
        Me.btnProgExecute.Name = "btnProgExecute"
        Me.btnProgExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnProgExecute.TabIndex = 102
        Me.btnProgExecute.Text = "Start"
        Me.btnProgExecute.UseVisualStyleBackColor = True
        '
        'btnProgDel
        '
        Me.btnProgDel.Enabled = False
        Me.btnProgDel.Location = New System.Drawing.Point(6, 376)
        Me.btnProgDel.Name = "btnProgDel"
        Me.btnProgDel.Size = New System.Drawing.Size(75, 23)
        Me.btnProgDel.TabIndex = 101
        Me.btnProgDel.Text = "Löschen"
        Me.btnProgDel.UseVisualStyleBackColor = True
        '
        'btnProgAdd
        '
        Me.btnProgAdd.Enabled = False
        Me.btnProgAdd.Location = New System.Drawing.Point(6, 347)
        Me.btnProgAdd.Name = "btnProgAdd"
        Me.btnProgAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnProgAdd.TabIndex = 100
        Me.btnProgAdd.Text = "Hinzufügen"
        Me.btnProgAdd.UseVisualStyleBackColor = True
        '
        'lbProgramm
        '
        Me.lbProgramm.FormattingEnabled = True
        Me.lbProgramm.Location = New System.Drawing.Point(6, 19)
        Me.lbProgramm.Name = "lbProgramm"
        Me.lbProgramm.Size = New System.Drawing.Size(475, 290)
        Me.lbProgramm.TabIndex = 99
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Steuerung)
        Me.TabControl1.Controls.Add(Me.Einstellungen)
        Me.TabControl1.Controls.Add(Me.ComLog)
        Me.TabControl1.Location = New System.Drawing.Point(0, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1556, 668)
        Me.TabControl1.TabIndex = 112
        '
        'Steuerung
        '
        Me.Steuerung.BackColor = System.Drawing.SystemColors.Control
        Me.Steuerung.Controls.Add(Me.GroupBox30)
        Me.Steuerung.Controls.Add(Me.GroupBox29)
        Me.Steuerung.Controls.Add(Me.GroupBox13)
        Me.Steuerung.Controls.Add(Me.GroupBox16)
        Me.Steuerung.Controls.Add(Me.GroupBox11)
        Me.Steuerung.Controls.Add(Me.btnStop)
        Me.Steuerung.Controls.Add(Me.GroupBox12)
        Me.Steuerung.Controls.Add(Me.GroupBox14)
        Me.Steuerung.Controls.Add(Me.btnProgTpLoad)
        Me.Steuerung.Controls.Add(Me.btnProgTpSave)
        Me.Steuerung.Location = New System.Drawing.Point(4, 22)
        Me.Steuerung.Name = "Steuerung"
        Me.Steuerung.Padding = New System.Windows.Forms.Padding(3)
        Me.Steuerung.Size = New System.Drawing.Size(1548, 642)
        Me.Steuerung.TabIndex = 0
        Me.Steuerung.Text = "Steuerung"
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.btnTpDown)
        Me.GroupBox30.Controls.Add(Me.btnTpUp)
        Me.GroupBox30.Controls.Add(Me.Label58)
        Me.GroupBox30.Controls.Add(Me.numTeachPointNum)
        Me.GroupBox30.Controls.Add(Me.Label57)
        Me.GroupBox30.Controls.Add(Me.tbTeachPointName)
        Me.GroupBox30.Controls.Add(Me.btnTpMoveTo)
        Me.GroupBox30.Controls.Add(Me.btnTpAdd)
        Me.GroupBox30.Controls.Add(Me.btnTpDel)
        Me.GroupBox30.Controls.Add(Me.lbTeachPoints)
        Me.GroupBox30.Location = New System.Drawing.Point(6, 422)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(400, 214)
        Me.GroupBox30.TabIndex = 118
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Teachpunkte"
        '
        'btnTpDown
        '
        Me.btnTpDown.Enabled = False
        Me.btnTpDown.Location = New System.Drawing.Point(342, 85)
        Me.btnTpDown.Name = "btnTpDown"
        Me.btnTpDown.Size = New System.Drawing.Size(48, 23)
        Me.btnTpDown.TabIndex = 124
        Me.btnTpDown.Text = "Runter"
        Me.btnTpDown.UseVisualStyleBackColor = True
        '
        'btnTpUp
        '
        Me.btnTpUp.Enabled = False
        Me.btnTpUp.Location = New System.Drawing.Point(288, 85)
        Me.btnTpUp.Name = "btnTpUp"
        Me.btnTpUp.Size = New System.Drawing.Size(48, 23)
        Me.btnTpUp.TabIndex = 123
        Me.btnTpUp.Text = "Hoch"
        Me.btnTpUp.UseVisualStyleBackColor = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(288, 43)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(21, 13)
        Me.Label58.TabIndex = 121
        Me.Label58.Text = "Nr:"
        '
        'numTeachPointNum
        '
        Me.numTeachPointNum.Location = New System.Drawing.Point(288, 59)
        Me.numTeachPointNum.Name = "numTeachPointNum"
        Me.numTeachPointNum.Size = New System.Drawing.Size(52, 20)
        Me.numTeachPointNum.TabIndex = 120
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(288, 111)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(38, 13)
        Me.Label57.TabIndex = 119
        Me.Label57.Text = "Name:"
        '
        'tbTeachPointName
        '
        Me.tbTeachPointName.Location = New System.Drawing.Point(288, 127)
        Me.tbTeachPointName.Name = "tbTeachPointName"
        Me.tbTeachPointName.Size = New System.Drawing.Size(106, 20)
        Me.tbTeachPointName.TabIndex = 118
        '
        'btnTpMoveTo
        '
        Me.btnTpMoveTo.Enabled = False
        Me.btnTpMoveTo.Location = New System.Drawing.Point(288, 18)
        Me.btnTpMoveTo.Name = "btnTpMoveTo"
        Me.btnTpMoveTo.Size = New System.Drawing.Size(75, 23)
        Me.btnTpMoveTo.TabIndex = 106
        Me.btnTpMoveTo.Text = "Move To"
        Me.btnTpMoveTo.UseVisualStyleBackColor = True
        '
        'btnTpAdd
        '
        Me.btnTpAdd.Enabled = False
        Me.btnTpAdd.Location = New System.Drawing.Point(288, 153)
        Me.btnTpAdd.Name = "btnTpAdd"
        Me.btnTpAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnTpAdd.TabIndex = 102
        Me.btnTpAdd.Text = "Hinzufügen"
        Me.btnTpAdd.UseVisualStyleBackColor = True
        '
        'btnTpDel
        '
        Me.btnTpDel.Enabled = False
        Me.btnTpDel.Location = New System.Drawing.Point(288, 182)
        Me.btnTpDel.Name = "btnTpDel"
        Me.btnTpDel.Size = New System.Drawing.Size(75, 23)
        Me.btnTpDel.TabIndex = 103
        Me.btnTpDel.Text = "Löschen"
        Me.btnTpDel.UseVisualStyleBackColor = True
        '
        'lbTeachPoints
        '
        Me.lbTeachPoints.FormattingEnabled = True
        Me.lbTeachPoints.Location = New System.Drawing.Point(6, 19)
        Me.lbTeachPoints.Name = "lbTeachPoints"
        Me.lbTeachPoints.Size = New System.Drawing.Size(276, 186)
        Me.lbTeachPoints.TabIndex = 100
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.lbProgramm)
        Me.GroupBox29.Controls.Add(Me.btnProgCopy)
        Me.GroupBox29.Controls.Add(Me.cbProgFunc)
        Me.GroupBox29.Controls.Add(Me.Label56)
        Me.GroupBox29.Controls.Add(Me.btnProgAdd)
        Me.GroupBox29.Controls.Add(Me.tbProgComment)
        Me.GroupBox29.Controls.Add(Me.btnProgDel)
        Me.GroupBox29.Controls.Add(Me.btnProgExecute)
        Me.GroupBox29.Controls.Add(Me.lblSeqFunc)
        Me.GroupBox29.Controls.Add(Me.cbSeqLoop)
        Me.GroupBox29.Controls.Add(Me.numSeqFuncValue)
        Me.GroupBox29.Controls.Add(Me.btnProgStop)
        Me.GroupBox29.Controls.Add(Me.btnProgReplace)
        Me.GroupBox29.Controls.Add(Me.btnProgExecuteLine)
        Me.GroupBox29.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(489, 410)
        Me.GroupBox29.TabIndex = 117
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "Programm"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.radSrv3)
        Me.GroupBox13.Controls.Add(Me.radSrv2)
        Me.GroupBox13.Controls.Add(Me.radSrv1)
        Me.GroupBox13.Controls.Add(Me.trbServo)
        Me.GroupBox13.Location = New System.Drawing.Point(1361, 64)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(181, 72)
        Me.GroupBox13.TabIndex = 112
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Servo bewegen"
        '
        'radSrv3
        '
        Me.radSrv3.AutoSize = True
        Me.radSrv3.Location = New System.Drawing.Point(124, 19)
        Me.radSrv3.Name = "radSrv3"
        Me.radSrv3.Size = New System.Drawing.Size(53, 17)
        Me.radSrv3.TabIndex = 16
        Me.radSrv3.Text = "Srv. 3"
        Me.radSrv3.UseVisualStyleBackColor = True
        '
        'radSrv2
        '
        Me.radSrv2.AutoSize = True
        Me.radSrv2.Location = New System.Drawing.Point(65, 19)
        Me.radSrv2.Name = "radSrv2"
        Me.radSrv2.Size = New System.Drawing.Size(53, 17)
        Me.radSrv2.TabIndex = 15
        Me.radSrv2.Text = "Srv. 2"
        Me.radSrv2.UseVisualStyleBackColor = True
        '
        'radSrv1
        '
        Me.radSrv1.AutoSize = True
        Me.radSrv1.Checked = True
        Me.radSrv1.Location = New System.Drawing.Point(6, 19)
        Me.radSrv1.Name = "radSrv1"
        Me.radSrv1.Size = New System.Drawing.Size(53, 17)
        Me.radSrv1.TabIndex = 14
        Me.radSrv1.TabStop = True
        Me.radSrv1.Text = "Srv. 1"
        Me.radSrv1.UseVisualStyleBackColor = True
        '
        'trbServo
        '
        Me.trbServo.AutoSize = False
        Me.trbServo.BackColor = System.Drawing.SystemColors.Window
        Me.trbServo.LargeChange = 10
        Me.trbServo.Location = New System.Drawing.Point(17, 42)
        Me.trbServo.Maximum = 100
        Me.trbServo.Name = "trbServo"
        Me.trbServo.Size = New System.Drawing.Size(144, 20)
        Me.trbServo.TabIndex = 13
        Me.trbServo.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Einstellungen
        '
        Me.Einstellungen.BackColor = System.Drawing.SystemColors.Control
        Me.Einstellungen.Controls.Add(Me.GroupBox15)
        Me.Einstellungen.Controls.Add(Me.GroupBox7)
        Me.Einstellungen.Controls.Add(Me.Label4)
        Me.Einstellungen.Controls.Add(Me.cbAxisSelect)
        Me.Einstellungen.Controls.Add(Me.btnSetDefaults)
        Me.Einstellungen.Controls.Add(Me.GroupBox50)
        Me.Einstellungen.Controls.Add(Me.btnSetLoad)
        Me.Einstellungen.Controls.Add(Me.Label9)
        Me.Einstellungen.Controls.Add(Me.btnSetSave)
        Me.Einstellungen.Controls.Add(Me.lblFilename)
        Me.Einstellungen.Controls.Add(Me.GroupBox10)
        Me.Einstellungen.Controls.Add(Me.GroupBox8)
        Me.Einstellungen.Controls.Add(Me.GroupBox9)
        Me.Einstellungen.Controls.Add(Me.lblNotSaved)
        Me.Einstellungen.Location = New System.Drawing.Point(4, 22)
        Me.Einstellungen.Name = "Einstellungen"
        Me.Einstellungen.Padding = New System.Windows.Forms.Padding(3)
        Me.Einstellungen.Size = New System.Drawing.Size(1548, 642)
        Me.Einstellungen.TabIndex = 1
        Me.Einstellungen.Text = "Einstellungen"
        '
        'ComLog
        '
        Me.ComLog.BackColor = System.Drawing.SystemColors.Control
        Me.ComLog.Controls.Add(Me.btnComLogClear)
        Me.ComLog.Controls.Add(Me.rtbComLog)
        Me.ComLog.Location = New System.Drawing.Point(4, 22)
        Me.ComLog.Name = "ComLog"
        Me.ComLog.Size = New System.Drawing.Size(1548, 642)
        Me.ComLog.TabIndex = 2
        Me.ComLog.Text = "Comlog"
        '
        'btnComLogClear
        '
        Me.btnComLogClear.Location = New System.Drawing.Point(1467, 614)
        Me.btnComLogClear.Name = "btnComLogClear"
        Me.btnComLogClear.Size = New System.Drawing.Size(75, 23)
        Me.btnComLogClear.TabIndex = 3
        Me.btnComLogClear.Text = "Clear"
        Me.btnComLogClear.UseVisualStyleBackColor = True
        '
        'rtbComLog
        '
        Me.rtbComLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbComLog.Location = New System.Drawing.Point(8, 3)
        Me.rtbComLog.Name = "rtbComLog"
        Me.rtbComLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.rtbComLog.Size = New System.Drawing.Size(1453, 634)
        Me.rtbComLog.TabIndex = 1
        Me.rtbComLog.Text = ""
        Me.rtbComLog.WordWrap = False
        '
        'RoboTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1558, 680)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RoboTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoboTest v1.1.0.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.numJ1JogInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJ1Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbJ1Target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.numRefAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRefSpeedSlow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRefSpeedFast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.numStopAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.numMinAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMechGear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.numMotGear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStepsPerRot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.numAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        CType(Me.numServo3Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numServo3Open, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox26.PerformLayout()
        CType(Me.numServo2Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numServo2Open, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        CType(Me.numServo1Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numServo1Open, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        CType(Me.numJ6JogInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJ6Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbJ6Target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        CType(Me.numJ5JogInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJ5Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbJ5Target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        CType(Me.numJ4JogInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJ4Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbJ4Target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.numJ3JogInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJ3Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbJ3Target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numJ2JogInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJ2Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbJ2Target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.numPark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox50.ResumeLayout(False)
        Me.GroupBox50.PerformLayout()
        CType(Me.numServoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numServoMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.numSeqFuncValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Steuerung.ResumeLayout(False)
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox30.PerformLayout()
        CType(Me.numTeachPointNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.trbServo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Einstellungen.ResumeLayout(False)
        Me.Einstellungen.PerformLayout()
        Me.ComLog.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbPort As ComboBox
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents timerCheckConnection As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents trbJ1Target As TrackBar
    Friend WithEvents cbJ1Sel As CheckBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogClear As Button
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRef As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbMode As ComboBox
    Friend WithEvents numMotGear As NumericUpDown
    Friend WithEvents numStepsPerRot As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents cbDir As ComboBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbCalDir As ComboBox
    Friend WithEvents numMaxAngle As NumericUpDown
    Friend WithEvents numMechGear As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents numRefAcc As NumericUpDown
    Friend WithEvents numRefSpeedSlow As NumericUpDown
    Friend WithEvents numRefSpeedFast As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents numMinAngle As NumericUpDown
    Friend WithEvents numMaxAcc As NumericUpDown
    Friend WithEvents numMaxSpeed As NumericUpDown
    Friend WithEvents numHome As NumericUpDown
    Friend WithEvents numJ1Target As NumericUpDown
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbAxisSelect As ComboBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents btnSetSave As Button
    Friend WithEvents btnSetLoad As Button
    Friend WithEvents btnSetDefaults As Button
    Friend WithEvents lblNotSaved As Label
    Friend WithEvents lblFilename As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents panJ1Limit As Panel
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents panEmergencyStop As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents panJ6Limit As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents panJ4Limit As Panel
    Friend WithEvents panJ5Limit As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents panJ3Limit As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents panJ2Limit As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents radJ1Steps As RadioButton
    Friend WithEvents radJ1Degree As RadioButton
    Friend WithEvents numJ1JogInterval As NumericUpDown
    Friend WithEvents btnJ1JogPos As Button
    Friend WithEvents btnJ1JogNeg As Button
    Friend WithEvents panJ1Ref As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents GroupBox27 As GroupBox
    Friend WithEvents btnServo3Open As Button
    Friend WithEvents btnServo3Close As Button
    Friend WithEvents numServo3Close As NumericUpDown
    Friend WithEvents Label47 As Label
    Friend WithEvents numServo3Open As NumericUpDown
    Friend WithEvents Label48 As Label
    Friend WithEvents GroupBox26 As GroupBox
    Friend WithEvents btnServo2Open As Button
    Friend WithEvents btnServo2Close As Button
    Friend WithEvents numServo2Close As NumericUpDown
    Friend WithEvents Label44 As Label
    Friend WithEvents numServo2Open As NumericUpDown
    Friend WithEvents Label46 As Label
    Friend WithEvents GroupBox25 As GroupBox
    Friend WithEvents btnServo1Open As Button
    Friend WithEvents btnServo1Close As Button
    Friend WithEvents numServo1Close As NumericUpDown
    Friend WithEvents Label43 As Label
    Friend WithEvents numServo1Open As NumericUpDown
    Friend WithEvents Label45 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents Label33 As Label
    Friend WithEvents radJ6Steps As RadioButton
    Friend WithEvents radJ6Degree As RadioButton
    Friend WithEvents numJ6JogInterval As NumericUpDown
    Friend WithEvents btnJ6JogPos As Button
    Friend WithEvents btnJ6JogNeg As Button
    Friend WithEvents panJ6Ref As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents numJ6Target As NumericUpDown
    Friend WithEvents Label36 As Label
    Friend WithEvents trbJ6Target As TrackBar
    Friend WithEvents cbJ6Sel As CheckBox
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents Label37 As Label
    Friend WithEvents radJ5Steps As RadioButton
    Friend WithEvents radJ5Degree As RadioButton
    Friend WithEvents numJ5JogInterval As NumericUpDown
    Friend WithEvents btnJ5JogPos As Button
    Friend WithEvents btnJ5JogNeg As Button
    Friend WithEvents panJ5Ref As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents numJ5Target As NumericUpDown
    Friend WithEvents Label39 As Label
    Friend WithEvents trbJ5Target As TrackBar
    Friend WithEvents cbJ5Sel As CheckBox
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents Label40 As Label
    Friend WithEvents radJ4Steps As RadioButton
    Friend WithEvents radJ4Degree As RadioButton
    Friend WithEvents numJ4JogInterval As NumericUpDown
    Friend WithEvents btnJ4JogPos As Button
    Friend WithEvents btnJ4JogNeg As Button
    Friend WithEvents panJ4Ref As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents numJ4Target As NumericUpDown
    Friend WithEvents Label42 As Label
    Friend WithEvents trbJ4Target As TrackBar
    Friend WithEvents cbJ4Sel As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents radJ3Steps As RadioButton
    Friend WithEvents radJ3Degree As RadioButton
    Friend WithEvents numJ3JogInterval As NumericUpDown
    Friend WithEvents btnJ3JogPos As Button
    Friend WithEvents btnJ3JogNeg As Button
    Friend WithEvents panJ3Ref As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents numJ3Target As NumericUpDown
    Friend WithEvents Label32 As Label
    Friend WithEvents trbJ3Target As TrackBar
    Friend WithEvents cbJ3Sel As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents panJ2Ref As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents numJ2Target As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents trbJ2Target As TrackBar
    Friend WithEvents cbJ2Sel As CheckBox
    Friend WithEvents GroupBox50 As GroupBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents numServoMin As NumericUpDown
    Friend WithEvents numServoMax As NumericUpDown
    Friend WithEvents cbServoSelect As ComboBox
    Friend WithEvents Label49 As Label
    Friend WithEvents cbSyncAxis As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents radJ2Steps As RadioButton
    Friend WithEvents radJ2Degree As RadioButton
    Friend WithEvents numJ2JogInterval As NumericUpDown
    Friend WithEvents btnJ2JogPos As Button
    Friend WithEvents btnJ2JogNeg As Button
    Friend WithEvents btnProgExecute As Button
    Friend WithEvents btnProgDel As Button
    Friend WithEvents btnProgAdd As Button
    Friend WithEvents lbProgramm As ListBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents numAcc As NumericUpDown
    Friend WithEvents numSpeed As NumericUpDown
    Friend WithEvents Label55 As Label
    Friend WithEvents numStopAcc As NumericUpDown
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents numPark As NumericUpDown
    Friend WithEvents Label54 As Label
    Friend WithEvents btnProgStop As Button
    Friend WithEvents cbSeqLoop As CheckBox
    Friend WithEvents btnProgExecuteLine As Button
    Friend WithEvents btnPark As Button
    Friend WithEvents btnProgTpLoad As Button
    Friend WithEvents btnProgTpSave As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Steuerung As TabPage
    Friend WithEvents Einstellungen As TabPage
    Friend WithEvents btnProgReplace As Button
    Friend WithEvents lblSeqFunc As Label
    Friend WithEvents numSeqFuncValue As NumericUpDown
    Friend WithEvents cbProgFunc As ComboBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents radSrv3 As RadioButton
    Friend WithEvents radSrv2 As RadioButton
    Friend WithEvents radSrv1 As RadioButton
    Friend WithEvents trbServo As TrackBar
    Friend WithEvents Label56 As Label
    Friend WithEvents tbProgComment As TextBox
    Friend WithEvents btnProgCopy As Button
    Friend WithEvents GroupBox30 As GroupBox
    Friend WithEvents lbTeachPoints As ListBox
    Friend WithEvents GroupBox29 As GroupBox
    Friend WithEvents btnTpMoveTo As Button
    Friend WithEvents btnTpAdd As Button
    Friend WithEvents btnTpDel As Button
    Friend WithEvents Label57 As Label
    Friend WithEvents tbTeachPointName As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents numTeachPointNum As NumericUpDown
    Friend WithEvents ComLog As TabPage
    Friend WithEvents btnComLogClear As Button
    Friend WithEvents rtbComLog As RichTextBox
    Friend WithEvents btnTpDown As Button
    Friend WithEvents btnTpUp As Button
End Class
