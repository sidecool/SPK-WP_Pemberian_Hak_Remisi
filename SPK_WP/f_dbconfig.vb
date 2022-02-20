Public Class f_dbconfig

    Private Sub LoadAwal()
        f_utama.MenuStrip1.Visible = False

        f_utama.LoadPanel(f_login)
        f_login.LoadForm()
        f_login.Dispose()
    End Sub

    Sub LoadForm()
        PFormShow.Left = (PScreen.Width - PFormShow.Width) / 2
        PFormShow.Top = (PScreen.Height - PFormShow.Height) / 2

        'menyiapkan string untuk menampung lokasi file .ini 
        Dim FilePath As String = Application.StartupPath & "\setting.ini"

        TBServer.Text = ReadIni(FilePath, "ConfigDB", "Server", "")
        TBPort.Text = ReadIni(FilePath, "ConfigDB", "Port", "")
        TBUser.Text = ReadIni(FilePath, "ConfigDB", "User", "")
        TBPass.Text = ReadIni(FilePath, "ConfigDB", "Password", "")
        TBDatabase.Text = ReadIni(FilePath, "ConfigDB", "DBName", "")

        'If cek_koneksi(TBServer.Text, TBPort.Text, TBUser.Text, TBPass.Text, TBDatabase.Text) = True Then
        'LoadAwal()
        'End If

        TBServer.Focus()
    End Sub

    Private Sub btnCek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCek.Click
        If cek_koneksi(TBServer.Text, TBPort.Text, TBUser.Text, TBPass.Text, TBDatabase.Text) = True Then
            MsgBox("Database terhubung", MsgBoxStyle.Information, "Informasi")
        Else
            MsgBox("Database tidak terhubung", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub TBServer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBServer.KeyDown, TBUser.KeyDown, TBPort.KeyDown, TBPass.KeyDown, TBDatabase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBServer Then
                TBPort.Focus()
            ElseIf sender Is TBPort Then
                TBUser.Focus()
            ElseIf sender Is TBUser Then
                TBPass.Focus()
            ElseIf sender Is TBPass Then
                TBDatabase.Focus()
            ElseIf sender Is TBDatabase Then
                If (TBServer.Text <> "") And (TBPort.Text <> "") And (TBUser.Text <> "") And (TBDatabase.Text <> "") Then
                    btnSimpan_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If TBServer.Text = "" Then
            ErrorProvider1.SetError(TBServer, "Server Host tidak boleh kosong.")
            TBServer.Focus()
        ElseIf TBPort.Text = "" Then
            ErrorProvider1.SetError(TBPort, "Port Number tidak boleh kosong.")
            TBPort.Focus()
        ElseIf TBUser.Text = "" Then
            ErrorProvider1.SetError(TBUser, "User Database tidak boleh kosong.")
            TBUser.Focus()
        ElseIf TBDatabase.Text = "" Then
            ErrorProvider1.SetError(TBDatabase, "Nama Database tidak boleh kosong.")
            TBDatabase.Focus()
        Else
            'menyiapkan string untuk menampung lokasi file .ini 
            Dim FilePath As String = Application.StartupPath & "\setting.ini"

            WriteIni(FilePath, "ConfigDB", "Server", TBServer.Text)
            WriteIni(FilePath, "ConfigDB", "Port", TBPort.Text)
            WriteIni(FilePath, "ConfigDB", "User", TBUser.Text)
            WriteIni(FilePath, "ConfigDB", "Password", TBPass.Text)
            WriteIni(FilePath, "ConfigDB", "DBName", TBDatabase.Text)
            If cek_koneksi(TBServer.Text, TBPort.Text, TBUser.Text, TBPass.Text, TBDatabase.Text) = True Then
                MsgBox("Konfigurasi berhasil disimpan", MsgBoxStyle.Information, "Informasi")
                Application.Restart()
            Else
                MsgBox("Database belum terhubung", MsgBoxStyle.Information, "Informasi")
            End If
        End If
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        End
    End Sub

    Private Sub TBPort_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBPort.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        ErrorProvider1.Clear()
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                ErrorProvider1.SetError(TBPort, "Port diisi dengan Angka")
                'MsgBox("Port diisi dengan Angka", MsgBoxStyle.Information, "Informasi Port")
            End If
        End If
    End Sub

    Private Sub Hide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        TBPass.UseSystemPasswordChar = False
        btnHide.Visible = False
    End Sub

    Private Sub Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        TBPass.UseSystemPasswordChar = True
        btnHide.Visible = True
    End Sub
End Class