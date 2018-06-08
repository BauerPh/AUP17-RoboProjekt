Option Strict On
Public Class classSettings
    Private Const cDefaultConfigFile As String = "default.conf"
    Private _actFilename As String
    Structure structMot
        Public stepsPerRot As Int32
        Public gear As Double
        Public mode As Int32
        Public dir As Int32
    End Structure
    Structure structMech
        Public gear As Double
        Public minAngle As Double
        Public maxAngle As Double
        Public homePosAngle As Double
        Public parkPosAngle As Double
    End Structure
    Structure structCal
        Public dir As Int32
        Public speedFast As Double
        Public speedSlow As Double
        Public acc As Double
    End Structure
    Structure structProfile
        Public maxSpeed As Double
        Public maxAcc As Double
        Public stopAcc As Double
    End Structure
    Public Structure structJoint
        Public nr As Int32
        Public mot As structMot
        Public mech As structMech
        Public cal As structCal
        Public profile As structProfile
    End Structure
    Public Structure structServo
        Public minAngle As Double
        Public maxAngle As Double
    End Structure

    Public Property configFileLoaded As Boolean = False
    Public Property jointSettings As structJoint()
    Public Property servoSettings As structServo()

    Public Sub New()
        'Datensätze erzeugen
        jointSettings = New structJoint(5) {} '6 Joints
        servoSettings = New structServo(2) {} '3 Servos
        'Lade letzte geöffnete Datei, wenn vorhanden!
        If System.IO.File.Exists(My.Settings.lastConfigFile) Then
            XMLReader(My.Settings.lastConfigFile)
            _actFilename = My.Settings.lastConfigFile
            configFileLoaded = True
        Else
            If Not loadDefaulSettings() Then
                If MessageBox.Show($"Die Konfigurationsdatei ""{cDefaultConfigFile}"" konnte nicht gefunden werden oder ist fehlerhaft. Soll sie gesucht werden?", "Konfigurationsdatei nicht gefunden!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                    If loadSettings() Then
                        configFileLoaded = True
                    End If
                End If
            Else
                configFileLoaded = True
            End If
        End If
    End Sub
    Public Function getDefaulConfigFilename() As String
        Return cDefaultConfigFile
    End Function
    Public Function loadDefaulSettings() As Boolean
        If System.IO.File.Exists(cDefaultConfigFile) Then
            XMLReader(cDefaultConfigFile)
            _actFilename = cDefaultConfigFile
            Return True
        Else
            Return False
        End If
    End Function
    Public Function loadSettings() As Boolean
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "Konfig-Dateien (*.conf)|*.conf"
        }
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                XMLReader(openFileDialog.FileName)
                My.Settings.lastConfigFile = openFileDialog.FileName
                My.Settings.Save()
                _actFilename = openFileDialog.FileName
                Return True
            Catch e As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    Public Function saveSettings() As Boolean
        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "Konfig-Dateien (*.conf)|*.conf"
        }
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                XMLWriter(saveFileDialog.FileName)
                My.Settings.lastConfigFile = saveFileDialog.FileName
                My.Settings.Save()
                _actFilename = saveFileDialog.FileName
                Return True
            Catch e As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    Public Function getActFilename() As String
        If _actFilename <> Nothing Then
            Return _actFilename
        Else
            Return ""
        End If
    End Function

    Private Sub XMLWriter(filename As String)
        Dim enc As New System.Text.UnicodeEncoding
        Dim XMLobj As Xml.XmlTextWriter = New Xml.XmlTextWriter(filename, enc)

        With XMLobj
            .Formatting = Xml.Formatting.Indented
            .Indentation = 4
            .WriteStartDocument()
            .WriteStartElement("Settings")
            For i = 0 To 5
                .WriteStartElement("J" & (i + 1).ToString())

                .WriteStartElement("mot")
                .WriteAttributeString("stepsPerRot", jointSettings(i).mot.stepsPerRot.ToString)
                .WriteAttributeString("gear", jointSettings(i).mot.gear.ToString)
                .WriteAttributeString("mode", jointSettings(i).mot.mode.ToString)
                .WriteAttributeString("dir", jointSettings(i).mot.dir.ToString)
                .WriteEndElement()

                .WriteStartElement("mech")
                .WriteAttributeString("gear", jointSettings(i).mech.gear.ToString)
                .WriteAttributeString("minAngle", jointSettings(i).mech.minAngle.ToString)
                .WriteAttributeString("maxAngle", jointSettings(i).mech.maxAngle.ToString)
                .WriteAttributeString("homePosAngle", jointSettings(i).mech.homePosAngle.ToString)
                .WriteAttributeString("parkPosAngle", jointSettings(i).mech.parkPosAngle.ToString)
                .WriteEndElement()

                .WriteStartElement("cal")
                .WriteAttributeString("dir", jointSettings(i).cal.dir.ToString)
                .WriteAttributeString("speedFast", jointSettings(i).cal.speedFast.ToString)
                .WriteAttributeString("speedSlow", jointSettings(i).cal.speedSlow.ToString)
                .WriteAttributeString("acc", jointSettings(i).cal.acc.ToString)
                .WriteEndElement()

                .WriteStartElement("profile")
                .WriteAttributeString("maxSpeed", jointSettings(i).profile.maxSpeed.ToString)
                .WriteAttributeString("maxAcc", jointSettings(i).profile.maxAcc.ToString)
                .WriteAttributeString("stopAcc", jointSettings(i).profile.stopAcc.ToString)
                .WriteEndElement()

                .WriteEndElement()
            Next
            For i = 0 To 2
                .WriteStartElement("SRV" & (i + 1).ToString())

                .WriteStartElement("angles")
                .WriteAttributeString("minAngle", servoSettings(i).minAngle.ToString)
                .WriteAttributeString("maxAngle", servoSettings(i).maxAngle.ToString)
                .WriteEndElement()

                .WriteEndElement()
            Next
            .WriteEndElement()
            .Close()
        End With
    End Sub

    Public Sub XMLReader(filename As String)
        Dim XMLReader As Xml.XmlReader = New Xml.XmlTextReader(filename)
        Dim i As Int32 'Index
        Dim joints As Boolean = False

        With XMLReader
            Do While .Read ' Es sind noch Daten vorhanden 
                If .NodeType = Xml.XmlNodeType.Element Then
                    Dim e As String = .Name 'Elementname
                    If e.Substring(0, 1) = "J" Then
                        i = CInt(e.Substring(1)) - 1 'Joint Nr
                        joints = True
                    ElseIf e.Substring(0, 3) = "SRV" Then
                        i = CInt(e.Substring(3)) - 1
                        joints = False
                    End If
                    If .AttributeCount > 0 Then 'sind überhaupt Attribute vorhanden?
                        While .MoveToNextAttribute 'Attribute durchlaufen
                            If joints Then
                                '********** JOINTS **********
                                Select Case e
                                    Case "mot"
                                        Select Case .Name
                                            Case "stepsPerRot"
                                                jointSettings(i).mot.stepsPerRot = CInt(.Value)
                                            Case "gear"
                                                jointSettings(i).mot.gear = CDec(.Value)
                                            Case "mode"
                                                jointSettings(i).mot.mode = CInt(.Value)
                                            Case "dir"
                                                jointSettings(i).mot.dir = CInt(.Value)
                                        End Select
                                    Case "mech"
                                        Select Case .Name
                                            Case "gear"
                                                jointSettings(i).mech.gear = CDec(.Value)
                                            Case "minAngle"
                                                jointSettings(i).mech.minAngle = CDec(.Value)
                                            Case "maxAngle"
                                                jointSettings(i).mech.maxAngle = CDec(.Value)
                                            Case "homePosAngle"
                                                jointSettings(i).mech.homePosAngle = CDec(.Value)
                                            Case "parkPosAngle"
                                                jointSettings(i).mech.parkPosAngle = CDec(.Value)
                                        End Select
                                    Case "cal"
                                        Select Case .Name
                                            Case "dir"
                                                jointSettings(i).cal.dir = CInt(.Value)
                                            Case "speedFast"
                                                jointSettings(i).cal.speedFast = CDec(.Value)
                                            Case "speedSlow"
                                                jointSettings(i).cal.speedSlow = CDec(.Value)
                                            Case "acc"
                                                jointSettings(i).cal.acc = CDec(.Value)
                                        End Select
                                    Case "profile"
                                        Select Case .Name
                                            Case "maxSpeed"
                                                jointSettings(i).profile.maxSpeed = CDec(.Value)
                                            Case "maxAcc"
                                                jointSettings(i).profile.maxAcc = CDec(.Value)
                                            Case "stopAcc"
                                                jointSettings(i).profile.stopAcc = CDec(.Value)
                                        End Select
                                End Select
                            Else
                                '********** SERVOS **********
                                Select Case e
                                    Case "angles"
                                        Select Case .Name
                                            Case "minAngle"
                                                servoSettings(i).minAngle = CDec(.Value)
                                            Case "maxAngle"
                                                servoSettings(i).maxAngle = CDec(.Value)
                                        End Select
                                End Select
                            End If
                        End While
                    End If
                End If
            Loop
            .Close()
        End With
    End Sub
End Class
