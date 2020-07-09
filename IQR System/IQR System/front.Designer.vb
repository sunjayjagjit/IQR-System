<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class front
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnLecturer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IQ-Revision System"
        '
        'btnStudent
        '
        Me.btnStudent.Location = New System.Drawing.Point(210, 350)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(107, 66)
        Me.btnStudent.TabIndex = 1
        Me.btnStudent.Text = "Student"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnLecturer
        '
        Me.btnLecturer.Location = New System.Drawing.Point(210, 252)
        Me.btnLecturer.Name = "btnLecturer"
        Me.btnLecturer.Size = New System.Drawing.Size(107, 68)
        Me.btnLecturer.TabIndex = 1
        Me.btnLecturer.Text = "Lecturer"
        Me.btnLecturer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Login as:"
        '
        'front
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 526)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLecturer)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.Label1)
        Me.Name = "front"
        Me.Text = "IQR System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnLecturer As Button
    Friend WithEvents Label2 As Label
End Class
