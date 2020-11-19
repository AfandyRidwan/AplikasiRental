Public Class Form1

    Private Sub InputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputToolStripMenuItem.Click
        FrmDataMobil.Show()
    End Sub

    Private Sub InputDataPelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataPelangganToolStripMenuItem.Click
        FrmDataPelanggan.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Tanya = MessageBox.Show("Anda Yakin Akan Menutup Aplikasi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tanya = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        FrmTransaksi.Show()
    End Sub
End Class
