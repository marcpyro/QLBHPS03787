Public Class frmHD
   'Khai báo biến để truy xuất Database từ lớp DataBaseAccess
   Private _DBAccess As New DataBaseAccess

   'Khai báo biến trạng thái kiểm tra dữ liệu đang Load
   Private _isLoading As Boolean = False

   'Định nghĩa thủ tục load dữ liệu từ bảng HOA_DON vào DataGridView
   Private Sub LoadAllDataOnGridView()
      Dim sqlQuery As String = "select MaHD, HOA_DON.MaKH, TenKH, DiaChi from HOA_DON, CUSTOMER where HOA_DON.MaKH = CUSTOMER.MaKH"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvHD.DataSource = dTable
      With Me.dgvHD
         .Columns(0).HeaderText = "Mã HĐ"
         .Columns(1).HeaderText = "Mã KH"
         .Columns(2).HeaderText = "Tên KH"
         .Columns(3).HeaderText = "Địa chỉ"
      End With
   End Sub
   'Định nghĩa thủ tục load dữ liệu từ bảng HOA_DON theo từng NgayGD vào DataGridView
   Private Sub LoadDataOnGridView(NgayGD As String)
      Dim sqlQuery As String = String.Format("select MaHD, HOA_DON.MaKH, TenKH, DiaChi from HOA_DON, CUSTOMER where NgayGD = '{0}' and HOA_DON.MaKH = CUSTOMER.MaKH", NgayGD)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvHD.DataSource = dTable
      With Me.dgvHD
         .Columns(0).HeaderText = "Mã HĐ"
         .Columns(1).HeaderText = "Mã KH"
         .Columns(2).HeaderText = "Tên KH"
         .Columns(3).HeaderText = "Địa chỉ"
      End With
   End Sub

   Private Sub frmHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      _isLoading = True 'True khi dữ liệu bắt đầu Load

      LoadAllDataOnGridView()

      _isLoading = False 'False khi Load dữ liệu xong
   End Sub

   Private Sub dtpDD_ValueChanged(sender As Object, e As EventArgs) Handles dtpDD.ValueChanged
      LoadDataOnGridView(dtpDD.Text)
   End Sub
   Private Sub SearchAllHD(value As String)
      Dim sqlQuery As String = "select MaHD, CUSTOMER.MaKH, TenKH, DiaChi from HOA_DON, CUSTOMER"
      sqlQuery += String.Format(" where HOA_DON.MaKH = CUSTOMER.MaKH and MaHD LIKE '%{0}%'", value)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvHD.DataSource = dTable
      With Me.dgvHD
         .Columns(0).HeaderText = "Mã HĐ"
         .Columns(1).HeaderText = "Mã KH"
         .Columns(2).HeaderText = "Tên KH"
         .Columns(3).HeaderText = "Địa chỉ"
      End With
   End Sub

   Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
      SearchAllHD(Me.txtSearch.Text)
   End Sub

   Private Sub btnAddHD_Click(sender As Object, e As EventArgs) Handles btnAddHD.Click
      Dim frm As New frmAddHD(False)
      frm.txtTenKH.Enabled = False 'Không cho sửa lại Tên KH
      frm.txtDiaChi.Enabled = False 'Không cho sửa lại Địa chỉ
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         'Load dữ liệu vào DataGridView
         LoadDataOnGridView(dtpDD.Text)
      End If
   End Sub

   Private Sub btnEditHD_Click(sender As Object, e As EventArgs) Handles btnEditHD.Click
      Dim frm As New frmAddHD(True)
      frm.txtMaHD.Enabled = False 'Không cho sửa lại Mã HĐ
      frm.txtTenKH.Enabled = False 'Không cho sửa lại Tên KH
      frm.txtDiaChi.Enabled = False 'Không cho sửa lại Địa chỉ
      With Me.dgvHD
         frm.txtMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHD").Value
         frm.txtMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
         frm.txtTenKH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
         frm.txtDiaChi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
      End With
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then 'Sửa dữ liệu thành công thì Load lại vào DataGridView
         LoadDataOnGridView(dtpDD.Text)
      End If
   End Sub

   Private Sub btnDeleteHD_Click(sender As Object, e As EventArgs) Handles btnDeleteHD.Click
      'Khai báo biến lấy MaHĐ đã được chọn trên DataGridView
      Dim MAHĐ As String = Me.dgvHD.Rows(Me.dgvHD.CurrentCell.RowIndex).Cells("MaHD").Value
      'Khai báo câu lệnh Query để xóa
      Dim sqlQuery As String = String.Format("delete from HOA_DON where MaHD = '{0}'", MAHĐ)
      'Thực hiện xóa
      Dim Choice As Integer
      Choice = MsgBox("Bạn có chắc muốn xóa hàng này không?", vbYesNo + vbQuestion, "Thông báo")
      If Choice = vbYes Then
         If _DBAccess.ExecuteNoneQuery(sqlQuery) Then 'Xóa thành công thì thông báo
            MsgBox("Xóa dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
            'Load lại dữ liệu trên DataGridView
            LoadDataOnGridView(dtpDD.Text)
         Else
            MsgBox("Lỗi xóa dữ liệu", MsgBoxStyle.Critical, "Thông báo")
         End If
      End If
   End Sub

   Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
      If Not _isLoading Then 'Nếu Load xong dữ liệu
         LoadAllDataOnGridView()
      End If
   End Sub
End Class