Public Class questiondel
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.QuestionTableAdapter.DeleteQuestion(main_lecturer.questionselect)
        main_lecturer.questionselect = ""
        main_lecturer.Refresh()
        Me.Close()

    End Sub

    Private Sub QuestionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.QuestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub questiondel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IQR_DataSet.Question' table. You can move, or remove it, as needed.


    End Sub

End Class