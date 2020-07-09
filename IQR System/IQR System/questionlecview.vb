Public Class questionlecview
    Private Sub QuestionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles QuestionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.QuestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub questionlecview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim question_ref As Integer = Convert.ToInt32(main_lecturer.questionselect)

        'TODO: This line of code loads data into the 'IQR_DataSet.SubQuestion' table. You can move, or remove it, as needed.
        Me.SubQuestionTableAdapter.FillSubQuiz(Me.IQR_DataSet.SubQuestion, question_ref)
        'TODO: This line of code loads data into the 'IQR_DataSet.Question' table. You can move, or remove it, as needed.
        Me.QuestionTableAdapter.FillQuestion(Me.IQR_DataSet.Question, main_lecturer.questionselect)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        main_lecturer.questionselect = ""
        Me.Close()
        main_lecturer.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SubQuestionBindingSource.MovePrevious()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SubQuestionBindingSource.MoveNext()
    End Sub
End Class