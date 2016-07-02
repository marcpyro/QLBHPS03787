<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtUser = New System.Windows.Forms.TextBox()
      Me.txtPassword = New System.Windows.Forms.TextBox()
      Me.btnCreateExit = New System.Windows.Forms.Button()
      Me.btnCreateOK = New System.Windows.Forms.Button()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label1.Location = New System.Drawing.Point(14, 152)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(87, 19)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Username:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label2.Location = New System.Drawing.Point(14, 204)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(85, 19)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Password:"
      '
      'txtUser
      '
      Me.txtUser.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtUser.Location = New System.Drawing.Point(12, 174)
      Me.txtUser.Multiline = True
      Me.txtUser.Name = "txtUser"
      Me.txtUser.Size = New System.Drawing.Size(260, 27)
      Me.txtUser.TabIndex = 1
      '
      'txtPassword
      '
      Me.txtPassword.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtPassword.Location = New System.Drawing.Point(12, 226)
      Me.txtPassword.Multiline = True
      Me.txtPassword.Name = "txtPassword"
      Me.txtPassword.Size = New System.Drawing.Size(260, 27)
      Me.txtPassword.TabIndex = 2
      '
      'btnCreateExit
      '
      Me.btnCreateExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnCreateExit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCreateExit.ForeColor = System.Drawing.Color.Red
      Me.btnCreateExit.Image = Global.QLBH03787.My.Resources.Resources.red_icon
      Me.btnCreateExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnCreateExit.Location = New System.Drawing.Point(172, 259)
      Me.btnCreateExit.Name = "btnCreateExit"
      Me.btnCreateExit.Size = New System.Drawing.Size(100, 30)
      Me.btnCreateExit.TabIndex = 4
      Me.btnCreateExit.Text = "&Exit"
      Me.btnCreateExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnCreateExit.UseVisualStyleBackColor = False
      '
      'btnCreateOK
      '
      Me.btnCreateOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnCreateOK.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCreateOK.ForeColor = System.Drawing.Color.Lime
      Me.btnCreateOK.Image = Global.QLBH03787.My.Resources.Resources.OK
      Me.btnCreateOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnCreateOK.Location = New System.Drawing.Point(12, 259)
      Me.btnCreateOK.Name = "btnCreateOK"
      Me.btnCreateOK.Size = New System.Drawing.Size(100, 30)
      Me.btnCreateOK.TabIndex = 3
      Me.btnCreateOK.Text = "&OK"
      Me.btnCreateOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnCreateOK.UseVisualStyleBackColor = False
      '
      'PictureBox1
      '
      Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.Member_Icon
      Me.PictureBox1.Location = New System.Drawing.Point(80, 12)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'frmCreateAccount
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(284, 299)
      Me.Controls.Add(Me.btnCreateExit)
      Me.Controls.Add(Me.btnCreateOK)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.txtPassword)
      Me.Controls.Add(Me.txtUser)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Name = "frmCreateAccount"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Tạo tài khoản"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtUser As System.Windows.Forms.TextBox
   Friend WithEvents txtPassword As System.Windows.Forms.TextBox
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents btnCreateOK As System.Windows.Forms.Button
   Friend WithEvents btnCreateExit As System.Windows.Forms.Button
End Class
