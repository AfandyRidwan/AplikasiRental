Public Class FrmTransaksi
    Dim SQL As String
    Dim process As New ClsConnection
    Dim tblTransaksi As DataTable

    Sub Code_Otomatic()
        tblTransaksi = process.ExecuteQuery("Select * From transaksi_rental order by id_transaksi desc")
        If tblTransaksi.Rows.Count = 0 Then
            IdTransaksiTxt.Text = "TRN00001"
        Else
            With tblTransaksi.Rows(0)
                IdTransaksiTxt.Text = .Item("id_transaksi")
            End With

            IdTransaksiTxt.Text = Val(Microsoft.VisualBasic.Right(IdTransaksiTxt.Text, 5)) + 1
            Select Case Len(IdTransaksiTxt.Text)
                Case 1
                    IdTransaksiTxt.Text = "TRN0000" & IdTransaksiTxt.Text & ""
                Case 2
                    IdTransaksiTxt.Text = "TRN000" & IdTransaksiTxt.Text & ""
                Case 3
                    IdTransaksiTxt.Text = "TRN00" & IdTransaksiTxt.Text & ""
                Case 4
                    IdTransaksiTxt.Text = "TRN0" & IdTransaksiTxt.Text & ""
                Case 5
                    IdTransaksiTxt.Text = "TRN" & IdTransaksiTxt.Text & ""

            End Select
        End If
    End Sub
    Sub Data_Record()
        tblTransaksi = process.ExecuteQuery("Select * From transaksi_rental order by id_transaksi asc")
        DGTransaksi.DataSource = tblTransaksi
        DGTransaksi.Columns(0).Width = 70
        DGTransaksi.Columns(1).Width = 70
        DGTransaksi.Columns(2).Width = 130
        DGTransaksi.Columns(3).Width = 140
        DGTransaksi.Columns(4).Width = 200
    End Sub

    Sub mobil()
        tblTransaksi = process.ExecuteQuery("Select * From data_mobil order by nomor_mobil asc")
        If tblTransaksi.Rows.Count = 0 Then
        Else
            CbMobil.Items.Clear()
            With tblTransaksi.Columns(0)
                For a = 0 To tblTransaksi.Rows.Count - 1
                    CbMobil.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub
    Sub pelanggan_rental()
        tblTransaksi = process.ExecuteQuery("Select * From data_pelanggan order by id_pelanggan asc")
        If tblTransaksi.Rows.Count = 0 Then
        Else
            CbPelanggan.Items.Clear()
            With tblTransaksi.Columns(0)
                For a = 0 To tblTransaksi.Rows.Count - 1
                    CbPelanggan.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next
            End With
        End If
    End Sub
    Sub Arrange()
        IdTransaksiTxt.Text = ""
        LamaRentalTxt.Text = ""
        TanggalRentalTxt.Text = ""

        NamaPelangganTxt.Enabled = False
        NoKontakTxt.Enabled = False
        JenisMobilTxt.Enabled = False
        HargaSewaTxt.Enabled = False

        CbMobil.Text = ""
        CbPelanggan.Text = ""
        Call Code_Otomatic()
        Call Data_Record()
        Call pelanggan_rental()
        Call mobil()
    End Sub
    Private Sub CbMobil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbMobil.TextChanged
        tblTransaksi = process.ExecuteQuery("Select * From data_mobil where nomor_mobil = '" &
      Microsoft.VisualBasic.Left(CbMobil.Text, 7) & "' order by nomor_mobil asc")
        If tblTransaksi.Rows.Count = 0 Then
        Else
            With tblTransaksi.Rows(0)
                JenisMobilTxt.Text = .Item("jenis_mobil")
                HargaSewaTxt.Text = .Item("harga_sewa")

            End With
        End If
    End Sub
    Private Sub CbPelanggan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPelanggan.TextChanged
        tblTransaksi = process.ExecuteQuery("Select * From data_pelanggan where id_pelanggan ='" &
    Microsoft.VisualBasic.Left(CbPelanggan.Text, 7) & "' order by id_pelanggan asc")
        If tblTransaksi.Rows.Count = 0 Then
        Else
            With tblTransaksi.Rows(0)
                NamaPelangganTxt.Text = .Item("nama_pelanggan")
                NoKontakTxt.Text = .Item("nomor_kontak")
            End With
        End If
    End Sub

    Private Sub FrmTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Arrange()
    End Sub

    Private Sub ProsesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProsesBtn.Click
        If IdTransaksiTxt.Text = "" Then IdTransaksiTxt.Focus() : Exit Sub
        If LamaRentalTxt.Text = "" Then LamaRentalTxt.Focus() : Exit Sub
        If HargaSewaTxt.Text = "" Then HargaSewaTxt.Focus() : Exit Sub
        If TanggalRentalTxt.Text = "" Then TanggalRentalTxt.Focus() : Exit Sub

        If CbMobil.Text = "" Then CbMobil.Focus() : Exit Sub
        If CbPelanggan.Text = "" Then CbPelanggan.Focus() : Exit Sub
        Dim TotalHargaSewa As Integer
        TotalHargaSewa = LamaRentalTxt.Text * HargaSewaTxt.Text
        SQL = "Insert Into transaksi_rental Values ('" & IdTransaksiTxt.Text & "','" & LamaRentalTxt.Text & "','" & TanggalRentalTxt.Text & "','" & TotalHargaSewa & "','" &
        CbMobil.Text & "','" & CbPelanggan.Text & "')"
        process.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru Berhasil Di Simpan..!!", "Saving success",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Call Arrange()
    End Sub
    
    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If RadioButton1.Checked = True Then
            tblTransaksi = process.ExecuteQuery("Select * From data_pelanggan Where id_pelanggan Like '%" & TextBox5.Text & "%'")
            If tblTransaksi.Rows.Count = 0 Then
                DGTransaksi.DataSource = tblTransaksi
                TextBox5.Focus()
            Else
                DGTransaksi.DataSource = tblTransaksi
            End If
        ElseIf RadioButton2.Checked = True Then
            tblTransaksi = process.ExecuteQuery("Select * From data_mobil Where nomor_mobil Like '%" & TextBox5.Text & "%'")
            If tblTransaksi.Rows.Count = 0 Then
                DGTransaksi.DataSource = tblTransaksi
                TextBox5.Focus()
            Else
                DGTransaksi.DataSource = tblTransaksi
            End If
        End If
    End Sub
End Class