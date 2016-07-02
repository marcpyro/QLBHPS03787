Public Class frmKH
   'Khai báo biến để truy xuất Database từ lớp DataBaseAccess
   Private _DBAccess As New DataBaseAccess

   'Khai báo biến trạng thái kiểm tra dữ liệu đang Load
   Private _isLoading As Boolean = False

   'Định nghĩa thủ tục load dữ liệu từ bảng LEVEL_CARD vào combobox
   Private Sub LoadDataOnCombobox()
      Dim sqlQuery As String = "select LevelCardID, LevelCardName from LEVEL_CARD"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.cmbListView.DataSource = dTable
      Me.cmbListView.ValueMember = "LevelCardID"
      Me.cmbListView.DisplayMember = "LevelCardName"
   End Sub
   'Định nghĩa thủ tục load dữ liệu từ bảng CUSTOMER vào DataGridView
   Private Sub LoadAllDataOnGridView()
      Dim sqlQuery As String = "select MaKH, TenKH, DiaChi, SDT from CUSTOMER"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvKH.DataSource = dTable
      With Me.dgvKH
         .Columns(0).HeaderText = "Mã KH"
         .Columns(1).HeaderText = "Tên KH"
         .Columns(2).HeaderText = "Địa chỉ"
         .Columns(3).HeaderText = "Số ĐT"
      End With
   End Sub
   'Định nghĩa thủ tục load dữ liệu từ bảng CUSTOMER theo từng LevelCard vào DataGridView
   Private Sub LoadDataOnGridView(LevelCardID As String)
      Dim sqlQuery As String = String.Format("select MaKH, TenKH, DiaChi, SDT from CUSTOMER where LevelCardID = '{0}'", LevelCardID)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvKH.DataSource = dTable
      With Me.dgvKH
         .Columns(0).HeaderText = "Mã KH"
         .Columns(1).HeaderText = "Tên KH"
         .Columns(2).HeaderText = "Địa chỉ"
         .Columns(3).HeaderText = "Số ĐT"
      End With
   End Sub
   Private Sub frmKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      _isLoading = True 'True khi dữ liệu bắt đầu Load

      LoadDataOnCombobox()
      LoadAllDataOnGridView()

      _isLoading = False 'False khi Load dữ liệu xong
   End Sub


   Private Sub cmbListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
               cmbListView.SelectedIndexChanged
      If Not _isLoading Then 'Nếu Load xong dữ liệu
         LoadDataOnGridView(Me.cmbListView.SelectedValue)
      End If
   End Sub
   Private Sub SearchAllKH(value As String)
      Dim sqlQuery As String = "select MaKH, TenKH, DiaChi, SDT from CUSTOMER"
      sqlQuery += String.Format(" where MaKH like '%{0}%' or TenKH like N'%{0}%' or DiaChi like N'%{0}%'", value)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvKH.DataSource = dTable
      With Me.dgvKH
         .Columns(0).HeaderText = "Mã KH"
         .Columns(1).HeaderText = "Tên KH"
         .Columns(2).HeaderText = "Địa chỉ"
         .Columns(3).HeaderText = "Số ĐT"
      End With
   End Sub

   Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
      SearchAllKH(Me.txtSearch.Text)
   End Sub

   Private Sub btnAddKH_Click(sender As Object, e As EventArgs) Handles btnAddKH.Click
      Dim frm As New frmAddKH(False)
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         'Load dữ liệu vào DataGridView
         LoadDataOnGridView(Me.cmbListView.SelectedValue)
      End If
   End Sub

   Private Sub btnEditKH_Click(sender As Object, e As EventArgs) Handles btnEditKH.Click
      Dim frm As New frmAddKH(True)
      frm.txtMaKH.Enabled = False 'Không cho sửa lại Mã KH
      With Me.dgvKH
         frm.txtMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
         frm.txtTenKH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
         frm.txtDiaChi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
         frm.txtSDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
      End With
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then 'Sửa dữ liệu thành công thì Load lại vào DataGridView
         LoadDataOnGridView(Me.cmbListView.SelectedValue)
      End If
   End Sub

   Private Sub btnDeleteKH_Click(sender As Object, e As EventArgs) Handles btnDeleteKH.Click
      'Khai báo biến lấy MaKH đã được chọn trên DataGridView
      Dim MAKH As String = Me.dgvKH.Rows(Me.dgvKH.CurrentCell.RowIndex).Cells("MaKH").Value
      'Khai báo câu lệnh Query để xóa
      Dim sqlQuery As String = String.Format("delete from CUSTOMER where MaKH = '{0}'", MAKH)
      'Thực hiện xóa
      Dim Choice As Integer
      Choice = MsgBox("Bạn có chắc muốn xóa hàng này không?", vbYesNo + vbQuestion, "Thông báo")
      If Choice = vbYes Then
         If _DBAccess.ExecuteNoneQuery(sqlQuery) Then 'Xóa thành công thì thông báo
            MsgBox("Xóa dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
            'Load lại dữ liệu trên DataGridView
            LoadDataOnGridView(Me.cmbListView.SelectedValue)
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