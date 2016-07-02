<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
      Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
      Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.QuảnLýKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.HàngHóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.QuảnLýHHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.KiểmKêToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ChiTietToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.TàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ĐổiMậtKhẩuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.txtLoginID = New System.Windows.Forms.TextBox()
      Me.txtMon = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.txtLop = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtMSSV = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtName = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.MenuStrip1.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'MenuStrip1
      '
      Me.MenuStrip1.BackColor = System.Drawing.Color.Black
      Me.MenuStrip1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchHàngToolStripMenuItem, Me.HàngHóaToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.TàiKhoảnToolStripMenuItem})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(508, 27)
      Me.MenuStrip1.TabIndex = 0
      Me.MenuStrip1.Text = "MenuStrip1"
      '
      'KháchHàngToolStripMenuItem
      '
      Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýKHToolStripMenuItem})
      Me.KháchHàngToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
      Me.KháchHàngToolStripMenuItem.Image = Global.QLBH03787.My.Resources.Resources.user
      Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
      Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(128, 23)
      Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
      '
      'QuảnLýKHToolStripMenuItem
      '
      Me.QuảnLýKHToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
      Me.QuảnLýKHToolStripMenuItem.Name = "QuảnLýKHToolStripMenuItem"
      Me.QuảnLýKHToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
      Me.QuảnLýKHToolStripMenuItem.Text = "Thông tin KH"
      '
      'HàngHóaToolStripMenuItem
      '
      Me.HàngHóaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýHHToolStripMenuItem})
      Me.HàngHóaToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
      Me.HàngHóaToolStripMenuItem.Image = Global.QLBH03787.My.Resources.Resources.green_icon
      Me.HàngHóaToolStripMenuItem.Name = "HàngHóaToolStripMenuItem"
      Me.HàngHóaToolStripMenuItem.Size = New System.Drawing.Size(110, 23)
      Me.HàngHóaToolStripMenuItem.Text = "Hàng Hóa"
      '
      'QuảnLýHHToolStripMenuItem
      '
      Me.QuảnLýHHToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
      Me.QuảnLýHHToolStripMenuItem.Name = "QuảnLýHHToolStripMenuItem"
      Me.QuảnLýHHToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
      Me.QuảnLýHHToolStripMenuItem.Text = "Quản lý HH"
      '
      'HóaĐơnToolStripMenuItem
      '
      Me.HóaĐơnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KiểmKêToolStripMenuItem, Me.ChiTietToolStripMenuItem})
      Me.HóaĐơnToolStripMenuItem.ForeColor = System.Drawing.Color.Red
      Me.HóaĐơnToolStripMenuItem.Image = Global.QLBH03787.My.Resources.Resources.red_icon_product
      Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
      Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(103, 23)
      Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
      '
      'KiểmKêToolStripMenuItem
      '
      Me.KiểmKêToolStripMenuItem.ForeColor = System.Drawing.Color.Red
      Me.KiểmKêToolStripMenuItem.Name = "KiểmKêToolStripMenuItem"
      Me.KiểmKêToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
      Me.KiểmKêToolStripMenuItem.Text = "Kiểm Kê HĐ"
      '
      'ChiTietToolStripMenuItem
      '
      Me.ChiTietToolStripMenuItem.ForeColor = System.Drawing.Color.Red
      Me.ChiTietToolStripMenuItem.Name = "ChiTietToolStripMenuItem"
      Me.ChiTietToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
      Me.ChiTietToolStripMenuItem.Text = "Chi Tiết HĐ"
      '
      'TàiKhoảnToolStripMenuItem
      '
      Me.TàiKhoảnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐổiMậtKhẩuToolStripMenuItem, Me.ĐăngXuấtToolStripMenuItem})
      Me.TàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
      Me.TàiKhoảnToolStripMenuItem.Image = Global.QLBH03787.My.Resources.Resources.icon_bacsi
      Me.TàiKhoảnToolStripMenuItem.Name = "TàiKhoảnToolStripMenuItem"
      Me.TàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(111, 23)
      Me.TàiKhoảnToolStripMenuItem.Text = "Tài khoản"
      '
      'ĐổiMậtKhẩuToolStripMenuItem
      '
      Me.ĐổiMậtKhẩuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
      Me.ĐổiMậtKhẩuToolStripMenuItem.Image = Global.QLBH03787.My.Resources.Resources.changekey
      Me.ĐổiMậtKhẩuToolStripMenuItem.Name = "ĐổiMậtKhẩuToolStripMenuItem"
      Me.ĐổiMậtKhẩuToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
      Me.ĐổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu"
      '
      'ĐăngXuấtToolStripMenuItem
      '
      Me.ĐăngXuấtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
      Me.ĐăngXuấtToolStripMenuItem.Image = Global.QLBH03787.My.Resources.Resources.logout
      Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
      Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
      Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng xuất"
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.txtLoginID)
      Me.GroupBox1.Controls.Add(Me.txtMon)
      Me.GroupBox1.Controls.Add(Me.Label5)
      Me.GroupBox1.Controls.Add(Me.Label4)
      Me.GroupBox1.Controls.Add(Me.txtLop)
      Me.GroupBox1.Controls.Add(Me.Label3)
      Me.GroupBox1.Controls.Add(Me.txtMSSV)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.txtName)
      Me.GroupBox1.Controls.Add(Me.Label1)
      Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.GroupBox1.Location = New System.Drawing.Point(256, 30)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(240, 280)
      Me.GroupBox1.TabIndex = 2
      Me.GroupBox1.TabStop = False
      '
      'txtLoginID
      '
      Me.txtLoginID.Enabled = False
      Me.txtLoginID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtLoginID.Location = New System.Drawing.Point(10, 243)
      Me.txtLoginID.Name = "txtLoginID"
      Me.txtLoginID.ReadOnly = True
      Me.txtLoginID.Size = New System.Drawing.Size(221, 26)
      Me.txtLoginID.TabIndex = 1
      Me.txtLoginID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'txtMon
      '
      Me.txtMon.Enabled = False
      Me.txtMon.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtMon.Location = New System.Drawing.Point(10, 192)
      Me.txtMon.Name = "txtMon"
      Me.txtMon.Size = New System.Drawing.Size(221, 26)
      Me.txtMon.TabIndex = 1
      Me.txtMon.Text = "Điện Toán Đám Mây"
      Me.txtMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(6, 221)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(112, 19)
      Me.Label5.TabIndex = 0
      Me.Label5.Text = "Login Account:"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(6, 170)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 19)
      Me.Label4.TabIndex = 0
      Me.Label4.Text = "Môn:"
      '
      'txtLop
      '
      Me.txtLop.Enabled = False
      Me.txtLop.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtLop.Location = New System.Drawing.Point(10, 141)
      Me.txtLop.Name = "txtLop"
      Me.txtLop.Size = New System.Drawing.Size(221, 26)
      Me.txtLop.TabIndex = 1
      Me.txtLop.Text = "PT11101"
      Me.txtLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(6, 119)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(41, 19)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Lớp:"
      '
      'txtMSSV
      '
      Me.txtMSSV.Enabled = False
      Me.txtMSSV.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtMSSV.Location = New System.Drawing.Point(10, 90)
      Me.txtMSSV.Name = "txtMSSV"
      Me.txtMSSV.Size = New System.Drawing.Size(221, 26)
      Me.txtMSSV.TabIndex = 1
      Me.txtMSSV.Text = "PS03787"
      Me.txtMSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(6, 68)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(51, 19)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "MSSV:"
      '
      'txtName
      '
      Me.txtName.Enabled = False
      Me.txtName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.txtName.Location = New System.Drawing.Point(10, 39)
      Me.txtName.Name = "txtName"
      Me.txtName.Size = New System.Drawing.Size(221, 26)
      Me.txtName.TabIndex = 1
      Me.txtName.Text = "Trần Ngọc Long"
      Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(6, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(59, 19)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Tên SV:"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.banhang
      Me.PictureBox1.Location = New System.Drawing.Point(0, 51)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 1
      Me.PictureBox1.TabStop = False
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(508, 322)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.MenuStrip1)
      Me.MainMenuStrip = Me.MenuStrip1
      Me.Name = "frmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Quản lý bán hàng"
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
   Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents QuảnLýKHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents HàngHóaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents QuảnLýHHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents HóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents KiểmKêToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents txtLoginID As System.Windows.Forms.TextBox
   Friend WithEvents txtMon As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtLop As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtMSSV As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtName As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TàiKhoảnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ĐổiMậtKhẩuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ChiTietToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
