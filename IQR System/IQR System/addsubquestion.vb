Public Class addsubquestion
    Private Sub SubQuestionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SubQuestionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SubQuestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub addsubquestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IQR_DataSet.SubQuestion' table. You can move, or remove it, as needed.
        Me.SubQuestionTableAdapter.FillSubQuiz(Me.IQR_DataSet.SubQuestion, questionlecadd.questionadd)
        Question_ref_numTextBox.Text = questionlecadd.questionadd
    End Sub

    Private Sub SubQuestion_answLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SubQuestion_answTextBox_TextChanged(sender As Object, e As EventArgs) Handles SubQuestion_answTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        questionlecadd.questionadd = ""
        Me.Close()
        main_lecturer.Show()

    End Sub

    Private Sub SubQuestionBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles SubQuestionBindingNavigator.RefreshItems

    End Sub
End Class