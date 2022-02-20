Public Class f_utama
    Public Sub LoadPanel(ByVal _Form As System.Windows.Forms.Form)
        LTitleForm.Text = "Menu : " & _Form.Text
        PViewer.Controls.Clear()
        For Each FormCtrl As Control In _Form.Controls
            PViewer.Controls.Add(FormCtrl)
        Next
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = "Jam : " & Format(TimeOfDay, "hh:mm:ss")
    End Sub

    Private Sub f_utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'menyiapkan string untuk menampung lokasi file .ini 
        Dim FilePath As String = Application.StartupPath & "\setting.ini"

        If System.IO.File.Exists(FilePath) Then
            Dim Server = ReadIni(FilePath, "ConfigDB", "Server", "")
            Dim Port = ReadIni(FilePath, "ConfigDB", "Port", "")
            Dim User = ReadIni(FilePath, "ConfigDB", "User", "")
            Dim Pass = ReadIni(FilePath, "ConfigDB", "Password", "")
            Dim DBName = ReadIni(FilePath, "ConfigDB", "DBName", "")

            If cek_koneksi(Server, Port, User, Pass, DBName) = True Then
                LoadPanel(f_login)
                f_login.LoadForm()
                f_login.Dispose()
            Else
                LoadPanel(f_dbconfig)
                f_dbconfig.LoadForm()
            End If
        Else
            LoadPanel(f_dbconfig)
            f_dbconfig.LoadForm()
        End If

        ToolStripStatusLabel1.Text = "Tanggal : " & Format(Date.Today, "dd/MM/yyyy")
        ToolStripStatusLabel3.Visible = False
        Timer1.Start()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MenuStrip1.Visible = False
        ToolStripStatusLabel3.Text = "Login as : "
        ToolStripStatusLabel3.Visible = False

        LoadPanel(f_login)
        f_login.LoadForm()
        f_login.Dispose()        
    End Sub

    Public Sub LogoutClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LogoutToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub HalamanUtamaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HalamanUtamaToolStripMenuItem.Click
        PViewer.Controls.Clear()
        LTitleForm.Text = "Menu : -"
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterDataUserToolStripMenuItem.Click
        LoadPanel(f_user)
        f_user.LoadForm()
        f_user.Dispose()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        LoadPanel(f_ganti_paswd)
        f_ganti_paswd.LoadForm()
        f_ganti_paswd.Dispose()
    End Sub

    Private Sub DataKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKriteriaToolStripMenuItem.Click
        LoadPanel(f_kriteria)
        f_kriteria.LoadForm()
        f_kriteria.Dispose()
    End Sub

    Private Sub DataNarapidanaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNarapidanaToolStripMenuItem.Click
        LoadPanel(f_data_napi)
        f_data_napi.LoadForm()
        f_data_napi.Dispose()
    End Sub

    Private Sub DataAlternatifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAlternatifToolStripMenuItem.Click
        LoadPanel(f_alternatif)
        f_alternatif.LoadForm()
        f_alternatif.Dispose()
    End Sub

    Private Sub PerhitunganWPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerhitunganWPToolStripMenuItem.Click
        LoadPanel(f_perhitungan)
        f_perhitungan.LoadForm()
        f_perhitungan.Dispose()
    End Sub

    Private Sub LTitleForm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LTitleForm.TextChanged
        For i As Integer = 0 To MenuStrip1.Items.Count - 1
            MenuStrip1.Items(i).BackColor = System.Drawing.SystemColors.ControlLight
        Next

        If LTitleForm.Text = "Menu : -" Then
            HalamanUtamaToolStripMenuItem.BackColor = Color.Red
        End If

        If LTitleForm.Text = "Menu : " & f_user.Text Or _
           LTitleForm.Text = "Menu : " & f_ganti_paswd.Text Then
            DataUserToolStripMenuItem.BackColor = Color.Red
        End If

        If LTitleForm.Text = "Menu : " & f_kriteria.Text Or _
           LTitleForm.Text = "Menu : " & f_alternatif.Text Or _
           LTitleForm.Text = "Menu : " & f_data_napi.Text Then
            MasterDataToolStripMenuItem.BackColor = Color.Red
        End If

        If LTitleForm.Text = "Menu : " & f_perhitungan.Text Then
            PerhitunganWPToolStripMenuItem.BackColor = Color.Red
        End If

        If LTitleForm.Text = "Menu : " & f_laporan.Text Then
            LaporanHasilToolStripMenuItem.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnClose_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.MouseHover
        With BtnClose
            .BackColor = Color.Red
            .ForeColor = Color.White
        End With
    End Sub

    Private Sub BtnClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.MouseLeave
        With BtnClose
            .BackColor = System.Drawing.SystemColors.ControlLight
            .ForeColor = System.Drawing.SystemColors.ControlText
        End With
    End Sub

    Sub PrintLaporan()
        LoadPanel(f_laporan)
        f_laporan.LoadForm()
        f_laporan.Dispose()
    End Sub

    Private Sub LaporanHasilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanHasilToolStripMenuItem.Click
        LoadPanel(f_laporan)
        f_laporan.LoadForm()
        f_laporan.Dispose()
    End Sub

    Private Sub DataSubKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSubKriteriaToolStripMenuItem.Click
        LoadPanel(f_sub_kriteria)
        f_sub_kriteria.LoadForm()
        f_sub_kriteria.Dispose()
    End Sub
End Class
