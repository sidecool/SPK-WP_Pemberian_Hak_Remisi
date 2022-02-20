<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_dbconfig
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
        Me.PFormShow = New System.Windows.Forms.Panel
        Me.btnHide = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnTutup = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnCek = New System.Windows.Forms.Button
        Me.TBDatabase = New System.Windows.Forms.TextBox
        Me.TBPass = New System.Windows.Forms.TextBox
        Me.TBUser = New System.Windows.Forms.TextBox
        Me.TBPort = New System.Windows.Forms.TextBox
        Me.TBServer = New System.Windows.Forms.TextBox
        Me.PScreen = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PFormShow.SuspendLayout()
        Me.PScreen.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PFormShow
        '
        Me.PFormShow.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PFormShow.Controls.Add(Me.btnHide)
        Me.PFormShow.Controls.Add(Me.btnShow)
        Me.PFormShow.Controls.Add(Me.btnTutup)
        Me.PFormShow.Controls.Add(Me.Label5)
        Me.PFormShow.Controls.Add(Me.Label4)
        Me.PFormShow.Controls.Add(Me.Label3)
        Me.PFormShow.Controls.Add(Me.Label2)
        Me.PFormShow.Controls.Add(Me.Label1)
        Me.PFormShow.Controls.Add(Me.btnSimpan)
        Me.PFormShow.Controls.Add(Me.btnCek)
        Me.PFormShow.Controls.Add(Me.TBDatabase)
        Me.PFormShow.Controls.Add(Me.TBPass)
        Me.PFormShow.Controls.Add(Me.TBUser)
        Me.PFormShow.Controls.Add(Me.TBPort)
        Me.PFormShow.Controls.Add(Me.TBServer)
        Me.PFormShow.Location = New System.Drawing.Point(13, 11)
        Me.PFormShow.Name = "PFormShow"
        Me.PFormShow.Size = New System.Drawing.Size(377, 205)
        Me.PFormShow.TabIndex = 0
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Transparent
        Me.btnHide.Image = Global.SPK_WP.My.Resources.Resources.layer_visible
        Me.btnHide.Location = New System.Drawing.Point(317, 89)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(32, 23)
        Me.btnHide.TabIndex = 14
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Transparent
        Me.btnShow.Image = Global.SPK_WP.My.Resources.Resources.layer_novisible
        Me.btnShow.Location = New System.Drawing.Point(317, 89)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(32, 23)
        Me.btnShow.TabIndex = 13
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(272, 168)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 7
        Me.btnTutup.TabStop = False
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(27, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "NAMA DATABASE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(27, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "USER DATABASE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(27, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "PORT NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SERVER HOST"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(191, 168)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.TabStop = False
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(30, 168)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(122, 23)
        Me.btnCek.TabIndex = 5
        Me.btnCek.TabStop = False
        Me.btnCek.Text = "&Cek Koneksi"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'TBDatabase
        '
        Me.TBDatabase.Location = New System.Drawing.Point(144, 117)
        Me.TBDatabase.Name = "TBDatabase"
        Me.TBDatabase.Size = New System.Drawing.Size(203, 20)
        Me.TBDatabase.TabIndex = 4
        '
        'TBPass
        '
        Me.TBPass.Location = New System.Drawing.Point(144, 91)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(175, 20)
        Me.TBPass.TabIndex = 3
        Me.TBPass.UseSystemPasswordChar = True
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(144, 65)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(203, 20)
        Me.TBUser.TabIndex = 2
        '
        'TBPort
        '
        Me.TBPort.Location = New System.Drawing.Point(144, 39)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(96, 20)
        Me.TBPort.TabIndex = 1
        '
        'TBServer
        '
        Me.TBServer.Location = New System.Drawing.Point(144, 13)
        Me.TBServer.Name = "TBServer"
        Me.TBServer.Size = New System.Drawing.Size(203, 20)
        Me.TBServer.TabIndex = 0
        '
        'PScreen
        '
        Me.PScreen.BackColor = System.Drawing.Color.Transparent
        Me.PScreen.Controls.Add(Me.PFormShow)
        Me.PScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PScreen.Location = New System.Drawing.Point(0, 0)
        Me.PScreen.Name = "PScreen"
        Me.PScreen.Size = New System.Drawing.Size(404, 228)
        Me.PScreen.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_dbconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 228)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_dbconfig"
        Me.Text = "Konfigurasi Database"
        Me.PFormShow.ResumeLayout(False)
        Me.PFormShow.PerformLayout()
        Me.PScreen.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PFormShow As System.Windows.Forms.Panel
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents TBDatabase As System.Windows.Forms.TextBox
    Friend WithEvents TBPass As System.Windows.Forms.TextBox
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents TBPort As System.Windows.Forms.TextBox
    Friend WithEvents TBServer As System.Windows.Forms.TextBox
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
