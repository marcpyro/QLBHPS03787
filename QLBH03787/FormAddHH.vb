Public Class frmAddHH
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
   Private Function InsertHH() As Boolean
      Dim sqlQuery As String = "insert into HANG_HOA (MaHH, TenHH, DonGia, TonKho, DonViID)"
      sqlQuery += String.Format("values ('{0}',N'{1}','{2}','{3}',N'{4}')", txtMaHH.Text, txtTenHH.Text, txtDonGia.Text, txtTonKho.Text, cmbDonViID.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function
   'Định nghĩa hàm Update
   Private Function UpdateHH() As Boolean
      Dim sqlQuery As String = String.Format("update HANG_HOA set TenHH = N'{1}', DonGia = '{2}', TonKho = '{3}', DonViID = '{4}' where MaHH = '{0}'", Me.txtMaHH.Text, Me.txtTenHH.Text, Me.txtDonGia.Text, Me.txtTonKho.Text, Me.cmbDonViID.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function
   'Định nghĩa hàm kiểm tra MaHH, TenHH và DonVi nhập vào có rỗng hay không
   Private Function IsEmpty() As Boolean
      'Hàm trả về true nếu MaHH hoặc TenHH hoặc DonVi rỗng
      Return String.IsNullOrEmpty(txtMaHH.Text) OrElse String.IsNullOrEmpty(txtTenHH.Text) _
      OrElse String.IsNullOrEmpty(cmbDonViID.Text)
   End Function

   Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
      If IsEmpty() Then 'Kiểm tra trường dữ liệu trước khi thực hiện Add, Edit
         MsgBox("Không được để trống Mã HH, Tên HH và Đơn vị", MsgBoxStyle.Exclamation, "Thông báo")
      Else
         If _isEdit Then 'Nếu là Edit thì gọi hàm Update
            If UpdateHH() Then 'Nếu update thành công thì thông báo
               MsgBox("Sửa dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
               Me.DialogResult = Windows.Forms.DialogResult.OK
            Else 'Nếu có lỗi khi sửa thì thông báo lỗi
               MsgBox("Lỗi sửa dữ liệu", MsgBoxStyle.Exclamation, "Thông báo")
            End If
         Else 'Nếu không phải Edit thì gọi hàm Insert
            If InsertHH() Then 'Nếu insert thành công thì thông báo
               MsgBox("Thêm dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
               Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
               MsgBox("Mã HH đã tồn tại", MsgBoxStyle.Exclamation, "Thông báo")
            End If
         End If
      End If
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Me.Close()
   End Sub
End Class