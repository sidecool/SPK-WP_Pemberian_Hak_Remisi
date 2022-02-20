Public Class f_data_napi
    Dim IsDataBaru As Boolean

    Sub LoadForm()
        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TampilData("")
        TampilCombo()
        DTPTahan.Value = Today
        DTPPutusan.Value = Today
        TahunPenahanan.Value = Today
        
        KodeBaru()
        TBKode.Focus()
        TBNama.Focus()
    End Sub

    Sub KodeBaru()
        MyConn.Close()
        SQL = "SELECT KD_ALTERNATIF FROM T_ALTERNATIF " _
            & "WHERE KD_ALTERNATIF IN (SELECT MAX(KD_ALTERNATIF) FROM T_ALTERNATIF)"
        MyConn.Open()
        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
        Dim urut As String
        Dim hitung As Long
        MyDataReader = MyCommand.ExecuteReader
        MyDataReader.Read()
        If Not MyDataReader.HasRows Then
            urut = "A" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(MyDataReader.GetString(0), 3) + 1
            urut = "A" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If

        TBKode.Text = urut
        IsDataBaru = True
    End Sub

    Sub TampilData(ByVal SQLFilter As String)
        MyConn.Close()
        SQL = "SELECT KD_ALTERNATIF, NM_ALTERNATIF, PERKARA, PERILAKU, JASA, MASA_TAHANAN " _
            & "FROM T_ALTERNATIF " & SQLFilter & " ORDER BY KD_ALTERNATIF"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_ALTERNATIF")
        DataGridView1.DataSource = DS.Tables("T_ALTERNATIF")

        Try
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(0).HeaderText = "KODE"
            DataGridView1.Columns(1).HeaderText = "NAMA NARAPIDANA"
            DataGridView1.Columns(2).HeaderText = "PERKARA"
            DataGridView1.Columns(3).HeaderText = "PERILAKU"
            DataGridView1.Columns(4).HeaderText = "JASA"
            DataGridView1.Columns(5).HeaderText = "MASA TAHANAN"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TampilCombo()
        CBAgama.Items.Clear()
        CBAgama.Items.Add("-- Pilih Agama --")
        CBAgama.Items.Add("Buddha")
        CBAgama.Items.Add("Hindu")
        CBAgama.Items.Add("Islam")
        CBAgama.Items.Add("Katholik")
        CBAgama.Items.Add("Kong Hu Cu")
        CBAgama.Items.Add("Kristen")
        CBAgama.SelectedIndex = 0

        CBPerkara.Items.Clear()
        CBPerkara.Items.Insert(0, "-- Pilih Perkara Pidana --")
        CBPerkara.Items.Insert(1, "Narapidana melakukan tindak pidana umum dan khusus")
        CBPerkara.Items.Insert(2, "Narapidana melakukan lebih dari satu tindak pidana khusus")
        CBPerkara.Items.Insert(3, "Narapidana melakukan satu tindak pidana khusus")
        CBPerkara.Items.Insert(4, "Narapidana melakukan lebih dari satu tindak pidana umum")
        CBPerkara.Items.Insert(5, "Narapidana melakukan satu tindak pidana umum")
        CBPerkara.SelectedIndex = 0

        CBPerilaku.Items.Clear()
        CBPerilaku.Items.Insert(0, "-- Pilih Perilaku --")
        CBPerilaku.Items.Insert(1, "Buruk")
        CBPerilaku.Items.Insert(2, "Kurang Baik")
        CBPerilaku.Items.Insert(3, "Cukup")
        CBPerilaku.Items.Insert(4, "Baik")
        CBPerilaku.Items.Insert(5, "Sangat Baik")
        CBPerilaku.SelectedIndex = 0

        CBJasa.Items.Clear()
        CBJasa.Items.Insert(0, "-- Pilih Jasa --")
        CBJasa.Items.Insert(1, "Tidak berpartisipasi dalam kegiatan")
        CBJasa.Items.Insert(2, "Ikut menjaga keamanan dalam lingkungan lembaga pemasyarakatan")
        CBJasa.Items.Insert(3, "Donor darah")
        CBJasa.Items.Insert(4, "Menghasilkan karya dalam ilmu pengetahuan")
        CBJasa.Items.Insert(5, "Menjadi seorang pemuka dalam lembaga pemasyarakatan")
        CBJasa.SelectedIndex = 0

        CBMasaTahanan.Items.Clear()
        CBMasaTahanan.Items.Insert(0, "-- Pilih Masa Tahanan --")
        CBMasaTahanan.Items.Insert(1, "6 sampai 12 bulan")
        CBMasaTahanan.Items.Insert(2, "12 bulan lebih")
        CBMasaTahanan.Items.Insert(3, "Tahun kedua")
        CBMasaTahanan.Items.Insert(4, "Tahun ketiga")
        CBMasaTahanan.Items.Insert(5, "Tahun keempat dan kelima")
        CBMasaTahanan.Items.Insert(6, "Tahun keenam dan seterusnya")
        CBMasaTahanan.SelectedIndex = 0

    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        f_utama.PViewer.Controls.Clear()
        f_utama.LTitleForm.Text = "Menu : -"
    End Sub

    Private Sub TBKode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKode.KeyDown, TBNama.KeyDown, TBPasal.KeyDown, CBAgama.KeyDown, DTPTahan.KeyDown, DTPPutusan.KeyDown, TBPutusan.KeyDown, TBAsal.KeyDown, CBJasa.KeyDown, CBMasaTahanan.KeyDown, CBPerilaku.KeyDown, CBPerkara.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBKode Then
                TBNama.Focus()
            ElseIf sender Is TBNama Then
                CBAgama.Focus()
            ElseIf sender Is CBAgama Then
                CBPerkara.Focus()
            ElseIf sender Is CBPerkara Then
                TBPasal.Focus()
            ElseIf sender Is TBPasal Then
                DTPTahan.Focus()
            ElseIf sender Is DTPTahan Then
                TBPutusan.Focus()
            ElseIf sender Is TBPutusan Then
                DTPPutusan.Focus()
            ElseIf sender Is DTPPutusan Then
                TBAsal.Focus()
            ElseIf sender Is TBAsal Then
                CBPerilaku.Focus()
            ElseIf sender Is CBPerilaku Then
                CBJasa.Focus()
            ElseIf sender Is CBJasa Then
                CBMasaTahanan.Focus()
            ElseIf sender Is CBMasaTahanan Then
                BtnSimpan_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        ErrorProvider1.Clear()
        If TBKode.Text = "" Then
            ErrorProvider1.SetError(TBKode, "Kode tidak boleh kosong.")
            TBKode.Focus()
        ElseIf TBNama.Text = "" Then
            ErrorProvider1.SetError(TBNama, "Nama Alternatif tidak boleh kosong.")
            TBNama.Focus()
        ElseIf CBPerkara.SelectedIndex = 0 Then
            ErrorProvider1.SetError(CBPerkara, "Perkara belum dipilih.")
            CBPerkara.Focus()
        ElseIf CBPerilaku.SelectedIndex = 0 Then
            ErrorProvider1.SetError(CBPerilaku, "Perilaku belum dipilih.")
            CBPerilaku.Focus()
        ElseIf CBJasa.SelectedIndex = 0 Then
            ErrorProvider1.SetError(CBJasa, "Jasa belum dipilih.")
            CBJasa.Focus()
        ElseIf CBMasaTahanan.SelectedIndex = 0 Then
            ErrorProvider1.SetError(CBMasaTahanan, "Masa Tahanan belum dipilih.")
            CBMasaTahanan.Focus()
        Else
            MyConn.Close()
            If IsDataBaru = True Then
                SQL = "INSERT INTO T_ALTERNATIF VALUES ('" & TBKode.Text & "'," _
                                                     & "'" & TBNama.Text & "'," _
                                                     & "'" & CBPerkara.Text & "'," _
                                                     & "'" & CBPerkara.SelectedIndex & "'," _
                                                     & "'" & TBPasal.Text & "'," _
                                                     & "'" & CBAgama.Text & "'," _
                                                     & "'" & DTPTahan.Value.Date.ToString("yyyy-MM-dd") & "'," _
                                                     & "'" & DTPPutusan.Value.Date.ToString("yyyy-MM-dd") & "'," _
                                                     & "'" & TBPutusan.Text & "'," _
                                                     & "'" & TBAsal.Text & "'," _
                                                     & "'" & CBPerilaku.Text & "'," _
                                                     & "'" & CBPerilaku.SelectedIndex & "'," _
                                                     & "'" & CBJasa.Text & "'," _
                                                     & "'" & CBJasa.SelectedIndex & "'," _
                                                     & "'" & CBMasaTahanan.Text & "'," _
                                                     & "'" & CBMasaTahanan.SelectedIndex & "')"

            ElseIf IsDataBaru = False Then
                SQL = "UPDATE T_ALTERNATIF SET NM_ALTERNATIF='" & TBNama.Text & "'," _
                    & "PERKARA='" & CBPerkara.Text & "'," _
                    & "N_PERKARA='" & CBPerkara.SelectedIndex & "'," _
                    & "PASAL='" & TBPasal.Text & "'," _
                    & "AGAMA='" & CBAgama.Text & "'," _
                    & "TGL_TAHAN='" & DTPTahan.Value.Date.ToString("yyyy-MM-dd") & "'," _
                    & "TGL_PUTUSAN='" & DTPPutusan.Value.Date.ToString("yyyy-MM-dd") & "'," _
                    & "NO_PUTUSAN='" & TBPutusan.Text & "'," _
                    & "ASAL_PUTUSAN='" & TBAsal.Text & "'," _
                    & "PERILAKU='" & CBPerilaku.Text & "'," _
                    & "N_PERILAKU='" & CBPerilaku.SelectedIndex & "'," _
                    & "JASA='" & CBJasa.Text & "'," _
                    & "N_JASA='" & CBJasa.SelectedIndex & "'," _
                    & "MASA_TAHANAN='" & CBMasaTahanan.Text & "'," _
                    & "N_MASA_TAHANAN='" & CBMasaTahanan.SelectedIndex & "'" _
                    & "WHERE KD_ALTERNATIF='" & TBKode.Text & "'"
            End If
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

            Try
                MyCommand.ExecuteNonQuery()

                'simpan ke tabel t_nilai_bobot
                MyConn.Close()
                SQL = "DELETE FROM T_NILAI_BOBOT WHERE KD_ALTERNATIF='" & TBKode.Text & "'"
                MyConn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
                MyCommand.ExecuteNonQuery()

                MyConn.Close()
                SQL = "INSERT INTO T_NILAI_BOBOT (KD_BOBOT, KD_ALTERNATIF, KD_KRITERIA, N_PENILAIAN_ANGKA) VALUES " _
                    & "('" & TBKode.Text & "C001', '" & TBKode.Text & "', 'C001', '" & CBPerkara.SelectedIndex & "'), " _
                    & "('" & TBKode.Text & "C002', '" & TBKode.Text & "', 'C002', '" & CBPerilaku.SelectedIndex & "'), " _
                    & "('" & TBKode.Text & "C003', '" & TBKode.Text & "', 'C003', '" & CBJasa.SelectedIndex & "'), " _
                    & "('" & TBKode.Text & "C004', '" & TBKode.Text & "', 'C004', '" & CBMasaTahanan.SelectedIndex & "')  "
                MyConn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
                MyCommand.ExecuteNonQuery()

                If IsDataBaru = True Then
                    MsgBox("Data '" & TBKode.Text & "' berhasil ditambahkan.", MsgBoxStyle.Information, "Berhasil")
                ElseIf IsDataBaru = False Then
                    MsgBox("Data '" & TBKode.Text & "' berhasil diperbaharui.", MsgBoxStyle.Information, "Berhasil")
                End If
                TampilData("")
                BtnBatal_Click(sender, e)
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
            End Try
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TBKode.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus.", MsgBoxStyle.Exclamation, "Error")
            TBKode.Focus()
        Else
            If MessageBox.Show("Apakah Anda ingin menghapus data '" & TBKode.Text & "' ?", "Konfirmasi", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MyConn.Close()
                SQL = "DELETE FROM T_ALTERNATIF WHERE KD_ALTERNATIF='" & TBKode.Text & "'"
                MyConn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

                Try
                    MyCommand.ExecuteNonQuery()
                    MsgBox("Data '" & TBKode.Text & "' berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                    TampilData("")
                    BtnBatal_Click(sender, e)
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
                End Try
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        TBKode.Clear()
        TBNama.Clear()
        CBPerkara.SelectedIndex = 0
        TBPasal.Clear()
        TBPutusan.Clear()
        CBAgama.SelectedIndex = 0
        DTPTahan.Value = Today
        DTPPutusan.Value = Today
        TBPutusan.Clear()
        TBAsal.Clear()
        CBPerilaku.SelectedIndex = 0
        CBJasa.SelectedIndex = 0
        CBMasaTahanan.SelectedIndex = 0

        KodeBaru()

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TBNama.Focus()
    End Sub

    Private Sub TBKode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBKode.Leave
        If TBKode.Text <> "" Then
            MyConn.Close()
            SQL = "SELECT * FROM T_ALTERNATIF WHERE KD_ALTERNATIF='" & TBKode.Text & "'"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows = 0 Then
                TBNama.Clear()
                CBPerkara.SelectedIndex = 0
                TBPasal.Clear()
                CBAgama.SelectedIndex = 0
                DTPTahan.Value = Today
                DTPPutusan.Value = Today
                TBPutusan.Clear()
                TBAsal.Clear()
                CBPerilaku.SelectedIndex = 0
                CBJasa.SelectedIndex = 0
                CBMasaTahanan.SelectedIndex = 0
                IsDataBaru = True
                BtnHapus.Enabled = False
                BtnBatal.Enabled = False
            Else
                MyDataReader.Read()
                TBNama.Text = MyDataReader!NM_ALTERNATIF
                If IsDBNull(MyDataReader!PERKARA) Then
                    CBPerkara.SelectedIndex = 0
                Else
                    CBPerkara.SelectedIndex = CBPerkara.FindString(MyDataReader!PERKARA)
                End If
                If IsDBNull(MyDataReader!PASAL) Then
                    TBPasal.Text = ""
                Else
                    TBPasal.Text = MyDataReader!PASAL
                End If
                If IsDBNull(MyDataReader!AGAMA) Then
                    CBAgama.SelectedIndex = 0
                Else
                    CBAgama.SelectedIndex = CBAgama.FindString(MyDataReader!AGAMA)
                End If
                If IsDBNull(MyDataReader!TGL_TAHAN) Then
                    DTPTahan.Value = Today
                Else
                    DTPTahan.Value = MyDataReader!TGL_TAHAN
                End If
                If IsDBNull(MyDataReader!TGL_PUTUSAN) Then
                    DTPPutusan.Value = Today
                Else
                    DTPPutusan.Value = MyDataReader!TGL_PUTUSAN
                End If
                If IsDBNull(MyDataReader!NO_PUTUSAN) Then
                    TBPutusan.Text = ""
                Else
                    TBPutusan.Text = MyDataReader!NO_PUTUSAN
                End If
                If IsDBNull(MyDataReader!ASAL_PUTUSAN) Then
                    TBAsal.Text = ""
                Else
                    TBAsal.Text = MyDataReader!ASAL_PUTUSAN
                End If
                If IsDBNull(MyDataReader!PERILAKU) Then
                    CBPerilaku.SelectedIndex = 0
                Else
                    CBPerilaku.SelectedIndex = CBPerilaku.FindString(MyDataReader!PERILAKU)
                End If
                If IsDBNull(MyDataReader!JASA) Then
                    CBJasa.SelectedIndex = 0
                Else
                    CBJasa.SelectedIndex = CBJasa.FindString(MyDataReader!JASA)
                End If
                If IsDBNull(MyDataReader!MASA_TAHANAN) Then
                    CBMasaTahanan.SelectedIndex = 0
                Else
                    CBMasaTahanan.SelectedIndex = CBMasaTahanan.FindString(MyDataReader!MASA_TAHANAN)
                End If
                IsDataBaru = False
                BtnHapus.Enabled = True
                BtnBatal.Enabled = True
            End If
        Else
            TBNama.Clear()
            CBPerkara.SelectedIndex = 0
            TBPasal.Clear()
            CBAgama.SelectedIndex = 0
            DTPTahan.Value = Today
            DTPPutusan.Value = Today
            TBPutusan.Clear()
            TBAsal.Clear()
            CBPerilaku.SelectedIndex = 0
            CBJasa.SelectedIndex = 0
            CBMasaTahanan.SelectedIndex = 0
            IsDataBaru = True
            BtnHapus.Enabled = False
            BtnBatal.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(0).Value) Then
                TBKode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                TBKode_Leave(sender, e)
                TBNama.Focus()
            End If
        End If
    End Sub

    Private Sub CBAgama_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBAgama.KeyPress, CBPerilaku.KeyPress, CBPerkara.KeyPress, CBJasa.KeyPress, CBMasaTahanan.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFilter.Click
        Call TampilData("WHERE YEAR(TGL_TAHAN)='" & TahunPenahanan.Text & "'")
    End Sub
End Class