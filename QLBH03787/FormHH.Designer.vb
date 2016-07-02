<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHH
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
      Me.dgvHH = New System.Windows.Forms.DataGridView()
      Me.txtSearch = New System.Windows.Forms.TextBox()
      Me.cmbListView = New System.Windows.Forms.ComboBox()
      Me.btnEditImage = New System.Windows.Forms.Button()
      Me.ptbHH = New System.Windows.Forms.PictureBox()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btnViewAll = New System.Windows.Forms.Button()
      Me.btnDeleteHH = New System.Windows.Forms.Button()
      Me.btnEditHH = New System.Windows.Forms.Button()
      Me.btnAddHH = New System.Windows.Forms.Button()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtMaHH = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      CType(Me.dgvHH, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ptbHH, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'dgvHH
      '
      Me.dgvHH.AllowUserToAddRows = False
      Me.dgvHH.AllowUserToDeleteRows = False
      Me.dgvHH.AllowUserToOrderColumns = True
      Me.dgvHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.dgvHH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
      Me.dgvHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvHH.Location = New System.Drawing.Point(150, 90)
      Me.dgvHH.MultiSelect = False
      Me.dgvHH.Name = "dgvHH"
      Me.dgvHH.ReadOnly = True
      Me.dgvHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvHH.Size = New System.Drawing.Size(505, 211)
      Me.dgvHH.TabIndex = 0
      Me.dgvHH.TabStop = False
      '
      'txtSearch
      '
      Me.txtSearch.Location = New System.Drawing.Point(487, 56)
      Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
      Me.txtSearch.Multiline = True
      Me.txtSearch.Name = "txtSearch"
      Me.txtSearch.Size = New System.Drawing.Size(168, 27)
      Me.txtSearch.TabIndex = 1
      '
      'cmbListView
      '
      Me.cmbListView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbListView.FormattingEnabled = True
      Me.cmbListView.Location = New System.Drawing.Point(15, 113)
      Me.cmbListView.Margin = New System.Windows.Forms.Padding(4)
      Me.cmbListView.Name = "cmbListView"
      Me.cmbListView.Size = New System.Drawing.Size(128, 27)
      Me.cmbListView.TabIndex = 0
      Me.cmbListView.TabStop = False
      '
      'btnEditImage
      '
      Me.btnEditImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnEditImage.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnEditImage.ForeColor = System.Drawing.Color.Lime
      Me.btnEditImage.Image = Global.QLBH03787.My.Resources.Resources.orange_edit
      Me.btnEditImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnEditImage.Location = New System.Drawing.Point(678, 222)
      Me.btnEditImage.Name = "btnEditImage"
      Me.btnEditImage.Size = New System.Drawing.Size(140, 30)
      Me.btnEditImage.TabIndex = 5
      Me.btnEditImage.Text = "Edit &Image"
      Me.btnEditImage.UseVisualStyleBackColor = False
      '
      'ptbHH
      '
      Me.ptbHH.ErrorImage = Global.QLBH03787.My.Resources.Resources.nophoto
      Me.ptbHH.Location = New System.Drawing.Point(661, 12)
      Me.ptbHH.Name = "ptbHH"
      Me.ptbHH.Size = New System.Drawing.Size(170, 170)
      Me.ptbHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.ptbHH.TabIndex = 18
      Me.ptbHH.TabStop = False
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.products_banner
      Me.PictureBox1.Location = New System.Drawing.Point(150, 21)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(330, 62)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 17
      Me.PictureBox1.TabStop = False
      '
      'btnViewAll
      '
      Me.btnViewAll.Image = Global.QLBH03787.My.Resources.Resources.View_Icon
      Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnViewAll.Location = New System.Drawing.Point(15, 21)
      Me.btnViewAll.Name = "btnViewAll"
      Me.btnViewAll.Size = New System.Drawing.Size(128, 29)
      Me.btnViewAll.TabIndex = 0
      Me.btnViewAll.TabStop = False
      Me.btnViewAll.Text = "View All"
      Me.btnViewAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnViewAll.UseVisualStyleBackColor = True
      '
      'btnDeleteHH
      '
      Me.btnDeleteHH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnDeleteHH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnDeleteHH.ForeColor = System.Drawing.Color.Red
      Me.btnDeleteHH.Image = Global.QLBH03787.My.Resources.Resources.orange_trash
      Me.btnDeleteHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnDeleteHH.Location = New System.Drawing.Point(26, 271)
      Me.btnDeleteHH.Name = "btnDeleteHH"
      Me.btnDeleteHH.Size = New System.Drawing.Size(100, 30)
      Me.btnDeleteHH.TabIndex = 4
      Me.btnDeleteHH.Text = "&Delete"
      Me.btnDeleteHH.UseVisualStyleBackColor = False
      '
      'btnEditHH
      '
      Me.btnEditHH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnEditHH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnEditHH.ForeColor = System.Drawing.Color.Lime
      Me.btnEditHH.Image = Global.QLBH03787.My.Resources.Resources.orange_edit
      Me.btnEditHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnEditHH.Location = New System.Drawing.Point(26, 235)
      Me.btnEditHH.Name = "btnEditHH"
      Me.btnEditHH.Size = New System.Drawing.Size(100, 30)
      Me.btnEditHH.TabIndex = 3
      Me.btnEditHH.Text = "&Edit"
      Me.btnEditHH.UseVisualStyleBackColor = False
      '
      'btnAddHH
      '
      Me.btnAddHH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnAddHH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnAddHH.ForeColor = System.Drawing.SystemColors.Highlight
      Me.btnAddHH.Image = Global.QLBH03787.My.Resources.Resources.orange_plus
      Me.btnAddHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnAddHH.Location = New System.Drawing.Point(26, 199)
      Me.btnAddHH.Name = "btnAddHH"
      Me.btnAddHH.Size = New System.Drawing.Size(100, 30)
      Me.btnAddHH.TabIndex = 2
      Me.btnAddHH.Text = "&Add"
      Me.btnAddHH.UseVisualStyleBackColor = False
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Image = Global.QLBH03787.My.Resources.Resources.orange_search
      Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.Label2.Location = New System.Drawing.Point(486, 33)
      Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(118, 19)
      Me.Label2.TabIndex = 11
      Me.Label2.Text = "     Search Here:"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label3.Image = Global.QLBH03787.My.Resources.Resources.Filter
      Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.Label3.Location = New System.Drawing.Point(14, 90)
      Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(102, 19)
      Me.Label3.TabIndex = 12
      Me.Label3.Text = "     Unit Filter:"
      '
      'txtMaHH
      '
      Me.txtMaHH.Enabled = False
      Me.txtMaHH.Location = New System.Drawing.Point(750, 188)
      Me.txtMaHH.Multiline = True
      Me.txtMaHH.Name = "txtMaHH"
      Me.txtMaHH.Size = New System.Drawing.Size(68, 28)
      Me.txtMaHH.TabIndex = 0
      Me.txtMaHH.TabStop = False
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label1.Location = New System.Drawing.Point(680, 193)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(64, 19)
      Me.Label1.TabIndex = 26
      Me.Label1.Text = "Mã HH:"
      '
      'frmHH
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(841, 313)
      Me.Controls.Add(Me.txtMaHH)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.btnEditImage)
      Me.Controls.Add(Me.ptbHH)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.btnViewAll)
      Me.Controls.Add(Me.btnDeleteHH)
      Me.Controls.Add(Me.btnEditHH)
      Me.Controls.Add(Me.btnAddHH)
      Me.Controls.Add(Me.dgvHH)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtSearch)
      Me.Controls.Add(Me.cmbListView)
      Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "frmHH"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Quản Lý Hàng Hóa"
      CType(Me.dgvHH, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ptbHH, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnViewAll As System.Windows.Forms.Button
   Friend WithEvents btnDeleteHH As System.Windows.Forms.Button
   Friend WithEvents btnEditHH As System.Windows.Forms.Button
   Friend WithEvents btnAddHH As System.Windows.Forms.Button
   Friend WithEvents dgvHH As System.Windows.Forms.DataGridView
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtSearch As System.Windows.Forms.TextBox
   Friend WithEvents cmbListView As System.Windows.Forms.ComboBox
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents ptbHH As System.Windows.Forms.PictureBox
   Friend WithEvents btnEditImage As System.Windows.Forms.Button
   Friend WithEvents txtMaHH As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
