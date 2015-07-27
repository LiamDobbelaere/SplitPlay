Imports System.Threading
Imports System.Drawing.Imaging
Imports System.IO
Imports SplitPlay.InputManager
Imports X9Tech.XBox.Input
Imports System.Reflection

Public Class frmMain

    '[SplitPlay software]
    'Author: Tom Dobbelaere
    'The code is ugly and needs rewriting, I know.

    Dim WithEvents objStream As VideoStream
    Dim WithEvents objKeyStream As KeyStream
    Dim trdScreencap As Thread
    Dim objGraph As Graphics
    Dim bmpTestFrame As Bitmap
    Dim bmpCapt As New Bitmap(My.Settings.RegionWidth, My.Settings.RegionHeight, PixelFormat.Format16bppRgb555)
    Dim jpgEncoder As ImageCodecInfo
    Dim myEncoderParameters As EncoderParameters
    Dim blnReceiving As Boolean = False
    Dim objGameview As New frmGameView
    Dim WithEvents kbHook As New KeyboardHook
    Dim xbxManager As XBoxControllerManager
    Dim xbxController As XBoxController
    Dim intWidth As Integer = My.Settings.RegionWidth
    Dim intHeight As Integer = My.Settings.RegionHeight
    Dim szeSize As Size = New Size(intWidth, intHeight)
    Dim pntDest As Point = New Point(0, 0)
    Dim pntSource As Point = New Point(CInt((Screen.PrimaryScreen.Bounds.Width / 2) - (intWidth / 2)), CInt((Screen.PrimaryScreen.Bounds.Height / 2) - (intHeight / 2)))
    Dim arrBtn As Boolean() = {False, False, False, False, False, _
                               False, False, False, False, False, _
                               False, False, False, False, False, _
                               False, False, False, False, False, _
                               False, False}
    Dim blnUsingcontroller As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = "v" & Assembly.GetExecutingAssembly().GetName().Version.Major.ToString & "." & Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString & " build " & Assembly.GetExecutingAssembly().GetName().Version.Build

        objGraph = Graphics.FromImage(bmpCapt)

        jpgEncoder = GetEncoder(ImageFormat.Jpeg)
        Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
        myEncoderParameters = New EncoderParameters(1)

        Dim myEncoderParameter As EncoderParameter = New EncoderParameter(myEncoder, CLng(txtQuality.Text))
        myEncoderParameters.Param(0) = myEncoderParameter
    End Sub

    Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo

        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

        Dim codec As ImageCodecInfo
        For Each codec In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next codec
        Return Nothing

    End Function

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        objStream = New VideoStream(txtIP.Text, CUShort(txtPort.Text))
        Try
            objStream.Start()
        Catch ex As Exception
            MessageBox.Show("The entered IP-address is invalid.")
            Exit Sub
        End Try

        objKeyStream = New KeyStream(CUShort(txtPortKey.Text))

        tmrCapture.Start()

        btnSend.Enabled = False
        btnReceive.Enabled = False
    End Sub

    Private Sub btnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        'Jeez, this is really dirty too. Gotta fix that in a later stage
        If IsNumeric(txtPort.Text) And IsNumeric(txtPortKey.Text) Then
            If CUShort(txtPort.Text) <= UShort.MaxValue And CUShort(txtPortKey.Text) <= UShort.MaxValue Then
                'Ok
            Else
                MessageBox.Show("Port number too high!")
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid ports specified.")
            Exit Sub
        End If

        objStream = New VideoStream(CUShort(txtPort.Text))
        objKeyStream = New KeyStream(txtIP.Text, CUShort(txtPortKey.Text))
        Try
            objKeyStream.Start()
        Catch ex As Exception
            MessageBox.Show("The entered IP-address is invalid.")
            Exit Sub
        End Try

        blnReceiving = True

        If blnUsingcontroller Then
            tmrKeycap.Start()
        End If

        Me.Hide()
        objGameview.Text = "SplitPlay session with " & txtIP.Text
        objGameview.ShowDialog()

        btnSend.Enabled = False
        btnReceive.Enabled = False
    End Sub

    Sub GetFrame() Handles objStream.FrameReady
        objGameview.pbxGameview.Image = objStream.bmpCurrentFrame
    End Sub

    Private Sub tmrCapture_Tick(sender As Object, e As EventArgs) Handles tmrCapture.Tick
        '[29/06/2014 15:40] Minor optimization, instead of creating instances of Point & Size
        'at runtime every frame, they are now made at startup and just once. This should be
        'a very slight performance improvement
        'Here's the old code:
        'objGraph.CopyFromScreen(New Point(CInt((Screen.PrimaryScreen.Bounds.Width / 2) - (656 / 2)), CInt((Screen.PrimaryScreen.Bounds.Height / 2) - (518 / 2))), New Point(0, 0), New Size(656, 518))
        objGraph.CopyFromScreen(pntSource, pntDest, szeSize, CopyPixelOperation.MergeCopy)
        If My.Settings.Grayscale Then
            bmpCapt = MakeGrayscale3(bmpCapt)
        End If

        Dim msTest As New MemoryStream
        bmpCapt.Save(msTest, jpgEncoder, myEncoderParameters)
        'bmpCapt.Save(msTest, ImageFormat.jp)

        If msTest.Length > 540 Then
            lblSize.BackColor = System.Drawing.Color.FromArgb(255, 50, 20)
        Else
            lblSize.BackColor = System.Drawing.Color.FromArgb(0, 98, 221)
        End If

        lblSize.Text = msTest.Length.ToString & " bytes"

        objStream.Send(msTest.GetBuffer())

        bmpTestFrame = CType(Bitmap.FromStream(msTest), Bitmap)
        PictureBox1.Image = bmpTestFrame
    End Sub

    Private Shared Function GetBytes(str As String) As Byte()
        Dim bytes As Byte() = New Byte(str.Length * 2 - 1) {}
        System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length)
        Return bytes
    End Function

    Private Shared Function GetString(bytes As Byte()) As String
        Dim chars As Char() = New Char(bytes.Length \ 2 - 1) {}
        System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length)
        Return New String(chars)
    End Function

    Private Sub kbHook_KeyDown(key As Windows.Forms.Keys) Handles kbHook.KeyDown
        If blnReceiving = False Then
            Exit Sub
        End If

        Dim strData As String = "d" & CInt(key).ToString
        Dim baKeys As Byte() = GetBytes(strData)

        objKeyStream.Send(baKeys)
    End Sub

    Private Sub kbHook_KeyUp(key As Windows.Forms.Keys) Handles kbHook.KeyUp
        If blnReceiving = False Then
            Exit Sub
        End If

        Dim strData As String = "u" & CInt(key).ToString
        Dim baKeys As Byte() = GetBytes(strData)

        objKeyStream.Send(baKeys)
    End Sub

    Sub KeyReceived() Handles objKeyStream.FrameReady
        Dim strData As String = GetString(objKeyStream.bytData)

        If strData.Substring(0, 1) = "u" Then
            Dim intKeycode As Integer = CInt(strData.Substring(1, strData.Length - 1))
            Keyboard.KeyUp(CType(intKeycode, Keys))
        ElseIf strData.Substring(0, 1) = "d" Then
            Dim intKeycode As Integer = CInt(strData.Substring(1, strData.Length - 1))
            Keyboard.KeyDown(CType(intKeycode, Keys))
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            objStream.Cleanup()
        Catch ex As Exception

        End Try
        Environment.Exit(0)
    End Sub

    Private Sub txtQuality_TextChanged(sender As Object, e As EventArgs) Handles txtQuality.TextChanged
        If txtQuality.Text = String.Empty Or Not IsNumeric(txtQuality.Text) Then
            Exit Sub
        End If

        jpgEncoder = GetEncoder(ImageFormat.Jpeg)
        Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
        myEncoderParameters = New EncoderParameters(1)

        Dim myEncoderParameter As EncoderParameter = New EncoderParameter(myEncoder, CLng(txtQuality.Text))
        myEncoderParameters.Param(0) = myEncoderParameter
    End Sub

    Private Sub chkXbox_CheckedChanged(sender As Object, e As EventArgs) Handles chkXbox.CheckedChanged
        'If it's not checked, don't proceed. This is because in the code below, the checked state is
        'changed by the program at runtime, triggering another unwanted CheckedChanged event.
        If Not chkXbox.Checked Then
            Exit Sub
        End If

        xbxManager = New XBoxControllerManager()
        If xbxManager.GetConnectedControllers().Count > 0 Then
            'I just pick the first controller in the list
            'It looks like dirty code (and maybe it is), but player one is always at spot 0 anyways
            xbxController = xbxManager.GetConnectedControllers()(0)
        Else
            MessageBox.Show("No xbox 360 controller found :(")
            chkXbox.Checked = False
        End If
        blnUsingcontroller = True
    End Sub

    Sub SendKeyManually(strState As String, key As Keys)
        If blnReceiving = False Then
            Exit Sub
        End If

        Dim strData As String = strState & CInt(key).ToString
        Dim baKeys As Byte() = GetBytes(strData)

        objKeyStream.Send(baKeys)
    End Sub

    Sub HandlePress(blnControllerButton As Boolean, intMemory As Integer, keyTranslated As Keys)
        If blnControllerButton And Not arrBtn(intMemory) Then
            SendKeyManually("d", keyTranslated)
            arrBtn(intMemory) = True
        ElseIf arrBtn(intMemory) Then
            SendKeyManually("u", keyTranslated)
            arrBtn(intMemory) = False
        End If
    End Sub

    Sub HandleThumb(dblControllerThumb As Double, dblLimit As Double, intMemory As Integer, keyPositive As Keys, keyNegative As Keys)
        If (dblControllerThumb > 50 + dblLimit) And Not arrBtn(intMemory) Then
            SendKeyManually("d", keyPositive)
            arrBtn(intMemory) = True
        ElseIf (dblControllerThumb < 50 - dblLimit) And Not arrBtn(intMemory) Then
            SendKeyManually("d", keyNegative)
            arrBtn(intMemory) = True
        ElseIf (Not (dblControllerThumb > 50 + dblLimit)) And (Not (dblControllerThumb < 50 - dblLimit)) And arrBtn(intMemory) Then
            SendKeyManually("u", keyPositive)
            SendKeyManually("u", keyNegative)
            arrBtn(intMemory) = False
        End If
    End Sub

    Private Sub tmrKeycap_Tick(sender As Object, e As EventArgs) Handles tmrKeycap.Tick
        'Right now, controller buttons just emulate keypresses serverside
        'this is kind of a bad way to go about it, even though it works alright
        '(at least for games that don't use trigger states between 0 and 1)
        'Instead, a virtual controller should be implemented and emulated serverside
        'but unless this product reaches a much later stage, this won't happen
        'anytime soon.
        HandlePress(xbxController.ButtonAPressed, 0, Keys.H)
        HandlePress(xbxController.ButtonBackPressed, 1, Keys.B)
        HandlePress(xbxController.ButtonBPressed, 2, Keys.J)
        HandlePress(xbxController.ButtonDownPressed, 3, Keys.Down)
        HandlePress(xbxController.ButtonLeftPressed, 4, Keys.Left)
        HandlePress(xbxController.ButtonRightPressed, 5, Keys.Right)
        HandlePress(xbxController.ButtonShoulderLeftPressed, 6, Keys.A)
        HandlePress(xbxController.ButtonShoulderRightPressed, 7, Keys.E)
        HandlePress(xbxController.ButtonStartPressed, 8, Keys.N)
        HandlePress(xbxController.ButtonUpPressed, 9, Keys.Up)
        HandlePress(xbxController.ButtonXPressed, 10, Keys.Y)
        HandlePress(xbxController.ButtonYPressed, 11, Keys.U)
        HandlePress(xbxController.TriggerLeftPressed, 12, Keys.D1)
        HandlePress(xbxController.TriggerRightPressed, 13, Keys.D2)
        HandleThumb(xbxController.ThumbLeftX, 15, 14, Keys.D, Keys.Q)
        HandleThumb(xbxController.ThumbLeftY, 15, 15, Keys.Z, Keys.S)
        HandleThumb(xbxController.ThumbRightX, 15, 16, Keys.M, Keys.K)
        HandleThumb(xbxController.ThumbRightY, 15, 17, Keys.O, Keys.L)
    End Sub
End Class
