Public Class frmAddDetailHD
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
   'Định nghĩa thủ tục load dữ liệu từ bảng HOA_DON vào combobox MaHD
   Private Sub LoadDataOnCombobox()
      Dim sqlQuery As String = "select MaHD from HOA_DON"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.cmbMaHD.DataSource = dTable
      Me.cmbMaHD.ValueMember = "MaHD"
      Me.cmbMaHD.DisplayMember = "MaHD"
   End Sub
   'Định nghĩa thủ tục load dữ liệu từ bảng HANG_HOA vào combobox MaHH
   Private Sub LoadDataOnCombobox2()
      Dim sqlQuery As String = "select MaHH from HANG_HOA"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.cmbMaHH.DataSource = dTable
      Me.cmbMaHH.ValueMember = "MaHH"
      Me.cmbMaHH.DisplayMember = "MaHH"
   End Sub
   'Định nghĩa hàm Insert
   Private Function InsertDetailHD() As Boolean
      Dim sqlQuery As String = "insert into CHI_TIET_HD (MaHD, MaHH, Soluong, TongTien)"
      sqlQuery += String.Format("values ('{0}','{1}','{2}','{3}')", cmbMaHD.Text, cmbMaHH.Text, txtSoLuong.Text, txtTongtien.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function
   'Định nghĩa hàm Update
   Private Function UpdateDetailHD() As Boolean
      Dim sqlQuery As String = String.Format("update CHI_TIET_HD set MaHH = '{1}', SoLuong = '{2}', TongTien = '{3}' where MaHD = '{0}'", Me.cmbMaHD.Text, Me.cmbMaHH.Text, Me.txtSoLuong.Text, Me.txtTongtien.Text)
      Return _DBAccess.ExecuteNoneQuery(sqlQuery)
   End Function
   'Định nghĩa hàm kiểm tra MaHH, TenHH và DonVi nhập vào có rỗng hay không
   Private Function IsEmpty() As Boolean
      'Hàm trả về true nếu MaHH hoặc TenHH hoặc DonVi rỗng
      Return String.IsNullOrEmpty(cmbMaHD.Text) OrElse String.IsNullOrEmpty(cmbMaHH.Text)
   End Function

   Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
      If IsEmpty() Then 'Kiểm tra trường dữ liệu trước khi thực hiện Add, Edit
         MsgBox("Không được để trống Mã HĐ, Mã HH", MsgBoxStyle.Exclamation, "Thông báo")
      Else
         If _isEdit Then 'Nếu là Edit thì gọi hàm Update
            If UpdateDetailHD() Then 'Nếu update thành công thì thông báo
               MsgBox("Sửa dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
               Me.DialogResult = Windows.Forms.DialogResult.OK
            Else 'Nếu có lỗi khi sửa thì thông báo lỗi
               MsgBox("Mã HH không tồn tại", MsgBoxStyle.Exclamation, "Thông báo")
            End If
         Else 'Nếu không phải Edit thì gọi hàm Insert
            If InsertDetailHD() Then 'Nếu insert thành công thì thông báo
               MsgBox("Thêm dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
               Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
               MsgBox("Mã HĐ không tồn tại hoặc Mã HH không tồn tại", MsgBoxStyle.Exclamation, "Thông báo")
            End If
         End If
      End If
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Me.Close()
   End Sub

   Private Sub frmAddDetailHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      LoadDataOnCombobox()
      LoadDataOnCombobox2()
   End Sub
End Class