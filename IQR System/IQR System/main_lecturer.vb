Public Class main_lecturer

    Public Shared questionselect As String
    Public Shared optionselect As String

    Private Sub LecturerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LecturerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub main_lecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IQR_DataSet.Question' table. You can move, or remove it, as needed.


        Dim lec_name As String
        Dim lec_email As String
        Dim lec_fal As String

        lec_name = LecturerTableAdapter.GetDataLecName(login_lecturer.usersession).ToString
        lec_email = LecturerTableAdapter.GetDataLecEmail(login_lecturer.usersession).ToString
        lec_fal = LecturerTableAdapter.GetDataLecFal(login_lecturer.usersession).ToString

        Me.lblid.Text = login_lecturer.usersession
        Me.lblname.Text = lec_name
        Me.lblemail.Text = lec_email
        Me.lblfal.Text = lec_fal

        Me.QuestionTableAdapter.FillQuestionStud(IQR_DataSet.Question, lec_fal)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click

        login_lecturer.usersession = ""
        Me.Close()
        front.Show()

    End Sub

    Private Sub FillQuestionLecToolStripButton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub QuestionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub QuestionDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles QuestionDataGridView.CellContentClick


        Dim quizselect As String = QuestionDataGridView.Rows(e.RowIndex).Cells(0).Value
        Dim manage As String = e.ColumnIndex.ToString

        optionselect = manage
        questionselect = quizselect


        If optionselect = "5" Then
            Me.Hide()
            questionlecview.Show()
        ElseIf optionselect = "6" Then
            questiondel.Show()
        End If

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Hide()
        questionlecadd.Show()

    End Sub
End Class