Imports MySql.Data.MySqlClient

Module metode_wp
    Dim JmlKriteria As Integer = 0
    Dim JmlAlternatif As Integer = 0
    Dim n_atribut(), n_bobot(), p_bobot(), tot_bobot As Double
    Dim kode_krt() As String

    Private Sub perbaikan_bobot()
        MyConn.Close()
        SQL = "SELECT COUNT(*) AS JML_BARIS FROM T_KRITERIA"
        MyConn.Open()
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        MyDataReader.Read()
        JmlKriteria = MyDataReader!JML_BARIS
        MyDataReader.Close()

        ReDim n_atribut(JmlKriteria)
        ReDim n_bobot(JmlKriteria)
        ReDim p_bobot(JmlKriteria)
        ReDim kode_krt(JmlKriteria)

        MyConn.Close()
        SQL = "SELECT KD_KRITERIA, N_ATRIBUT, N_BOBOT FROM T_KRITERIA ORDER BY KD_KRITERIA"
        MyConn.Open()
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader        

        tot_bobot = 0
        Dim i As Integer = 0
        While MyDataReader.Read
            kode_krt(i) = MyDataReader!KD_KRITERIA

            n_atribut(i) = MyDataReader!N_ATRIBUT
            n_bobot(i) = MyDataReader!N_BOBOT
            tot_bobot += n_bobot(i)
            i += 1
        End While

        For i = 0 To JmlKriteria - 1
            If n_atribut(i) = "0" Then
                p_bobot(i) = n_bobot(i) / tot_bobot
            ElseIf n_atribut(i) = "1" Then
                p_bobot(i) = -(n_bobot(i) / tot_bobot)
            End If

            MyConn.Close()
            SQL = "INSERT INTO T_NORMALISASI_BOBOT (KD_KRITERIA, N_BOBOT) " _
                & "VALUES ('" & kode_krt(i) & "', '" & p_bobot(i) & "') " _
                & "ON DUPLICATE KEY UPDATE N_BOBOT=VALUES(N_BOBOT)"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyCommand.ExecuteNonQuery()
            'Simpan Bobot ke tabel t_normalisasi_bobot dengan field kode_krt(i), p_bobot(i)
        Next
    End Sub

    Dim vektor_s(), n_pangkat, tot_vektor_s As Double
    Dim kode_alt() As String

    Private Sub nilai_vektor_s(ByVal SQLFilter As String)
        MyConn.Close()
        SQL = "SELECT COUNT(*) AS JML_BARIS FROM T_ALTERNATIF " & SQLFilter
        MyConn.Open()
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        MyDataReader.Read()
        JmlAlternatif = MyDataReader!JML_BARIS
        MyDataReader.Close()

        ReDim vektor_s(JmlAlternatif)
        ReDim kode_alt(JmlAlternatif)

        MyConn.Close()
        SQL = "SELECT KD_ALTERNATIF FROM T_ALTERNATIF " & SQLFilter & " ORDER BY KD_ALTERNATIF"
        MyConn.Open()
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader

        tot_vektor_s = 0
        Dim i As Integer = 0
        While MyDataReader.Read
            kode_alt(i) = MyDataReader!KD_ALTERNATIF

            RearConn.Close()
            SQL = "SELECT KD_KRITERIA FROM T_KRITERIA ORDER BY KD_KRITERIA"
            RearConn.Open()
            MyCommand = New MySqlCommand(SQL, RearConn)
            Dim DataReaderKriteria As MySqlDataReader
            DataReaderKriteria = MyCommand.ExecuteReader

            Dim j As Integer = 0
            While DataReaderKriteria.Read
                Rear2Conn.Close()
                SQL = "SELECT N_PENILAIAN_ANGKA FROM T_NILAI_BOBOT " _
                    & "WHERE KD_BOBOT='" & MyDataReader!KD_ALTERNATIF & DataReaderKriteria!KD_KRITERIA & "'"
                Rear2Conn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, Rear2Conn)
                Dim DataReaderBobot As MySql.Data.MySqlClient.MySqlDataReader
                DataReaderBobot = MyCommand.ExecuteReader
                While DataReaderBobot.Read
                    If j = 0 Then
                        n_pangkat = DataReaderBobot!N_PENILAIAN_ANGKA ^ Math.Round(p_bobot(j), 2)
                    ElseIf j > 0 Then
                        n_pangkat = n_pangkat * (DataReaderBobot!N_PENILAIAN_ANGKA ^ Math.Round(p_bobot(j), 2))
                    End If
                End While
                DataReaderBobot.Close()
                j += 1
            End While
            vektor_s(i) = n_pangkat
            tot_vektor_s += vektor_s(i)
            DataReaderKriteria.Close()
            i += 1
        End While
        MyDataReader.Close()

        For i = 0 To JmlAlternatif - 1
            'MsgBox(kode_alt(i) & " Vector S " & i & " : " & vektor_s(i))
            MyConn.Close()
            SQL = "INSERT INTO T_NILAI_VEKTOR (KD_ALTERNATIF, N_VEKTOR_S) VALUES ('" & kode_alt(i) & "', '" & Replace(vektor_s(i), ",", ".") & "') ON DUPLICATE KEY UPDATE N_VEKTOR_S=VALUES(N_VEKTOR_S)"
            'MsgBox(SQL)
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyCommand.ExecuteNonQuery()
        Next
    End Sub

    Dim n_preferensi() As Double

    Private Sub nilai_preferensi()
        ReDim n_preferensi(JmlAlternatif)

        Dim i As Integer
        For i = 0 To JmlAlternatif - 1
            n_preferensi(i) = Math.Round(vektor_s(i) / tot_vektor_s, 3)
        Next

        For i = 0 To JmlAlternatif - 1
            'MsgBox(kode_alt(i) & " Nilai Preferensi " & i & " : " & n_preferensi(i))
            MyConn.Close()
            SQL = "INSERT INTO T_NILAI_VEKTOR (KD_ALTERNATIF, N_PREFERENSI) VALUES ('" & kode_alt(i) & "', '" & Replace(n_preferensi(i), ",", ".") & "') ON DUPLICATE KEY UPDATE N_PREFERENSI=VALUES(N_PREFERENSI)"
            'MsgBox(SQL)
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyCommand.ExecuteNonQuery()
        Next
    End Sub

    Private Sub perankingan()

    End Sub

    Private Sub TRUNC_TABLE(ByVal SQLString As String)
        MyConn.Close()
        MyConn.Open()
        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQLString, MyConn)
        MyCommand.ExecuteNonQuery()
    End Sub

    Sub hitung_wp(ByVal Tahun As String)
        perbaikan_bobot()
        TRUNC_TABLE("TRUNCATE TABLE T_NILAI_VEKTOR")
        nilai_vektor_s("WHERE YEAR(TGL_TAHAN)='" & Tahun & "'")
        nilai_preferensi()
        'perankingan()
    End Sub
End Module
