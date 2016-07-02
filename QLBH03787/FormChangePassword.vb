Public Class frmChangePassword
   'Khai báo biến truy xuất DB từ lớp DBAccess
   Private _DBAccess As New DataBaseAccess
   
   'Định nghĩa hàm Update
   Private Function UpdatePassword() As Boolean
      Dim sqlQuery As String = String.Format("update Accounts set password = '{1}' where username = '{0}'", _
                                             Me.txtUser.Text, Me.txtNewPassword.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function

   Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
      If UpdatePassword() Then 'Nếu update thành công thì thông báo
         MsgBox("Đổi password thành công", MsgBoxStyle.Information, "Thông báo")
         Me.DialogResult = Windows.Forms.DialogResult.OK
      Else 'Nếu có lỗi khi sửa thì thông báo lỗi
         MsgBox("Password quá dài", MsgBoxStyle.Exclamation, "Thông báo")
      End If
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Me.Close()
   End Sub

   Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      txtUser.Text = Username
   End Sub
End Class