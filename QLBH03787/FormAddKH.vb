Public Class frmAddKH
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
   Private Function InsertKH() As Boolean
      Dim sqlQuery As String = "insert into CUSTOMER (MaKH, TenKH, LevelCardID, DiaChi, SDT)"
      sqlQuery += String.Format("values ('{0}',N'{1}','{2}',N'{3}','{4}')", _
                                txtMaKH.Text, txtTenKH.Text, cmbCLI.Text, txtDiaChi.Text, txtSDT.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function
   'Định nghĩa hàm Update
   Private Function UpdateKH() As Boolean
      Dim sqlQuery As String = String.Format("update CUSTOMER set TenKH = N'{1}', LevelCardID = '{2}'," & _
                                             "DiaChi = N'{3}', SDT = '{4}' where MaKH = '{0}'", _
                        Me.txtMaKH.Text, Me.txtTenKH.Text, Me.cmbCLI.Text, Me.txtDiaChi.Text, Me.txtSDT.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function
   'Định nghĩa hàm kiểm tra MaKH, TenKH và CardLevelID nhập vào có rỗng hay không
   Private Function IsEmpty() As Boolean
      'Hàm trả về true nếu MaKH hoặc TenKH hoặc CardLevelID rỗng
      Return String.IsNullOrEmpty(txtMaKH.Text) OrElse String.IsNullOrEmpty(txtTenKH.Text) _
         OrElse String.IsNullOrEmpty(cmbCLI.Text)
   End Function

   Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
      If IsEmpty() Then 'Kiểm tra trường dữ liệu trước khi thực hiện Add, Edit
         MsgBox("Không được để trống Mã KH, Tên KH và Card Level ID", MsgBoxStyle.Exclamation, "Thông báo")
      Else
         If _isEdit Then 'Nếu là Edit thì gọi hàm Update
            If UpdateKH() Then 'Nếu update thành công thì thông báo
               MsgBox("Sửa dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
               Me.DialogResult = Windows.Forms.DialogResult.OK
            Else 'Nếu có lỗi khi sửa thì thông báo lỗi
               MsgBox("Lỗi sửa dữ liệu", MsgBoxStyle.Exclamation, "Thông báo")
            End If
         Else 'Nếu không phải Edit thì gọi hàm Insert
            If InsertKH() Then 'Nếu insert thành công thì thông báo
               MsgBox("Thêm dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
               Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
               MsgBox("Mã KH đã tồn tại", MsgBoxStyle.Exclamation, "Thông báo")
            End If
         End If
      End If
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Me.Close()
   End Sub
End Class