Imports System.IO
Imports System.Speech
Imports System.Speech.Recognition
Imports System.Speech.Synthesis

Public Class Form1
    Dim rcv1 As String
    Dim rcv As Integer
    Dim rcvx As Integer
    Dim rcvy As String
    Dim wh As Integer = 0
    Dim whx As String
    Dim speech_result As Integer
    Dim read_text As Integer


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = DateString
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        rcv1 = SerialPort1.ReadLine()
        efg()
        abc()


    End Sub



    Private Sub btnSerialOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSerialOk.Click
        Try
            SerialPort1.PortName = ComboBox1.Text()
            SerialPort1.Open()
            SerialPort1.WriteLine("999")
            Label4.BackColor = Color.MediumSeaGreen
            Timer2.Enabled = True
            Timer3.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub efg()
        rcvx = CInt(rcv1)
    End Sub

    Private Sub abc()
        If rcvx > 22000 And rcvx <= 22500 Then
            rcv = rcvx Mod 1000
            If rcv = 115 Then
                lbl1.BackColor = Color.FromArgb(95, 124, 138)
            ElseIf rcv = 116 Then
                lbl1.BackColor = Color.FromArgb(0, 149, 135)
            ElseIf rcv = 125 Then
                lbl2.BackColor = Color.FromArgb(95, 124, 138)
            ElseIf rcv = 126 Then
                lbl2.BackColor = Color.FromArgb(0, 149, 135)
            ElseIf rcv = 135 Then
                lbl3.BackColor = Color.FromArgb(95, 124, 138)
            ElseIf rcv = 136 Then
                lbl3.BackColor = Color.FromArgb(0, 149, 135)
            ElseIf rcv = 145 Then
                lbl4.BackColor = Color.FromArgb(95, 124, 138)
            ElseIf rcv = 146 Then
                lbl4.BackColor = Color.FromArgb(0, 149, 135)
            ElseIf rcv = 155 Then
                lbl5.BackColor = Color.FromArgb(95, 124, 138)
            ElseIf rcv = 156 Then
                lbl5.BackColor = Color.FromArgb(0, 149, 135)

            End If
        ElseIf rcvx >= 20000 And rcvx <= 21024 Then
            rcvy = (rcvx Mod 1000) / 1024 * 100


        End If
    End Sub

    Private Sub lbl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl1.Click
        If lbl1.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl1.BackColor = Color.FromArgb(95, 124, 138)
            SerialPort1.Write("22115")
            lblx4.Text = lblx4.Text - 1
        Else
            lbl1.BackColor = Color.FromArgb(0, 149, 135)
            SerialPort1.Write("22116")
            lblx4.Text = lblx4.Text + 1
        End If
    End Sub

    Private Sub lbl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl2.Click
        If lbl2.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl2.BackColor = Color.FromArgb(95, 124, 138)
            SerialPort1.Write("22125")
            lblx4.Text = lblx4.Text - 1
        Else
            lbl2.BackColor = Color.FromArgb(0, 149, 135)

            SerialPort1.Write("22126")
            lblx4.Text = lblx4.Text + 1
        End If
    End Sub

    Private Sub lbl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl3.Click
        If lbl3.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl3.BackColor = Color.FromArgb(95, 124, 138)
            SerialPort1.Write("22135")
            lblx4.Text = lblx4.Text - 1
        Else
            lbl3.BackColor = Color.FromArgb(0, 149, 135)
            SerialPort1.Write("22136")
            lblx4.Text = lblx4.Text + 1
        End If
    End Sub

    Private Sub lbl4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl4.Click
        If lbl4.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl4.BackColor = Color.FromArgb(95, 124, 138)
            SerialPort1.Write("22145")
            lblx4.Text = lblx4.Text - 1
        Else
            lbl4.BackColor = Color.FromArgb(0, 149, 135)
            SerialPort1.Write("22146")
            lblx4.Text = lblx4.Text + 1
        End If
    End Sub

    Private Sub lbl5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl5.Click
        If lbl5.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl5.BackColor = Color.FromArgb(95, 124, 138)
            SerialPort1.Write("22155")
            lblx4.Text = lblx4.Text - 1
        Else
            lbl5.BackColor = Color.FromArgb(0, 149, 135)
            SerialPort1.Write("22156")
            lblx4.Text = lblx4.Text + 1
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblx2.Text = rcvy + "%"
    End Sub

    Private Sub lbl6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl6.Click
        If lbl6.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl6.BackColor = Color.FromArgb(95, 124, 138)

        Else
            lbl6.BackColor = Color.FromArgb(0, 149, 135)

        End If
    End Sub

    Private Sub lbl7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl7.Click
        If lbl7.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl7.BackColor = Color.FromArgb(95, 124, 138)

        Else
            lbl7.BackColor = Color.FromArgb(0, 149, 135)

        End If
    End Sub

    Private Sub lbl8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl8.Click
        If lbl8.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl8.BackColor = Color.FromArgb(95, 124, 138)

        Else
            lbl8.BackColor = Color.FromArgb(0, 149, 135)

        End If
    End Sub


    Private Sub lbl9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl9.Click
        If lbl9.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl9.BackColor = Color.FromArgb(95, 124, 138)
            lblx5.Text = lblx5.Text - 1
        Else
            lbl9.BackColor = Color.FromArgb(0, 149, 135)
            lblx5.Text = lblx5.Text + 1
        End If
    End Sub

    Private Sub lbl10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl10.Click
        If lbl10.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl10.BackColor = Color.FromArgb(95, 124, 138)
            lblx5.Text = lblx5.Text - 1
        Else
            lbl10.BackColor = Color.FromArgb(0, 149, 135)
            lblx5.Text = lblx5.Text + 1
        End If
    End Sub

    Private Sub lbl11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl11.Click
        If lbl11.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl11.BackColor = Color.FromArgb(95, 124, 138)
            lblx5.Text = lblx5.Text - 1
        Else
            lbl11.BackColor = Color.FromArgb(0, 149, 135)
            lblx5.Text = lblx5.Text + 1
        End If
    End Sub

    Private Sub lbl12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl12.Click
        If lbl12.BackColor = Color.FromArgb(0, 149, 135) Then
            lbl12.BackColor = Color.FromArgb(95, 124, 138)
            lblx5.Text = lblx5.Text - 1
        Else
            lbl12.BackColor = Color.FromArgb(0, 149, 135)
            lblx5.Text = lblx5.Text + 1
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If lblx4.Text > 0 Then
            Timer3.Interval = (21 - (((lblx4.Text) * 1) + ((lblx5.Text) * 3))) * 1000
            wh = wh + 1
            whx = wh
            lblx1.Text = whx + " Wh"
        End If
    End Sub

    '''<summary>Speech Recognize Part</summary>'''


    Public synth As New Synthesis.SpeechSynthesizer
    Public WithEvents recognizer As New SpeechRecognitionEngine

    ' Dim Command_List As New List(Of String)
    Dim GrammerDoc As New SrgsGrammar.SrgsDocument
    Dim GrammerRules As New SrgsGrammar.SrgsRule("CommandList")
    Dim Rule_sets As New SrgsGrammar.SrgsOneOf()
    Dim Word_Dict As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

    Public Sub GotSpeech(ByVal sender As Object, ByVal phrase As System.Speech.Recognition.SpeechRecognizedEventArgs) Handles recognizer.SpeechRecognized

        'recognized commands in phrase.Result.Text
        Result_lbl.Text = phrase.Result.Text
        speech_result = Word_Dict(phrase.Result.Text).ToString()
        speech_result = speech_result + 22000
        Label1.Text = speech_result
        rcvx = speech_result
        abc()
        SerialPort1.Write(rcvx)
        speech()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim SPEAKER As New SpeechSynthesizer
        SPEAKER.SelectVoice("Microsoft Zira Desktop")
        SPEAKER.Speak("Hello, I'm Aleesha, your personal home assistant, How can I help you")


        recognizer.SetInputToDefaultAudioDevice()
        recognizer.RecognizeAsync(RecognizeMode.Multiple)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists("cmdList.txt") Then
            MsgBox("cmdList.txt Not Found", MsgBoxStyle.Critical)
            Exit Sub
        End If

        For Each Line As String In File.ReadLines("cmdList.txt")
            If Line.Equals("") Then Exit For

            Dim temp As String() = Line.Split(":")
            Word_Dict.Add(temp(0), Int(temp(1)))

            Rule_sets.Add(New SrgsGrammar.SrgsItem(temp(0)))
        Next

        GrammerRules.Add(Rule_sets)
        GrammerDoc.Rules.Add(GrammerRules)
        GrammerDoc.Root = GrammerRules

        recognizer.LoadGrammar(New Grammar(GrammerDoc))
    End Sub

    Private Function ReadDataStuctre(ByVal path As String) As Dictionary(Of String, String)

        Dim DataDict As New Dictionary(Of String, String) From {}

        Using reader As New StreamReader(path)
            Dim line As String = reader.ReadLine()

            Do While (Not line Is Nothing)

                Dim Number = line.Split(":")(0)

                Dim word = line.Split(":")(1)

                DataDict(Number) = word

                line = reader.ReadLine()
            Loop

        End Using

        Return DataDict
    End Function

    Private Sub speech()
        read_text = speech_result - 22000
        Label5.Text = read_text
        Dim datadict As Dictionary(Of String, String) = ReadDataStuctre("Data.txt")
        Dim Index_no As Integer = Label5.Text


        If datadict.ContainsKey(Index_no) Then
            Dim SPEAKER As New SpeechSynthesizer
            SPEAKER.SelectVoice("Microsoft Zira Desktop")
            SPEAKER.Speak(datadict(Index_no))
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
