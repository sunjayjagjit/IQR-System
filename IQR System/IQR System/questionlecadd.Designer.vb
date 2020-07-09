<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class questionlecadd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(questionlecadd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtquizname = New System.Windows.Forms.TextBox()
        Me.cbfal = New System.Windows.Forms.ComboBox()
        Me.cbtype = New System.Windows.Forms.ComboBox()
        Me.SubQuestionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.SubQuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IQR_DataSet = New IQR_System.IQR_DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SubQuestionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbsub = New System.Windows.Forms.ComboBox()
        Me.SubQuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.SubQuestionTableAdapter()
        Me.TableAdapterManager = New IQR_System.IQR_DataSetTableAdapters.TableAdapterManager()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.QuestionTableAdapter()
        CType(Me.SubQuestionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubQuestionBindingNavigator.SuspendLayout()
        CType(Me.SubQuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Faculty:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Type:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 152)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Quiz Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Subject: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 36)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Add Question"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(15, 223)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 53)
        Me.Button4.TabIndex = 109
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtquizname
        '
        Me.txtquizname.Location = New System.Drawing.Point(115, 150)
        Me.txtquizname.Name = "txtquizname"
        Me.txtquizname.Size = New System.Drawing.Size(281, 20)
        Me.txtquizname.TabIndex = 118
        '
        'cbfal
        '
        Me.cbfal.FormattingEnabled = True
        Me.cbfal.Items.AddRange(New Object() {"FCI", "FCM", "FOE", "FOM"})
        Me.cbfal.Location = New System.Drawing.Point(115, 103)
        Me.cbfal.Name = "cbfal"
        Me.cbfal.Size = New System.Drawing.Size(100, 21)
        Me.cbfal.TabIndex = 119
        '
        'cbtype
        '
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"MCQ", "FTB"})
        Me.cbtype.Location = New System.Drawing.Point(115, 172)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(100, 21)
        Me.cbtype.TabIndex = 119
        '
        'SubQuestionBindingNavigator
        '
        Me.SubQuestionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SubQuestionBindingNavigator.BindingSource = Me.SubQuestionBindingSource
        Me.SubQuestionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SubQuestionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SubQuestionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SubQuestionBindingNavigatorSaveItem})
        Me.SubQuestionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SubQuestionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SubQuestionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SubQuestionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SubQuestionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SubQuestionBindingNavigator.Name = "SubQuestionBindingNavigator"
        Me.SubQuestionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SubQuestionBindingNavigator.Size = New System.Drawing.Size(417, 25)
        Me.SubQuestionBindingNavigator.TabIndex = 120
        Me.SubQuestionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'SubQuestionBindingSource
        '
        Me.SubQuestionBindingSource.DataMember = "SubQuestion"
        Me.SubQuestionBindingSource.DataSource = Me.IQR_DataSet
        '
        'IQR_DataSet
        '
        Me.IQR_DataSet.DataSetName = "IQR_DataSet"
        Me.IQR_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SubQuestionBindingNavigatorSaveItem
        '
        Me.SubQuestionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SubQuestionBindingNavigatorSaveItem.Image = CType(resources.GetObject("SubQuestionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SubQuestionBindingNavigatorSaveItem.Name = "SubQuestionBindingNavigatorSaveItem"
        Me.SubQuestionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SubQuestionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 223)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 53)
        Me.Button1.TabIndex = 109
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 18)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Kindly fill the following field"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 223)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 53)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbsub
        '
        Me.cbsub.FormattingEnabled = True
        Me.cbsub.Items.AddRange(New Object() {"FCM2222", "FOE2023", "TSE2101"})
        Me.cbsub.Location = New System.Drawing.Point(115, 126)
        Me.cbsub.Name = "cbsub"
        Me.cbsub.Size = New System.Drawing.Size(142, 21)
        Me.cbsub.TabIndex = 119
        '
        'SubQuestionTableAdapter
        '
        Me.SubQuestionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FacultyTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.MarksTableAdapter = Nothing
        Me.TableAdapterManager.QuestionTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.SubQuestionTableAdapter = Me.SubQuestionTableAdapter
        Me.TableAdapterManager.UpdateOrder = IQR_System.IQR_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'questionlecadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 296)
        Me.Controls.Add(Me.SubQuestionBindingNavigator)
        Me.Controls.Add(Me.cbtype)
        Me.Controls.Add(Me.cbsub)
        Me.Controls.Add(Me.cbfal)
        Me.Controls.Add(Me.txtquizname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Name = "questionlecadd"
        Me.Text = "Question Add"
        CType(Me.SubQuestionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubQuestionBindingNavigator.ResumeLayout(False)
        Me.SubQuestionBindingNavigator.PerformLayout()
        CType(Me.SubQuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtquizname As TextBox
    Friend WithEvents cbfal As ComboBox
    Friend WithEvents cbtype As ComboBox
    Friend WithEvents IQR_DataSet As IQR_DataSet
    Friend WithEvents SubQuestionBindingSource As BindingSource
    Friend WithEvents SubQuestionTableAdapter As IQR_DataSetTableAdapters.SubQuestionTableAdapter
    Friend WithEvents TableAdapterManager As IQR_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SubQuestionBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SubQuestionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cbsub As ComboBox
    Friend WithEvents QuestionBindingSource As BindingSource
    Friend WithEvents QuestionTableAdapter As IQR_DataSetTableAdapters.QuestionTableAdapter
End Class
