Public Class f_alternatif
    Dim IsDataBaru As Boolean

    Sub LoadForm()
        SetTableAlternatif()

        With DataGridView1
            .Columns(0).Visible = False
            .Columns(1).Width = 250
            .Columns(1).HeaderText = "NAMA NARAPIDANA"
            .Columns(1).ReadOnly = True            
        End With
    End Sub

    Sub SetTableAlternatif()
        DataGridView1.Columns.Clear()
        MyConn.Close()
        SQL = "SELECT KD_ALTERNATIF AS KODE, NM_ALTERNATIF AS NAMA " _
            & "FROM T_ALTERNATIF ORDER BY NM_ALTERNATIF"
        MyConn.Open()
        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        Dim i As Integer = 0
        While MyDataReader.Read
            If i = 0 Then
                DataGridView1.Columns.Add("", "No. ID")
                DataGridView1.Columns.Add("", "Nama Narapidana")
            End If
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = MyDataReader!KODE
            DataGridView1.Item(1, i).Value = MyDataReader!NAMA

            RearConn.Close()
            SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA ORDER BY KD_KRITERIA"
            RearConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, RearConn)
            Dim DataReaderKriteria As MySql.Data.MySqlClient.MySqlDataReader
            DataReaderKriteria = MyCommand.ExecuteReader
            Dim j As Integer = 0
            While DataReaderKriteria.Read
                If i = 0 Then
                    DataGridView1.Columns.Add(DataReaderKriteria!KD_KRITERIA, DataReaderKriteria!NM_KRITERIA)
                End If

                Rear2Conn.Close()
                SQL = "SELECT N_PENILAIAN_ANGKA FROM T_NILAI_BOBOT " _
                    & "WHERE KD_BOBOT='" & MyDataReader!KODE & DataReaderKriteria!KD_KRITERIA & "'"
                Rear2Conn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, Rear2Conn)
                Dim DataReaderBobot As MySql.Data.MySqlClient.MySqlDataReader
                DataReaderBobot = MyCommand.ExecuteReader
                While DataReaderBobot.Read
                    DataGridView1.Item(j + 2, i).Value = DataReaderBobot!N_PENILAIAN_ANGKA
                End While
                DataReaderBobot.Close()
                j += 1
            End While
            DataReaderKriteria.Close()
            i += 1
        End While
        MyDataReader.Close()
    End Sub

    Dim N_BOBOT, N_ATRIBUT As String
    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If CStr(DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value) <> "" Then
            MyConn.Close()
            SQL = "SELECT N_BOBOT, N_ATRIBUT FROM T_KRITERIA WHERE KD_KRITERIA='" & DataGridView1.Columns(e.ColumnIndex).Name & "'"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader
            If MyDataReader.HasRows Then
                MyDataReader.Read()

                N_BOBOT = MyDataReader!N_BOBOT
                N_ATRIBUT = MyDataReader!N_ATRIBUT
            End If
            MyDataReader.Close()

            MyDataReader = MyCommand.ExecuteReader
            If MyDataReader.HasRows Then
                MyDataReader.Read()

                N_BOBOT = MyDataReader!N_BOBOT
                N_ATRIBUT = MyDataReader!N_ATRIBUT
            End If
            MyDataReader.Close()

            MyConn.Close()
            SQL = "INSERT INTO T_NILAI_BOBOT (KD_BOBOT, KD_ALTERNATIF, KD_KRITERIA, N_PENILAIAN_ANGKA) " _
                & "VALUES (?, ? , ?, ?) ON DUPLICATE KEY UPDATE N_PENILAIAN_ANGKA=VALUES(N_PENILAIAN_ANGKA)"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyCommand.Parameters.Add("@KD_BOBOT", MySql.Data.MySqlClient.MySqlDbType.String).Value = DataGridView1.Item(0, e.RowIndex).Value & DataGridView1.Columns(e.ColumnIndex).Name
            MyCommand.Parameters.Add("@KD_ALTERNATIF", MySql.Data.MySqlClient.MySqlDbType.String).Value = DataGridView1.Item(0, e.RowIndex).Value
            MyCommand.Parameters.Add("@KD_KRITERIA", MySql.Data.MySqlClient.MySqlDbType.String).Value = DataGridView1.Columns(e.ColumnIndex).Name
            MyCommand.Parameters.Add("@N_PENILAIAN_ANGKA", MySql.Data.MySqlClient.MySqlDbType.String).Value = DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value
            MyCommand.ExecuteNonQuery()

            DataGridView1.Columns(e.ColumnIndex).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub
End Class