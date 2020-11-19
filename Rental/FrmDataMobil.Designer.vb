<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataMobil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataMobil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NoMobilTxt = New System.Windows.Forms.TextBox()
        Me.JenisMobilTxt = New System.Windows.Forms.TextBox()
        Me.MerkMobilTxt = New System.Windows.Forms.TextBox()
        Me.HargaSewaTxt = New System.Windows.Forms.TextBox()
        Me.FindTxt = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.NoMobilRb = New System.Windows.Forms.RadioButton()
        Me.JenisMobilRb = New System.Windows.Forms.RadioButton()
        Me.DGMobil = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Data Mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Mobil :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Mobil :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Merk Mobil :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Sewa :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cari :"
        '
        'NoMobilTxt
        '
        Me.NoMobilTxt.Location = New System.Drawing.Point(108, 55)
        Me.NoMobilTxt.Name = "NoMobilTxt"
        Me.NoMobilTxt.Size = New System.Drawing.Size(100, 20)
        Me.NoMobilTxt.TabIndex = 6
        '
        'JenisMobilTxt
        '
        Me.JenisMobilTxt.Location = New System.Drawing.Point(108, 91)
        Me.JenisMobilTxt.Name = "JenisMobilTxt"
        Me.JenisMobilTxt.Size = New System.Drawing.Size(100, 20)
        Me.JenisMobilTxt.TabIndex = 7
        '
        'MerkMobilTxt
        '
        Me.MerkMobilTxt.Location = New System.Drawing.Point(108, 128)
        Me.MerkMobilTxt.Name = "MerkMobilTxt"
        Me.MerkMobilTxt.Size = New System.Drawing.Size(100, 20)
        Me.MerkMobilTxt.TabIndex = 8
        '
        'HargaSewaTxt
        '
        Me.HargaSewaTxt.Location = New System.Drawing.Point(108, 163)
        Me.HargaSewaTxt.Name = "HargaSewaTxt"
        Me.HargaSewaTxt.Size = New System.Drawing.Size(100, 20)
        Me.HargaSewaTxt.TabIndex = 9
        '
        'FindTxt
        '
        Me.FindTxt.Location = New System.Drawing.Point(108, 229)
        Me.FindTxt.Name = "FindTxt"
        Me.FindTxt.Size = New System.Drawing.Size(100, 20)
        Me.FindTxt.TabIndex = 10
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(230, 260)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 11
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(320, 260)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBtn.TabIndex = 12
        Me.UpdateBtn.Text = "Edit"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(411, 260)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 13
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'NoMobilRb
        '
        Me.NoMobilRb.AutoSize = True
        Me.NoMobilRb.Location = New System.Drawing.Point(37, 266)
        Me.NoMobilRb.Name = "NoMobilRb"
        Me.NoMobilRb.Size = New System.Drawing.Size(67, 17)
        Me.NoMobilRb.TabIndex = 14
        Me.NoMobilRb.TabStop = True
        Me.NoMobilRb.Text = "No Mobil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NoMobilRb.UseVisualStyleBackColor = True
        '
        'JenisMobilRb
        '
        Me.JenisMobilRb.AutoSize = True
        Me.JenisMobilRb.Location = New System.Drawing.Point(131, 266)
        Me.JenisMobilRb.Name = "JenisMobilRb"
        Me.JenisMobilRb.Size = New System.Drawing.Size(77, 17)
        Me.JenisMobilRb.TabIndex = 15
        Me.JenisMobilRb.TabStop = True
        Me.JenisMobilRb.Text = "Jenis Mobil"
        Me.JenisMobilRb.UseVisualStyleBackColor = True
        '
        'DGMobil
        '
        Me.DGMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMobil.Location = New System.Drawing.Point(35, 298)
        Me.DGMobil.Name = "DGMobil"
        Me.DGMobil.Size = New System.Drawing.Size(451, 114)
        Me.DGMobil.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(276, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'FrmDataMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 424)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGMobil)
        Me.Controls.Add(Me.JenisMobilRb)
        Me.Controls.Add(Me.NoMobilRb)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.FindTxt)
        Me.Controls.Add(Me.HargaSewaTxt)
        Me.Controls.Add(Me.MerkMobilTxt)
        Me.Controls.Add(Me.JenisMobilTxt)
        Me.Controls.Add(Me.NoMobilTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmDataMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Mobil"
        CType(Me.DGMobil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NoMobilTxt As System.Windows.Forms.TextBox
    Friend WithEvents JenisMobilTxt As System.Windows.Forms.TextBox
    Friend WithEvents MerkMobilTxt As System.Windows.Forms.TextBox
    Friend WithEvents HargaSewaTxt As System.Windows.Forms.TextBox
    Friend WithEvents FindTxt As System.Windows.Forms.TextBox
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents NoMobilRb As System.Windows.Forms.RadioButton
    Friend WithEvents JenisMobilRb As System.Windows.Forms.RadioButton
    Friend WithEvents DGMobil As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
