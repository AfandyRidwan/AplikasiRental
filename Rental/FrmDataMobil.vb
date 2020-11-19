Public Class FrmDataMobil

    Dim SQL As String
    Dim Process As New ClsConnection
    Dim tblMobil As DataTable
    Sub Data_Record()
        tblMobil = Process.ExecuteQuery("Select * From data_mobil order by nomor_mobil asc")
        DGMobil.DataSource = tblMobil
        DGMobil.Columns(1).Width = 100
    End Sub

    Sub Arrange()
        NoMobilTxt.Text = ""
        JenisMobilTxt.Text = ""
        MerkMobilTxt.Text = ""
        HargaSewaTxt.Text = ""
        Call Data_Record()
        SaveBtn.Enabled = True
        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False

    End Sub

    Private Sub FrmDataMobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Arrange()
    End Sub

    Private Sub DGMobil_CelDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGMobil.CellDoubleClick
        NoMobilTxt.Text = DGMobil.SelectedCells(0).Value
        JenisMobilTxt.Text = DGMobil.SelectedCells(1).Value
        MerkMobilTxt.Text = DGMobil.SelectedCells(2).Value
        HargaSewaTxt.Text = DGMobil.SelectedCells(3).Value

        SaveBtn.Enabled = False
        UpdateBtn.Enabled = True
        DeleteBtn.Enabled = True
    End Sub
   
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If NoMobilTxt.Text = "" Then NoMobilTxt.Focus() : Exit Sub
        If JenisMobilTxt.Text = "" Then JenisMobilTxt.Focus() : Exit Sub
        If MerkMobilTxt.Text = "" Then MerkMobilTxt.Focus() : Exit Sub
        If HargaSewaTxt.Text = "" Then HargaSewaTxt.Focus() : Exit Sub

        SQL = "Insert Into data_mobil Values ('" & NoMobilTxt.Text & "','" & JenisMobilTxt.Text & "','" & MerkMobilTxt.Text & "','" & HargaSewaTxt.Text & "')"
        Process.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru Sudah di Simpan..!!", "Sukses menyimpan",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        If NoMobilTxt.Text = "" Then NoMobilTxt.Focus() : Exit Sub
        If JenisMobilTxt.Text = "" Then JenisMobilTxt.Focus() : Exit Sub
        If MerkMobilTxt.Text = "" Then MerkMobilTxt.Focus() : Exit Sub
        If HargaSewaTxt.Text = "" Then HargaSewaTxt.Focus() : Exit Sub


        SQL = "Update data_mobil Set nomor_mobil ='" & NoMobilTxt.Text & "',jenis_mobil = '" & JenisMobilTxt.Text & "',merek_mobil = '" & MerkMobilTxt.Text & "', harga_sewa = '" &
HargaSewaTxt.Text & "'where nomor_mobil = '" & NoMobilTxt.Text & "'"
        Process.ExecuteNonQuery(SQL)

        MessageBox.Show("Data sudah berhasil di Update..!!", "Update Data",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        SQL = "Delete From data_mobil Where nomor_mobil = '" & NoMobilTxt.Text & "'"
        Process.ExecuteNonQuery(SQL)
        MessageBox.Show("Data sudah berhasil di Delete..!!", "Delete Data",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub FindTxt_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindTxt.TextChanged
        If NoMobilRb.Checked = True Then
            tblMobil = Process.ExecuteQuery("Select * From data_mobil Where nomor_mobil Like '%" & FindTxt.Text & "%'")
            If tblMobil.Rows.Count = 0 Then
                DGMobil.DataSource = tblMobil
                FindTxt.Focus()
            Else
                DGMobil.DataSource = tblMobil
            End If
        ElseIf JenisMobilRb.Checked = True Then
            tblMobil = Process.ExecuteQuery("Select * From data_mobil where jenis_mobil Like '%" & FindTxt.Text & "%'")
            If tblMobil.Rows.Count = 0 Then
                DGMobil.DataSource = tblMobil
                FindTxt.Focus()
            Else
                DGMobil.DataSource = tblMobil
            End If
        End If
    End Sub

    
End Class