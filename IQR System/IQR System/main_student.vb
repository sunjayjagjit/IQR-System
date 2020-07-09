Public Class main_student

    Public Shared studquestionselect As String
    Public Shared studoptionselect As String



    Private Sub main_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IQR_DataSet.Question' table. You can move, or remove it, as needed.


        Dim stud_name As String
        Dim stud_email As String
        Dim stud_fal As String

        stud_name = StudentTableAdapter.GetDataStudName(login_student.usersession).ToString
        stud_email = StudentTableAdapter.GetDataStudEmail(login_student.usersession).ToString
        stud_fal = StudentTableAdapter.GetDataStudFal(login_student.usersession).ToString

        Me.lblid.Text = login_student.usersession
        Me.lblname.Text = stud_name
        Me.lblemail.Text = stud_email
        Me.lblfal.Text = stud_fal

        Me.QuestionTableAdapter.FillQuestionStud(Me.IQR_DataSet.Question, stud_fal)

    End Sub

    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub Faculty_refTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblid.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        login_student.usersession = ""
        Me.Close()
        front.Show()

    End Sub

    Private Sub QuestionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles QuestionDataGridView.CellContentClick

        Dim quizselect As String = QuestionDataGridView.Rows(e.RowIndex).Cells(0).Value
        Dim manage As String = e.ColumnIndex.ToString

        studoptionselect = manage
        studquestionselect = quizselect


        If studoptionselect = "7" Then
            questionstart.Show()
        ElseIf studoptionselect = "8" Then
            Me.Hide()
            studmark.Show()

        End If
    End Sub
End Class