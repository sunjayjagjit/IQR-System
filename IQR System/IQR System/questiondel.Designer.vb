<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class questiondel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IQR_DataSet = New IQR_System.IQR_DataSet()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.QuestionTableAdapter()
        Me.TableAdapterManager = New IQR_System.IQR_DataSetTableAdapters.TableAdapterManager()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This will delete the question. Are you sure?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Yes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "No"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IQR_DataSet
        '
        Me.IQR_DataSet.DataSetName = "IQR_DataSet"
        Me.IQR_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FacultyTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.MarksTableAdapter = Nothing
        Me.TableAdapterManager.QuestionTableAdapter = Me.QuestionTableAdapter
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.SubQuestionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IQR_System.IQR_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'questiondel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 139)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "questiondel"
        Me.Text = "Confirm Delete"
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents IQR_DataSet As IQR_DataSet
    Friend WithEvents QuestionBindingSource As BindingSource
    Friend WithEvents QuestionTableAdapter As IQR_DataSetTableAdapters.QuestionTableAdapter
    Friend WithEvents TableAdapterManager As IQR_DataSetTableAdapters.TableAdapterManager
End Class
