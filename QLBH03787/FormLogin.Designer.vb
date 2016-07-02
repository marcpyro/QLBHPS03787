<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.btnLoginExit = New System.Windows.Forms.Button()
      Me.btnLoginCreate = New System.Windows.Forms.Button()
      Me.btnLoginOK = New System.Windows.Forms.Button()
      Me.txtPassword = New System.Windows.Forms.TextBox()
      Me.cmbUser = New System.Windows.Forms.ComboBox()
      Me.PictureBox4 = New System.Windows.Forms.PictureBox()
      Me.PictureBox3 = New System.Windows.Forms.PictureBox()
      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.GroupBox1.SuspendLayout()
      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'GroupBox1
      '
      Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.GroupBox1.Controls.Add(Me.btnLoginExit)
      Me.GroupBox1.Controls.Add(Me.btnLoginCreate)
      Me.GroupBox1.Controls.Add(Me.btnLoginOK)
      Me.GroupBox1.Controls.Add(Me.txtPassword)
      Me.GroupBox1.Controls.Add(Me.cmbUser)
      Me.GroupBox1.Controls.Add(Me.PictureBox4)
      Me.GroupBox1.Controls.Add(Me.PictureBox3)
      Me.GroupBox1.Location = New System.Drawing.Point(12, 118)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(277, 168)
      Me.GroupBox1.TabIndex = 1
      Me.GroupBox1.TabStop = False
      '
      'btnLoginExit
      '
      Me.btnLoginExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnLoginExit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnLoginExit.ForeColor = System.Drawing.Color.Red
      Me.btnLoginExit.Image = Global.QLBH03787.My.Resources.Resources.red_icon
      Me.btnLoginExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnLoginExit.Location = New System.Drawing.Point(170, 89)
      Me.btnLoginExit.Name = "btnLoginExit"
      Me.btnLoginExit.Size = New System.Drawing.Size(100, 30)
      Me.btnLoginExit.TabIndex = 5
      Me.btnLoginExit.Text = "&Exit"
      Me.btnLoginExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnLoginExit.UseVisualStyleBackColor = False
      '
      'btnLoginCreate
      '
      Me.btnLoginCreate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnLoginCreate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnLoginCreate.ForeColor = System.Drawing.Color.Orange
      Me.btnLoginCreate.Image = Global.QLBH03787.My.Resources.Resources.Icon_Workforce
      Me.btnLoginCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnLoginCreate.Location = New System.Drawing.Point(43, 125)
      Me.btnLoginCreate.Name = "btnLoginCreate"
      Me.btnLoginCreate.Size = New System.Drawing.Size(227, 30)
      Me.btnLoginCreate.TabIndex = 4
      Me.btnLoginCreate.Text = "&Create an account"
      Me.btnLoginCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnLoginCreate.UseVisualStyleBackColor = False
      '
      'btnLoginOK
      '
      Me.btnLoginOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnLoginOK.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnLoginOK.ForeColor = System.Drawing.Color.Lime
      Me.btnLoginOK.Image = Global.QLBH03787.My.Resources.Resources.OK
      Me.btnLoginOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnLoginOK.Location = New System.Drawing.Point(43, 89)
      Me.btnLoginOK.Name = "btnLoginOK"
      Me.btnLoginOK.Size = New System.Drawing.Size(100, 30)
      Me.btnLoginOK.TabIndex = 3
      Me.btnLoginOK.Text = "&OK"
      Me.btnLoginOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnLoginOK.UseVisualStyleBackColor = False
      '
      'txtPassword
      '
      Me.txtPassword.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtPassword.Location = New System.Drawing.Point(43, 57)
      Me.txtPassword.Name = "txtPassword"
      Me.txtPassword.Size = New System.Drawing.Size(228, 26)
      Me.txtPassword.TabIndex = 2
      Me.txtPassword.UseSystemPasswordChar = True
      '
      'cmbUser
      '
      Me.cmbUser.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.cmbUser.FormattingEnabled = True
      Me.cmbUser.Location = New System.Drawing.Point(42, 20)
      Me.cmbUser.Name = "cmbUser"
      Me.cmbUser.Size = New System.Drawing.Size(228, 27)
      Me.cmbUser.TabIndex = 1
      '
      'PictureBox4
      '
      Me.PictureBox4.Image = Global.QLBH03787.My.Resources.Resources.userlogin
      Me.PictureBox4.Location = New System.Drawing.Point(6, 19)
      Me.PictureBox4.Name = "PictureBox4"
      Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
      Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox4.TabIndex = 0
      Me.PictureBox4.TabStop = False
      '
      'PictureBox3
      '
      Me.PictureBox3.Image = Global.QLBH03787.My.Resources.Resources.key
      Me.PictureBox3.Location = New System.Drawing.Point(6, 55)
      Me.PictureBox3.Name = "PictureBox3"
      Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
      Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox3.TabIndex = 0
      Me.PictureBox3.TabStop = False
      '
      'PictureBox2
      '
      Me.PictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.PictureBox2.Image = Global.QLBH03787.My.Resources.Resources.banhang
      Me.PictureBox2.Location = New System.Drawing.Point(189, 12)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
      Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox2.TabIndex = 0
      Me.PictureBox2.TabStop = False
      '
      'PictureBox1
      '
      Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.welcome
      Me.PictureBox1.Location = New System.Drawing.Point(12, 42)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(171, 35)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 0
      Me.PictureBox1.TabStop = False
      '
      'frmLogin
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(302, 298)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.PictureBox2)
      Me.Controls.Add(Me.PictureBox1)
      Me.Name = "frmLogin"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Login"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
   Friend WithEvents btnLoginExit As System.Windows.Forms.Button
   Friend WithEvents btnLoginOK As System.Windows.Forms.Button
   Friend WithEvents txtPassword As System.Windows.Forms.TextBox
   Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
   Friend WithEvents btnLoginCreate As System.Windows.Forms.Button

End Class
