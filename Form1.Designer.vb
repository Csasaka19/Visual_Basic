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
        Me.txtFirstName = New System.Windows.Forms.Label()
        Me.txtSecondName = New System.Windows.Forms.Label()
        Me.txtFullNames = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.cbo2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdShowNames = New System.Windows.Forms.Button()
        Me.optMale = New System.Windows.Forms.RadioButton()
        Me.optFemale = New System.Windows.Forms.RadioButton()
        Me.optOther = New System.Windows.Forms.RadioButton()
        Me.lstCourse = New System.Windows.Forms.ListBox()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.CmdRemove = New System.Windows.Forms.Button()
        Me.CmdSort = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.AutoSize = True
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(55, 34)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(129, 27)
        Me.txtFirstName.TabIndex = 0
        Me.txtFirstName.Text = "First Name"
        '
        'txtSecondName
        '
        Me.txtSecondName.AutoSize = True
        Me.txtSecondName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSecondName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondName.Location = New System.Drawing.Point(55, 92)
        Me.txtSecondName.Name = "txtSecondName"
        Me.txtSecondName.Size = New System.Drawing.Size(164, 27)
        Me.txtSecondName.TabIndex = 1
        Me.txtSecondName.Text = "Second Name"
        '
        'txtFullNames
        '
        Me.txtFullNames.AutoSize = True
        Me.txtFullNames.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtFullNames.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullNames.Location = New System.Drawing.Point(55, 155)
        Me.txtFullNames.Name = "txtFullNames"
        Me.txtFullNames.Size = New System.Drawing.Size(135, 27)
        Me.txtFullNames.TabIndex = 2
        Me.txtFullNames.Text = "Full Names"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Year of study"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(239, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 26)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(239, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 26)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Location = New System.Drawing.Point(239, 157)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(252, 26)
        Me.TextBox3.TabIndex = 7
        '
        'cbo1
        '
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Items.AddRange(New Object() {"Year 1", "Year 2", "Year 3", "Year 4"})
        Me.cbo1.Location = New System.Drawing.Point(239, 211)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(252, 28)
        Me.cbo1.TabIndex = 8
        '
        'cbo2
        '
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Items.AddRange(New Object() {"Year 1", "Year 2", "Year 3", "Year 4"})
        Me.cbo2.Location = New System.Drawing.Point(239, 269)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(252, 28)
        Me.cbo2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 27)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Gender"
        '
        'CmdShowNames
        '
        Me.CmdShowNames.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmdShowNames.Location = New System.Drawing.Point(621, 157)
        Me.CmdShowNames.Name = "CmdShowNames"
        Me.CmdShowNames.Size = New System.Drawing.Size(158, 61)
        Me.CmdShowNames.TabIndex = 14
        Me.CmdShowNames.Text = "Show Names"
        Me.CmdShowNames.UseVisualStyleBackColor = False
        '
        'optMale
        '
        Me.optMale.AutoSize = True
        Me.optMale.Location = New System.Drawing.Point(239, 363)
        Me.optMale.Name = "optMale"
        Me.optMale.Size = New System.Drawing.Size(68, 24)
        Me.optMale.TabIndex = 15
        Me.optMale.TabStop = True
        Me.optMale.Text = "Male"
        Me.optMale.UseVisualStyleBackColor = True
        '
        'optFemale
        '
        Me.optFemale.AutoSize = True
        Me.optFemale.Location = New System.Drawing.Point(364, 363)
        Me.optFemale.Name = "optFemale"
        Me.optFemale.Size = New System.Drawing.Size(87, 24)
        Me.optFemale.TabIndex = 16
        Me.optFemale.TabStop = True
        Me.optFemale.Text = "Female"
        Me.optFemale.UseVisualStyleBackColor = True
        '
        'optOther
        '
        Me.optOther.AutoSize = True
        Me.optOther.Location = New System.Drawing.Point(517, 360)
        Me.optOther.Name = "optOther"
        Me.optOther.Size = New System.Drawing.Size(74, 24)
        Me.optOther.TabIndex = 17
        Me.optOther.TabStop = True
        Me.optOther.Text = "Other"
        Me.optOther.UseVisualStyleBackColor = True
        '
        'lstCourse
        '
        Me.lstCourse.FormattingEnabled = True
        Me.lstCourse.ItemHeight = 20
        Me.lstCourse.Items.AddRange(New Object() {"lstCourse"})
        Me.lstCourse.Location = New System.Drawing.Point(239, 407)
        Me.lstCourse.Name = "lstCourse"
        Me.lstCourse.Size = New System.Drawing.Size(187, 104)
        Me.lstCourse.TabIndex = 18
        '
        'CmdAdd
        '
        Me.CmdAdd.Location = New System.Drawing.Point(468, 418)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(275, 37)
        Me.CmdAdd.TabIndex = 19
        Me.CmdAdd.Text = "Add Courses"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'CmdRemove
        '
        Me.CmdRemove.Location = New System.Drawing.Point(468, 490)
        Me.CmdRemove.Name = "CmdRemove"
        Me.CmdRemove.Size = New System.Drawing.Size(275, 40)
        Me.CmdRemove.TabIndex = 20
        Me.CmdRemove.Text = "Remove courses"
        Me.CmdRemove.UseVisualStyleBackColor = True
        '
        'CmdSort
        '
        Me.CmdSort.Location = New System.Drawing.Point(468, 555)
        Me.CmdSort.Name = "CmdSort"
        Me.CmdSort.Size = New System.Drawing.Size(275, 40)
        Me.CmdSort.TabIndex = 21
        Me.CmdSort.Text = "Sort"
        Me.CmdSort.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(468, 626)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(275, 40)
        Me.CmdClear.TabIndex = 22
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 779)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdSort)
        Me.Controls.Add(Me.CmdRemove)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.lstCourse)
        Me.Controls.Add(Me.optOther)
        Me.Controls.Add(Me.optFemale)
        Me.Controls.Add(Me.optMale)
        Me.Controls.Add(Me.CmdShowNames)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo2)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFullNames)
        Me.Controls.Add(Me.txtSecondName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As Label
    Friend WithEvents txtSecondName As Label
    Friend WithEvents txtFullNames As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents cbo1 As ComboBox
    Friend WithEvents cbo2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdShowNames As Button
    Friend WithEvents optMale As RadioButton
    Friend WithEvents optFemale As RadioButton
    Friend WithEvents optOther As RadioButton
    Friend WithEvents lstCourse As ListBox
    Friend WithEvents CmdAdd As Button
    Friend WithEvents CmdRemove As Button
    Friend WithEvents CmdSort As Button
    Friend WithEvents CmdClear As Button
End Class
