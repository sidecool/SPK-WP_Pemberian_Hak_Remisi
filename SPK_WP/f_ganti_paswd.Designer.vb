<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_ganti_paswd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_ganti_paswd))
        Me.PScreen = New System.Windows.Forms.Panel
        Me.PForm = New System.Windows.Forms.Panel
        Me.HideKonf = New System.Windows.Forms.Button
        Me.HideBaru = New System.Windows.Forms.Button
        Me.HideLama = New System.Windows.Forms.Button
        Me.ShowKonf = New System.Windows.Forms.Button
        Me.ShowBaru = New System.Windows.Forms.Button
        Me.ShowLama = New System.Windows.Forms.Button
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.TBPassKonf = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TBPassBaru = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.TBPassLama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PScreen.SuspendLayout()
        Me.PForm.SuspendLayout()
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
        Me.PScreen.Size = New System.Drawing.Size(452, 204)
        Me.PScreen.TabIndex = 1
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PForm.Controls.Add(Me.HideKonf)
        Me.PForm.Controls.Add(Me.HideBaru)
        Me.PForm.Controls.Add(Me.HideLama)
        Me.PForm.Controls.Add(Me.ShowKonf)
        Me.PForm.Controls.Add(Me.ShowBaru)
        Me.PForm.Controls.Add(Me.ShowLama)
        Me.PForm.Controls.Add(Me.BtnTutup)
        Me.PForm.Controls.Add(Me.TBPassKonf)
        Me.PForm.Controls.Add(Me.Label3)
        Me.PForm.Controls.Add(Me.TBPassBaru)
        Me.PForm.Controls.Add(Me.Label1)
        Me.PForm.Controls.Add(Me.BtnSimpan)
        Me.PForm.Controls.Add(Me.TBPassLama)
        Me.PForm.Controls.Add(Me.Label2)
        Me.PForm.Location = New System.Drawing.Point(13, 11)
        Me.PForm.Name = "PForm"
        Me.PForm.Size = New System.Drawing.Size(427, 181)
        Me.PForm.TabIndex = 2
        '
        'HideKonf
        '
        Me.HideKonf.BackColor = System.Drawing.Color.Transparent
        Me.HideKonf.Image = Global.SPK_WP.My.Resources.Resources.layer_visible
        Me.HideKonf.Location = New System.Drawing.Point(374, 108)
        Me.HideKonf.Name = "HideKonf"
        Me.HideKonf.Size = New System.Drawing.Size(32, 23)
        Me.HideKonf.TabIndex = 17
        Me.HideKonf.UseVisualStyleBackColor = False
        '
        'HideBaru
        '
        Me.HideBaru.BackColor = System.Drawing.Color.Transparent
        Me.HideBaru.Image = Global.SPK_WP.My.Resources.Resources.layer_visible
        Me.HideBaru.Location = New System.Drawing.Point(374, 82)
        Me.HideBaru.Name = "HideBaru"
        Me.HideBaru.Size = New System.Drawing.Size(32, 23)
        Me.HideBaru.TabIndex = 16
        Me.HideBaru.UseVisualStyleBackColor = False
        '
        'HideLama
        '
        Me.HideLama.BackColor = System.Drawing.Color.Transparent
        Me.HideLama.Image = Global.SPK_WP.My.Resources.Resources.layer_visible
        Me.HideLama.Location = New System.Drawing.Point(374, 56)
        Me.HideLama.Name = "HideLama"
        Me.HideLama.Size = New System.Drawing.Size(32, 23)
        Me.HideLama.TabIndex = 15
        Me.HideLama.UseVisualStyleBackColor = False
        '
        'ShowKonf
        '
        Me.ShowKonf.BackColor = System.Drawing.Color.Transparent
        Me.ShowKonf.Image = Global.SPK_WP.My.Resources.Resources.layer_novisible
        Me.ShowKonf.Location = New System.Drawing.Point(374, 108)
        Me.ShowKonf.Name = "ShowKonf"
        Me.ShowKonf.Size = New System.Drawing.Size(32, 23)
        Me.ShowKonf.TabIndex = 14
        Me.ShowKonf.UseVisualStyleBackColor = False
        '
        'ShowBaru
        '
        Me.ShowBaru.BackColor = System.Drawing.Color.Transparent
        Me.ShowBaru.Image = Global.SPK_WP.My.Resources.Resources.layer_novisible
        Me.ShowBaru.Location = New System.Drawing.Point(374, 82)
        Me.ShowBaru.Name = "ShowBaru"
        Me.ShowBaru.Size = New System.Drawing.Size(32, 23)
        Me.ShowBaru.TabIndex = 13
        Me.ShowBaru.UseVisualStyleBackColor = False
        '
        'ShowLama
        '
        Me.ShowLama.BackColor = System.Drawing.Color.Transparent
        Me.ShowLama.Image = Global.SPK_WP.My.Resources.Resources.layer_novisible
        Me.ShowLama.Location = New System.Drawing.Point(374, 56)
        Me.ShowLama.Name = "ShowLama"
        Me.ShowLama.Size = New System.Drawing.Size(32, 23)
        Me.ShowLama.TabIndex = 12
        Me.ShowLama.UseVisualStyleBackColor = False
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(315, 147)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(60, 23)
        Me.BtnTutup.TabIndex = 10
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'TBPassKonf
        '
        Me.TBPassKonf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPassKonf.Location = New System.Drawing.Point(200, 110)
        Me.TBPassKonf.Name = "TBPassKonf"
        Me.TBPassKonf.Size = New System.Drawing.Size(175, 20)
        Me.TBPassKonf.TabIndex = 8
        Me.TBPassKonf.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(20, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "KONFIRMASI PASSWORD"
        '
        'TBPassBaru
        '
        Me.TBPassBaru.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPassBaru.Location = New System.Drawing.Point(200, 84)
        Me.TBPassBaru.Name = "TBPassBaru"
        Me.TBPassBaru.Size = New System.Drawing.Size(175, 20)
        Me.TBPassBaru.TabIndex = 6
        Me.TBPassBaru.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(20, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PASSWORD BARU"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(200, 147)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(109, 23)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.TabStop = False
        Me.BtnSimpan.Text = "&Ganti Password"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TBPassLama
        '
        Me.TBPassLama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPassLama.Location = New System.Drawing.Point(200, 58)
        Me.TBPassLama.Name = "TBPassLama"
        Me.TBPassLama.Size = New System.Drawing.Size(175, 20)
        Me.TBPassLama.TabIndex = 3
        Me.TBPassLama.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(20, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD LAMA"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "layer-novisible.ico")
        Me.ImageList1.Images.SetKeyName(1, "layer-visible.ico")
        '
        'f_ganti_paswd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 204)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_ganti_paswd"
        Me.Text = "Ganti Password"
        Me.PScreen.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.PForm.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents TBPassLama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBPassKonf As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBPassBaru As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ShowLama As System.Windows.Forms.Button
    Friend WithEvents HideKonf As System.Windows.Forms.Button
    Friend WithEvents HideBaru As System.Windows.Forms.Button
    Friend WithEvents HideLama As System.Windows.Forms.Button
    Friend WithEvents ShowKonf As System.Windows.Forms.Button
    Friend WithEvents ShowBaru As System.Windows.Forms.Button
End Class
