Public Class frmMain
   'Khai báo biến nhận kết quả trả về của form Login
   Private _LoginResult As DialogResult

   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      If _LoginResult <> Windows.Forms.DialogResult.OK Then
         Me.Close() 'Đóng Form Main nếu người dùng nhấn vào nút Exit
      End If
      txtLoginID.Text = Username
   End Sub

   Public Sub New()

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Dim frm As New frmLogin
      frm.ShowDialog()
      _LoginResult = frm.DialogResult
   End Sub

   Private Sub QuảnLýKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKHToolStripMenuItem.Click
      frmKH.ShowDialog()
   End Sub

   Private Sub QuảnLýHHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHHToolStripMenuItem.Click
      frmHH.ShowDialog()
   End Sub

   Private Sub KiểmKêToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KiểmKêToolStripMenuItem.Click
      frmHD.ShowDialog()
   End Sub

   Private Sub ChiTietToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTietToolStripMenuItem.Click
      frmDetailHD.ShowDialog()
   End Sub

   Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
      Me.Close()
   End Sub

   Private Sub ĐổiMậtKhẩuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐổiMậtKhẩuToolStripMenuItem.Click
      frmChangePassword.ShowDialog()
   End Sub
End Class
