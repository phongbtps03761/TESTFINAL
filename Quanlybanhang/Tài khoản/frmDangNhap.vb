Public Class frmDangNhap
    Private _DBAccess As New DataBaseAccess
    'dinh nghia ham kiem tra ID,PW
    Private Function CheckLogin(ID As String, PW As String)
        Dim sqlQuery As String = String.Format("select ID,PW,EMAIL,MA_QUYEN from TAIKHOAN where ID = '{0}' and  PW ='{1}'", ID, PW)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Return dTable.Rows.Count > 0
    End Function

    'Dinh nghia ham kiem tra rong
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txbTK.Text) OrElse String.IsNullOrEmpty(txbMK.Text)

    End Function

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'Kiem tra ID và PW
        If IsEmpty() Then
            MessageBox.Show("Tài khoản và mật khẩu không được để trống")
        Else
            If CheckLogin(txbTK.Text.ToLower, txbMK.Text.ToLower) Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Đăng nhập thành công!")
                frmMain.ShowDialog()
            Else 'sai ID hoặc PW
                MessageBox.Show("Sai thông tin tài khoản")
            End If
        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub lilTaoTK_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilTaoTK.LinkClicked
        frmTaoTK.ShowDialog()
    End Sub
End Class