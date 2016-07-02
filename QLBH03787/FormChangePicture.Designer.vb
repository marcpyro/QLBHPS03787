<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePicture
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
      Me.ImageDialogue = New System.Windows.Forms.OpenFileDialog()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtMaHH = New System.Windows.Forms.TextBox()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.btnEdit = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnAdd = New System.Windows.Forms.Button()
      Me.btnBrowse = New System.Windows.Forms.Button()
      Me.ptbHH = New System.Windows.Forms.PictureBox()
      CType(Me.ptbHH, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'ImageDialogue
      '
      Me.ImageDialogue.FileName = "ImageDialogue"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Label1.Location = New System.Drawing.Point(12, 204)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(64, 19)
      Me.Label1.TabIndex = 24
      Me.Label1.Text = "Mã HH:"
      '
      'txtMaHH
      '
      Me.txtMaHH.Enabled = False
      Me.txtMaHH.Location = New System.Drawing.Point(83, 199)
      Me.txtMaHH.Multiline = True
      Me.txtMaHH.Name = "txtMaHH"
      Me.txtMaHH.Size = New System.Drawing.Size(73, 28)
      Me.txtMaHH.TabIndex = 0
      Me.txtMaHH.TabStop = False
      '
      'btnExit
      '
      Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnExit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExit.ForeColor = System.Drawing.Color.Indigo
      Me.btnExit.Image = Global.QLBH03787.My.Resources.Resources.close_x
      Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnExit.Location = New System.Drawing.Point(162, 269)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(110, 30)
      Me.btnExit.TabIndex = 5
      Me.btnExit.Text = "&Exit"
      Me.btnExit.UseVisualStyleBackColor = False
      '
      'btnEdit
      '
      Me.btnEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnEdit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnEdit.ForeColor = System.Drawing.Color.Lime
      Me.btnEdit.Image = Global.QLBH03787.My.Resources.Resources.orange_edit
      Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnEdit.Location = New System.Drawing.Point(162, 233)
      Me.btnEdit.Name = "btnEdit"
      Me.btnEdit.Size = New System.Drawing.Size(110, 30)
      Me.btnEdit.TabIndex = 3
      Me.btnEdit.Text = "&Edit"
      Me.btnEdit.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnDelete.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.Red
      Me.btnDelete.Image = Global.QLBH03787.My.Resources.Resources.orange_trash
      Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnDelete.Location = New System.Drawing.Point(12, 269)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(110, 30)
      Me.btnDelete.TabIndex = 4
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnAdd
      '
      Me.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnAdd.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight
      Me.btnAdd.Image = Global.QLBH03787.My.Resources.Resources.orange_plus
      Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnAdd.Location = New System.Drawing.Point(12, 233)
      Me.btnAdd.Name = "btnAdd"
      Me.btnAdd.Size = New System.Drawing.Size(110, 30)
      Me.btnAdd.TabIndex = 2
      Me.btnAdd.Text = "&Add"
      Me.btnAdd.UseVisualStyleBackColor = False
      '
      'btnBrowse
      '
      Me.btnBrowse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.btnBrowse.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnBrowse.ForeColor = System.Drawing.Color.Blue
      Me.btnBrowse.Image = Global.QLBH03787.My.Resources.Resources.orange_folder_open
      Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnBrowse.Location = New System.Drawing.Point(162, 198)
      Me.btnBrowse.Name = "btnBrowse"
      Me.btnBrowse.Size = New System.Drawing.Size(110, 30)
      Me.btnBrowse.TabIndex = 1
      Me.btnBrowse.Text = "&Browse..."
      Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.btnBrowse.UseVisualStyleBackColor = False
      '
      'ptbHH
      '
      Me.ptbHH.ErrorImage = Global.QLBH03787.My.Resources.Resources.nophoto
      Me.ptbHH.Location = New System.Drawing.Point(53, 12)
      Me.ptbHH.Name = "ptbHH"
      Me.ptbHH.Size = New System.Drawing.Size(180, 180)
      Me.ptbHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.ptbHH.TabIndex = 19
      Me.ptbHH.TabStop = False
      '
      'frmChangePicture
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.ClientSize = New System.Drawing.Size(284, 311)
      Me.Controls.Add(Me.txtMaHH)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnEdit)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnAdd)
      Me.Controls.Add(Me.btnBrowse)
      Me.Controls.Add(Me.ptbHH)
      Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "frmChangePicture"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Chọn Ảnh"
      CType(Me.ptbHH, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ptbHH As System.Windows.Forms.PictureBox
   Friend WithEvents btnAdd As System.Windows.Forms.Button
   Friend WithEvents btnBrowse As System.Windows.Forms.Button
   Friend WithEvents ImageDialogue As System.Windows.Forms.OpenFileDialog
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents btnEdit As System.Windows.Forms.Button
   Friend WithEvents txtMaHH As System.Windows.Forms.TextBox
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
