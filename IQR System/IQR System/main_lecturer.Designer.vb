<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_lecturer
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
        Dim Lecturer_IDLabel As System.Windows.Forms.Label
        Dim Lecturer_nameLabel As System.Windows.Forms.Label
        Dim Lecturer_emailLabel As System.Windows.Forms.Label
        Dim Faculty_refLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.LecturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IQR_DataSet = New IQR_System.IQR_DataSet()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblfal = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QuestionDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.LecturerTableAdapter = New IQR_System.IQR_DataSetTableAdapters.LecturerTableAdapter()
        Me.TableAdapterManager = New IQR_System.IQR_DataSetTableAdapters.TableAdapterManager()
        Me.QuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.QuestionTableAdapter()
        Lecturer_IDLabel = New System.Windows.Forms.Label()
        Lecturer_nameLabel = New System.Windows.Forms.Label()
        Lecturer_emailLabel = New System.Windows.Forms.Label()
        Faculty_refLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QuestionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lecturer_IDLabel
        '
        Lecturer_IDLabel.AutoSize = True
        Lecturer_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lecturer_IDLabel.Location = New System.Drawing.Point(12, 67)
        Lecturer_IDLabel.Name = "Lecturer_IDLabel"
        Lecturer_IDLabel.Size = New System.Drawing.Size(123, 25)
        Lecturer_IDLabel.TabIndex = 1
        Lecturer_IDLabel.Text = "Lecturer ID:"
        '
        'Lecturer_nameLabel
        '
        Lecturer_nameLabel.AutoSize = True
        Lecturer_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lecturer_nameLabel.Location = New System.Drawing.Point(12, 95)
        Lecturer_nameLabel.Name = "Lecturer_nameLabel"
        Lecturer_nameLabel.Size = New System.Drawing.Size(156, 25)
        Lecturer_nameLabel.TabIndex = 3
        Lecturer_nameLabel.Text = "Lecturer name:"
        '
        'Lecturer_emailLabel
        '
        Lecturer_emailLabel.AutoSize = True
        Lecturer_emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lecturer_emailLabel.Location = New System.Drawing.Point(12, 123)
        Lecturer_emailLabel.Name = "Lecturer_emailLabel"
        Lecturer_emailLabel.Size = New System.Drawing.Size(154, 25)
        Lecturer_emailLabel.TabIndex = 7
        Lecturer_emailLabel.Text = "Lecturer email:"
        '
        'Faculty_refLabel
        '
        Faculty_refLabel.AutoSize = True
        Faculty_refLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Faculty_refLabel.Location = New System.Drawing.Point(12, 151)
        Faculty_refLabel.Name = "Faculty_refLabel"
        Faculty_refLabel.Size = New System.Drawing.Size(119, 25)
        Faculty_refLabel.TabIndex = 9
        Faculty_refLabel.Text = "Faculty ref:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(10, 25)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(155, 42)
        Label2.TabIndex = 11
        Label2.Text = "Lecturer"
        '
        'LecturerBindingSource
        '
        Me.LecturerBindingSource.DataMember = "Lecturer"
        Me.LecturerBindingSource.DataSource = Me.IQR_DataSet
        '
        'IQR_DataSet
        '
        Me.IQR_DataSet.DataSetName = "IQR_DataSet"
        Me.IQR_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(171, 67)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(77, 25)
        Me.lblid.TabIndex = 10
        Me.lblid.Text = "Label1"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(171, 95)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(77, 25)
        Me.lblname.TabIndex = 10
        Me.lblname.Text = "Label1"
        '
        'lblfal
        '
        Me.lblfal.AutoSize = True
        Me.lblfal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfal.Location = New System.Drawing.Point(171, 151)
        Me.lblfal.Name = "lblfal"
        Me.lblfal.Size = New System.Drawing.Size(77, 25)
        Me.lblfal.TabIndex = 10
        Me.lblfal.Text = "Label1"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(171, 123)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(77, 25)
        Me.lblemail.TabIndex = 10
        Me.lblemail.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QuestionDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 293)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quiz "
        '
        'QuestionDataGridView
        '
        Me.QuestionDataGridView.AllowUserToAddRows = False
        Me.QuestionDataGridView.AutoGenerateColumns = False
        Me.QuestionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QuestionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.Column1, Me.Column3})
        Me.QuestionDataGridView.DataSource = Me.QuestionBindingSource
        Me.QuestionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuestionDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.QuestionDataGridView.Name = "QuestionDataGridView"
        Me.QuestionDataGridView.Size = New System.Drawing.Size(589, 274)
        Me.QuestionDataGridView.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Question_ref_num"
        Me.Column4.HeaderText = "Ref"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Question_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quiz Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Question_Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date Created"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Question_type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Subject_code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "View"
        Me.Column1.HeaderText = "View"
        Me.Column1.Name = "Column1"
        Me.Column1.Text = "View"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 40
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Del"
        Me.Column3.HeaderText = "Del"
        Me.Column3.Name = "Column3"
        Me.Column3.Text = "Del"
        Me.Column3.UseColumnTextForButtonValue = True
        Me.Column3.Width = 40
        '
        'QuestionBindingSource
        '
        Me.QuestionBindingSource.DataMember = "Question"
        Me.QuestionBindingSource.DataSource = Me.IQR_DataSet
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(451, 75)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(115, 59)
        Me.btnCreate.TabIndex = 13
        Me.btnCreate.Text = "Create Question"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(460, 490)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(115, 59)
        Me.btnlogout.TabIndex = 13
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'LecturerTableAdapter
        '
        Me.LecturerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FacultyTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Me.LecturerTableAdapter
        Me.TableAdapterManager.MarksTableAdapter = Nothing
        Me.TableAdapterManager.QuestionTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.SubQuestionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IQR_System.IQR_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QuestionTableAdapter
        '
        Me.QuestionTableAdapter.ClearBeforeFill = True
        '
        'main_lecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 589)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblfal)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Lecturer_IDLabel)
        Me.Controls.Add(Lecturer_nameLabel)
        Me.Controls.Add(Lecturer_emailLabel)
        Me.Controls.Add(Faculty_refLabel)
        Me.Name = "main_lecturer"
        Me.Text = "Lecturer Mainpage"
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.QuestionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IQR_DataSet As IQR_DataSet
    Friend WithEvents LecturerBindingSource As BindingSource
    Friend WithEvents LecturerTableAdapter As IQR_DataSetTableAdapters.LecturerTableAdapter
    Friend WithEvents TableAdapterManager As IQR_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblid As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblfal As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents QuestionBindingSource As BindingSource
    Friend WithEvents QuestionTableAdapter As IQR_DataSetTableAdapters.QuestionTableAdapter
    Friend WithEvents QuestionDataGridView As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
