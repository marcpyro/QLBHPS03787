<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailHD
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
      Me.dgvDetailHD = New System.Windows.Forms.DataGridView()
      Me.txtSearch = New System.Windows.Forms.TextBox()
      Me.dtpDD = New System.Windows.Forms.DateTimePicker()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btnViewAll = New System.Windows.Forms.Button()
      Me.btnDeleteDetailHD = New System.Windows.Forms.Button()
      Me.btnEditDetailHD = New System.Windows.Forms.Button()
      Me.btnAddDetailHD = New System.Windows.Forms.Button()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      CType(Me.dgvDetailHD, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'dgvDetailHD
      '
      Me.dgvDetailHD.AllowUserToAddRows = False
      Me.dgvDetailHD.AllowUserToDeleteRows = False
      Me.dgvDetailHD.AllowUserToOrderColumns = True
      Me.dgvDetailHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.dgvDetailHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
      Me.dgvDetailHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvDetailHD.Location = New System.Drawing.Point(150, 90)
      Me.dgvDetailHD.MultiSelect = False
      Me.dgvDetailHD.Name = "dgvDetailHD"
      Me.dgvDetailHD.ReadOnly = True
      Me.dgvDetailHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvDetailHD.Size = New System.Drawing.Size(505, 211)
      Me.dgvDetailHD.TabIndex = 0
      Me.dgvDetailHD.TabStop = False
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
      'dtpDD
      '
      Me.dtpDD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDD.Location = New System.Drawing.Point(12, 112)
      Me.dtpDD.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
      Me.dtpDD.Name = "dtpDD"
      Me.dtpDD.Size = New System.Drawing.Size(131, 26)
      Me.dtpDD.TabIndex = 2
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.QLBH03787.My.Resources.Resources.invoice_banner
      Me.PictureBox1.Location = New System.Drawing.Point(150, 21)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(330, 62)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 27
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
      'btnDeleteDetailHD
      '
      Me.btnDeleteDetailHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnDeleteDetailHD.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnDeleteDetailHD.ForeColor = System.Drawing.Color.Red
      Me.btnDeleteDetailHD.Image = Global.QLBH03787.My.Resources.Resources.orange_trash
      Me.btnDeleteDetailHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnDeleteDetailHD.Location = New System.Drawing.Point(26, 271)
      Me.btnDeleteDetailHD.Name = "btnDeleteDetailHD"
      Me.btnDeleteDetailHD.Size = New System.Drawing.Size(100, 30)
      Me.btnDeleteDetailHD.TabIndex = 5
      Me.btnDeleteDetailHD.Text = "&Delete"
      Me.btnDeleteDetailHD.UseVisualStyleBackColor = False
      '
      'btnEditDetailHD
      '
      Me.btnEditDetailHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnEditDetailHD.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnEditDetailHD.ForeColor = System.Drawing.Color.Lime
      Me.btnEditDetailHD.Image = Global.QLBH03787.My.Resources.Resources.orange_edit
      Me.btnEditDetailHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnEditDetailHD.Location = New System.Drawing.Point(26, 235)
      Me.btnEditDetailHD.Name = "btnEditDetailHD"
      Me.btnEditDetailHD.Size = New System.Drawing.Size(100, 30)
      Me.btnEditDetailHD.TabIndex = 4
      Me.btnEditDetailHD.Text = "&Edit"
      Me.btnEditDetailHD.UseVisualStyleBackColor = False
      '
      'btnAddDetailHD
      '
      Me.btnAddDetailHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnAddDetailHD.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnAddDetailHD.ForeColor = System.Drawing.SystemColors.Highlight
      Me.btnAddDetailHD.Image = Global.QLBH03787.My.Resources.Resources.orange_plus
      Me.btnAddDetailHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnAddDetailHD.Location = New System.Drawing.Point(26, 199)
      Me.btnAddDetailHD.Name = "btnAddDetailHD"
      Me.btnAddDetailHD.Size = New System.Drawing.Size(100, 30)
      Me.btnAddDetailHD.TabIndex = 3
      Me.btnAddDetailHD.Text = "&Add"
      Me.btnAddDetailHD.UseVisualStyleBackColor = False
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Image = Global.QLBH03787.My.Resources.Resources.orange_search
      Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.Label2.Location = New System.Drawing.Point(486, 33)
      Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(153, 19)
      Me.Label2.TabIndex = 21
      Me.Label2.Text = "     Search By Mã HĐ:"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label3.Image = Global.QLBH03787.My.Resources.Resources.Filter
      Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.Label3.Location = New System.Drawing.Point(11, 90)
      Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(141, 19)
      Me.Label3.TabIndex = 22
      Me.Label3.Text = "     Deal Date Filter:"
      '
      'frmDetailHD
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(667, 313)
      Me.Controls.Add(Me.dtpDD)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.btnViewAll)
      Me.Controls.Add(Me.btnDeleteDetailHD)
      Me.Controls.Add(Me.btnEditDetailHD)
      Me.Controls.Add(Me.btnAddDetailHD)
      Me.Controls.Add(Me.dgvDetailHD)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtSearch)
      Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "frmDetailHD"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Chi Tiết Hóa Đơn"
      CType(Me.dgvDetailHD, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents btnViewAll As System.Windows.Forms.Button
   Friend WithEvents btnDeleteDetailHD As System.Windows.Forms.Button
   Friend WithEvents btnEditDetailHD As System.Windows.Forms.Button
   Friend WithEvents btnAddDetailHD As System.Windows.Forms.Button
   Friend WithEvents dgvDetailHD As System.Windows.Forms.DataGridView
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtSearch As System.Windows.Forms.TextBox
   Friend WithEvents dtpDD As System.Windows.Forms.DateTimePicker
End Class
