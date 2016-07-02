<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddHH
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
      Me.cmbDonViID = New System.Windows.Forms.ComboBox()
      Me.txtTonKho = New System.Windows.Forms.TextBox()
      Me.txtDonGia = New System.Windows.Forms.TextBox()
      Me.txtTenHH = New System.Windows.Forms.TextBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.txtMaHH = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.btnOK = New System.Windows.Forms.Button()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cmbDonViID
      '
      Me.cmbDonViID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbDonViID.Font = New System.Drawing.Font("Cambria", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.cmbDonViID.FormattingEnabled = True
      Me.cmbDonViID.Items.AddRange(New Object() {"1", "2", "3"})
      Me.cmbDonViID.Location = New System.Drawing.Point(147, 170)
      Me.cmbDonViID.Name = "cmbDonViID"
      Me.cmbDonViID.Size = New System.Drawing.Size(121, 28)
      Me.cmbDonViID.TabIndex = 0
      Me.cmbDonViID.TabStop = False
      '
      'txtTonKho
      '
      Me.txtTonKho.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtTonKho.Location = New System.Drawing.Point(12, 326)
      Me.txtTonKho.Multiline = True
      Me.txtTonKho.Name = "txtTonKho"
      Me.txtTonKho.Size = New System.Drawing.Size(260, 27)
      Me.txtTonKho.TabIndex = 4
      '
      'txtDonGia
      '
      Me.txtDonGia.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtDonGia.Location = New System.Drawing.Point(12, 274)
      Me.txtDonGia.Multiline = True
      Me.txtDonGia.Name = "txtDonGia"
      Me.txtDonGia.Size = New System.Drawing.Size(260, 27)
      Me.txtDonGia.TabIndex = 3
      '
      'txtTenHH
      '
      Me.txtTenHH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtTenHH.Location = New System.Drawing.Point(12, 222)
      Me.txtTenHH.Multiline = True
      Me.txtTenHH.Name = "txtTenHH"
      Me.txtTenHH.Size = New System.Drawing.Size(260, 27)
      Me.txtTenHH.TabIndex = 2
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label4.Location = New System.Drawing.Point(14, 304)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(73, 19)
      Me.Label4.TabIndex = 18
      Me.Label4.Text = "Tồn kho:"
      '
      'txtMaHH
      '
      Me.txtMaHH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtMaHH.Location = New System.Drawing.Point(12, 170)
      Me.txtMaHH.Multiline = True
      Me.txtMaHH.Name = "txtMaHH"
      Me.txtMaHH.Size = New System.Drawing.Size(125, 27)
      Me.txtMaHH.TabIndex = 1
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label3.Location = New System.Drawing.Point(14, 252)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(71, 19)
      Me.Label3.TabIndex = 21
      Me.Label3.Text = "Đơn giá:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label2.Location = New System.Drawing.Point(14, 200)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(68, 19)
      Me.Label2.TabIndex = 19
      Me.Label2.Text = "Tên HH:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label5.Location = New System.Drawing.Point(148, 148)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(83, 19)
      Me.Label5.TabIndex = 22
      Me.Label5.Text = "Đơn vị ID:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label1.Location = New System.Drawing.Point(14, 148)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(64, 19)
      Me.Label1.TabIndex = 23
      Me.Label1.Text = "Mã HH:"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.Packet_add_icon
      Me.PictureBox1.Location = New System.Drawing.Point(77, 12)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 25
      Me.PictureBox1.TabStop = False
      '
      'btnExit
      '
      Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnExit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExit.ForeColor = System.Drawing.Color.Red
      Me.btnExit.Image = Global.QLBH03787.My.Resources.Resources.red_icon
      Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnExit.Location = New System.Drawing.Point(172, 359)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(100, 30)
      Me.btnExit.TabIndex = 6
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
      Me.btnOK.Location = New System.Drawing.Point(12, 359)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(100, 30)
      Me.btnOK.TabIndex = 5
      Me.btnOK.Text = "&OK"
      Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnOK.UseVisualStyleBackColor = False
      '
      'frmAddHH
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(284, 400)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.cmbDonViID)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnOK)
      Me.Controls.Add(Me.txtTonKho)
      Me.Controls.Add(Me.txtDonGia)
      Me.Controls.Add(Me.txtTenHH)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.txtMaHH)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label1)
      Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "frmAddHH"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Thêm thông tin HH"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cmbDonViID As System.Windows.Forms.ComboBox
   Friend WithEvents btnExit As System.Windows.Forms.Button
   Friend WithEvents btnOK As System.Windows.Forms.Button
   Friend WithEvents txtTonKho As System.Windows.Forms.TextBox
   Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
   Friend WithEvents txtTenHH As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtMaHH As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
