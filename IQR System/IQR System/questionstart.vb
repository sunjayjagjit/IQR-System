Public Class questionstart

    Public Shared Total As Integer = 0
    Public Shared i As Integer = 1

    Private Sub QuestionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.QuestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub questionstart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IQR_DataSet.SubQuestion' table. You can move, or remove it, as needed.
        Me.SubQuestionTableAdapter.FillSubQuiz(Me.IQR_DataSet.SubQuestion, main_student.studquestionselect)
        'TODO: This line of code loads data into the 'IQR_DataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.FillStud(Me.IQR_DataSet.Student, login_student.usersession)


        'TODO: This line of code loads data into the 'IQR_DataSet.Question' table. You can move, or remove it, as needed.
        Me.QuestionTableAdapter.FillQuestion(Me.IQR_DataSet.Question, main_student.studquestionselect)

    End Sub

    Private Sub SubQuestion_noLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim answer As String = txtanswer.Text
        Dim trueanswer = Me.SubQuestionTableAdapter.ScalarQueryanswer(i)

        If answer = trueanswer Then
            Total = Total + 1
        End If

        i = i + 1

        SubQuestionBindingSource.MoveNext()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Total = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(Total)
    End Sub

    Private Sub Question_nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Question_nameTextBox.TextChanged

    End Sub
End Class