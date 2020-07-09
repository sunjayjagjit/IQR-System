Public Class login_student

    Public Shared usersession As String

    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub login_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IQR_DataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.IQR_DataSet.Student)

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Me.Close()
        front.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim stud_id As String
        Dim stud_pass As String
        Dim message As String = "The ID or Password was incorrect, please try again"

        stud_id = txtStudent_id.Text
        stud_pass = txtStudent_pass.Text

        If Me.StudentTableAdapter.ScalarQueryStudentLogin(stud_id, stud_pass) Then

            usersession = stud_id
            main_student.Show()
            txtStudent_id.Clear()
            txtStudent_pass.Text = ""

            Me.Hide()
        Else
            MessageBox.Show(message, "Information", MessageBoxButtons.OK)
            txtStudent_id.Clear()
            txtStudent_pass.Text = ""
        End If

    End Sub

    Private Sub linkRegister_stud_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegister_stud.LinkClicked
        Me.Hide()
        register_student.Show()
    End Sub
End Class