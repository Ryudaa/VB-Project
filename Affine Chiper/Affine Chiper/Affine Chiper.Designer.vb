<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnencrypt = New System.Windows.Forms.Button()
        Me.btndecrypt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmba = New System.Windows.Forms.ComboBox()
        Me.cmbb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblformula = New System.Windows.Forms.Label()
        Me.lblbefore = New System.Windows.Forms.Label()
        Me.txtbefore = New System.Windows.Forms.TextBox()
        Me.lblspecial = New System.Windows.Forms.Label()
        Me.txtspecial = New System.Windows.Forms.TextBox()
        Me.txtafter = New System.Windows.Forms.TextBox()
        Me.lblafter = New System.Windows.Forms.Label()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtainvers = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnencrypt
        '
        Me.btnencrypt.Location = New System.Drawing.Point(14, 12)
        Me.btnencrypt.Name = "btnencrypt"
        Me.btnencrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnencrypt.TabIndex = 0
        Me.btnencrypt.Text = "Encrypt"
        Me.btnencrypt.UseVisualStyleBackColor = True
        '
        'btndecrypt
        '
        Me.btndecrypt.Location = New System.Drawing.Point(95, 12)
        Me.btndecrypt.Name = "btndecrypt"
        Me.btndecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btndecrypt.TabIndex = 1
        Me.btndecrypt.Text = "Decrypt"
        Me.btndecrypt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "a="
        '
        'cmba
        '
        Me.cmba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmba.Enabled = False
        Me.cmba.FormattingEnabled = True
        Me.cmba.Items.AddRange(New Object() {"1", "3", "5", "7", "9", "11", "15", "17", "19", "21", "23", "25"})
        Me.cmba.Location = New System.Drawing.Point(224, 14)
        Me.cmba.Name = "cmba"
        Me.cmba.Size = New System.Drawing.Size(41, 21)
        Me.cmba.TabIndex = 3
        '
        'cmbb
        '
        Me.cmbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbb.Enabled = False
        Me.cmbb.FormattingEnabled = True
        Me.cmbb.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cmbb.Location = New System.Drawing.Point(295, 14)
        Me.cmbb.Name = "cmbb"
        Me.cmbb.Size = New System.Drawing.Size(41, 21)
        Me.cmbb.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "b="
        '
        'lblformula
        '
        Me.lblformula.AutoSize = True
        Me.lblformula.Location = New System.Drawing.Point(433, 17)
        Me.lblformula.Name = "lblformula"
        Me.lblformula.Size = New System.Drawing.Size(44, 13)
        Me.lblformula.TabIndex = 6
        Me.lblformula.Text = "Formula"
        '
        'lblbefore
        '
        Me.lblbefore.AutoSize = True
        Me.lblbefore.Location = New System.Drawing.Point(14, 51)
        Me.lblbefore.Name = "lblbefore"
        Me.lblbefore.Size = New System.Drawing.Size(38, 13)
        Me.lblbefore.TabIndex = 7
        Me.lblbefore.Text = "Before"
        '
        'txtbefore
        '
        Me.txtbefore.Enabled = False
        Me.txtbefore.Location = New System.Drawing.Point(17, 68)
        Me.txtbefore.Multiline = True
        Me.txtbefore.Name = "txtbefore"
        Me.txtbefore.Size = New System.Drawing.Size(709, 144)
        Me.txtbefore.TabIndex = 8
        '
        'lblspecial
        '
        Me.lblspecial.AutoSize = True
        Me.lblspecial.Location = New System.Drawing.Point(17, 231)
        Me.lblspecial.Name = "lblspecial"
        Me.lblspecial.Size = New System.Drawing.Size(102, 13)
        Me.lblspecial.TabIndex = 9
        Me.lblspecial.Text = "Special combination"
        '
        'txtspecial
        '
        Me.txtspecial.Enabled = False
        Me.txtspecial.Location = New System.Drawing.Point(125, 228)
        Me.txtspecial.Name = "txtspecial"
        Me.txtspecial.Size = New System.Drawing.Size(169, 20)
        Me.txtspecial.TabIndex = 11
        '
        'txtafter
        '
        Me.txtafter.Location = New System.Drawing.Point(20, 276)
        Me.txtafter.Multiline = True
        Me.txtafter.Name = "txtafter"
        Me.txtafter.ReadOnly = True
        Me.txtafter.Size = New System.Drawing.Size(709, 144)
        Me.txtafter.TabIndex = 13
        '
        'lblafter
        '
        Me.lblafter.AutoSize = True
        Me.lblafter.Location = New System.Drawing.Point(17, 259)
        Me.lblafter.Name = "lblafter"
        Me.lblafter.Size = New System.Drawing.Size(29, 13)
        Me.lblafter.TabIndex = 12
        Me.lblafter.Text = "After"
        '
        'btnnext
        '
        Me.btnnext.Enabled = False
        Me.btnnext.Location = New System.Drawing.Point(654, 426)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 14
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "a^-1="
        '
        'txtainvers
        '
        Me.txtainvers.Enabled = False
        Me.txtainvers.Location = New System.Drawing.Point(384, 14)
        Me.txtainvers.Name = "txtainvers"
        Me.txtainvers.Size = New System.Drawing.Size(28, 20)
        Me.txtainvers.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 461)
        Me.Controls.Add(Me.txtainvers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.txtafter)
        Me.Controls.Add(Me.lblafter)
        Me.Controls.Add(Me.txtspecial)
        Me.Controls.Add(Me.lblspecial)
        Me.Controls.Add(Me.txtbefore)
        Me.Controls.Add(Me.lblbefore)
        Me.Controls.Add(Me.lblformula)
        Me.Controls.Add(Me.cmbb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmba)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndecrypt)
        Me.Controls.Add(Me.btnencrypt)
        Me.Name = "Form1"
        Me.Text = "Affine Chiper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnencrypt As Button
    Friend WithEvents btndecrypt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmba As ComboBox
    Friend WithEvents cmbb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblformula As Label
    Friend WithEvents lblbefore As Label
    Friend WithEvents txtbefore As TextBox
    Friend WithEvents lblspecial As Label
    Friend WithEvents txtspecial As TextBox
    Friend WithEvents txtafter As TextBox
    Friend WithEvents lblafter As Label
    Friend WithEvents btnnext As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtainvers As TextBox
End Class
