Public Class f_sub_kriteria
    Sub LoadForm()
        LoadKriteria()

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TampilData()

    End Sub

    Private Sub LoadKriteria()    
        MyConn.Close()
        SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA ORDER BY KD_KRITERIA"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DT = New DataTable
        Try
            MyDataAdapter.Fill(DT)
            CBKriteria.DataSource = DT
            CBKriteria.ValueMember = "KD_KRITERIA"
            CBKriteria.DisplayMember = "NM_KRITERIA"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TampilData()
        MyConn.Close()
        SQL = "SELECT KD_KRITERIA, KD_SUB_KRITERIA, NM_SUB_KRITERIA, NILAI, " _
            & "FROM T_SUB_KRITERIA ORDER BY KD_SUB_KRITERIA"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_SUB_KRITERIA")
        DataGridView1.DataSource = DS.Tables("T_SUB_KRITERIA")

        Try
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(2).Width = 50
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(0).HeaderText = "KD KRITERIA"
            DataGridView1.Columns(1).HeaderText = "KODE"
            DataGridView1.Columns(2).HeaderText = "NAMA SUB KRITERIA"
            DataGridView1.Columns(3).HeaderText = "NILAI"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        f_utama.PViewer.Controls.Clear()
        f_utama.LTitleForm.Text = "Menu : -"
    End Sub

    Private Sub CBKriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBKriteria.SelectedIndexChanged
        'MessageBox.Show(CBKriteria.SelectedValue.ToString)
    End Sub
End Class