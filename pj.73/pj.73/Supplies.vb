Public Class Supplies
    Private Sub btnManageSupplies_Click(sender As Object, e As EventArgs) Handles btnManageSupplies.Click
        Dim managesuppliesForm As New ManageSupplies()
        managesuppliesForm.Show()
    End Sub

    Private Sub btnDispense_Click(sender As Object, e As EventArgs) Handles btnDispense.Click
        Dim dispenseForm As New Dispense()
        dispenseForm.Show()
    End Sub
End Class