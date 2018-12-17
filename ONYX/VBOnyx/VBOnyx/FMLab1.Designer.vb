<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMLab1
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
        Me.Money = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.txtSaraly = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVat = New System.Windows.Forms.Label()
        Me.txtReColi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Money
        '
        Me.Money.AutoSize = True
        Me.Money.Location = New System.Drawing.Point(101, 61)
        Me.Money.Name = "Money"
        Me.Money.Size = New System.Drawing.Size(51, 13)
        Me.Money.TabIndex = 0
        Me.Money.Text = "เงินเดือน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รายได้ทั้งปี"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "รายได้ทั้งปีหลังหักภาษี"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "คิดเงิน"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMoney
        '
        Me.txtMoney.Location = New System.Drawing.Point(329, 58)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(100, 20)
        Me.txtMoney.TabIndex = 4
        '
        'txtSaraly
        '
        Me.txtSaraly.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtSaraly.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSaraly.Location = New System.Drawing.Point(326, 96)
        Me.txtSaraly.Name = "txtSaraly"
        Me.txtSaraly.Size = New System.Drawing.Size(103, 14)
        Me.txtSaraly.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(231, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ภาษี 5%"
        '
        'txtVat
        '
        Me.txtVat.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtVat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtVat.Location = New System.Drawing.Point(326, 133)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(103, 14)
        Me.txtVat.TabIndex = 5
        '
        'txtReColi
        '
        Me.txtReColi.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtReColi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtReColi.Location = New System.Drawing.Point(326, 170)
        Me.txtReColi.Name = "txtReColi"
        Me.txtReColi.Size = New System.Drawing.Size(103, 14)
        Me.txtReColi.TabIndex = 5
        '
        'FMLab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 322)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtReColi)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtSaraly)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Money)
        Me.Name = "FMLab1"
        Me.Text = "FMLab1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Money As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtMoney As System.Windows.Forms.TextBox
    Friend WithEvents txtSaraly As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.Label
    Friend WithEvents txtReColi As System.Windows.Forms.Label

End Class
