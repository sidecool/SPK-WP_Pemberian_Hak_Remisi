<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_login))
        Me.PScreen = New System.Windows.Forms.Panel
        Me.PForm = New System.Windows.Forms.Panel
        Me.btnHide = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.BtnLogin = New System.Windows.Forms.Button
        Me.TBPass = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TBUser = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PScreen.SuspendLayout()
        Me.PForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'PScreen
        '
        Me.PScreen.BackColor = System.Drawing.Color.Transparent
        Me.PScreen.Controls.Add(Me.PForm)
        Me.PScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PScreen.Location = New System.Drawing.Point(0, 0)
        Me.PScreen.Name = "PScreen"
        Me.PScreen.Size = New System.Drawing.Size(374, 183)
        Me.PScreen.TabIndex = 0
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PForm.Controls.Add(Me.btnHide)
        Me.PForm.Controls.Add(Me.btnShow)
        Me.PForm.Controls.Add(Me.BtnLogin)
        Me.PForm.Controls.Add(Me.TBPass)
        Me.PForm.Controls.Add(Me.Label2)
        Me.PForm.Controls.Add(Me.TBUser)
        Me.PForm.Controls.Add(Me.Label1)
        Me.PForm.Location = New System.Drawing.Point(13, 11)
        Me.PForm.Name = "PForm"
        Me.PForm.Size = New System.Drawing.Size(348, 160)
        Me.PForm.TabIndex = 2
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Transparent
        Me.btnHide.Image = Global.SPK_WP.My.Resources.Resources.layer_visible
        Me.btnHide.Location = New System.Drawing.Point(294, 62)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(32, 23)
        Me.btnHide.TabIndex = 6
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Transparent
        Me.btnShow.Image = Global.SPK_WP.My.Resources.Resources.layer_novisible
        Me.btnShow.Location = New System.Drawing.Point(294, 62)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(32, 23)
        Me.btnShow.TabIndex = 5
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(110, 101)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.TabStop = False
        Me.BtnLogin.Text = "&Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TBPass
        '
        Me.TBPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPass.Location = New System.Drawing.Point(110, 64)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(184, 20)
        Me.TBPass.TabIndex = 3
        Me.TBPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(14, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD"
        '
        'TBUser
        '
        Me.TBUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBUser.Location = New System.Drawing.Point(110, 28)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(216, 20)
        Me.TBUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "layer-novisible.ico")
        Me.ImageList1.Images.SetKeyName(1, "layer-visible.ico")
        '
        'f_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 183)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_login"
        Me.Text = "Login"
        Me.PScreen.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.PForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents TBPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
End Class
