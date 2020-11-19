Public Class FrmDataPelanggan

    Dim SQL As String
    Dim Process As New ClsConnection
    Dim tblPelanggan As DataTable
    Sub Data_Record()
        tblPelanggan = Process.ExecuteQuery("Select * From data_pelanggan order by id_pelanggan asc")
        DGPelanggan.DataSource = tblPelanggan
        DGPelanggan.Columns(1).Width = 100

    End Sub
    Sub Code_Otomatic()
        tblPelanggan = Process.ExecuteQuery("Select * From data_pelanggan order by id_pelanggan desc")
        If tblPelanggan.Rows.Count = 0 Then
            IdPelangganTxt.Text = "000001"
        Else
            With tblPelanggan.Rows(0)
                IdPelangganTxt.Text = .Item("id_pelanggan")
            End With
            IdPelangganTxt.Text = Val(IdPelangganTxt.Text) + 1
            Select Case Len(IdPelangganTxt.Text)
                Case 1
                    IdPelangganTxt.Text = "00000" & IdPelangganTxt.Text & ""
                Case 2
                    IdPelangganTxt.Text = "0000" & IdPelangganTxt.Text & ""
                Case 3
                    IdPelangganTxt.Text = "000" & IdPelangganTxt.Text & ""
                Case 4
                    IdPelangganTxt.Text = "00" & IdPelangganTxt.Text & ""
                Case 5
                    IdPelangganTxt.Text = "0" & IdPelangganTxt.Text & ""
                Case 6
                    IdPelangganTxt.Text = "" & IdPelangganTxt.Text & ""
            End Select
        End If
    End Sub

    Sub Arrange()
        IdPelangganTxt.Text = ""
        IdPelangganTxt.Focus()
        NamaPelangganTxt.Text = ""
        NoKontakTxt.Text = ""
        AlamatTxt.Text = ""
        Call Code_Otomatic()
        Call Data_Record()
        SaveBtn.Enabled = True
        UpdateBtn.Enabled = True
        DeleteBtn.Enabled = True

    End Sub

    Private Sub FrmDataPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Arrange()
    End Sub

    Private Sub DGPelanggan_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPelanggan.CellDoubleClick
        IdPelangganTxt.Text = DGPelanggan.SelectedCells(0).Value
        NamaPelangganTxt.Text = DGPelanggan.SelectedCells(1).Value
        NoKontakTxt.Text = DGPelanggan.SelectedCells(2).Value
        AlamatTxt.Text = DGPelanggan.SelectedCells(3).Value
        SaveBtn.Enabled = False
        UpdateBtn.Enabled = True
        DeleteBtn.Enabled = True
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If IdPelangganTxt.Text = "" Then IdPelangganTxt.Focus() : Exit Sub
        If NamaPelangganTxt.Text = "" Then NamaPelangganTxt.Focus() : Exit Sub
        If NoKontakTxt.Text = "" Then NoKontakTxt.Focus() : Exit Sub
        If AlamatTxt.Text = "" Then AlamatTxt.Focus() : Exit Sub

        SQL = "Insert Into data_pelanggan Values ('" & IdPelangganTxt.Text & "','" & NamaPelangganTxt.Text & "','" & NoKontakTxt.Text & "','" & AlamatTxt.Text & "')"
        Process.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru Sudah di Simpan..!!", "Sukses menyimpan",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        If IdPelangganTxt.Text = "" Then IdPelangganTxt.Focus() : Exit Sub
        If NamaPelangganTxt.Text = "" Then NamaPelangganTxt.Focus() : Exit Sub
        If NoKontakTxt.Text = "" Then NoKontakTxt.Focus() : Exit Sub
        If AlamatTxt.Text = "" Then AlamatTxt.Focus() : Exit Sub


        SQL = "Update data_pelanggan Set id_pelanggan ='" & IdPelangganTxt.Text & "',nama_pelanggan = '" & NamaPelangganTxt.Text & "',nomor_kontak = '" & NoKontakTxt.Text & "', alamat = '" &
AlamatTxt.Text & "'where id_pelanggan = '" & IdPelangganTxt.Text & "'"
        Process.ExecuteNonQuery(SQL)

        MessageBox.Show("Data sudah berhasil di Update..!!", "Update Data",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        SQL = "Delete From data_pelanggan Where id_pelanggan = '" & IdPelangganTxt.Text & "'"
        Process.ExecuteNonQuery(SQL)
        MessageBox.Show("Data sudah berhasil di Delete..!!", "Delete Data",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If RbID.Checked = True Then
            tblPelanggan = Process.ExecuteQuery("Select * From data_pelanggan Where id_pelanggan Like '%" & TextBox5.Text & "%'")
            If tblPelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblPelanggan
                TextBox5.Focus()
            Else
                DGPelanggan.DataSource = tblPelanggan
            End If
        ElseIf RbNama.Checked = True Then
            tblPelanggan = Process.ExecuteQuery("Select * From data_pelanggan Where nama_pelanggan Like '%" & TextBox5.Text & "%'")
            If tblPelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblPelanggan
                TextBox5.Focus()
            Else
                DGPelanggan.DataSource = tblPelanggan
            End If
        ElseIf RBNo.Checked = True Then
            tblPelanggan = Process.ExecuteQuery("Select * From data_pelanggan Where nomor_kontak Like '%" & TextBox5.Text & "%'")
            If tblPelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblPelanggan
                TextBox5.Focus()
            Else
                DGPelanggan.DataSource = tblPelanggan
            End If
        End If
    End Sub
End Class