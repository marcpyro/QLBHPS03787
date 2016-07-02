<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKH
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
      Me.txtSearch = New System.Windows.Forms.TextBox()
      Me.dgvKH = New System.Windows.Forms.DataGridView()
      Me.cmbListView = New System.Windows.Forms.ComboBox()
      Me.btnViewAll = New System.Windows.Forms.Button()
      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
      Me.btnDeleteKH = New System.Windows.Forms.Button()
      Me.btnEditKH = New System.Windows.Forms.Button()
      Me.btnAddKH = New System.Windows.Forms.Button()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
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
      'dgvKH
      '
      Me.dgvKH.AllowUserToAddRows = False
      Me.dgvKH.AllowUserToDeleteRows = False
      Me.dgvKH.AllowUserToOrderColumns = True
      Me.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.dgvKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
      Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvKH.Location = New System.Drawing.Point(150, 90)
      Me.dgvKH.MultiSelect = False
      Me.dgvKH.Name = "dgvKH"
      Me.dgvKH.ReadOnly = True
      Me.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvKH.Size = New System.Drawing.Size(505, 211)
      Me.dgvKH.TabIndex = 0
      Me.dgvKH.TabStop = False
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
      'PictureBox2
      '
      Me.PictureBox2.Image = Global.QLBH03787.My.Resources.Resources.customer_banner
      Me.PictureBox2.Location = New System.Drawing.Point(150, 21)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(329, 62)
      Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox2.TabIndex = 6
      Me.PictureBox2.TabStop = False
      '
      'btnDeleteKH
      '
      Me.btnDeleteKH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnDeleteKH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnDeleteKH.ForeColor = System.Drawing.Color.Red
      Me.btnDeleteKH.Image = Global.QLBH03787.My.Resources.Resources.orange_trash
      Me.btnDeleteKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnDeleteKH.Location = New System.Drawing.Point(26, 271)
      Me.btnDeleteKH.Name = "btnDeleteKH"
      Me.btnDeleteKH.Size = New System.Drawing.Size(100, 30)
      Me.btnDeleteKH.TabIndex = 4
      Me.btnDeleteKH.Text = "&Delete"
      Me.btnDeleteKH.UseVisualStyleBackColor = False
      '
      'btnEditKH
      '
      Me.btnEditKH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnEditKH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnEditKH.ForeColor = System.Drawing.Color.Lime
      Me.btnEditKH.Image = Global.QLBH03787.My.Resources.Resources.orange_edit
      Me.btnEditKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnEditKH.Location = New System.Drawing.Point(26, 235)
      Me.btnEditKH.Name = "btnEditKH"
      Me.btnEditKH.Size = New System.Drawing.Size(100, 30)
      Me.btnEditKH.TabIndex = 3
      Me.btnEditKH.Text = "&Edit"
      Me.btnEditKH.UseVisualStyleBackColor = False
      '
      'btnAddKH
      '
      Me.btnAddKH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnAddKH.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.btnAddKH.ForeColor = System.Drawing.SystemColors.Highlight
      Me.btnAddKH.Image = Global.QLBH03787.My.Resources.Resources.orange_plus
      Me.btnAddKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnAddKH.Location = New System.Drawing.Point(26, 199)
      Me.btnAddKH.Name = "btnAddKH"
      Me.btnAddKH.Size = New System.Drawing.Size(100, 30)
      Me.btnAddKH.TabIndex = 2
      Me.btnAddKH.Text = "&Add"
      Me.btnAddKH.UseVisualStyleBackColor = False
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
      Me.Label2.TabIndex = 2
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
      Me.Label3.Size = New System.Drawing.Size(107, 19)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "     Card Filter:"
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'frmKH
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(667, 313)
      Me.Controls.Add(Me.btnViewAll)
      Me.Controls.Add(Me.PictureBox2)
      Me.Controls.Add(Me.btnDeleteKH)
      Me.Controls.Add(Me.btnEditKH)
      Me.Controls.Add(Me.btnAddKH)
      Me.Controls.Add(Me.dgvKH)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtSearch)
      Me.Controls.Add(Me.cmbListView)
      Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "frmKH"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Thông Tin Khách Hàng"
      CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtSearch As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents dgvKH As System.Windows.Forms.DataGridView
   Friend WithEvents btnAddKH As System.Windows.Forms.Button
   Friend WithEvents btnEditKH As System.Windows.Forms.Button
   Friend WithEvents btnDeleteKH As System.Windows.Forms.Button
   Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
   Friend WithEvents cmbListView As System.Windows.Forms.ComboBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents btnViewAll As System.Windows.Forms.Button
End Class
