<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_data_napi
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
        Me.PScreen = New System.Windows.Forms.Panel
        Me.PForm = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnFilter = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.TahunPenahanan = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.CBPerkara = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.CBMasaTahanan = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CBJasa = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CBPerilaku = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CBAgama = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TBAsal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TBPutusan = New System.Windows.Forms.TextBox
        Me.DTPPutusan = New System.Windows.Forms.DateTimePicker
        Me.DTPTahan = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.TBPasal = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TBNama = New System.Windows.Forms.TextBox
        Me.TBKode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PScreen.SuspendLayout()
        Me.PForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PScreen
        '
        Me.PScreen.BackColor = System.Drawing.Color.Transparent
        Me.PScreen.Controls.Add(Me.PForm)
        Me.PScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PScreen.Location = New System.Drawing.Point(0, 0)
        Me.PScreen.Name = "PScreen"
        Me.PScreen.Padding = New System.Windows.Forms.Padding(10)
        Me.PScreen.Size = New System.Drawing.Size(783, 588)
        Me.PScreen.TabIndex = 4
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PForm.Controls.Add(Me.GroupBox2)
        Me.PForm.Controls.Add(Me.GroupBox1)
        Me.PForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PForm.Location = New System.Drawing.Point(10, 10)
        Me.PForm.Name = "PForm"
        Me.PForm.Padding = New System.Windows.Forms.Padding(10)
        Me.PForm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PForm.Size = New System.Drawing.Size(763, 568)
        Me.PForm.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(10, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(743, 264)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Data Viewer  "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(130, 16)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(610, 245)
        Me.DataGridView1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnFilter)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TahunPenahanan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 245)
        Me.Panel2.TabIndex = 30
        '
        'BtnFilter
        '
        Me.BtnFilter.Location = New System.Drawing.Point(67, 30)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(53, 25)
        Me.BtnFilter.TabIndex = 32
        Me.BtnFilter.Text = "&Filter"
        Me.BtnFilter.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(6, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 19)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Tahun Penahanan"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TahunPenahanan
        '
        Me.TahunPenahanan.CustomFormat = "yyyy"
        Me.TahunPenahanan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TahunPenahanan.Location = New System.Drawing.Point(9, 33)
        Me.TahunPenahanan.Name = "TahunPenahanan"
        Me.TahunPenahanan.ShowUpDown = True
        Me.TahunPenahanan.Size = New System.Drawing.Size(53, 20)
        Me.TahunPenahanan.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.CBPerkara)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CBMasaTahanan)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CBJasa)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.CBPerilaku)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBAgama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBAsal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBPutusan)
        Me.GroupBox1.Controls.Add(Me.DTPPutusan)
        Me.GroupBox1.Controls.Add(Me.DTPTahan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBPasal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNama)
        Me.GroupBox1.Controls.Add(Me.TBKode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 284)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Form Inputan  "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnTutup)
        Me.Panel1.Controls.Add(Me.BtnBatal)
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.BtnSimpan)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 240)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 41)
        Me.Panel1.TabIndex = 49
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(397, 9)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 25)
        Me.BtnTutup.TabIndex = 31
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(316, 9)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 25)
        Me.BtnBatal.TabIndex = 30
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(235, 9)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 25)
        Me.BtnHapus.TabIndex = 29
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(154, 9)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 25)
        Me.BtnSimpan.TabIndex = 28
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'CBPerkara
        '
        Me.CBPerkara.BackColor = System.Drawing.SystemColors.Window
        Me.CBPerkara.FormattingEnabled = True
        Me.CBPerkara.Location = New System.Drawing.Point(158, 67)
        Me.CBPerkara.Name = "CBPerkara"
        Me.CBPerkara.Size = New System.Drawing.Size(554, 21)
        Me.CBPerkara.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(47, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 19)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "MASA TAHANAN"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBMasaTahanan
        '
        Me.CBMasaTahanan.BackColor = System.Drawing.SystemColors.Window
        Me.CBMasaTahanan.FormattingEnabled = True
        Me.CBMasaTahanan.Location = New System.Drawing.Point(158, 180)
        Me.CBMasaTahanan.Name = "CBMasaTahanan"
        Me.CBMasaTahanan.Size = New System.Drawing.Size(220, 21)
        Me.CBMasaTahanan.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(380, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 19)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "JASA"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBJasa
        '
        Me.CBJasa.BackColor = System.Drawing.SystemColors.Window
        Me.CBJasa.DropDownWidth = 435
        Me.CBJasa.FormattingEnabled = True
        Me.CBJasa.Location = New System.Drawing.Point(435, 157)
        Me.CBJasa.Name = "CBJasa"
        Me.CBJasa.Size = New System.Drawing.Size(276, 21)
        Me.CBJasa.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(23, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 19)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "PERILAKU"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBPerilaku
        '
        Me.CBPerilaku.BackColor = System.Drawing.SystemColors.Window
        Me.CBPerilaku.DropDownWidth = 554
        Me.CBPerilaku.FormattingEnabled = True
        Me.CBPerilaku.Location = New System.Drawing.Point(158, 156)
        Me.CBPerilaku.Name = "CBPerilaku"
        Me.CBPerilaku.Size = New System.Drawing.Size(220, 21)
        Me.CBPerilaku.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(377, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 19)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "TANGGAL PUTUSAN"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(377, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "TANGGAL DITAHAN"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(384, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "AGAMA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBAgama
        '
        Me.CBAgama.BackColor = System.Drawing.SystemColors.Window
        Me.CBAgama.FormattingEnabled = True
        Me.CBAgama.Location = New System.Drawing.Point(454, 44)
        Me.CBAgama.Name = "CBAgama"
        Me.CBAgama.Size = New System.Drawing.Size(124, 21)
        Me.CBAgama.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(23, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "ASAL PUTUSAN"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBAsal
        '
        Me.TBAsal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBAsal.Location = New System.Drawing.Point(158, 134)
        Me.TBAsal.MaxLength = 250
        Me.TBAsal.Name = "TBAsal"
        Me.TBAsal.Size = New System.Drawing.Size(220, 20)
        Me.TBAsal.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(23, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "NOMOR PUTUSAN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBPutusan
        '
        Me.TBPutusan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPutusan.Location = New System.Drawing.Point(158, 112)
        Me.TBPutusan.MaxLength = 250
        Me.TBPutusan.Name = "TBPutusan"
        Me.TBPutusan.Size = New System.Drawing.Size(220, 20)
        Me.TBPutusan.TabIndex = 34
        '
        'DTPPutusan
        '
        Me.DTPPutusan.Location = New System.Drawing.Point(512, 111)
        Me.DTPPutusan.Name = "DTPPutusan"
        Me.DTPPutusan.Size = New System.Drawing.Size(200, 20)
        Me.DTPPutusan.TabIndex = 33
        '
        'DTPTahan
        '
        Me.DTPTahan.Location = New System.Drawing.Point(512, 90)
        Me.DTPTahan.Name = "DTPTahan"
        Me.DTPTahan.Size = New System.Drawing.Size(200, 20)
        Me.DTPTahan.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(23, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "PASAL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBPasal
        '
        Me.TBPasal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPasal.Location = New System.Drawing.Point(158, 90)
        Me.TBPasal.MaxLength = 250
        Me.TBPasal.Name = "TBPasal"
        Me.TBPasal.Size = New System.Drawing.Size(220, 20)
        Me.TBPasal.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(23, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "PERKARA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "NAMA NARAPIDANA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBNama
        '
        Me.TBNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNama.Location = New System.Drawing.Point(158, 45)
        Me.TBNama.MaxLength = 250
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(220, 20)
        Me.TBNama.TabIndex = 16
        '
        'TBKode
        '
        Me.TBKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBKode.Location = New System.Drawing.Point(158, 23)
        Me.TBKode.MaxLength = 25
        Me.TBKode.Name = "TBKode"
        Me.TBKode.ReadOnly = True
        Me.TBKode.Size = New System.Drawing.Size(103, 20)
        Me.TBKode.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "KODE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_data_napi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 588)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_data_napi"
        Me.Text = "Data Narapidana"
        Me.PScreen.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents TBKode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DTPTahan As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBPasal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBAgama As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBAsal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBPutusan As System.Windows.Forms.TextBox
    Friend WithEvents DTPPutusan As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBPerkara As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CBMasaTahanan As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CBJasa As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBPerilaku As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnFilter As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TahunPenahanan As System.Windows.Forms.DateTimePicker
End Class
