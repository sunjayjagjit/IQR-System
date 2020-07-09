<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Faculty_refLabel As System.Windows.Forms.Label
        Dim Student_emailLabel As System.Windows.Forms.Label
        Dim Student_nameLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IQR_DataSet = New IQR_System.IQR_DataSet()
        Me.StudentTableAdapter = New IQR_System.IQR_DataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New IQR_System.IQR_DataSetTableAdapters.TableAdapterManager()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblfal = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QuestionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.QuestionTableAdapter()
        Faculty_refLabel = New System.Windows.Forms.Label()
        Student_emailLabel = New System.Windows.Forms.Label()
        Student_nameLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QuestionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Faculty_refLabel
        '
        Faculty_refLabel.AutoSize = True
        Faculty_refLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Faculty_refLabel.Location = New System.Drawing.Point(17, 165)
        Faculty_refLabel.Name = "Faculty_refLabel"
        Faculty_refLabel.Size = New System.Drawing.Size(119, 25)
        Faculty_refLabel.TabIndex = 10
        Faculty_refLabel.Text = "Faculty ref:"
        '
        'Student_emailLabel
        '
        Student_emailLabel.AutoSize = True
        Student_emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_emailLabel.Location = New System.Drawing.Point(17, 139)
        Student_emailLabel.Name = "Student_emailLabel"
        Student_emailLabel.Size = New System.Drawing.Size(149, 25)
        Student_emailLabel.TabIndex = 8
        Student_emailLabel.Text = "Student email:"
        '
        'Student_nameLabel
        '
        Student_nameLabel.AutoSize = True
        Student_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_nameLabel.Location = New System.Drawing.Point(17, 113)
        Student_nameLabel.Name = "Student_nameLabel"
        Student_nameLabel.Size = New System.Drawing.Size(151, 25)
        Student_nameLabel.TabIndex = 4
        Student_nameLabel.Text = "Student name:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(17, 87)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(118, 25)
        Student_IDLabel.TabIndex = 2
        Student_IDLabel.Text = "Student ID:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(15, 30)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(157, 42)
        Label2.TabIndex = 2
        Label2.Text = "Student "
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.IQR_DataSet
        '
        'IQR_DataSet
        '
        Me.IQR_DataSet.DataSetName = "IQR_DataSet"
        Me.IQR_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FacultyTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.MarksTableAdapter = Nothing
        Me.TableAdapterManager.QuestionTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.SubQuestionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IQR_System.IQR_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(191, 139)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(77, 25)
        Me.lblemail.TabIndex = 1
        Me.lblemail.Text = "Label1"
        '
        'lblfal
        '
        Me.lblfal.AutoSize = True
        Me.lblfal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfal.Location = New System.Drawing.Point(191, 165)
        Me.lblfal.Name = "lblfal"
        Me.lblfal.Size = New System.Drawing.Size(77, 25)
        Me.lblfal.TabIndex = 1
        Me.lblfal.Text = "Label1"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(191, 113)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(77, 25)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Label1"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(191, 87)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(77, 25)
        Me.lblid.TabIndex = 1
        Me.lblid.Text = "Label1"
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(491, 495)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(116, 54)
        Me.btnlogout.TabIndex = 12
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QuestionDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 267)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quiz"
        '
        'QuestionDataGridView
        '
        Me.QuestionDataGridView.AutoGenerateColumns = False
        Me.QuestionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QuestionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Column1})
        Me.QuestionDataGridView.DataSource = Me.QuestionBindingSource
        Me.QuestionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuestionDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.QuestionDataGridView.Name = "QuestionDataGridView"
        Me.QuestionDataGridView.Size = New System.Drawing.Size(589, 248)
        Me.QuestionDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Question_ref_num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Question_ref_num"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Question_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Question"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Question_Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Question_type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Subject_code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Faculty_ref"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Faculty"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Lecturer_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Creator"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Question_ref_num"
        Me.Column1.HeaderText = "Answer"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Text = "Begin"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 50
        '
        'QuestionBindingSource
        '
        Me.QuestionBindingSource.DataMember = "Question"
        Me.QuestionBindingSource.DataSource = Me.IQR_DataSet
        '
        'QuestionTableAdapter
        '
        Me.QuestionTableAdapter.ClearBeforeFill = True
        '
        'main_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 561)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Student_nameLabel)
        Me.Controls.Add(Student_emailLabel)
        Me.Controls.Add(Faculty_refLabel)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblfal)
        Me.Name = "main_student"
        Me.Text = "Student Mainpage"
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.QuestionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IQR_DataSet As IQR_DataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As IQR_DataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager As IQR_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblemail As Label
    Friend WithEvents lblfal As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblid As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QuestionBindingSource As BindingSource
    Friend WithEvents QuestionTableAdapter As IQR_DataSetTableAdapters.QuestionTableAdapter
    Friend WithEvents QuestionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
End Class
