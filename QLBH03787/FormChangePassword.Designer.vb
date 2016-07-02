<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
      Me.txtNewPassword = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.btnOK = New System.Windows.Forms.Button()
      Me.txtUser = New System.Windows.Forms.TextBox()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'txtNewPassword
      '
      Me.txtNewPassword.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtNewPassword.Location = New System.Drawing.Point(12, 223)
      Me.txtNewPassword.Multiline = True
      Me.txtNewPassword.Name = "txtNewPassword"
      Me.txtNewPassword.Size = New System.Drawing.Size(260, 27)
      Me.txtNewPassword.TabIndex = 1
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label3.Location = New System.Drawing.Point(14, 201)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(119, 19)
      Me.Label3.TabIndex = 10
      Me.Label3.Text = "Password mới:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label2.Location = New System.Drawing.Point(14, 149)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(87, 19)
      Me.Label2.TabIndex = 9
      Me.Label2.Text = "Username:"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.add_user_icon
      Me.PictureBox1.Location = New System.Drawing.Point(77, 12)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 12
      Me.PictureBox1.TabStop = False
      '
      'btnExit
      '
      Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnExit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExit.ForeColor = System.Drawing.Color.Red
      Me.btnExit.Image = Global.QLBH03787.My.Resources.Resources.red_icon
      Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnExit.Location = New System.Drawing.Point(172, 256)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(100, 30)
      Me.btnExit.TabIndex = 4
      Me.btnExit.Text = "&Exit"
      Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnExit.UseVisualStyleBackColor = False
      '
      'btnOK
      '
      Me.btnOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnOK.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOK.ForeColor = System.Drawing.Color.Lime
      Me.btnOK.Image = Global.QLBH03787.My.Resources.Resources.OK
      Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnOK.Location = New System.Drawing.Point(12, 256)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(100, 30)
      Me.btnOK.TabIndex = 3
      Me.btnOK.Text = "&OK"
      Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnOK.UseVisualStyleBackColor = False
      '
      'txtUser
      '
      Me.txtUser.Enabled = False
      Me.txtUser.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtUser.Location = New System.Drawing.Point(12, 171)
      Me.txtUser.Multiline = True
      Me.txtUser.Name = "txtUser"
      Me.txtUser.Size = New System.Drawing.Size(260, 27)
      Me.txtUser.TabIndex = 0
      '
      'frmChangePassword
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(284, 299)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnOK)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.txtUser)
      Me.Controls.Add(Me.txtNewPassword)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "frmChangePassword"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Đổi Mật Khẩu"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents btnExit As System.Windows.Forms.Button
   Friend WithEvents btnOK As System.Windows.Forms.Button
   Friend WithEvents txtUser As System.Windows.Forms.TextBox
End Class
