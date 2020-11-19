<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataPelanggan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RbID = New System.Windows.Forms.RadioButton()
        Me.RbNama = New System.Windows.Forms.RadioButton()
        Me.RBNo = New System.Windows.Forms.RadioButton()
        Me.IdPelangganTxt = New System.Windows.Forms.TextBox()
        Me.NamaPelangganTxt = New System.Windows.Forms.TextBox()
        Me.NoKontakTxt = New System.Windows.Forms.TextBox()
        Me.AlamatTxt = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.DGPelanggan = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(209, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Data Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Pelanggan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Kontak :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Find :"
        '
        'RbID
        '
        Me.RbID.AutoSize = True
        Me.RbID.Location = New System.Drawing.Point(32, 268)
        Me.RbID.Name = "RbID"
        Me.RbID.Size = New System.Drawing.Size(36, 17)
        Me.RbID.TabIndex = 6
        Me.RbID.TabStop = True
        Me.RbID.Text = "ID"
        Me.RbID.UseVisualStyleBackColor = True
        '
        'RbNama
        '
        Me.RbNama.AutoSize = True
        Me.RbNama.Location = New System.Drawing.Point(90, 268)
        Me.RbNama.Name = "RbNama"
        Me.RbNama.Size = New System.Drawing.Size(53, 17)
        Me.RbNama.TabIndex = 7
        Me.RbNama.TabStop = True
        Me.RbNama.Text = "Nama"
        Me.RbNama.UseVisualStyleBackColor = True
        '
        'RBNo
        '
        Me.RBNo.AutoSize = True
        Me.RBNo.Location = New System.Drawing.Point(161, 268)
        Me.RBNo.Name = "RBNo"
        Me.RBNo.Size = New System.Drawing.Size(76, 17)
        Me.RBNo.TabIndex = 8
        Me.RBNo.TabStop = True
        Me.RBNo.Text = "No Kontak"
        Me.RBNo.UseVisualStyleBackColor = True
        '
        'IdPelangganTxt
        '
        Me.IdPelangganTxt.Location = New System.Drawing.Point(130, 58)
        Me.IdPelangganTxt.Name = "IdPelangganTxt"
        Me.IdPelangganTxt.Size = New System.Drawing.Size(100, 20)
        Me.IdPelangganTxt.TabIndex = 9
        '
        'NamaPelangganTxt
        '
        Me.NamaPelangganTxt.Location = New System.Drawing.Point(130, 96)
        Me.NamaPelangganTxt.Name = "NamaPelangganTxt"
        Me.NamaPelangganTxt.Size = New System.Drawing.Size(100, 20)
        Me.NamaPelangganTxt.TabIndex = 10
        '
        'NoKontakTxt
        '
        Me.NoKontakTxt.Location = New System.Drawing.Point(130, 128)
        Me.NoKontakTxt.Name = "NoKontakTxt"
        Me.NoKontakTxt.Size = New System.Drawing.Size(100, 20)
        Me.NoKontakTxt.TabIndex = 11
        '
        'AlamatTxt
        '
        Me.AlamatTxt.Location = New System.Drawing.Point(130, 161)
        Me.AlamatTxt.Name = "AlamatTxt"
        Me.AlamatTxt.Size = New System.Drawing.Size(100, 20)
        Me.AlamatTxt.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(130, 233)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 13
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(474, 305)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 14
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(474, 409)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBtn.TabIndex = 15
        Me.UpdateBtn.Text = "Edit"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(474, 358)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 16
        Me.DeleteBtn.Text = " Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'DGPelanggan
        '
        Me.DGPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPelanggan.Location = New System.Drawing.Point(12, 305)
        Me.DGPelanggan.Name = "DGPelanggan"
        Me.DGPelanggan.Size = New System.Drawing.Size(445, 127)
        Me.DGPelanggan.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(277, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'FrmDataPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 444)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGPelanggan)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.AlamatTxt)
        Me.Controls.Add(Me.NoKontakTxt)
        Me.Controls.Add(Me.NamaPelangganTxt)
        Me.Controls.Add(Me.IdPelangganTxt)
        Me.Controls.Add(Me.RBNo)
        Me.Controls.Add(Me.RbNama)
        Me.Controls.Add(Me.RbID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDataPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pelanggan"
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RbID As System.Windows.Forms.RadioButton
    Friend WithEvents RbNama As System.Windows.Forms.RadioButton
    Friend WithEvents RBNo As System.Windows.Forms.RadioButton
    Friend WithEvents IdPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents NamaPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents NoKontakTxt As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTxt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents DGPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
