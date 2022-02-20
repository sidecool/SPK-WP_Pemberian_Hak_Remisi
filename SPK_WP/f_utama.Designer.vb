<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_utama))
        Me.PTitle = New System.Windows.Forms.Panel
        Me.LTitle = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HalamanUtamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterDataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.DataNarapidanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataAlternatifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PerhitunganWPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanHasilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PLoader = New System.Windows.Forms.Panel
        Me.PTitleForm = New System.Windows.Forms.Panel
        Me.LTitleForm = New System.Windows.Forms.Label
        Me.DataKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PViewer = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DataSubKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PTitle.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PLoader.SuspendLayout()
        Me.PTitleForm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PTitle
        '
        Me.PTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PTitle.Controls.Add(Me.PictureBox1)
        Me.PTitle.Controls.Add(Me.LTitle)
        Me.PTitle.Controls.Add(Me.BtnClose)
        Me.PTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitle.Location = New System.Drawing.Point(0, 0)
        Me.PTitle.Name = "PTitle"
        Me.PTitle.Size = New System.Drawing.Size(758, 48)
        Me.PTitle.TabIndex = 0
        '
        'LTitle
        '
        Me.LTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LTitle.Location = New System.Drawing.Point(0, 0)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(709, 48)
        Me.LTitle.TabIndex = 1
        Me.LTitle.Text = "Sistem Pendukung Keputusan"
        Me.LTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.Font = New System.Drawing.Font("Berlin Sans FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClose.Location = New System.Drawing.Point(709, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(49, 48)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.TabStop = False
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        Me.BtnClose.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 450)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(758, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(77, 17)
        Me.ToolStripStatusLabel1.Text = "Tanggal : "
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel2.Text = "Jam : "
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(80, 17)
        Me.ToolStripStatusLabel3.Text = "Login as : "
        Me.ToolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HalamanUtamaToolStripMenuItem, Me.DataUserToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.PerhitunganWPToolStripMenuItem, Me.LaporanHasilToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 48)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(162, 402)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'HalamanUtamaToolStripMenuItem
        '
        Me.HalamanUtamaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.HalamanUtamaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.HalamanUtamaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.HalamanUtamaToolStripMenuItem.Name = "HalamanUtamaToolStripMenuItem"
        Me.HalamanUtamaToolStripMenuItem.Size = New System.Drawing.Size(129, 25)
        Me.HalamanUtamaToolStripMenuItem.Text = "Halaman Utama"
        Me.HalamanUtamaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataUserToolStripMenuItem, Me.GantiPasswordToolStripMenuItem})
        Me.DataUserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.DataUserToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(129, 25)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        Me.DataUserToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MasterDataUserToolStripMenuItem
        '
        Me.MasterDataUserToolStripMenuItem.Name = "MasterDataUserToolStripMenuItem"
        Me.MasterDataUserToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.MasterDataUserToolStripMenuItem.Text = "Master Data User"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKriteriaToolStripMenuItem, Me.DataSubKriteriaToolStripMenuItem, Me.ToolStripMenuItem1, Me.DataNarapidanaToolStripMenuItem, Me.DataAlternatifToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.MasterDataToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(129, 25)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        Me.MasterDataToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(280, 6)
        '
        'DataNarapidanaToolStripMenuItem
        '
        Me.DataNarapidanaToolStripMenuItem.Name = "DataNarapidanaToolStripMenuItem"
        Me.DataNarapidanaToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.DataNarapidanaToolStripMenuItem.Text = "Data Narapidana"
        '
        'DataAlternatifToolStripMenuItem
        '
        Me.DataAlternatifToolStripMenuItem.Name = "DataAlternatifToolStripMenuItem"
        Me.DataAlternatifToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.DataAlternatifToolStripMenuItem.Text = "Data Nilai Bobot (Alternatif)"
        Me.DataAlternatifToolStripMenuItem.Visible = False
        '
        'PerhitunganWPToolStripMenuItem
        '
        Me.PerhitunganWPToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.PerhitunganWPToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.PerhitunganWPToolStripMenuItem.Name = "PerhitunganWPToolStripMenuItem"
        Me.PerhitunganWPToolStripMenuItem.Size = New System.Drawing.Size(129, 25)
        Me.PerhitunganWPToolStripMenuItem.Text = "Proses Remisi"
        Me.PerhitunganWPToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LaporanHasilToolStripMenuItem
        '
        Me.LaporanHasilToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.LaporanHasilToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.LaporanHasilToolStripMenuItem.Name = "LaporanHasilToolStripMenuItem"
        Me.LaporanHasilToolStripMenuItem.Size = New System.Drawing.Size(129, 25)
        Me.LaporanHasilToolStripMenuItem.Text = "Laporan Hasil"
        Me.LaporanHasilToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.LogoutToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(129, 25)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PLoader
        '
        Me.PLoader.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PLoader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PLoader.Controls.Add(Me.PViewer)
        Me.PLoader.Controls.Add(Me.PTitleForm)
        Me.PLoader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PLoader.Location = New System.Drawing.Point(162, 48)
        Me.PLoader.Name = "PLoader"
        Me.PLoader.Padding = New System.Windows.Forms.Padding(5)
        Me.PLoader.Size = New System.Drawing.Size(596, 402)
        Me.PLoader.TabIndex = 3
        '
        'PTitleForm
        '
        Me.PTitleForm.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PTitleForm.Controls.Add(Me.LTitleForm)
        Me.PTitleForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitleForm.Location = New System.Drawing.Point(5, 5)
        Me.PTitleForm.Name = "PTitleForm"
        Me.PTitleForm.Size = New System.Drawing.Size(582, 48)
        Me.PTitleForm.TabIndex = 0
        '
        'LTitleForm
        '
        Me.LTitleForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTitleForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitleForm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LTitleForm.Location = New System.Drawing.Point(0, 0)
        Me.LTitleForm.Name = "LTitleForm"
        Me.LTitleForm.Padding = New System.Windows.Forms.Padding(10)
        Me.LTitleForm.Size = New System.Drawing.Size(582, 48)
        Me.LTitleForm.TabIndex = 0
        Me.LTitleForm.Text = "Menu : -"
        Me.LTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataKriteriaToolStripMenuItem
        '
        Me.DataKriteriaToolStripMenuItem.Name = "DataKriteriaToolStripMenuItem"
        Me.DataKriteriaToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.DataKriteriaToolStripMenuItem.Text = "Data Kriteria"
        '
        'PViewer
        '
        Me.PViewer.BackColor = System.Drawing.SystemColors.Window
        Me.PViewer.BackgroundImage = CType(resources.GetObject("PViewer.BackgroundImage"), System.Drawing.Image)
        Me.PViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PViewer.Location = New System.Drawing.Point(5, 53)
        Me.PViewer.Name = "PViewer"
        Me.PViewer.Size = New System.Drawing.Size(582, 340)
        Me.PViewer.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 48)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'DataSubKriteriaToolStripMenuItem
        '
        Me.DataSubKriteriaToolStripMenuItem.Name = "DataSubKriteriaToolStripMenuItem"
        Me.DataSubKriteriaToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.DataSubKriteriaToolStripMenuItem.Text = "Data Sub Kriteria"
        '
        'f_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 472)
        Me.Controls.Add(Me.PLoader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "f_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PTitle.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PLoader.ResumeLayout(False)
        Me.PTitleForm.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PTitle As System.Windows.Forms.Panel
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HalamanUtamaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PLoader As System.Windows.Forms.Panel
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LTitle As System.Windows.Forms.Label
    Friend WithEvents PTitleForm As System.Windows.Forms.Panel
    Friend WithEvents LTitleForm As System.Windows.Forms.Label
    Friend WithEvents PerhitunganWPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHasilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MasterDataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataNarapidanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAlternatifToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSubKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PViewer As System.Windows.Forms.Panel

End Class
