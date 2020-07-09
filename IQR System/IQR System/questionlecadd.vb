Public Class questionlecadd

    Public Shared questionadd As String

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub SubQuestionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SubQuestionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SubQuestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub questionlecadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IQR_DataSet.Question' table. You can move, or remove it, as needed.
        Me.QuestionTableAdapter.Fill(Me.IQR_DataSet.Question)
        'TODO: This line of code loads data into the 'IQR_DataSet.SubQuestion' table. You can move, or remove it, as needed.




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim quiz_name As String = txtquizname.Text
        Dim quiz_date As Date = Date.Now
        Dim quiz_type As String = cbtype.Text
        Dim quiz_total As Integer = 0
        Dim quiz_subject As String = cbsub.Text
        Dim quiz_fal As String = cbfal.Text
        Dim quiz_editor As String = login_lecturer.usersession

        Me.QuestionTableAdapter.InsertQueryQuestion(quiz_name, quiz_date, quiz_type, quiz_total, quiz_subject, quiz_fal, quiz_editor)
        MsgBox("Succesfull! Please proceed next!")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        questionadd = QuestionTableAdapter.GetQuestionref(txtquizname.Text)
        Me.Hide()
        addsubquestion.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        main_lecturer.Show()


    End Sub
End Class