<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHD
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
      Me.dtpDD = New System.Windows.Forms.DateTimePicker()
      Me.dgvHD = New System.Windows.Forms.DataGridView()
      Me.txtSearch = New System.Windows.Forms.TextBox()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btnViewAll = New System.Windows.Forms.Button()
      Me.btnDeleteHD = New System.Windows.Forms.Button()
      Me.btnEditHD = New System.Windows.Forms.Button()
      Me.btnAddHD = New System.Windows.Forms.Button()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'dtpDD
      '
      Me.dtpDD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDD.Location = New System.Drawing.Point(12, 107)
      Me.dtpDD.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
      Me.dtpDD.Name = "dtpDD"
      Me.dtpDD.Size = New System.Drawing.Size(131, 26)
      Me.dtpDD.TabIndex = 2
      '
      'dgvHD
      '
      Me.dgvHD.AllowUserToAddRows = False
      Me.dgvHD.AllowUserToDeleteRows = False
      Me.dgvHD.AllowUserToOrderColumns = True
      Me.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.dgvHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
      Me.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvHD.Location = New System.Drawing.Point(150, 85)
      Me.dgvHD.MultiSelect = False
      Me.dgvHD.Name = "dgvHD"
      Me.dgvHD.ReadOnly = True
      Me.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvHD.Size = New System.Drawing.Size(505, 211)
      Me.dgvHD.TabIndex = 0
      Me.dgvHD.TabStop = False
      '
      'txtSearch
      '
      Me.txtSearch.Location = New System.Drawing.Point(487, 51)
      Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
      Me.txtSearch.Multiline = True
      Me.txtSearch.Name = "txtSearch"
      Me.txtSearch.Size = New System.Drawing.Size(168, 27)
      Me.txtSearch.TabIndex = 1
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.invoice
      Me.PictureBox1.Location = New System.Drawing.Point(150, 16)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(330, 62)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 37
      Me.PictureBox1.TabStop = False
      '
      'btnViewAll
      '
      Me.btnViewAll.Image = Global.QLBH03787.My.Resources.Resources.View_Icon
      Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnViewAll.Location = New System.Drawing.Point(15, 16)
      Me.btnViewAll.Name = "btnViewAll"
      Me.btnViewAll.Size = New System.Drawing.Size(128, 29)
      Me.btnViewAll.TabIndex = 0
      Me.btnViewAll.TabStop = False
      Me.btnViewAll.Text = "View All"
      Me.btnViewAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnViewAll.UseVisualStyleBackColor = True
      '
      'btnDeleteHD
      '
      Me.btnDeleteHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnDeleteHD.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnDeleteHD.ForeColor = System.Drawing.Color.Red
      Me.btnDeleteHD.Image = Global.QLBH03787.My.Resources.Resources.orange_trash
      Me.btnDeleteHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnDeleteHD.Location = New System.Drawing.Point(26, 266)
      Me.btnDeleteHD.Name = "btnDeleteHD"
      Me.btnDeleteHD.Size = New System.Drawing.Size(100, 30)
      Me.btnDeleteHD.TabIndex = 5
      Me.btnDeleteHD.Text = "&Delete"
      Me.btnDeleteHD.UseVisualStyleBackColor = False
      '
      'btnEditHD
      '
      Me.btnEditHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnEditHD.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnEditHD.ForeColor = System.Drawing.Color.Lime
      Me.btnEditHD.Image = Global.QLBH03787.My.Resources.Resources.orange_edit
      Me.btnEditHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnEditHD.Location = New System.Drawing.Point(26, 230)
      Me.btnEditHD.Name = "btnEditHD"
      Me.btnEditHD.Size = New System.Drawing.Size(100, 30)
      Me.btnEditHD.TabIndex = 4
      Me.btnEditHD.Text = "&Edit"
      Me.btnEditHD.UseVisualStyleBackColor = False
      '
      'btnAddHD
      '
      Me.btnAddHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnAddHD.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnAddHD.ForeColor = System.Drawing.SystemColors.Highlight
      Me.btnAddHD.Image = Global.QLBH03787.My.Resources.Resources.orange_plus
      Me.btnAddHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnAddHD.Location = New System.Drawing.Point(26, 194)
      Me.btnAddHD.Name = "btnAddHD"
      Me.btnAddHD.Size = New System.Drawing.Size(100, 30)
      Me.btnAddHD.TabIndex = 3
      Me.btnAddHD.Text = "&Add"
      Me.btnAddHD.UseVisualStyleBackColor = False
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Image = Global.QLBH03787.My.Resources.Resources.orange_search
      Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.Label2.Location = New System.Drawing.Point(486, 28)
      Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(153, 19)
      Me.Label2.TabIndex = 35
      Me.Label2.Text = "     Search By Mã HĐ:"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label3.Image = Global.QLBH03787.My.Resources.Resources.Filter
      Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.Label3.Location = New System.Drawing.Point(11, 85)
      Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(141, 19)
      Me.Label3.TabIndex = 36
      Me.Label3.Text = "     Deal Date Filter:"
      '
      'frmHD
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(667, 313)
      Me.Controls.Add(Me.dtpDD)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.btnViewAll)
      Me.Controls.Add(Me.btnDeleteHD)
      Me.Controls.Add(Me.btnEditHD)
      Me.Controls.Add(Me.btnAddHD)
      Me.Controls.Add(Me.dgvHD)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtSearch)
      Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "frmHD"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Kiểm Kê Hóa Đơn"
      CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents dtpDD As System.Windows.Forms.DateTimePicker
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents btnViewAll As System.Windows.Forms.Button
   Friend WithEvents btnDeleteHD As System.Windows.Forms.Button
   Friend WithEvents btnEditHD As System.Windows.Forms.Button
   Friend WithEvents btnAddHD As System.Windows.Forms.Button
   Friend WithEvents dgvHD As System.Windows.Forms.DataGridView
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
