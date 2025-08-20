Public Class MainMenu
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim staffForm As New Staff()
        staffForm.Show()
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        Dim suppliersForm As New Suppliers()
        suppliersForm.Show()
    End Sub
End Class