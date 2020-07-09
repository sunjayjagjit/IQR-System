<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addsubquestion
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
        Dim Question_ref_numLabel As System.Windows.Forms.Label
        Dim SubQuestion_answLabel As System.Windows.Forms.Label
        Dim SubQuestion_descLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addsubquestion))
        Me.IQR_DataSet = New IQR_System.IQR_DataSet()
        Me.SubQuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubQuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.SubQuestionTableAdapter()
        Me.TableAdapterManager = New IQR_System.IQR_DataSetTableAdapters.TableAdapterManager()
        Me.SubQuestionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.SubQuestion_answTextBox = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Question_ref_numTextBox = New System.Windows.Forms.TextBox()
        Question_ref_numLabel = New System.Windows.Forms.Label()
        SubQuestion_answLabel = New System.Windows.Forms.Label()
        SubQuestion_descLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubQuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubQuestionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubQuestionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Question_ref_numLabel
        '
        Question_ref_numLabel.AutoSize = True
        Question_ref_numLabel.Location = New System.Drawing.Point(364, 31)
        Question_ref_numLabel.Name = "Question_ref_numLabel"
        Question_ref_numLabel.Size = New System.Drawing.Size(90, 13)
        Question_ref_numLabel.TabIndex = 7
        Question_ref_numLabel.Text = "Question ref num:"
        '
        'SubQuestion_answLabel
        '
        SubQuestion_answLabel.AutoSize = True
        SubQuestion_answLabel.Location = New System.Drawing.Point(12, 241)
        SubQuestion_answLabel.Name = "SubQuestion_answLabel"
        SubQuestion_answLabel.Size = New System.Drawing.Size(42, 13)
        SubQuestion_answLabel.TabIndex = 5
        SubQuestion_answLabel.Text = "Answer"
        AddHandler SubQuestion_answLabel.Click, AddressOf Me.SubQuestion_answLabel_Click
        '
        'SubQuestion_descLabel
        '
        SubQuestion_descLabel.AutoSize = True
        SubQuestion_descLabel.Location = New System.Drawing.Point(10, 34)
        SubQuestion_descLabel.Name = "SubQuestion_descLabel"
        SubQuestion_descLabel.Size = New System.Drawing.Size(100, 13)
        SubQuestion_descLabel.TabIndex = 3
        SubQuestion_descLabel.Text = "Sub Question desc:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 295)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(434, 13)
        Label1.TabIndex = 5
        Label1.Text = "Kindly use the Navigation Above for Add, Delete, Update question. Hit ""Done"" once" &
    " finish."
        AddHandler Label1.Click, AddressOf Me.SubQuestion_answLabel_Click
        '
        'IQR_DataSet
        '
        Me.IQR_DataSet.DataSetName = "IQR_DataSet"
        Me.IQR_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubQuestionBindingSource
        '
        Me.SubQuestionBindingSource.DataMember = "SubQuestion"
        Me.SubQuestionBindingSource.DataSource = Me.IQR_DataSet
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
        Me.SubQuestionBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.SubQuestionBindingNavigator.TabIndex = 0
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
        'SubQuestion_answTextBox
        '
        Me.SubQuestion_answTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubQuestionBindingSource, "SubQuestion_answ", True))
        Me.SubQuestion_answTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubQuestion_answTextBox.Location = New System.Drawing.Point(15, 257)
        Me.SubQuestion_answTextBox.Name = "SubQuestion_answTextBox"
        Me.SubQuestion_answTextBox.Size = New System.Drawing.Size(557, 22)
        Me.SubQuestion_answTextBox.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubQuestionBindingSource, "SubQuestion_desc", True))
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 50)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(557, 188)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 44)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Question_ref_numTextBox
        '
        Me.Question_ref_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubQuestionBindingSource, "Question_ref_num", True))
        Me.Question_ref_numTextBox.Location = New System.Drawing.Point(460, 27)
        Me.Question_ref_numTextBox.Name = "Question_ref_numTextBox"
        Me.Question_ref_numTextBox.Size = New System.Drawing.Size(53, 20)
        Me.Question_ref_numTextBox.TabIndex = 17
        '
        'addsubquestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 359)
        Me.Controls.Add(Me.Question_ref_numTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(SubQuestion_descLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(SubQuestion_answLabel)
        Me.Controls.Add(Me.SubQuestion_answTextBox)
        Me.Controls.Add(Question_ref_numLabel)
        Me.Controls.Add(Me.SubQuestionBindingNavigator)
        Me.Name = "addsubquestion"
        Me.Text = "Add Sub Question"
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubQuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubQuestionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubQuestionBindingNavigator.ResumeLayout(False)
        Me.SubQuestionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents SubQuestion_answTextBox As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Question_ref_numTextBox As TextBox
End Class
