Public Class register_lecturer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub register_lecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim lec_ID As String = txtid.Text
        Dim lec_name As String = txtname.Text
        Dim lec_email As String = txtemail.Text
        Dim lec_fal As String = combofal.Text
        Dim lec_pass As String = txtpass.Text

        Me.StudentTableAdapter.InsertQueryStud(lec_ID, lec_name, lec_pass, lec_email, lec_fal)
        MessageBox.Show("Successfully Register, redirect to login...", "Information", MessageBoxButtons.OK)
        Me.Close()
        login_student.Show()





    End Sub
End Class