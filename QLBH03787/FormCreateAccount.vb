Public Class frmCreateAccount
   'Khai báo biến truy xuất DB từ lớp DBAccess
   Private _DBAccess As New DataBaseAccess

   'Định nghĩa hàm thêm bản ghi account vào Database
   Private Function InsertAccount()
      Dim sqlQuery As String = "insert into Accounts (username, password)"
      sqlQuery += String.Format("values ('{0}','{1}')", txtUser.Text, txtPassword.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function

   'Định nghĩa hàm kiểm tra username nhập vào có rỗng hay không
   Private Function IsEmpty() As Boolean
      'Hàm trả về true nếu username rỗng
      Return String.IsNullOrEmpty(txtUser.Text)
   End Function

   Private Sub btnCreateOK_Click(sender As Object, e As EventArgs) Handles btnCreateOK.Click
      'Kiểm tra username có nhập vào hay không
      If IsEmpty() Then
         MsgBox("Không được để trống Username", MsgBoxStyle.Exclamation, "Thông báo")
      Else
         If InsertAccount() Then 'Nếu insert thành công thì thông báo
            MsgBox("Tạo tài khoản thành công", MsgBoxStyle.Information, "Thông báo")
            Me.DialogResult = Windows.Forms.DialogResult.OK
         Else
            MsgBox("Username đã tồn tại", MsgBoxStyle.Exclamation, "Thông báo")
         End If
      End If
   End Sub

   Private Sub btnCreateExit_Click(sender As Object, e As EventArgs) Handles btnCreateExit.Click
      Me.Close()
   End Sub
End Class