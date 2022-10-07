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
        Me.cmdcompute = New System.Windows.Forms.Button()
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.txtoutput = New System.Windows.Forms.Label()
        Me.cmdright = New System.Windows.Forms.Button()
        Me.txtcharacters = New System.Windows.Forms.TextBox()
        Me.cmdleft = New System.Windows.Forms.Button()
        Me.cmdmid = New System.Windows.Forms.Button()
        Me.txtstart = New System.Windows.Forms.TextBox()
        Me.cmdupper = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdcompute
        '
        Me.cmdcompute.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cmdcompute.Location = New System.Drawing.Point(287, 255)
        Me.cmdcompute.Name = "cmdcompute"
        Me.cmdcompute.Size = New System.Drawing.Size(187, 38)
        Me.cmdcompute.TabIndex = 0
        Me.cmdcompute.Text = "&compute"
        Me.cmdcompute.UseVisualStyleBackColor = False
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(287, 81)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(187, 26)
        Me.txtinput.TabIndex = 1
        Me.txtinput.Text = "&input"
        '
        'txtoutput
        '
        Me.txtoutput.AutoSize = True
        Me.txtoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtoutput.Location = New System.Drawing.Point(346, 166)
        Me.txtoutput.Name = "txtoutput"
        Me.txtoutput.Size = New System.Drawing.Size(2, 22)
        Me.txtoutput.TabIndex = 2
        '
        'cmdright
        '
        Me.cmdright.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmdright.Location = New System.Drawing.Point(287, 315)
        Me.cmdright.Name = "cmdright"
        Me.cmdright.Size = New System.Drawing.Size(187, 45)
        Me.cmdright.TabIndex = 3
        Me.cmdright.Text = "&right"
        Me.cmdright.UseVisualStyleBackColor = False
        '
        'txtcharacters
        '
        Me.txtcharacters.BackColor = System.Drawing.SystemColors.Info
        Me.txtcharacters.Location = New System.Drawing.Point(25, 166)
        Me.txtcharacters.Name = "txtcharacters"
        Me.txtcharacters.Size = New System.Drawing.Size(187, 26)
        Me.txtcharacters.TabIndex = 4
        Me.txtcharacters.Text = "&characters"
        '
        'cmdleft
        '
        Me.cmdleft.Location = New System.Drawing.Point(287, 390)
        Me.cmdleft.Name = "cmdleft"
        Me.cmdleft.Size = New System.Drawing.Size(187, 33)
        Me.cmdleft.TabIndex = 5
        Me.cmdleft.Text = "&left"
        Me.cmdleft.UseVisualStyleBackColor = True
        '
        'cmdmid
        '
        Me.cmdmid.Location = New System.Drawing.Point(287, 464)
        Me.cmdmid.Name = "cmdmid"
        Me.cmdmid.Size = New System.Drawing.Size(187, 37)
        Me.cmdmid.TabIndex = 6
        Me.cmdmid.Text = "&mid"
        Me.cmdmid.UseVisualStyleBackColor = True
        '
        'txtstart
        '
        Me.txtstart.Location = New System.Drawing.Point(553, 166)
        Me.txtstart.Name = "txtstart"
        Me.txtstart.Size = New System.Drawing.Size(187, 26)
        Me.txtstart.TabIndex = 7
        Me.txtstart.Text = "&start"
        '
        'cmdupper
        '
        Me.cmdupper.Location = New System.Drawing.Point(603, 315)
        Me.cmdupper.Name = "cmdupper"
        Me.cmdupper.Size = New System.Drawing.Size(100, 35)
        Me.cmdupper.TabIndex = 8
        Me.cmdupper.Text = "&upper"
        Me.cmdupper.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1026, 658)
        Me.Controls.Add(Me.cmdupper)
        Me.Controls.Add(Me.txtstart)
        Me.Controls.Add(Me.cmdmid)
        Me.Controls.Add(Me.cmdleft)
        Me.Controls.Add(Me.txtcharacters)
        Me.Controls.Add(Me.cmdright)
        Me.Controls.Add(Me.txtoutput)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.cmdcompute)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdcompute As Button
    Friend WithEvents txtinput As TextBox
    Friend WithEvents txtoutput As Label
    Friend WithEvents cmdright As Button
    Friend WithEvents txtcharacters As TextBox
    Friend WithEvents cmdleft As Button
    Friend WithEvents cmdmid As Button
    Friend WithEvents txtstart As TextBox
    Friend WithEvents cmdupper As Button
End Class
