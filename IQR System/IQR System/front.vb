Public Class front
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        login_student.Show()


    End Sub

    Private Sub btnLecturer_Click(sender As Object, e As EventArgs) Handles btnLecturer.Click
        Me.Hide()
        login_lecturer.Show()
    End Sub
End Class
