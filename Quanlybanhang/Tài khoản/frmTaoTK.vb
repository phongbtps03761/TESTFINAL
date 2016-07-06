Public Class frmTaoTK
    'Load du lieu len combobox
    Private _DBAccess As New DataBaseAccess
    Private Sub LoadDataOnCombobox()
        Dim sqlQuery As String = "SELECT MA_QUYEN, TEN_QUYEN FROM QUYEN"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        cmbQuyen.DataSource = dTable
        cmbQuyen.ValueMember = "MA_QUYEN"
        cmbQuyen.DisplayMember = "TEN_QUYEN"
    End Sub

    Private Sub frmTaoTK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnCombobox()
    End Sub
    'khai bao insert thong tin tai khoan
    Private Function insertProduct() As Boolean
        Dim sqlQuery As String = "INSERT INTO TAIKHOAN(ID, PW, EMAIL, MA_QUYEN)"
        sqlQuery += String.Format("Values ('{0}','{1}','{2}','{3}')", txbTK.Text, txbMK.Text, txbEmail.Text, cmbQuyen.SelectedValue)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnTaoTK_Click(sender As Object, e As EventArgs) Handles btnTaoTK.Click

    End Sub

    Private Sub cmbQuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuyen.SelectedIndexChanged
        txbMK2.Text = cmbQuyen.ValueMember
    End Sub
End Class