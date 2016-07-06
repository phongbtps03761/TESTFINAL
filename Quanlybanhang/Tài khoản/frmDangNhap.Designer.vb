<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbTK = New System.Windows.Forms.TextBox()
        Me.txbMK = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.lilTaoTK = New System.Windows.Forms.LinkLabel()
        Me.lilQuenMK = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài khoản:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mật khẩu:"
        '
        'txbTK
        '
        Me.txbTK.Location = New System.Drawing.Point(159, 26)
        Me.txbTK.Name = "txbTK"
        Me.txbTK.Size = New System.Drawing.Size(154, 20)
        Me.txbTK.TabIndex = 1
        Me.txbTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbMK
        '
        Me.txbMK.Location = New System.Drawing.Point(159, 58)
        Me.txbMK.Name = "txbMK"
        Me.txbMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txbMK.Size = New System.Drawing.Size(154, 20)
        Me.txbMK.TabIndex = 2
        Me.txbMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(159, 101)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnDangNhap.TabIndex = 3
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'lilTaoTK
        '
        Me.lilTaoTK.AutoSize = True
        Me.lilTaoTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lilTaoTK.Location = New System.Drawing.Point(156, 139)
        Me.lilTaoTK.Name = "lilTaoTK"
        Me.lilTaoTK.Size = New System.Drawing.Size(79, 13)
        Me.lilTaoTK.TabIndex = 5
        Me.lilTaoTK.TabStop = True
        Me.lilTaoTK.Text = "•Tạo tài khoản"
        '
        'lilQuenMK
        '
        Me.lilQuenMK.AutoSize = True
        Me.lilQuenMK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lilQuenMK.Location = New System.Drawing.Point(156, 166)
        Me.lilQuenMK.Name = "lilQuenMK"
        Me.lilQuenMK.Size = New System.Drawing.Size(101, 13)
        Me.lilQuenMK.TabIndex = 6
        Me.lilQuenMK.TabStop = True
        Me.lilQuenMK.Text = "• Quên mật khẩu ?!"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(156, 166)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel2.TabIndex = 3
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(238, 101)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 204)
        Me.Controls.Add(Me.lilQuenMK)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.lilTaoTK)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txbMK)
        Me.Controls.Add(Me.txbTK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDangNhap"
        Me.Text = "frmDangNhap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbTK As TextBox
    Friend WithEvents txbMK As TextBox
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents lilTaoTK As LinkLabel
    Friend WithEvents lilQuenMK As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents btnThoat As Button
End Class
