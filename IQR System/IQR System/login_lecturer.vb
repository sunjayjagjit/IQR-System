Public Class login_lecturer

    Public Shared usersession As String

    Private Sub LecturerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LecturerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LecturerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IQR_DataSet)

    End Sub

    Private Sub login_lecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IQR_DataSet.Lecturer' table. You can move, or remove it, as needed.
        Me.LecturerTableAdapter.Fill(Me.IQR_DataSet.Lecturer)

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Me.Close()
        front.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim lec_id As String
        Dim lec_pass As String
        Dim message As String = "The ID or Password was incorrect, please try again"

        lec_id = txtLecturer_id.Text
        lec_pass = txtLecturer_pass.Text

        If Me.LecturerTableAdapter.ScalarQueryLecLogin(lec_id, lec_pass) Then

            usersession = lec_id
            main_lecturer.Show()
            txtLecturer_id.Clear()
            txtLecturer_pass.Text = ""

            Me.Hide()
        Else
            MessageBox.Show(message, "Information", MessageBoxButtons.OK)
            txtLecturer_id.Clear()
            txtLecturer_pass.Text = ""
        End If
    End Sub
End Class