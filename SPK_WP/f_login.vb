Public Class f_login

    Sub LoadForm()
        PForm.Left = (PScreen.Width - PForm.Width) / 2
        PForm.Top = (PScreen.Height - PForm.Height) / 2

        f_utama.MasterDataUserToolStripMenuItem.Visible = True
        f_utama.MasterDataToolStripMenuItem.Visible = True
        f_utama.PerhitunganWPToolStripMenuItem.Visible = True

        TBUser.Focus()
    End Sub

    Private Sub TBUser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBUser.KeyDown, TBPass.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBUser Then
                TBPass.Focus()
            ElseIf sender Is TBPass Then
                BtnLogin_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If TBUser.Text = "" Then
            MsgBox("Username tidak boleh kosong. Silahkan diisi terlebih dahulu", MsgBoxStyle.Exclamation, "Error")
            TBUser.Focus()
        ElseIf TBPass.Text = "" Then
            MsgBox("Password tidak boleh kosong. Silahkan diisi terlebih dahulu", MsgBoxStyle.Exclamation, "Error")
            TBPass.Focus()
        Else
            Try
                MyConn.Close()
                SQL = "SELECT * FROM T_USER " _
                    & "WHERE USERNAME='" & TBUser.Text & "' " _
                    & "AND PASSWORD='" & TBPass.Text & "' "
                MyConn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
                MyDataReader = MyCommand.ExecuteReader()

                If MyDataReader.HasRows = 0 Then
                    MsgBox("Login gagal, silahkan ulangi lagi dengan benar.", MsgBoxStyle.Exclamation, "Error Login")
                    TBUser.Clear()
                    TBPass.Clear()
                    TBUser.Focus()
                Else
                    MyDataReader.Read()
                    MsgBox("Selamat Datang " & MyDataReader!NM_USER, MsgBoxStyle.Information, "Login Berhasil")
                    USERLOGIN = MyDataReader!USERNAME
                    f_utama.ToolStripStatusLabel3.Text = "Login as : " & MyDataReader!NM_USER
                    f_utama.ToolStripStatusLabel3.Visible = True
                    f_utama.PViewer.Controls.Clear()
                    f_utama.MenuStrip1.Visible = True
                    f_utama.LTitleForm.Text = "Menu : -"
                    If MyDataReader!LEVEL = "1" Then
                        f_utama.MasterDataUserToolStripMenuItem.Visible = False
                        f_utama.MasterDataToolStripMenuItem.Visible = False
                        f_utama.PerhitunganWPToolStripMenuItem.Visible = False
                    End If
                    f_utama.MenuStrip1.Focus()                    
                End If
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Login")
            End Try
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