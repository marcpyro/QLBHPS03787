Imports System.Data.DataSet
Imports System.Data.SqlClient
Imports System.IO
Public Class frmHH
   'Khai báo biến để truy xuất Database từ lớp DataBaseAccess
   Private _DBAccess As New DataBaseAccess

   'Khai báo biến trạng thái kiểm tra dữ liệu đang Load
   Private _isLoading As Boolean = False

   Private Sub LoadImageOnPicturebox()
      'Khai báo biến kết nối tới CSDL
      Dim ConnectionString As String = "workstation id=QLBH03787.mssql.somee.com;packet size=4096;user id=longtnps03787_SQLLogin_5;pwd=ceubdendma;data source=QLBH03787.mssql.somee.com;persist security info=False;initial catalog=QLBH03787"
      Dim con As New SqlConnection(ConnectionString)
      Dim da = New SqlDataAdapter("Select * From HH_PICTURES Where MaHH = '" & txtMaHH.Text & "'", con)
      Dim ds As New DataTable
      Try
         con.Open()
         da.Fill(ds)
         Dim c As Integer = ds.Rows.Count
         If c > 0 Then
            Dim bytImage() As Byte =
                ds.Rows(c - 1)("ImageName")
            Dim stmImage As New MemoryStream(bytImage)
            ptbHH.SizeMode = PictureBoxSizeMode.StretchImage
            ptbHH.Image = Image.FromStream(stmImage)
         Else
            ptbHH.Image = ptbHH.ErrorImage
            ptbHH.SizeMode = PictureBoxSizeMode.StretchImage
         End If
      Catch ex As Exception
         MsgBox("Lỗi", MsgBoxStyle.Exclamation, "Thông báo")
      Finally
         con.Close()
      End Try
   End Sub
   'Định nghĩa thủ tục load dữ liệu từ bảng UNIT_TYPE vào combobox
   Private Sub LoadDataOnCombobox()
      Dim sqlQuery As String = "select DonViID, DonVi from UNIT_TYPE"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.cmbListView.DataSource = dTable
      Me.cmbListView.ValueMember = "DonViID"
      Me.cmbListView.DisplayMember = "DonVi"
   End Sub
   'Định nghĩa thủ tục load dữ liệu từ bảng HANG_HOA vào DataGridView
   Private Sub LoadAllDataOnGridView()
      Dim sqlQuery As String = "select MaHH, TenHH, DonGia, TonKho from HANG_HOA"
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvHH.DataSource = dTable
      With Me.dgvHH
         .Columns(0).HeaderText = "Mã HH"
         .Columns(1).HeaderText = "Tên HH"
         .Columns(2).HeaderText = "Đơn giá"
         .Columns(3).HeaderText = "Tồn kho"
      End With
   End Sub
   'Định nghĩa thủ tục load dữ liệu từ bảng HANG_HOA theo từng DonVi vào DataGridView
   Private Sub LoadDataOnGridView(DonViID As String)
      Dim sqlQuery As String = String.Format _
("select MaHH, TenHH, DonGia, TonKho from HANG_HOA where DonViID = '{0}'", DonViID)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvHH.DataSource = dTable
      With Me.dgvHH
         .Columns(0).HeaderText = "Mã HH"
         .Columns(1).HeaderText = "Tên HH"
         .Columns(2).HeaderText = "Đơn giá"
         .Columns(3).HeaderText = "Tồn kho"
      End With
   End Sub

   Private Sub frmHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      _isLoading = True 'True khi dữ liệu bắt đầu Load

      ptbHH.Image = ptbHH.ErrorImage
      LoadDataOnCombobox()
      LoadAllDataOnGridView()

      _isLoading = False 'False khi Load dữ liệu xong
   End Sub

   Private Sub cmbListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbListView.SelectedIndexChanged
      If Not _isLoading Then 'Nếu Load xong dữ liệu
         LoadDataOnGridView(Me.cmbListView.SelectedValue)
      End If
   End Sub
   Private Sub SearchAllHH(value As String)
      Dim sqlQuery As String = "select MaHH, TenHH, DonGia, TonKho from HANG_HOA"
      sqlQuery += String.Format(" where MaHH LIKE '%{0}%' or TenHH like N'%{0}%' or DonGia like '%{0}%'", value)
      Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
      Me.dgvHH.DataSource = dTable
      With Me.dgvHH
         .Columns(0).HeaderText = "Mã HH"
         .Columns(1).HeaderText = "Tên HH"
         .Columns(2).HeaderText = "Đơn giá"
         .Columns(3).HeaderText = "Tồn kho"
      End With
   End Sub

   Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
      SearchAllHH(Me.txtSearch.Text)
   End Sub

   Private Sub btnAddHH_Click(sender As Object, e As EventArgs) Handles btnAddHH.Click
      Dim frm As New frmAddHH(False)
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         'Load dữ liệu vào DataGridView
         LoadDataOnGridView(Me.cmbListView.SelectedValue)
      End If
   End Sub

   Private Sub btnEditHH_Click(sender As Object, e As EventArgs) Handles btnEditHH.Click
      Dim frm As New frmAddHH(True)
      frm.txtMaHH.Enabled = False 'Không cho sửa lại Mã HH
      With Me.dgvHH
         frm.txtMaHH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHH").Value
         frm.txtTenHH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenHH").Value
         frm.txtDonGia.Text = .Rows(.CurrentCell.RowIndex).Cells("DonGia").Value
         frm.txtTonKho.Text = .Rows(.CurrentCell.RowIndex).Cells("TonKho").Value
      End With
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then 'Sửa dữ liệu thành công thì Load lại vào DataGridView
         LoadDataOnGridView(Me.cmbListView.SelectedValue)
      End If
   End Sub

   Private Sub btnDeleteHH_Click(sender As Object, e As EventArgs) Handles btnDeleteHH.Click
      'Khai báo biến lấy MaHH đã được chọn trên DataGridView
      Dim MAHH As String = Me.dgvHH.Rows(Me.dgvHH.CurrentCell.RowIndex).Cells("MaHH").Value
      'Khai báo câu lệnh Query để xóa
      Dim sqlQuery As String = String.Format("delete from HANG_HOA where MaHH = '{0}'", MAHH)
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

   Private Sub dgvHH_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHH.CellClick
      If dgvHH.SelectedCells.Count > 0 Then
         '(Dữ liệu hiển thị trên các Textbox và DateTimePicker sẽ lần lượt là từng cột trong cùng một hàng DataGridView
         txtMaHH.Text = dgvHH.CurrentRow.Cells(0).Value.ToString
         LoadImageOnPicturebox()
      End If
   End Sub

   Private Sub btnEditImage_Click(sender As Object, e As EventArgs) Handles btnEditImage.Click
      Dim frm As New frmChangePicture
      With Me.dgvHH
         frm.txtMaHH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHH").Value
      End With
      frm.ShowDialog()
      If frm.DialogResult = DialogResult.OK Then
         LoadImageOnPicturebox()
      End If
   End Sub
End Class