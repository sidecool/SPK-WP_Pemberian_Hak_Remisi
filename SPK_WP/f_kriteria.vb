Public Class f_kriteria
    Dim IsDataBaru As Boolean

    Sub LoadForm()
        CBAtribut.Items.Clear()
        CBAtribut.Items.Insert(0, "0. Benefit")
        CBAtribut.Items.Insert(1, "1. Cost")
        CBAtribut.SelectedIndex = 0

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TampilData()

        KodeBaru()
        TBKode.Focus()
        TBNama.Focus()
    End Sub

    Sub KodeBaru()
        MyConn.Close()
        SQL = "SELECT KD_KRITERIA FROM T_KRITERIA " _
            & "WHERE KD_KRITERIA IN (SELECT MAX(KD_KRITERIA) FROM T_KRITERIA)"
        MyConn.Open()
        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
        Dim urut As String
        Dim hitung As Long
        MyDataReader = MyCommand.ExecuteReader
        MyDataReader.Read()
        If Not MyDataReader.HasRows Then
            urut = "C" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(MyDataReader.GetString(0), 3) + 1
            urut = "C" + Microsoft.VisualBasic.Right("000" & hitung, 3)        
        End If

        TBKode.Text = urut
        IsDataBaru = True
    End Sub

    Sub TampilData()
        MyConn.Close()
        SQL = "SELECT KD_KRITERIA, NM_KRITERIA, N_BOBOT, " _
            & "CASE WHEN N_ATRIBUT=0 THEN 'Benefit' ELSE 'Cost' END AS NM_ATRIBUT " _
            & "FROM T_KRITERIA ORDER BY KD_KRITERIA"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_KRITERIA")
        DataGridView1.DataSource = DS.Tables("T_KRITERIA")

        Try
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(2).Width = 50
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(0).HeaderText = "KODE"
            DataGridView1.Columns(1).HeaderText = "NAMA KRITERIA"
            DataGridView1.Columns(2).HeaderText = "NILAI BOBOT"
            DataGridView1.Columns(3).HeaderText = "ATRIBUT"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        f_utama.PViewer.Controls.Clear()
        f_utama.LTitleForm.Text = "Menu : -"
    End Sub

    Private Sub TBKode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKode.KeyDown, TBNama.KeyDown, TBBobot.KeyDown, CBAtribut.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBKode Then
                TBNama.Focus()
            ElseIf sender Is TBNama Then
                TBBobot.Focus()
            ElseIf sender Is TBBobot Then
                CBAtribut.Focus()
            ElseIf sender Is CBAtribut Then
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
            ErrorProvider1.SetError(TBNama, "Nama Kriteria tidak boleh kosong.")
            TBNama.Focus()
        ElseIf TBBobot.Text = "" Then
            ErrorProvider1.SetError(TBBobot, "Nilai Bobot tidak boleh kosong.")
            TBBobot.Focus()
        Else
            MyConn.Close()
            If IsDataBaru = True Then
                SQL = "INSERT INTO T_KRITERIA VALUES ('" & TBKode.Text & "'," _
                                                   & "'" & TBNama.Text & "'," _
                                                   & "'" & TBBobot.Text & "'," _
                                                   & "'" & CBAtribut.SelectedIndex & "')"
            ElseIf IsDataBaru = False Then
                SQL = "UPDATE T_KRITERIA SET NM_KRITERIA='" & TBNama.Text & "'," _
                    & "N_BOBOT='" & TBBobot.Text & "'," _
                    & "N_ATRIBUT='" & CBAtribut.SelectedIndex & "' " _
                    & "WHERE KD_KRITERIA='" & TBKode.Text & "'"
            End If
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

            Try
                MyCommand.ExecuteNonQuery()
                If IsDataBaru = True Then
                    MsgBox("Data '" & TBKode.Text & "' berhasil ditambahkan.", MsgBoxStyle.Information, "Berhasil")
                ElseIf IsDataBaru = False Then
                    MsgBox("Data '" & TBKode.Text & "' berhasil diperbaharui.", MsgBoxStyle.Information, "Berhasil")
                End If
                TampilData()                
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
                SQL = "DELETE FROM T_KRITERIA WHERE KD_KRITERIA='" & TBKode.Text & "'"
                MyConn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

                Try
                    MyCommand.ExecuteNonQuery()
                    MsgBox("Data '" & TBKode.Text & "' berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                    TampilData()                    
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
        TBBobot.Clear()
        CBAtribut.SelectedIndex = 0
        KodeBaru()        

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TBNama.Focus()
    End Sub

    Private Sub TBKode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBKode.Leave
        If TBKode.Text <> "" Then
            MyConn.Close()
            SQL = "SELECT * FROM T_KRITERIA WHERE KD_KRITERIA='" & TBKode.Text & "'"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows = 0 Then
                TBNama.Clear()
                TBBobot.Clear()
                CBAtribut.SelectedIndex = 0
                IsDataBaru = True
                BtnHapus.Enabled = False
                BtnBatal.Enabled = False
            Else
                MyDataReader.Read()
                TBNama.Text = MyDataReader!NM_KRITERIA
                TBBobot.Text = MyDataReader!N_BOBOT
                CBAtribut.SelectedIndex = MyDataReader!N_ATRIBUT
                IsDataBaru = False
                BtnHapus.Enabled = True
                BtnBatal.Enabled = True
            End If
        Else
            TBNama.Clear()
            TBBobot.Clear()
            CBAtribut.SelectedIndex = 0
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

    Private Sub TBBobot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBBobot.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        ErrorProvider1.Clear()
        If Asc(e.KeyChar) <> 8 Then 'Backspace
            If Asc(e.KeyChar) <> 44 Then 'Koma
                If Asc(e.KeyChar) <> 46 Then 'Titik
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        e.Handled = True
                        ErrorProvider1.SetError(TBBobot, "Bobot diisi dengan Angka")
                    End If
                End If
            End If
        End If
    End Sub
End Class