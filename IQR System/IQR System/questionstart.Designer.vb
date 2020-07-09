<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class questionstart
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
        Me.components = New System.ComponentModel.Container()
        Dim Question_ref_numLabel As System.Windows.Forms.Label
        Dim Question_nameLabel As System.Windows.Forms.Label
        Dim Question_typeLabel As System.Windows.Forms.Label
        Dim Subject_codeLabel As System.Windows.Forms.Label
        Dim Faculty_refLabel As System.Windows.Forms.Label
        Dim Lecturer_IDLabel As System.Windows.Forms.Label
        Dim SubQuestion_noLabel As System.Windows.Forms.Label
        Dim SubQuestion_answLabel As System.Windows.Forms.Label
        Me.Question_ref_numTextBox = New System.Windows.Forms.TextBox()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IQR_DataSet = New IQR_System.IQR_DataSet()
        Me.Question_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Question_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Question_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Faculty_refTextBox = New System.Windows.Forms.TextBox()
        Me.Lecturer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_nameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SubQuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubQuestion_noTextBox = New System.Windows.Forms.TextBox()
        Me.QuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.QuestionTableAdapter()
        Me.TableAdapterManager = New IQR_System.IQR_DataSetTableAdapters.TableAdapterManager()
        Me.StudentTableAdapter = New IQR_System.IQR_DataSetTableAdapters.StudentTableAdapter()
        Me.SubQuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.SubQuestionTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Question_ref_numLabel = New System.Windows.Forms.Label()
        Question_nameLabel = New System.Windows.Forms.Label()
        Question_typeLabel = New System.Windows.Forms.Label()
        Subject_codeLabel = New System.Windows.Forms.Label()
        Faculty_refLabel = New System.Windows.Forms.Label()
        Lecturer_IDLabel = New System.Windows.Forms.Label()
        SubQuestion_noLabel = New System.Windows.Forms.Label()
        SubQuestion_answLabel = New System.Windows.Forms.Label()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SubQuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Question_ref_numLabel
        '
        Question_ref_numLabel.AutoSize = True
        Question_ref_numLabel.Location = New System.Drawing.Point(448, 31)
        Question_ref_numLabel.Name = "Question_ref_numLabel"
        Question_ref_numLabel.Size = New System.Drawing.Size(90, 13)
        Question_ref_numLabel.TabIndex = 1
        Question_ref_numLabel.Text = "Question ref num:"
        '
        'Question_nameLabel
        '
        Question_nameLabel.AutoSize = True
        Question_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Question_nameLabel.Location = New System.Drawing.Point(12, 61)
        Question_nameLabel.Name = "Question_nameLabel"
        Question_nameLabel.Size = New System.Drawing.Size(121, 20)
        Question_nameLabel.TabIndex = 3
        Question_nameLabel.Text = "Question name:"
        '
        'Question_typeLabel
        '
        Question_typeLabel.AutoSize = True
        Question_typeLabel.Location = New System.Drawing.Point(448, 56)
        Question_typeLabel.Name = "Question_typeLabel"
        Question_typeLabel.Size = New System.Drawing.Size(75, 13)
        Question_typeLabel.TabIndex = 7
        Question_typeLabel.Text = "Question type:"
        '
        'Subject_codeLabel
        '
        Subject_codeLabel.AutoSize = True
        Subject_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject_codeLabel.Location = New System.Drawing.Point(12, 81)
        Subject_codeLabel.Name = "Subject_codeLabel"
        Subject_codeLabel.Size = New System.Drawing.Size(106, 20)
        Subject_codeLabel.TabIndex = 13
        Subject_codeLabel.Text = "Subject code:"
        '
        'Faculty_refLabel
        '
        Faculty_refLabel.AutoSize = True
        Faculty_refLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Faculty_refLabel.Location = New System.Drawing.Point(12, 100)
        Faculty_refLabel.Name = "Faculty_refLabel"
        Faculty_refLabel.Size = New System.Drawing.Size(87, 20)
        Faculty_refLabel.TabIndex = 15
        Faculty_refLabel.Text = "Faculty ref:"
        '
        'Lecturer_IDLabel
        '
        Lecturer_IDLabel.AutoSize = True
        Lecturer_IDLabel.Location = New System.Drawing.Point(395, 107)
        Lecturer_IDLabel.Name = "Lecturer_IDLabel"
        Lecturer_IDLabel.Size = New System.Drawing.Size(63, 13)
        Lecturer_IDLabel.TabIndex = 17
        Lecturer_IDLabel.Text = "Lecturer ID:"
        '
        'SubQuestion_noLabel
        '
        SubQuestion_noLabel.AutoSize = True
        SubQuestion_noLabel.Location = New System.Drawing.Point(18, 16)
        SubQuestion_noLabel.Name = "SubQuestion_noLabel"
        SubQuestion_noLabel.Size = New System.Drawing.Size(67, 13)
        SubQuestion_noLabel.TabIndex = 0
        SubQuestion_noLabel.Text = "Question no:"
        AddHandler SubQuestion_noLabel.Click, AddressOf Me.SubQuestion_noLabel_Click
        '
        'SubQuestion_answLabel
        '
        SubQuestion_answLabel.AutoSize = True
        SubQuestion_answLabel.Location = New System.Drawing.Point(18, 247)
        SubQuestion_answLabel.Name = "SubQuestion_answLabel"
        SubQuestion_answLabel.Size = New System.Drawing.Size(68, 13)
        SubQuestion_answLabel.TabIndex = 4
        SubQuestion_answLabel.Text = "Answer Here"
        '
        'Question_ref_numTextBox
        '
        Me.Question_ref_numTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question_ref_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Question_ref_num", True))
        Me.Question_ref_numTextBox.Location = New System.Drawing.Point(544, 28)
        Me.Question_ref_numTextBox.Name = "Question_ref_numTextBox"
        Me.Question_ref_numTextBox.ReadOnly = True
        Me.Question_ref_numTextBox.Size = New System.Drawing.Size(28, 13)
        Me.Question_ref_numTextBox.TabIndex = 2
        '
        'QuestionBindingSource
        '
        Me.QuestionBindingSource.DataMember = "Question"
        Me.QuestionBindingSource.DataSource = Me.IQR_DataSet
        '
        'IQR_DataSet
        '
        Me.IQR_DataSet.DataSetName = "IQR_DataSet"
        Me.IQR_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Question_nameTextBox
        '
        Me.Question_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Question_name", True))
        Me.Question_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_nameTextBox.Location = New System.Drawing.Point(139, 61)
        Me.Question_nameTextBox.Name = "Question_nameTextBox"
        Me.Question_nameTextBox.ReadOnly = True
        Me.Question_nameTextBox.Size = New System.Drawing.Size(200, 19)
        Me.Question_nameTextBox.TabIndex = 4
        '
        'Question_DateDateTimePicker
        '
        Me.Question_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QuestionBindingSource, "Question_Date", True))
        Me.Question_DateDateTimePicker.Location = New System.Drawing.Point(372, 78)
        Me.Question_DateDateTimePicker.Name = "Question_DateDateTimePicker"
        Me.Question_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Question_DateDateTimePicker.TabIndex = 6
        '
        'Question_typeTextBox
        '
        Me.Question_typeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Question_type", True))
        Me.Question_typeTextBox.Location = New System.Drawing.Point(528, 56)
        Me.Question_typeTextBox.Name = "Question_typeTextBox"
        Me.Question_typeTextBox.ReadOnly = True
        Me.Question_typeTextBox.Size = New System.Drawing.Size(72, 13)
        Me.Question_typeTextBox.TabIndex = 8
        '
        'Subject_codeTextBox
        '
        Me.Subject_codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Subject_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Subject_code", True))
        Me.Subject_codeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject_codeTextBox.Location = New System.Drawing.Point(115, 81)
        Me.Subject_codeTextBox.Name = "Subject_codeTextBox"
        Me.Subject_codeTextBox.ReadOnly = True
        Me.Subject_codeTextBox.Size = New System.Drawing.Size(200, 19)
        Me.Subject_codeTextBox.TabIndex = 14
        '
        'Faculty_refTextBox
        '
        Me.Faculty_refTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Faculty_refTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Faculty_ref", True))
        Me.Faculty_refTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Faculty_refTextBox.Location = New System.Drawing.Point(103, 100)
        Me.Faculty_refTextBox.Name = "Faculty_refTextBox"
        Me.Faculty_refTextBox.ReadOnly = True
        Me.Faculty_refTextBox.Size = New System.Drawing.Size(72, 19)
        Me.Faculty_refTextBox.TabIndex = 16
        '
        'Lecturer_IDTextBox
        '
        Me.Lecturer_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lecturer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Lecturer_ID", True))
        Me.Lecturer_IDTextBox.Location = New System.Drawing.Point(464, 106)
        Me.Lecturer_IDTextBox.Name = "Lecturer_IDTextBox"
        Me.Lecturer_IDTextBox.ReadOnly = True
        Me.Lecturer_IDTextBox.Size = New System.Drawing.Size(102, 13)
        Me.Lecturer_IDTextBox.TabIndex = 18
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Student_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Student_ID", True))
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(12, 37)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(191, 19)
        Me.Student_IDTextBox.TabIndex = 19
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.IQR_DataSet
        '
        'Student_nameTextBox
        '
        Me.Student_nameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Student_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Student_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Student_name", True))
        Me.Student_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_nameTextBox.Location = New System.Drawing.Point(15, 10)
        Me.Student_nameTextBox.Name = "Student_nameTextBox"
        Me.Student_nameTextBox.Size = New System.Drawing.Size(346, 19)
        Me.Student_nameTextBox.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.txtanswer)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(SubQuestion_noLabel)
        Me.GroupBox1.Controls.Add(Me.SubQuestion_noTextBox)
        Me.GroupBox1.Controls.Add(SubQuestion_answLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 318)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'txtanswer
        '
        Me.txtanswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanswer.Location = New System.Drawing.Point(21, 263)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(524, 26)
        Me.txtanswer.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(482, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 20)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 292)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(428, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Please input the correct answer for the question. Kindly input a capital characte" &
    "r for MCQ."
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubQuestionBindingSource, "SubQuestion_desc", True))
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 39)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(533, 195)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'SubQuestionBindingSource
        '
        Me.SubQuestionBindingSource.DataMember = "SubQuestion"
        Me.SubQuestionBindingSource.DataSource = Me.IQR_DataSet
        '
        'SubQuestion_noTextBox
        '
        Me.SubQuestion_noTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SubQuestion_noTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubQuestion_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubQuestionBindingSource, "SubQuestion_no", True))
        Me.SubQuestion_noTextBox.Location = New System.Drawing.Point(91, 13)
        Me.SubQuestion_noTextBox.Name = "SubQuestion_noTextBox"
        Me.SubQuestion_noTextBox.Size = New System.Drawing.Size(46, 13)
        Me.SubQuestion_noTextBox.TabIndex = 1
        '
        'QuestionTableAdapter
        '
        Me.QuestionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FacultyTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.MarksTableAdapter = Nothing
        Me.TableAdapterManager.QuestionTableAdapter = Me.QuestionTableAdapter
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.SubQuestionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IQR_System.IQR_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'SubQuestionTableAdapter
        '
        Me.SubQuestionTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(462, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 47)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Done!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 479)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 47)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'questionstart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 561)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(Me.Student_nameTextBox)
        Me.Controls.Add(Question_ref_numLabel)
        Me.Controls.Add(Me.Question_ref_numTextBox)
        Me.Controls.Add(Question_nameLabel)
        Me.Controls.Add(Me.Question_nameTextBox)
        Me.Controls.Add(Me.Question_DateDateTimePicker)
        Me.Controls.Add(Question_typeLabel)
        Me.Controls.Add(Me.Question_typeTextBox)
        Me.Controls.Add(Subject_codeLabel)
        Me.Controls.Add(Me.Subject_codeTextBox)
        Me.Controls.Add(Faculty_refLabel)
        Me.Controls.Add(Me.Faculty_refTextBox)
        Me.Controls.Add(Lecturer_IDLabel)
        Me.Controls.Add(Me.Lecturer_IDTextBox)
        Me.Name = "questionstart"
        Me.Text = "Begin!"
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SubQuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IQR_DataSet As IQR_DataSet
    Friend WithEvents QuestionBindingSource As BindingSource
    Friend WithEvents QuestionTableAdapter As IQR_DataSetTableAdapters.QuestionTableAdapter
    Friend WithEvents TableAdapterManager As IQR_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Question_ref_numTextBox As TextBox
    Friend WithEvents Question_nameTextBox As TextBox
    Friend WithEvents Question_DateDateTimePicker As DateTimePicker
    Friend WithEvents Question_typeTextBox As TextBox
    Friend WithEvents Subject_codeTextBox As TextBox
    Friend WithEvents Faculty_refTextBox As TextBox
    Friend WithEvents Lecturer_IDTextBox As TextBox
    Friend WithEvents StudentTableAdapter As IQR_DataSetTableAdapters.StudentTableAdapter
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents Student_nameTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SubQuestionBindingSource As BindingSource
    Friend WithEvents SubQuestionTableAdapter As IQR_DataSetTableAdapters.SubQuestionTableAdapter
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SubQuestion_noTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtanswer As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
