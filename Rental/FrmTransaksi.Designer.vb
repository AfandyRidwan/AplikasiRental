<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransaksi))
        Me.DGTransaksi = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IdTransaksiTxt = New System.Windows.Forms.TextBox()
        Me.LamaRentalTxt = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TanggalRentalTxt = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NamaPelangganTxt = New System.Windows.Forms.TextBox()
        Me.JenisMobilTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NoKontakTxt = New System.Windows.Forms.TextBox()
        Me.HargaSewaTxt = New System.Windows.Forms.TextBox()
        Me.CbPelanggan = New System.Windows.Forms.ComboBox()
        Me.CbMobil = New System.Windows.Forms.ComboBox()
        Me.ProsesBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGTransaksi
        '
        Me.DGTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransaksi.Location = New System.Drawing.Point(26, 278)
        Me.DGTransaksi.Name = "DGTransaksi"
        Me.DGTransaksi.Size = New System.Drawing.Size(617, 124)
        Me.DGTransaksi.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID Transaksi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Lama Rental :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tanggal Rental :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "ID Pelanggan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ID Mobil :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Find :"
        '
        'IdTransaksiTxt
        '
        Me.IdTransaksiTxt.Location = New System.Drawing.Point(129, 19)
        Me.IdTransaksiTxt.Name = "IdTransaksiTxt"
        Me.IdTransaksiTxt.Size = New System.Drawing.Size(100, 20)
        Me.IdTransaksiTxt.TabIndex = 26
        '
        'LamaRentalTxt
        '
        Me.LamaRentalTxt.Location = New System.Drawing.Point(129, 53)
        Me.LamaRentalTxt.Name = "LamaRentalTxt"
        Me.LamaRentalTxt.Size = New System.Drawing.Size(40, 20)
        Me.LamaRentalTxt.TabIndex = 27
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(28, 242)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 29
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ID Pelanggan"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(124, 242)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton2.TabIndex = 30
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ID Mobil"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TanggalRentalTxt
        '
        Me.TanggalRentalTxt.CustomFormat = "dd MM yyy"
        Me.TanggalRentalTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TanggalRentalTxt.Location = New System.Drawing.Point(129, 83)
        Me.TanggalRentalTxt.Name = "TanggalRentalTxt"
        Me.TanggalRentalTxt.Size = New System.Drawing.Size(100, 20)
        Me.TanggalRentalTxt.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Hari"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(129, 208)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(242, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Nama Pelanggan :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(242, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Jenis Mobil :"
        '
        'NamaPelangganTxt
        '
        Me.NamaPelangganTxt.Location = New System.Drawing.Point(343, 212)
        Me.NamaPelangganTxt.Name = "NamaPelangganTxt"
        Me.NamaPelangganTxt.Size = New System.Drawing.Size(100, 20)
        Me.NamaPelangganTxt.TabIndex = 38
        '
        'JenisMobilTxt
        '
        Me.JenisMobilTxt.Location = New System.Drawing.Point(343, 239)
        Me.JenisMobilTxt.Name = "JenisMobilTxt"
        Me.JenisMobilTxt.Size = New System.Drawing.Size(100, 20)
        Me.JenisMobilTxt.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(461, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "No Kontak :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(461, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Harga Sewa :"
        '
        'NoKontakTxt
        '
        Me.NoKontakTxt.Location = New System.Drawing.Point(543, 214)
        Me.NoKontakTxt.Name = "NoKontakTxt"
        Me.NoKontakTxt.Size = New System.Drawing.Size(100, 20)
        Me.NoKontakTxt.TabIndex = 42
        '
        'HargaSewaTxt
        '
        Me.HargaSewaTxt.Location = New System.Drawing.Point(543, 239)
        Me.HargaSewaTxt.Name = "HargaSewaTxt"
        Me.HargaSewaTxt.Size = New System.Drawing.Size(100, 20)
        Me.HargaSewaTxt.TabIndex = 43
        '
        'CbPelanggan
        '
        Me.CbPelanggan.FormattingEnabled = True
        Me.CbPelanggan.Location = New System.Drawing.Point(129, 120)
        Me.CbPelanggan.Name = "CbPelanggan"
        Me.CbPelanggan.Size = New System.Drawing.Size(100, 21)
        Me.CbPelanggan.TabIndex = 44
        '
        'CbMobil
        '
        Me.CbMobil.FormattingEnabled = True
        Me.CbMobil.Location = New System.Drawing.Point(129, 153)
        Me.CbMobil.Name = "CbMobil"
        Me.CbMobil.Size = New System.Drawing.Size(100, 21)
        Me.CbMobil.TabIndex = 45
        '
        'ProsesBtn
        '
        Me.ProsesBtn.Location = New System.Drawing.Point(35, 431)
        Me.ProsesBtn.Name = "ProsesBtn"
        Me.ProsesBtn.Size = New System.Drawing.Size(75, 23)
        Me.ProsesBtn.TabIndex = 46
        Me.ProsesBtn.Text = "Proses"
        Me.ProsesBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(134, 431)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 47
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(271, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(512, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 157)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'FrmTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 466)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ProsesBtn)
        Me.Controls.Add(Me.CbMobil)
        Me.Controls.Add(Me.CbPelanggan)
        Me.Controls.Add(Me.HargaSewaTxt)
        Me.Controls.Add(Me.NoKontakTxt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.JenisMobilTxt)
        Me.Controls.Add(Me.NamaPelangganTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TanggalRentalTxt)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LamaRentalTxt)
        Me.Controls.Add(Me.IdTransaksiTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGTransaksi)
        Me.MaximizeBox = False
        Me.Name = "FrmTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Rental"
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IdTransaksiTxt As System.Windows.Forms.TextBox
    Friend WithEvents LamaRentalTxt As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TanggalRentalTxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NamaPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents JenisMobilTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NoKontakTxt As System.Windows.Forms.TextBox
    Friend WithEvents HargaSewaTxt As System.Windows.Forms.TextBox
    Friend WithEvents CbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents CbMobil As System.Windows.Forms.ComboBox
    Friend WithEvents ProsesBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
