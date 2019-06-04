<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnSerialOk = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblx2 = New System.Windows.Forms.Label()
        Me.lblx4 = New System.Windows.Forms.Label()
        Me.lblx5 = New System.Windows.Forms.Label()
        Me.lblx6 = New System.Windows.Forms.Label()
        Me.lblx7 = New System.Windows.Forms.Label()
        Me.lblx3 = New System.Windows.Forms.Label()
        Me.lblx1 = New System.Windows.Forms.Label()
        Me.lblx9 = New System.Windows.Forms.Label()
        Me.lblx8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Result_lbl = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.btnSerialOk)
        Me.Panel1.Location = New System.Drawing.Point(197, 499)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 47)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.IndianRed
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(722, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(611, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data receiving "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select serial port"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11"})
        Me.ComboBox1.Location = New System.Drawing.Point(131, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'btnSerialOk
        '
        Me.btnSerialOk.Location = New System.Drawing.Point(266, 12)
        Me.btnSerialOk.Name = "btnSerialOk"
        Me.btnSerialOk.Size = New System.Drawing.Size(51, 23)
        Me.btnSerialOk.TabIndex = 0
        Me.btnSerialOk.Text = "OK"
        Me.btnSerialOk.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(505, 26)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(422, 91)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "00:00:00 --"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(787, 126)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(179, 37)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "00/00/0000"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl5)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Controls.Add(Me.lbl3)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 212)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lights"
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.Black
        Me.lbl5.Location = New System.Drawing.Point(11, 175)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(151, 18)
        Me.lbl5.TabIndex = 14
        Me.lbl5.Text = "Outdoor"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(11, 142)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(151, 18)
        Me.lbl4.TabIndex = 13
        Me.lbl4.Text = "Room 3"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(11, 108)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(151, 18)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "Room 2"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(11, 74)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(151, 18)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Room 1"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(11, 39)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(151, 18)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Living Room "
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lbl8)
        Me.GroupBox2.Controls.Add(Me.lbl6)
        Me.GroupBox2.Controls.Add(Me.lbl7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(173, 137)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Doors"
        '
        'lbl8
        '
        Me.lbl8.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.Black
        Me.lbl8.Location = New System.Drawing.Point(11, 98)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(151, 18)
        Me.lbl8.TabIndex = 7
        Me.lbl8.Text = "Garage"
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.Black
        Me.lbl6.Location = New System.Drawing.Point(11, 31)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(151, 18)
        Me.lbl6.TabIndex = 7
        Me.lbl6.Text = "Main"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl7
        '
        Me.lbl7.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.Black
        Me.lbl7.Location = New System.Drawing.Point(11, 65)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(151, 18)
        Me.lbl7.TabIndex = 4
        Me.lbl7.Text = "Back "
        Me.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbl12)
        Me.GroupBox3.Controls.Add(Me.lbl11)
        Me.GroupBox3.Controls.Add(Me.lbl9)
        Me.GroupBox3.Controls.Add(Me.lbl10)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 379)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 167)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Air conditioner"
        '
        'lbl12
        '
        Me.lbl12.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.Black
        Me.lbl12.Location = New System.Drawing.Point(11, 130)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(151, 18)
        Me.lbl12.TabIndex = 11
        Me.lbl12.Text = "Room 3"
        Me.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl11
        '
        Me.lbl11.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.Color.Black
        Me.lbl11.Location = New System.Drawing.Point(11, 98)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(151, 18)
        Me.lbl11.TabIndex = 10
        Me.lbl11.Text = "Room 2"
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl9
        '
        Me.lbl9.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.Black
        Me.lbl9.Location = New System.Drawing.Point(11, 31)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(151, 18)
        Me.lbl9.TabIndex = 9
        Me.lbl9.Text = "Living Room"
        Me.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl10
        '
        Me.lbl10.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.Black
        Me.lbl10.Location = New System.Drawing.Point(11, 65)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(151, 18)
        Me.lbl10.TabIndex = 8
        Me.lbl10.Text = "Room 1"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SerialPort1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'lblx2
        '
        Me.lblx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx2.ForeColor = System.Drawing.Color.White
        Me.lblx2.Image = CType(resources.GetObject("lblx2.Image"), System.Drawing.Image)
        Me.lblx2.Location = New System.Drawing.Point(299, 20)
        Me.lblx2.Name = "lblx2"
        Me.lblx2.Size = New System.Drawing.Size(104, 152)
        Me.lblx2.TabIndex = 15
        Me.lblx2.Text = "00 %"
        Me.lblx2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblx4
        '
        Me.lblx4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx4.ForeColor = System.Drawing.Color.White
        Me.lblx4.Image = CType(resources.GetObject("lblx4.Image"), System.Drawing.Image)
        Me.lblx4.Location = New System.Drawing.Point(193, 177)
        Me.lblx4.Name = "lblx4"
        Me.lblx4.Size = New System.Drawing.Size(104, 152)
        Me.lblx4.TabIndex = 16
        Me.lblx4.Text = "0"
        Me.lblx4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblx5
        '
        Me.lblx5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx5.ForeColor = System.Drawing.Color.White
        Me.lblx5.Image = CType(resources.GetObject("lblx5.Image"), System.Drawing.Image)
        Me.lblx5.Location = New System.Drawing.Point(299, 177)
        Me.lblx5.Name = "lblx5"
        Me.lblx5.Size = New System.Drawing.Size(104, 152)
        Me.lblx5.TabIndex = 17
        Me.lblx5.Text = "0"
        Me.lblx5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblx6
        '
        Me.lblx6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx6.ForeColor = System.Drawing.Color.White
        Me.lblx6.Image = CType(resources.GetObject("lblx6.Image"), System.Drawing.Image)
        Me.lblx6.Location = New System.Drawing.Point(405, 177)
        Me.lblx6.Name = "lblx6"
        Me.lblx6.Size = New System.Drawing.Size(104, 152)
        Me.lblx6.TabIndex = 18
        Me.lblx6.Text = "26 C"
        Me.lblx6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblx7
        '
        Me.lblx7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx7.ForeColor = System.Drawing.Color.White
        Me.lblx7.Image = CType(resources.GetObject("lblx7.Image"), System.Drawing.Image)
        Me.lblx7.Location = New System.Drawing.Point(193, 335)
        Me.lblx7.Name = "lblx7"
        Me.lblx7.Size = New System.Drawing.Size(104, 152)
        Me.lblx7.TabIndex = 19
        Me.lblx7.Text = "Cloudy"
        Me.lblx7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblx3
        '
        Me.lblx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx3.ForeColor = System.Drawing.Color.White
        Me.lblx3.Image = CType(resources.GetObject("lblx3.Image"), System.Drawing.Image)
        Me.lblx3.Location = New System.Drawing.Point(405, 20)
        Me.lblx3.Name = "lblx3"
        Me.lblx3.Size = New System.Drawing.Size(104, 152)
        Me.lblx3.TabIndex = 20
        Me.lblx3.Text = "No Alerts"
        Me.lblx3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblx1
        '
        Me.lblx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx1.ForeColor = System.Drawing.Color.White
        Me.lblx1.Image = CType(resources.GetObject("lblx1.Image"), System.Drawing.Image)
        Me.lblx1.Location = New System.Drawing.Point(193, 20)
        Me.lblx1.Name = "lblx1"
        Me.lblx1.Size = New System.Drawing.Size(104, 152)
        Me.lblx1.TabIndex = 21
        Me.lblx1.Text = "0 Wh"
        Me.lblx1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblx9
        '
        Me.lblx9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx9.ForeColor = System.Drawing.Color.White
        Me.lblx9.Image = CType(resources.GetObject("lblx9.Image"), System.Drawing.Image)
        Me.lblx9.Location = New System.Drawing.Point(405, 335)
        Me.lblx9.Name = "lblx9"
        Me.lblx9.Size = New System.Drawing.Size(104, 152)
        Me.lblx9.TabIndex = 23
        Me.lblx9.Text = "5"
        Me.lblx9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblx8
        '
        Me.lblx8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx8.ForeColor = System.Drawing.Color.White
        Me.lblx8.Image = CType(resources.GetObject("lblx8.Image"), System.Drawing.Image)
        Me.lblx8.Location = New System.Drawing.Point(299, 335)
        Me.lblx8.Name = "lblx8"
        Me.lblx8.Size = New System.Drawing.Size(104, 152)
        Me.lblx8.TabIndex = 22
        Me.lblx8.Text = "4"
        Me.lblx8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(361, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 82)
        Me.Label17.TabIndex = 24
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Result_lbl)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Location = New System.Drawing.Point(531, 177)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 152)
        Me.Panel2.TabIndex = 25
        '
        'Result_lbl
        '
        Me.Result_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Result_lbl.Location = New System.Drawing.Point(12, 18)
        Me.Result_lbl.Name = "Result_lbl"
        Me.Result_lbl.Size = New System.Drawing.Size(343, 117)
        Me.Result_lbl.TabIndex = 25
        Me.Result_lbl.Text = "Hi, I'm Aleesha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "How can I help?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(531, 335)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(440, 152)
        Me.Panel3.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Timer3
        '
        Me.Timer3.Interval = 10000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(983, 559)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblx9)
        Me.Controls.Add(Me.lblx8)
        Me.Controls.Add(Me.lblx1)
        Me.Controls.Add(Me.lblx3)
        Me.Controls.Add(Me.lblx7)
        Me.Controls.Add(Me.lblx6)
        Me.Controls.Add(Me.lblx5)
        Me.Controls.Add(Me.lblx4)
        Me.Controls.Add(Me.lblx2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Home Automation System 2.0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSerialOk As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lblx2 As System.Windows.Forms.Label
    Friend WithEvents lblx4 As System.Windows.Forms.Label
    Friend WithEvents lblx5 As System.Windows.Forms.Label
    Friend WithEvents lblx6 As System.Windows.Forms.Label
    Friend WithEvents lblx7 As System.Windows.Forms.Label
    Friend WithEvents lblx3 As System.Windows.Forms.Label
    Friend WithEvents lblx1 As System.Windows.Forms.Label
    Friend WithEvents lblx9 As System.Windows.Forms.Label
    Friend WithEvents lblx8 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Result_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
End Class
