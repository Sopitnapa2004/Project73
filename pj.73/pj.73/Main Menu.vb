Public Class MainMenu
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim staffForm As New Staff()
        staffForm.Show()
    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        Dim patientForm As New Patient()
        patientForm.Show()
    End Sub
End Class