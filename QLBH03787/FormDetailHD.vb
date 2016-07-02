Public Class frmDetailHD
   'Khai báo biến để truy xuất Database từ lớp DataBaseAccess
   Private _DBAccess As New DataBaseAccess

   'Khai báo biến trạng thái kiểm tra dữ liệu đang Load
   Private _isLoading As Boolean = False

   'Định nghĩa thủ tục load dữ liệu từ bảng CHI_TIET_HD, HANG_HOA, UNIT_TYPE vào DataGridView
   Private Sub LoadAllDataOnGridView()
      Dim sqlQuery As String = "select HOA_DON.MaHD, HANG_HOA.MaHH, TenHH, SoLuong, TongTien from HOA_DON, CHI_TIET_HD, HANG_HOA where HOA_DON.MaHD = CHI_TIET_HD.MaHD and HANG_HOA.MaHH = CHI_TIET_HD.MaHH"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvDetailHD.DataSource = dTable
      With Me.dgvDetailHD
         .Columns(0).HeaderText = "Mã HĐ"
         .Columns(1).HeaderText = "Mã HH"
         .Columns(2).HeaderText = "Tên HH"
         .Columns(3).HeaderText = "Số lượng"
         .Columns(4).HeaderText = "Tổng tiền"
      End With
   End Sub
   'Định nghĩa thủ tục load dữ liệu từ bảng HOA_DON, CHI_TIET_HD, HANG_HOA, UNIT_TYPE theo từng NgayGD vào DataGridView
   Private Sub LoadDataOnGridView(NgayGD As String)
      Dim sqlQuery As String = String.Format("select HOA_DON.MaHD, HANG_HOA.MaHH, TenHH, SoLuong, TongTien from HOA_DON, CHI_TIET_HD, HANG_HOA where HOA_DON.NgayGD = '{0}' and HOA_DON.MaHD = CHI_TIET_HD.MaHD and HANG_HOA.MaHH = CHI_TIET_HD.MaHH", NgayGD)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvDetailHD.DataSource = dTable
      With Me.dgvDetailHD
         .Columns(0).HeaderText = "Mã HĐ"
         .Columns(1).HeaderText = "Mã HH"
         .Columns(2).HeaderText = "Tên HH"
         .Columns(3).HeaderText = "Số lượng"
         .Columns(4).HeaderText = "Tổng tiền"
      End With
   End Sub

   Private Sub frmDetailHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      _isLoading = True 'True khi dữ liệu bắt đầu Load

      LoadAllDataOnGridView()

      _isLoading = False 'False khi Load dữ liệu xong
   End Sub

   Private Sub dtpDD_ValueChanged(sender As Object, e As EventArgs) Handles dtpDD.ValueChanged
      LoadDataOnGridView(dtpDD.Text)
   End Sub
   Private Sub SearchAllDetailHD(value As String)
      Dim sqlQuery As String = "select HOA_DON.MaHD, HANG_HOA.MaHH, TenHH, SoLuong, TongTien from HOA_DON, CHI_TIET_HD, HANG_HOA"
      sqlQuery += String.Format(" where HOA_DON.MaHD = CHI_TIET_HD.MaHD and HANG_HOA.MaHH = CHI_TIET_HD.MaHH and CHI_TIET_HD.MaHD like '%{0}%'", value)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvDetailHD.DataSource = dTable
      With Me.dgvDetailHD
         .Columns(0).HeaderText = "Mã HĐ"
         .Columns(1).HeaderText = "Mã HH"
         .Columns(2).HeaderText = "Tên HH"
         .Columns(3).HeaderText = "Số lượng"
         .Columns(4).HeaderText = "Tổng tiền"
      End With
   End Sub

   Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
      SearchAllDetailHD(Me.txtSearch.Text)
   End Sub

   Private Sub btnAddDetailHD_Click(sender As Object, e As EventArgs) Handles btnAddDetailHD.Click
      Dim frm As New frmAddDetailHD(False)
      frm.txtTenHH.Enabled = False 'Không cho sửa lại Tên HH
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         'Load dữ liệu vào DataGridView
         LoadDataOnGridView(dtpDD.Text)
      End If
   End Sub

   Private Sub btnEditDetailHD_Click(sender As Object, e As EventArgs) Handles btnEditDetailHD.Click
      Dim frm As New frmAddDetailHD(True)
      frm.txtTenHH.Enabled = False 'Không cho sửa lại Tên HH
      With Me.dgvDetailHD
         frm.cmbMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHD").Value
         frm.cmbMaHH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHH").Value
         frm.txtTenHH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenHH").Value
         frm.txtSoLuong.Text = .Rows(.CurrentCell.RowIndex).Cells("SoLuong").Value
         frm.txtTongtien.Text = .Rows(.CurrentCell.RowIndex).Cells("TongTien").Value
      End With
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then 'Sửa dữ liệu thành công thì Load lại vào DataGridView
         LoadDataOnGridView(dtpDD.Text)
      End If
   End Sub

   Private Sub btnDeleteDetailHD_Click(sender As Object, e As EventArgs) Handles btnDeleteDetailHD.Click
      'Khai báo biến lấy MaHĐ đã được chọn trên DataGridView
      Dim MAHĐ As String = Me.dgvDetailHD.Rows(Me.dgvDetailHD.CurrentCell.RowIndex).Cells("MaHD").Value
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