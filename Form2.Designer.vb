<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox2ProductDetails = New System.Windows.Forms.GroupBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.GroupBox1ProductDetails = New System.Windows.Forms.GroupBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.LabelUnitPrice = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelProductID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2ProductDetails.SuspendLayout()
        Me.GroupBox1ProductDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2ProductDetails
        '
        Me.GroupBox2ProductDetails.Controls.Add(Me.txtDetails)
        Me.GroupBox2ProductDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2ProductDetails.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2ProductDetails.Location = New System.Drawing.Point(52, 22)
        Me.GroupBox2ProductDetails.Name = "GroupBox2ProductDetails"
        Me.GroupBox2ProductDetails.Size = New System.Drawing.Size(743, 187)
        Me.GroupBox2ProductDetails.TabIndex = 2
        Me.GroupBox2ProductDetails.TabStop = False
        Me.GroupBox2ProductDetails.Text = "Product Details"
        '
        'txtDetails
        '
        Me.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetails.Location = New System.Drawing.Point(29, 38)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(691, 122)
        Me.txtDetails.TabIndex = 0
        '
        'GroupBox1ProductDetails
        '
        Me.GroupBox1ProductDetails.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox1ProductDetails.Controls.Add(Me.txtDescription)
        Me.GroupBox1ProductDetails.Controls.Add(Me.txtProductID)
        Me.GroupBox1ProductDetails.Controls.Add(Me.txtName)
        Me.GroupBox1ProductDetails.Controls.Add(Me.LabelUnitPrice)
        Me.GroupBox1ProductDetails.Controls.Add(Me.LabelDescription)
        Me.GroupBox1ProductDetails.Controls.Add(Me.LabelName)
        Me.GroupBox1ProductDetails.Controls.Add(Me.LabelProductID)
        Me.GroupBox1ProductDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1ProductDetails.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1ProductDetails.Location = New System.Drawing.Point(85, 241)
        Me.GroupBox1ProductDetails.Name = "GroupBox1ProductDetails"
        Me.GroupBox1ProductDetails.Size = New System.Drawing.Size(684, 337)
        Me.GroupBox1ProductDetails.TabIndex = 3
        Me.GroupBox1ProductDetails.TabStop = False
        Me.GroupBox1ProductDetails.Text = "Product Details"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnitPrice.Location = New System.Drawing.Point(217, 244)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(394, 39)
        Me.txtUnitPrice.TabIndex = 6
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(217, 179)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(394, 39)
        Me.txtDescription.TabIndex = 5
        '
        'txtProductID
        '
        Me.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductID.Location = New System.Drawing.Point(217, 38)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(394, 39)
        Me.txtProductID.TabIndex = 1
        Me.txtProductID.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(217, 113)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(394, 39)
        Me.txtName.TabIndex = 4
        '
        'LabelUnitPrice
        '
        Me.LabelUnitPrice.AutoSize = True
        Me.LabelUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitPrice.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelUnitPrice.Location = New System.Drawing.Point(23, 251)
        Me.LabelUnitPrice.Name = "LabelUnitPrice"
        Me.LabelUnitPrice.Size = New System.Drawing.Size(157, 32)
        Me.LabelUnitPrice.TabIndex = 3
        Me.LabelUnitPrice.Text = "Unit Price:"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelDescription.Location = New System.Drawing.Point(11, 186)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(178, 32)
        Me.LabelDescription.TabIndex = 2
        Me.LabelDescription.Text = "Description:"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelName.Location = New System.Drawing.Point(45, 120)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(103, 32)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = "Name:"
        '
        'LabelProductID
        '
        Me.LabelProductID.AutoSize = True
        Me.LabelProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductID.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelProductID.Location = New System.Drawing.Point(23, 47)
        Me.LabelProductID.Name = "LabelProductID"
        Me.LabelProductID.Size = New System.Drawing.Size(166, 32)
        Me.LabelProductID.TabIndex = 0
        Me.LabelProductID.Text = "Product ID:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(302, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 85)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Separate Text"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 734)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1ProductDetails)
        Me.Controls.Add(Me.GroupBox2ProductDetails)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox2ProductDetails.ResumeLayout(False)
        Me.GroupBox2ProductDetails.PerformLayout()
        Me.GroupBox1ProductDetails.ResumeLayout(False)
        Me.GroupBox1ProductDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2ProductDetails As GroupBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents GroupBox1ProductDetails As GroupBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents LabelUnitPrice As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelProductID As Label
    Friend WithEvents Button1 As Button

    Private Sub txtDetails_TextChanged(sender As Object, e As EventArgs) Handles txtDetails.TextChanged
        txtDetails.CharacterCasing = CharacterCasing.Lower
    End Sub

    Private Sub txtProductID_TextChanged(sender As Object, e As EventArgs) Handles txtProductID.TextChanged
        With txtProductID
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        With txtName
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        With txtDescription
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        With txtUnitPrice
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub
End Class
