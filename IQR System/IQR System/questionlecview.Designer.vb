<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class questionlecview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(questionlecview))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SubQuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IQR_DataSet = New IQR_System.IQR_DataSet()
        Me.SubQuestion_answTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.QuestionTableAdapter()
        Me.TableAdapterManager = New IQR_System.IQR_DataSetTableAdapters.TableAdapterManager()
        Me.QuestionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.QuestionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Question_ref_numTextBox = New System.Windows.Forms.TextBox()
        Me.Question_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Question_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Question_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Question_totalTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Faculty_refTextBox = New System.Windows.Forms.TextBox()
        Me.Lecturer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.SubQuestionTableAdapter = New IQR_System.IQR_DataSetTableAdapters.SubQuestionTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SubQuestion_noTextBox = New System.Windows.Forms.TextBox()
        Question_ref_numLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SubQuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuestionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Question_ref_numLabel
        '
        Question_ref_numLabel.AutoSize = True
        Question_ref_numLabel.Location = New System.Drawing.Point(421, 12)
        Question_ref_numLabel.Name = "Question_ref_numLabel"
        Question_ref_numLabel.Size = New System.Drawing.Size(90, 13)
        Question_ref_numLabel.TabIndex = 91
        Question_ref_numLabel.Text = "Question ref num:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(390, 9)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 13)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Question Reference Number: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 189)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 13)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Total number of question."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.SubQuestion_noTextBox)
        Me.GroupBox1.Controls.Add(Me.SubQuestion_answTextBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(565, 232)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubQuestionBindingSource, "SubQuestion_desc", True))
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 48)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(542, 122)
        Me.RichTextBox1.TabIndex = 114
        Me.RichTextBox1.Text = ""
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
        'SubQuestion_answTextBox
        '
        Me.SubQuestion_answTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SubQuestion_answTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubQuestionBindingSource, "SubQuestion_answ", True))
        Me.SubQuestion_answTextBox.Location = New System.Drawing.Point(11, 193)
        Me.SubQuestion_answTextBox.Name = "SubQuestion_answTextBox"
        Me.SubQuestion_answTextBox.ReadOnly = True
        Me.SubQuestion_answTextBox.Size = New System.Drawing.Size(539, 22)
        Me.SubQuestion_answTextBox.TabIndex = 113
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 218)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(428, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Please input the correct answer for the question. Kindly input a capital characte" &
    "r for MCQ."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 173)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Input Answer"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(453, 19)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 20)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(486, 19)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 20)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Question Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Faculty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Editor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Type:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Quiz Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 89)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Subject: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 36)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "View Question"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 456)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 66)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Back to Mainpage"
        Me.Button4.UseVisualStyleBackColor = True
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
        'QuestionBindingNavigator
        '
        Me.QuestionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QuestionBindingNavigator.BindingSource = Me.QuestionBindingSource
        Me.QuestionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QuestionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QuestionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QuestionBindingNavigatorSaveItem})
        Me.QuestionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QuestionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QuestionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QuestionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QuestionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QuestionBindingNavigator.Name = "QuestionBindingNavigator"
        Me.QuestionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QuestionBindingNavigator.Size = New System.Drawing.Size(590, 25)
        Me.QuestionBindingNavigator.TabIndex = 91
        Me.QuestionBindingNavigator.Text = "BindingNavigator1"
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
        'QuestionBindingNavigatorSaveItem
        '
        Me.QuestionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QuestionBindingNavigatorSaveItem.Image = CType(resources.GetObject("QuestionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QuestionBindingNavigatorSaveItem.Name = "QuestionBindingNavigatorSaveItem"
        Me.QuestionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QuestionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Question_ref_numTextBox
        '
        Me.Question_ref_numTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question_ref_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Question_ref_num", True))
        Me.Question_ref_numTextBox.Location = New System.Drawing.Point(512, 12)
        Me.Question_ref_numTextBox.Name = "Question_ref_numTextBox"
        Me.Question_ref_numTextBox.ReadOnly = True
        Me.Question_ref_numTextBox.Size = New System.Drawing.Size(26, 13)
        Me.Question_ref_numTextBox.TabIndex = 92
        '
        'Question_nameTextBox
        '
        Me.Question_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Question_name", True))
        Me.Question_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_nameTextBox.Location = New System.Drawing.Point(91, 114)
        Me.Question_nameTextBox.Name = "Question_nameTextBox"
        Me.Question_nameTextBox.ReadOnly = True
        Me.Question_nameTextBox.Size = New System.Drawing.Size(200, 17)
        Me.Question_nameTextBox.TabIndex = 94
        '
        'Question_DateDateTimePicker
        '
        Me.Question_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QuestionBindingSource, "Question_Date", True))
        Me.Question_DateDateTimePicker.Location = New System.Drawing.Point(378, 165)
        Me.Question_DateDateTimePicker.Name = "Question_DateDateTimePicker"
        Me.Question_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Question_DateDateTimePicker.TabIndex = 96
        '
        'Question_typeTextBox
        '
        Me.Question_typeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Question_type", True))
        Me.Question_typeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_typeTextBox.Location = New System.Drawing.Point(50, 141)
        Me.Question_typeTextBox.Name = "Question_typeTextBox"
        Me.Question_typeTextBox.ReadOnly = True
        Me.Question_typeTextBox.Size = New System.Drawing.Size(51, 17)
        Me.Question_typeTextBox.TabIndex = 98
        '
        'Question_totalTextBox
        '
        Me.Question_totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question_totalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Question_total", True))
        Me.Question_totalTextBox.Location = New System.Drawing.Point(141, 190)
        Me.Question_totalTextBox.Name = "Question_totalTextBox"
        Me.Question_totalTextBox.ReadOnly = True
        Me.Question_totalTextBox.Size = New System.Drawing.Size(41, 13)
        Me.Question_totalTextBox.TabIndex = 102
        '
        'Subject_codeTextBox
        '
        Me.Subject_codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Subject_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Subject_code", True))
        Me.Subject_codeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject_codeTextBox.Location = New System.Drawing.Point(64, 90)
        Me.Subject_codeTextBox.Name = "Subject_codeTextBox"
        Me.Subject_codeTextBox.ReadOnly = True
        Me.Subject_codeTextBox.Size = New System.Drawing.Size(86, 17)
        Me.Subject_codeTextBox.TabIndex = 104
        '
        'Faculty_refTextBox
        '
        Me.Faculty_refTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Faculty_refTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Faculty_ref", True))
        Me.Faculty_refTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Faculty_refTextBox.Location = New System.Drawing.Point(64, 69)
        Me.Faculty_refTextBox.Name = "Faculty_refTextBox"
        Me.Faculty_refTextBox.ReadOnly = True
        Me.Faculty_refTextBox.Size = New System.Drawing.Size(63, 17)
        Me.Faculty_refTextBox.TabIndex = 106
        '
        'Lecturer_IDTextBox
        '
        Me.Lecturer_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lecturer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionBindingSource, "Lecturer_ID", True))
        Me.Lecturer_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lecturer_IDTextBox.Location = New System.Drawing.Point(64, 163)
        Me.Lecturer_IDTextBox.Name = "Lecturer_IDTextBox"
        Me.Lecturer_IDTextBox.ReadOnly = True
        Me.Lecturer_IDTextBox.Size = New System.Drawing.Size(200, 17)
        Me.Lecturer_IDTextBox.TabIndex = 108
        '
        'SubQuestionTableAdapter
        '
        Me.SubQuestionTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "No."
        '
        'SubQuestion_noTextBox
        '
        Me.SubQuestion_noTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SubQuestion_noTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubQuestion_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubQuestionBindingSource, "SubQuestion_no", True))
        Me.SubQuestion_noTextBox.Location = New System.Drawing.Point(38, 11)
        Me.SubQuestion_noTextBox.Name = "SubQuestion_noTextBox"
        Me.SubQuestion_noTextBox.ReadOnly = True
        Me.SubQuestion_noTextBox.Size = New System.Drawing.Size(45, 15)
        Me.SubQuestion_noTextBox.TabIndex = 109
        '
        'questionlecview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 561)
        Me.Controls.Add(Question_ref_numLabel)
        Me.Controls.Add(Me.Question_ref_numTextBox)
        Me.Controls.Add(Me.Question_nameTextBox)
        Me.Controls.Add(Me.Question_DateDateTimePicker)
        Me.Controls.Add(Me.Question_typeTextBox)
        Me.Controls.Add(Me.Question_totalTextBox)
        Me.Controls.Add(Me.Subject_codeTextBox)
        Me.Controls.Add(Me.Faculty_refTextBox)
        Me.Controls.Add(Me.Lecturer_IDTextBox)
        Me.Controls.Add(Me.QuestionBindingNavigator)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Name = "questionlecview"
        Me.Text = "Lecturer Viewing Question"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SubQuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuestionBindingNavigator.ResumeLayout(False)
        Me.QuestionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents IQR_DataSet As IQR_DataSet
    Friend WithEvents QuestionBindingSource As BindingSource
    Friend WithEvents QuestionTableAdapter As IQR_DataSetTableAdapters.QuestionTableAdapter
    Friend WithEvents TableAdapterManager As IQR_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents QuestionBindingNavigator As BindingNavigator
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
    Friend WithEvents QuestionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Question_ref_numTextBox As TextBox
    Friend WithEvents Question_nameTextBox As TextBox
    Friend WithEvents Question_DateDateTimePicker As DateTimePicker
    Friend WithEvents Question_typeTextBox As TextBox
    Friend WithEvents Question_totalTextBox As TextBox
    Friend WithEvents Subject_codeTextBox As TextBox
    Friend WithEvents Faculty_refTextBox As TextBox
    Friend WithEvents Lecturer_IDTextBox As TextBox
    Friend WithEvents SubQuestionBindingSource As BindingSource
    Friend WithEvents SubQuestionTableAdapter As IQR_DataSetTableAdapters.SubQuestionTableAdapter
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SubQuestion_answTextBox As TextBox
    Friend WithEvents SubQuestion_noTextBox As TextBox
    Friend WithEvents Label6 As Label
End Class
