Public Class frmAddHD
   'Khai báo biến truy xuất DB từ lớp DBAccess
   Private _DBAccess As New DataBaseAccess
   'Khai báo biến để biết trạng thái đang là Edit hay Insert
   Private _isEdit As Boolean = False

   Public Sub New(isEdit As Boolean)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      _isEdit = isEdit
   End Sub
   'Định nghĩa hàm Insert
   Private Function InsertHD() As Boolean
      Dim sqlQuery As String = "insert into HOA_DON (MaHD, NgayGD, MaKH)"
      sqlQuery += String.Format("values ('{0}','{1}','{2}')", txtMaHD.Text, dtpDD.Text, txtMaKH.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function
   'Định nghĩa hàm Update
   Private Function UpdateHD() As Boolean
      Dim sqlQuery As String = String.Format("update HOA_DON set NgayGD = '{1}', MaKH = '{2}' where MaHD = '{0}'", Me.txtMaHD.Text, Me.dtpDD.Text, Me.txtMaKH.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function
   'Định nghĩa hàm kiểm tra MaHH, TenHH và DonVi nhập vào có rỗng hay không
   Private Function IsEmpty() As Boolean
      'Hàm trả về true nếu MaHH hoặc TenHH hoặc DonVi rỗng
      Return String.IsNullOrEmpty(txtMaHD.Text) OrElse String.IsNullOrEmpty(txtMaKH.Text)
   End Function

   Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
      If IsEmpty() Then 'Kiểm tra trường dữ liệu trước khi thực hiện Add, Edit
         MsgBox("Không được để trống Mã HĐ, Mã KH", MsgBoxStyle.Exclamation, "Thông báo")
      Else
         If _isEdit Then 'Nếu là Edit thì gọi hàm Update
            If UpdateHD() Then 'Nếu update thành công thì thông báo
               MsgBox("Sửa dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
               Me.DialogResult = Windows.Forms.DialogResult.OK
            Else 'Nếu có lỗi khi sửa thì thông báo lỗi
               MsgBox("Mã KH không tồn tại", MsgBoxStyle.Exclamation, "Thông báo")
            End If
         Else 'Nếu không phải Edit thì gọi hàm Insert
            If InsertHD() Then 'Nếu insert thành công thì thông báo
               MsgBox("Thêm dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
               Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
               MsgBox("Mã HĐ đã tồn tại hoặc Mã KH không tồn tại", MsgBoxStyle.Exclamation, "Thông báo")
            End If
         End If
      End If
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Me.Close()
   End Sub
End Class