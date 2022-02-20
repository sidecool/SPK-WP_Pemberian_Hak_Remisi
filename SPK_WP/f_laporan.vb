Imports MySql.Data.MySqlClient

Public Class f_laporan

    Sub LoadForm()
        Cetak()
    End Sub

    Private Sub Cetak()
        MyConn.Close()
        MyConn.Open()
        SQL = "SELECT * FROM V_LAPORAN"
        Dim MyDataAdapter As New MySqlDataAdapter(SQL, MyConn)
        Dim DS As New DSLaporan
        MyDataAdapter.Fill(DS, "V_LAPORAN")
        MyConn.Close()
        MyConn.Open()

        Dim CReport As New Laporan
        CReport.SetDataSource(DS)
        CrystalReportViewer1.ReportSource = CReport
        CrystalReportViewer1.Refresh()
    End Sub
End Class