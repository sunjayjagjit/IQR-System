<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login_lecturer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_lecturer))
        Me.btnChange = New System.Windows.Forms.Button()
        Me.linkRegister_lec = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtLecturer_pass = New System.Windows.Forms.TextBox()
        Me.txtLecturer_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IQR_DataSet = New IQR_System.IQR_DataSet()
        Me.LecturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LecturerTableAdapter = New IQR_System.IQR_DataSetTableAdapters.LecturerTableAdapter()
        Me.TableAdapterManager = New IQR_System.IQR_DataSetTableAdapters.TableAdapterManager()
        Me.LecturerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LecturerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LecturerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(255, 440)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(83, 43)
        Me.btnChange.TabIndex = 28
        Me.btnChange.Text = "Change User"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'linkRegister_lec
        '
        Me.linkRegister_lec.AutoSize = True
        Me.linkRegister_lec.Location = New System.Drawing.Point(260, 410)
        Me.linkRegister_lec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.linkRegister_lec.Name = "linkRegister_lec"
        Me.linkRegister_lec.Size = New System.Drawing.Size(74, 13)
        Me.linkRegister_lec.TabIndex = 27
        Me.linkRegister_lec.TabStop = True
        Me.linkRegister_lec.Text = "Register Now!"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(388, 340)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(63, 48)
        Me.btnLogin.TabIndex = 26
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtLecturer_pass
        '
        Me.txtLecturer_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecturer_pass.Location = New System.Drawing.Point(213, 368)
        Me.txtLecturer_pass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLecturer_pass.Name = "txtLecturer_pass"
        Me.txtLecturer_pass.Size = New System.Drawing.Size(168, 24)
        Me.txtLecturer_pass.TabIndex = 24
        Me.txtLecturer_pass.UseSystemPasswordChar = True
        '
        'txtLecturer_id
        '
        Me.txtLecturer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecturer_id.Location = New System.Drawing.Point(213, 340)
        Me.txtLecturer_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLecturer_id.Name = "txtLecturer_id"
        Me.txtLecturer_id.Size = New System.Drawing.Size(168, 24)
        Me.txtLecturer_id.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 340)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 368)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 73)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Lecturer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(249, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 36)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 299)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Please enter id and password."
        '
        'IQR_DataSet
        '
        Me.IQR_DataSet.DataSetName = "IQR_DataSet"
        Me.IQR_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LecturerBindingSource
        '
        Me.LecturerBindingSource.DataMember = "Lecturer"
        Me.LecturerBindingSource.DataSource = Me.IQR_DataSet
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
        'LecturerBindingNavigator
        '
        Me.LecturerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LecturerBindingNavigator.BindingSource = Me.LecturerBindingSource
        Me.LecturerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LecturerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LecturerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LecturerBindingNavigatorSaveItem})
        Me.LecturerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LecturerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LecturerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LecturerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LecturerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LecturerBindingNavigator.Name = "LecturerBindingNavigator"
        Me.LecturerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LecturerBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.LecturerBindingNavigator.TabIndex = 29
        Me.LecturerBindingNavigator.Text = "BindingNavigator1"
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
        'LecturerBindingNavigatorSaveItem
        '
        Me.LecturerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LecturerBindingNavigatorSaveItem.Image = CType(resources.GetObject("LecturerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LecturerBindingNavigatorSaveItem.Name = "LecturerBindingNavigatorSaveItem"
        Me.LecturerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LecturerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'login_lecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.LecturerBindingNavigator)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.linkRegister_lec)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtLecturer_pass)
        Me.Controls.Add(Me.txtLecturer_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login_lecturer"
        Me.Text = "Lecturer Login"
        CType(Me.IQR_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LecturerBindingNavigator.ResumeLayout(False)
        Me.LecturerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChange As Button
    Friend WithEvents linkRegister_lec As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLecturer_pass As TextBox
    Friend WithEvents txtLecturer_id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IQR_DataSet As IQR_DataSet
    Friend WithEvents LecturerBindingSource As BindingSource
    Friend WithEvents LecturerTableAdapter As IQR_DataSetTableAdapters.LecturerTableAdapter
    Friend WithEvents TableAdapterManager As IQR_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LecturerBindingNavigator As BindingNavigator
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
    Friend WithEvents LecturerBindingNavigatorSaveItem As ToolStripButton
End Class
