<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDetailHD
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
      Me.txtSoLuong = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtTenHH = New System.Windows.Forms.TextBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.txtTongtien = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.btnOK = New System.Windows.Forms.Button()
      Me.cmbMaHD = New System.Windows.Forms.ComboBox()
      Me.cmbMaHH = New System.Windows.Forms.ComboBox()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'txtSoLuong
      '
      Me.txtSoLuong.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtSoLuong.Location = New System.Drawing.Point(12, 275)
      Me.txtSoLuong.Multiline = True
      Me.txtSoLuong.Name = "txtSoLuong"
      Me.txtSoLuong.Size = New System.Drawing.Size(100, 27)
      Me.txtSoLuong.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label2.Location = New System.Drawing.Point(13, 253)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(79, 19)
      Me.Label2.TabIndex = 34
      Me.Label2.Text = "Số lượng:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label1.Location = New System.Drawing.Point(13, 148)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(63, 19)
      Me.Label1.TabIndex = 37
      Me.Label1.Text = "Mã HĐ:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label6.Location = New System.Drawing.Point(13, 201)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(68, 19)
      Me.Label6.TabIndex = 35
      Me.Label6.Text = "Tên HH:"
      '
      'txtTenHH
      '
      Me.txtTenHH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtTenHH.Location = New System.Drawing.Point(12, 223)
      Me.txtTenHH.Multiline = True
      Me.txtTenHH.Name = "txtTenHH"
      Me.txtTenHH.Size = New System.Drawing.Size(260, 27)
      Me.txtTenHH.TabIndex = 0
      Me.txtTenHH.TabStop = False
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label8.Location = New System.Drawing.Point(173, 253)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(82, 19)
      Me.Label8.TabIndex = 35
      Me.Label8.Text = "Tổng tiền:"
      '
      'txtTongtien
      '
      Me.txtTongtien.Enabled = False
      Me.txtTongtien.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtTongtien.Location = New System.Drawing.Point(172, 275)
      Me.txtTongtien.Multiline = True
      Me.txtTongtien.Name = "txtTongtien"
      Me.txtTongtien.Size = New System.Drawing.Size(100, 27)
      Me.txtTongtien.TabIndex = 0
      Me.txtTongtien.TabStop = False
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label3.Location = New System.Drawing.Point(173, 148)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(64, 19)
      Me.Label3.TabIndex = 37
      Me.Label3.Text = "Mã HH:"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.add_detail_invoice
      Me.PictureBox1.Location = New System.Drawing.Point(77, 12)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 38
      Me.PictureBox1.TabStop = False
      '
      'btnExit
      '
      Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnExit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExit.ForeColor = System.Drawing.Color.Red
      Me.btnExit.Image = Global.QLBH03787.My.Resources.Resources.red_icon
      Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnExit.Location = New System.Drawing.Point(172, 308)
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
      Me.btnOK.Location = New System.Drawing.Point(12, 308)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(100, 30)
      Me.btnOK.TabIndex = 3
      Me.btnOK.Text = "&OK"
      Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnOK.UseVisualStyleBackColor = False
      '
      'cmbMaHD
      '
      Me.cmbMaHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbMaHD.FormattingEnabled = True
      Me.cmbMaHD.Location = New System.Drawing.Point(12, 170)
      Me.cmbMaHD.Margin = New System.Windows.Forms.Padding(4)
      Me.cmbMaHD.Name = "cmbMaHD"
      Me.cmbMaHD.Size = New System.Drawing.Size(100, 27)
      Me.cmbMaHD.TabIndex = 0
      Me.cmbMaHD.TabStop = False
      '
      'cmbMaHH
      '
      Me.cmbMaHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbMaHH.FormattingEnabled = True
      Me.cmbMaHH.Location = New System.Drawing.Point(172, 171)
      Me.cmbMaHH.Margin = New System.Windows.Forms.Padding(4)
      Me.cmbMaHH.Name = "cmbMaHH"
      Me.cmbMaHH.Size = New System.Drawing.Size(100, 27)
      Me.cmbMaHH.TabIndex = 0
      Me.cmbMaHH.TabStop = False
      '
      'frmAddDetailHD
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(284, 351)
      Me.Controls.Add(Me.cmbMaHH)
      Me.Controls.Add(Me.cmbMaHD)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnOK)
      Me.Controls.Add(Me.txtTenHH)
      Me.Controls.Add(Me.txtTongtien)
      Me.Controls.Add(Me.txtSoLuong)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.Label8)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "frmAddDetailHD"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Thêm chi tiết HĐ"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents btnExit As System.Windows.Forms.Button
   Friend WithEvents btnOK As System.Windows.Forms.Button
   Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtTenHH As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtTongtien As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cmbMaHD As System.Windows.Forms.ComboBox
   Friend WithEvents cmbMaHH As System.Windows.Forms.ComboBox
End Class
