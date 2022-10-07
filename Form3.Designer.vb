<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.txtoutput = New System.Windows.Forms.Label()
        Me.cmdcompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(222, 188)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(337, 26)
        Me.txtinput.TabIndex = 0
        '
        'txtoutput
        '
        Me.txtoutput.AutoSize = True
        Me.txtoutput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtoutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoutput.Location = New System.Drawing.Point(260, 90)
        Me.txtoutput.Name = "txtoutput"
        Me.txtoutput.Size = New System.Drawing.Size(20, 27)
        Me.txtoutput.TabIndex = 1
        Me.txtoutput.Text = " "
        '
        'cmdcompute
        '
        Me.cmdcompute.BackColor = System.Drawing.Color.Gray
        Me.cmdcompute.Location = New System.Drawing.Point(235, 283)
        Me.cmdcompute.Name = "cmdcompute"
        Me.cmdcompute.Size = New System.Drawing.Size(184, 65)
        Me.cmdcompute.TabIndex = 2
        Me.cmdcompute.Text = "&compute"
        Me.cmdcompute.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdcompute)
        Me.Controls.Add(Me.txtoutput)
        Me.Controls.Add(Me.txtinput)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtinput As TextBox
    Friend WithEvents txtoutput As Label
    Friend WithEvents cmdcompute As Button

    Private Sub ButtonCompute_Click(sender As Object, e As EventArgs) Handles cmdcompute.Click
        txtoutput.Text = Len(txtinput.Text)
    End Sub
End Class
