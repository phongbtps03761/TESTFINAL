<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaoTK
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbTK = New System.Windows.Forms.TextBox()
        Me.txbMK = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.cmbQuyen = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbMK2 = New System.Windows.Forms.TextBox()
        Me.btnTaoTK = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên tài khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mật khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Chức vụ"
        '
        'txbTK
        '
        Me.txbTK.Location = New System.Drawing.Point(130, 8)
        Me.txbTK.Name = "txbTK"
        Me.txbTK.Size = New System.Drawing.Size(149, 20)
        Me.txbTK.TabIndex = 1
        Me.txbTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbMK
        '
        Me.txbMK.Location = New System.Drawing.Point(130, 39)
        Me.txbMK.Name = "txbMK"
        Me.txbMK.Size = New System.Drawing.Size(149, 20)
        Me.txbMK.TabIndex = 2
        Me.txbMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(130, 111)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(149, 20)
        Me.txbEmail.TabIndex = 4
        Me.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbQuyen
        '
        Me.cmbQuyen.FormattingEnabled = True
        Me.cmbQuyen.ItemHeight = 13
        Me.cmbQuyen.Location = New System.Drawing.Point(130, 145)
        Me.cmbQuyen.Name = "cmbQuyen"
        Me.cmbQuyen.Size = New System.Drawing.Size(149, 21)
        Me.cmbQuyen.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Xác nhận mật khẩu"
        '
        'txbMK2
        '
        Me.txbMK2.Location = New System.Drawing.Point(130, 74)
        Me.txbMK2.Name = "txbMK2"
        Me.txbMK2.Size = New System.Drawing.Size(149, 20)
        Me.txbMK2.TabIndex = 3
        Me.txbMK2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnTaoTK
        '
        Me.btnTaoTK.Location = New System.Drawing.Point(130, 193)
        Me.btnTaoTK.Name = "btnTaoTK"
        Me.btnTaoTK.Size = New System.Drawing.Size(68, 23)
        Me.btnTaoTK.TabIndex = 6
        Me.btnTaoTK.Text = "Đăng ký"
        Me.btnTaoTK.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(211, 193)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(68, 23)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmTaoTK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 279)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTaoTK)
        Me.Controls.Add(Me.cmbQuyen)
        Me.Controls.Add(Me.txbEmail)
        Me.Controls.Add(Me.txbMK2)
        Me.Controls.Add(Me.txbMK)
        Me.Controls.Add(Me.txbTK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTaoTK"
        Me.Text = "Tạo tài khoản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbTK As TextBox
    Friend WithEvents txbMK As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents cmbQuyen As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbMK2 As TextBox
    Friend WithEvents btnTaoTK As Button
    Friend WithEvents btnThoat As Button
End Class
