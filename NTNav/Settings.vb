Public Class Settings

    Private Sub ReactorButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReactorButton3.Click
        Form1.WebBrowser1.Navigate(ListBox1.SelectedItem)
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ListBox1.DataSource = My.Settings.Historique
        ListBox2.DataSource = My.Settings.Favoris
    End Sub

    Private Sub ReactorButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReactorButton1.Click
        My.Settings.Historique.Clear()
    End Sub

    Private Sub ReactorButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReactorButton6.Click
        Form1.WebBrowser1.Navigate(ListBox2.SelectedItem)
        Me.Hide()
    End Sub

    Private Sub ReactorButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReactorButton5.Click
        My.Settings.Historique.Clear()
    End Sub
End Class