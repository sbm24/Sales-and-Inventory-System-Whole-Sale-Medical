Public Class frminvtype

    Private Sub Sale_Click(sender As Object, e As EventArgs) Handles Sale.Click
        frmSales.Show()

        Me.Hide()
        frmSales.cmbInvType.SelectedIndex = 0
        Me.Close()

    End Sub

    Private Sub Tax_Click(sender As Object, e As EventArgs) Handles Tax.Click
        frmSales.Show()

        Me.Hide()
        frmSales.cmbInvType.SelectedIndex = 1
        Me.Close()
    End Sub
End Class