Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Configuration
Public Class frmChangePicture
   'Khai báo biến để truy xuất Database từ lớp DataBaseAccess
   Private _DBAccess As New DataBaseAccess
   'Khai báo biến kết nối tới CSDL
   Private ConnectionString As String = "workstation id=QLBH03787.mssql.somee.com;packet size=4096;user id=longtnps03787_SQLLogin_5;pwd=ceubdendma;data source=QLBH03787.mssql.somee.com;persist security info=False;initial catalog=QLBH03787"
   'Khai báo biến nhận đường dẫn của Image
   Private Path As String
   Dim con As New SqlConnection(ConnectionString)
   Dim com As SqlCommand

   Private Sub frmChangePicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Path = ""
      Dim da = New SqlDataAdapter("Select * From HH_PICTURES Where MaHH = '" & txtMaHH.Text & "'", con)
      Dim dt As New DataTable
      Try
         con.Open()
         da.Fill(dt)
         Dim c As Integer = dt.Rows.Count
         If c > 0 Then
            btnAdd.Enabled = False
            btnEdit.Enabled = True
            btnDelete.Enabled = True

            Dim bytImage() As Byte =
                dt.Rows(c - 1)("ImageName")

            Dim stmImage As New MemoryStream(bytImage)
            ptbHH.Image = Image.FromStream(stmImage)
            ptbHH.SizeMode = PictureBoxSizeMode.StretchImage
         Else
            ptbHH.Image = ptbHH.ErrorImage
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnAdd.Enabled = True
         End If
      Catch ex As Exception
         MsgBox("Lỗi", MsgBoxStyle.Exclamation, "Thông báo")
      Finally
         con.Close()
      End Try
   End Sub

   Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

      ImageDialogue.Title = "Select your Image."
      ImageDialogue.InitialDirectory = "C:\Users\Administrator\Downloads"
      ImageDialogue.Filter = "Image Files(*.jpeg;*.png;*.jpg|*.jpeg;*.png;*.jpg"
      ImageDialogue.RestoreDirectory = False

      If ImageDialogue.ShowDialog() = DialogResult.OK Then
         ptbHH.Image = Image.FromFile(ImageDialogue.FileName)
         Dim ID = ImageDialogue.FileName
         Path = ID
      End If
   End Sub

   Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
      Dim com As New SqlCommand("Insert Into HH_PICTURES Values(@MaHH, @Image)", con)
      Dim Path2 As String = Path
      If String.IsNullOrEmpty(Path2) Then
         MsgBox("Không được để trống ảnh", MsgBoxStyle.Exclamation, "Thông báo")
      Else
         btnEdit.Enabled = True
         btnDelete.Enabled = True
         Dim fs As New FileStream(Path2, FileMode.Open, FileAccess.Read)
         Dim bytImage(fs.Length() - 1) As Byte
         fs.Read(bytImage, 0, bytImage.Length)
         fs.Close()
         Dim prm As New SqlParameter("@Image", SqlDbType.VarBinary,
             bytImage.Length, ParameterDirection.Input, False,
             0, 0, Nothing, DataRowVersion.Current, bytImage)
         com.Parameters.AddWithValue("@MaHH", txtMaHH.Text)
         com.Parameters.Add(prm)
         Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Thêm dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
            DialogResult = DialogResult.OK
         Catch ex As Exception
            MsgBox("Lỗi thêm dữ liệu", MsgBoxStyle.Exclamation, "Thông báo")
         Finally
            con.Close()
         End Try
      End If
   End Sub

   Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
      Dim com As New SqlCommand("Update HH_PICTURES Set ImageName = @Image Where MaHH = @MaHH", con)
      Dim Path2 As String = Path
      If String.IsNullOrEmpty(Path2) Then
         MsgBox("Không được để trống ảnh", MsgBoxStyle.Exclamation, "Thông báo")
      Else
         Dim fs As New FileStream(Path2, FileMode.Open, FileAccess.Read)
         Dim bytImage(fs.Length() - 1) As Byte
         fs.Read(bytImage, 0, bytImage.Length)
         fs.Close()
         Dim prm As New SqlParameter("@Image", SqlDbType.VarBinary,
             bytImage.Length, ParameterDirection.Input, False,
             0, 0, Nothing, DataRowVersion.Current, bytImage)
         com.Parameters.AddWithValue("@MaHH", txtMaHH.Text)
         com.Parameters.Add(prm)
         Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Sửa dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
            DialogResult = DialogResult.OK
         Catch ex As Exception
            MsgBox("Lỗi sửa dữ liệu", MsgBoxStyle.Exclamation, "Thông báo")
         Finally
            con.Close()
         End Try
      End If
   End Sub

   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim com As New SqlCommand("Delete From HH_PICTURES Where MaHH = @MaHH", con)
      com.Parameters.AddWithValue("@MaHH", txtMaHH.Text)
      Try
         con.Open()
         com.ExecuteNonQuery()
         MsgBox("Xóa dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
         DialogResult = DialogResult.OK
      Catch ex As Exception
         MsgBox("Lỗi xóa dữ liệu", MsgBoxStyle.Exclamation, "Thông báo")
      Finally
         con.Close()
      End Try
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Me.Close()
   End Sub
End Class