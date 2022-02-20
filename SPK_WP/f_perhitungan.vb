Imports MySql.Data.MySqlClient

Public Class f_perhitungan
    Sub LoadForm()
        TahunPenahanan.Value = Today

        Call LoadBobot()
        Call LoadBobotAlternatif("WHERE YEAR(TGL_TAHAN)='" & TahunPenahanan.Text & "'")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hitung_wp(TahunPenahanan.Text)

        LoadNormalisasi()
        LoadVektor()
        LoadHasil()
    End Sub

    Private Sub LoadHasil()
        MyConn.Close()
        SQL = "SELECT a.kd_alternatif, b.nm_alternatif, b.perkara, b.perilaku, b.jasa, " _
            & "b.masa_tahanan, a.n_preferensi FROM t_nilai_vektor a LEFT JOIN t_alternatif b ON a.kd_alternatif=b.kd_alternatif ORDER BY n_preferensi DESC"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "V_HASIL")
        DGVHasil.DataSource = DS.Tables("V_HASIL")

        Try
            DGVHasil.Columns(0).HeaderText = "ID"
            DGVHasil.Columns(1).HeaderText = "NAMA NARAPIDANA"
            DGVHasil.Columns(2).HeaderText = "PERKARA"
            DGVHasil.Columns(3).HeaderText = "PERILAKU"
            DGVHasil.Columns(4).HeaderText = "JASA"
            DGVHasil.Columns(5).HeaderText = "MASA TAHANAN"
            DGVHasil.Columns(6).HeaderText = "HASIL WP"
            'DGVHasil.Columns(7).HeaderText = "KETERANGAN"
            DGVHasil.ReadOnly = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadVektor()
        MyConn.Close()
        SQL = "SELECT a.kd_alternatif, b.nm_alternatif, a.n_vektor_s, a.n_preferensi " _
            & "FROM t_nilai_vektor a LEFT JOIN t_alternatif b ON a.kd_alternatif=b.kd_alternatif " _
            & "ORDER BY n_preferensi DESC"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "V_VEKTOR")
        DGVVektor.DataSource = DS.Tables("V_VEKTOR")

        Try
            DGVVektor.Columns(0).HeaderText = "ID"
            DGVVektor.Columns(1).HeaderText = "NAMA NARAPIDANA"
            DGVVektor.Columns(2).HeaderText = "NILAI VEKTOR S"
            DGVVektor.Columns(3).HeaderText = "NILAI PREFERENSI"
            DGVVektor.ReadOnly = True            
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadNormalisasi()
        MyConn.Close()
        SQL = "SELECT A.kd_kriteria, B.nm_kriteria, A.n_bobot " _
            & "FROM t_normalisasi_bobot A LEFT OUTER JOIN t_kriteria B ON A.kd_kriteria=B.kd_kriteria " _
            & "ORDER BY kd_kriteria"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_NORMALISASI_BOBOT")
        DGVNormalisasi.DataSource = DS.Tables("T_NORMALISASI_BOBOT")

        Try
            DGVNormalisasi.Columns(0).HeaderText = "KODE"
            DGVNormalisasi.Columns(1).HeaderText = "KRITERIA"
            DGVNormalisasi.Columns(2).HeaderText = "NORMALISASI BOBOT"
            DGVNormalisasi.ReadOnly = True
            DGVNormalisasi.Columns(0).Visible = False
            DGVNormalisasi.RowHeadersVisible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadBobot()
        MyConn.Close()
        SQL = "SELECT KD_KRITERIA, NM_KRITERIA, N_BOBOT, " _
            & "CASE WHEN N_ATRIBUT=0 THEN 'Benefit' ELSE 'Cost' END AS NM_ATRIBUT " _
            & "FROM T_KRITERIA ORDER BY KD_KRITERIA"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_KRITERIA")
        DGVBobot.DataSource = DS.Tables("T_KRITERIA")

        Try
            DGVBobot.Columns(0).HeaderText = "KODE"
            DGVBobot.Columns(1).HeaderText = "NAMA KRITERIA"
            DGVBobot.Columns(2).HeaderText = "NILAI BOBOT"
            DGVBobot.Columns(3).HeaderText = "ATRIBUT"
            DGVBobot.ReadOnly = True
            DGVBobot.Columns(0).Visible = False
            DGVBobot.RowHeadersVisible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadBobotAlternatif(ByVal SQLFilter As String)
        DGVAlternatif.Columns.Clear()
        MyConn.Close()
        SQL = "SELECT KD_ALTERNATIF AS KODE, NM_ALTERNATIF AS NAMA " _
            & "FROM T_ALTERNATIF " & SQLFilter & " ORDER BY NM_ALTERNATIF"
        MyConn.Open()
        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        Dim i As Integer = 0
        While MyDataReader.Read
            If i = 0 Then
                DGVAlternatif.Columns.Add("", "No. ID")
                DGVAlternatif.Columns.Add("", "Nama Narapidana")
            End If
            DGVAlternatif.Rows.Add()
            DGVAlternatif.Item(0, i).Value = MyDataReader!KODE
            DGVAlternatif.Item(1, i).Value = MyDataReader!NAMA

            RearConn.Close()
            SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA ORDER BY KD_KRITERIA"
            RearConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, RearConn)
            Dim DataReaderKriteria As MySql.Data.MySqlClient.MySqlDataReader
            DataReaderKriteria = MyCommand.ExecuteReader
            Dim j As Integer = 0
            While DataReaderKriteria.Read
                If i = 0 Then
                    DGVAlternatif.Columns.Add(DataReaderKriteria!KD_KRITERIA, DataReaderKriteria!NM_KRITERIA)
                End If

                Rear2Conn.Close()
                SQL = "SELECT N_PENILAIAN_ANGKA FROM T_NILAI_BOBOT " _
                    & "WHERE KD_BOBOT='" & MyDataReader!KODE & DataReaderKriteria!KD_KRITERIA & "'"
                Rear2Conn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, Rear2Conn)
                Dim DataReaderBobot As MySql.Data.MySqlClient.MySqlDataReader
                DataReaderBobot = MyCommand.ExecuteReader
                While DataReaderBobot.Read
                    DGVAlternatif.Item(j + 2, i).Value = DataReaderBobot!N_PENILAIAN_ANGKA
                    DGVAlternatif.Columns(j + 2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End While
                DataReaderBobot.Close()
                j += 1
            End While
            DataReaderKriteria.Close()
            i += 1
        End While
        MyDataReader.Close()

        DGVAlternatif.ReadOnly = True
        DGVAlternatif.Columns(0).Visible = False
        DGVBobot.RowHeadersVisible = False
    End Sub

    Private Sub DGVVektor_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGVVektor.CellFormatting
        DGVVektor.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DGVHasil_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGVHasil.CellFormatting
        DGVHasil.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub BtnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFilter.Click
        Call LoadBobotAlternatif("WHERE YEAR(TGL_TAHAN)='" & TahunPenahanan.Text & "'")
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged        
        If TabControl1.SelectedIndex = 2 Then
            Dim Konfirmasi As String
            Konfirmasi = MsgBox("[Yes] : Print Hasil Perhitungan." & vbLf _
                              & "[No] : Melihat Hasil Perhitungan.", MsgBoxStyle.YesNo, "Konfirmasi")
            If Konfirmasi = DialogResult.Yes Then
                f_utama.PrintLaporan()
            ElseIf Konfirmasi = DialogResult.No Then
            End If
        End If
    End Sub
End Class