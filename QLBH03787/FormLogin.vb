Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmLogin
   'Khai báo biến để truy xuất Database từ lớp DataBaseAccess
   Private _DBAccess As New DataBaseAccess

   'Định nghĩa hàm kiểm tra username, password nhập vào có đúng không
   Private Function CheckLogin(user As String, pass As String)
      Dim sqlQuery As String = String.Format("select * from Accounts where username = '{0}' and password = '{1}'", user, pass)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Return dTable.Rows.Count > 0
   End Function

   'Định nghĩa hàm kiểm tra username nhập vào có rỗng hay không
   Private Function IsEmpty() As Boolean
      'Hàm trả về true nếu username hoặc password rỗng
      Return String.IsNullOrEmpty(Me.cmbUser.Text)
   End Function
   

   'Định nghĩa thủ tục load dữ liệu từ bảng Accounts vào combobox
   Private Sub LoadDataOnCombobox()
      Dim sqlQuery As String = "select * from Accounts"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.cmbUser.DataSource = dTable
      Me.cmbUser.ValueMember = "password"
      Me.cmbUser.DisplayMember = "username"
   End Sub


   Private Sub btnLoginOK_Click(sender As Object, e As EventArgs) Handles btnLoginOK.Click
      'Kiểm tra username và password có nhập vào hay không
      If IsEmpty() Then
         MsgBox("Không được để trống Username", MsgBoxStyle.Exclamation, "Thông báo")
      Else
         If CheckLogin(Me.cmbUser.Text.ToLower, Me.txtPassword.Text.ToLower) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            MsgBox("Đăng nhập thành công", MsgBoxStyle.Information, "Thông báo")
            Username = cmbUser.Text
         Else 'Trường hợp sai username hoặc password
            MsgBox("Username hoặc Password không đúng", MsgBoxStyle.Exclamation, "Thông báo")
         End If
      End If
   End Sub

   Private Sub btnLoginExit_Click(sender As Object, e As EventArgs) Handles btnLoginExit.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      LoadDataOnCombobox()
   End Sub

   Private Sub btnLoginCreate_Click(sender As Object, e As EventArgs) Handles btnLoginCreate.Click
      Dim frm As New frmCreateAccount
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         'Load dữ liệu vào cmbUser
         LoadDataOnCombobox()
      End If
   End Sub
End Class

