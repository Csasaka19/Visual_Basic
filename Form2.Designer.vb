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
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdSort = New System.Windows.Forms.Button()
        Me.CmdRemove = New System.Windows.Forms.Button()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.lsvCourse = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(377, 315)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(275, 40)
        Me.CmdClear.TabIndex = 27
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdSort
        '
        Me.CmdSort.Location = New System.Drawing.Point(377, 244)
        Me.CmdSort.Name = "CmdSort"
        Me.CmdSort.Size = New System.Drawing.Size(275, 40)
        Me.CmdSort.TabIndex = 26
        Me.CmdSort.Text = "Sort"
        Me.CmdSort.UseVisualStyleBackColor = True
        '
        'CmdRemove
        '
        Me.CmdRemove.Location = New System.Drawing.Point(377, 179)
        Me.CmdRemove.Name = "CmdRemove"
        Me.CmdRemove.Size = New System.Drawing.Size(275, 40)
        Me.CmdRemove.TabIndex = 25
        Me.CmdRemove.Text = "Remove"
        Me.CmdRemove.UseVisualStyleBackColor = True
        '
        'CmdAdd
        '
        Me.CmdAdd.Location = New System.Drawing.Point(377, 107)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(275, 37)
        Me.CmdAdd.TabIndex = 24
        Me.CmdAdd.Text = "Add"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'lsvCourse
        '
        Me.lsvCourse.HideSelection = False
        Me.lsvCourse.Location = New System.Drawing.Point(29, 67)
        Me.lsvCourse.Name = "lsvCourse"
        Me.lsvCourse.Size = New System.Drawing.Size(324, 316)
        Me.lsvCourse.TabIndex = 28
        Me.lsvCourse.UseCompatibleStateImageBehavior = False
        Me.lsvCourse.View = System.Windows.Forms.View.List
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lsvCourse)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdSort)
        Me.Controls.Add(Me.CmdRemove)
        Me.Controls.Add(Me.CmdAdd)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdClear As Button
    Friend WithEvents CmdSort As Button
    Friend WithEvents CmdRemove As Button
    Friend WithEvents CmdAdd As Button
    Friend WithEvents lsvCourse As ListView
End Class
