Public Class Form1

    Private Sub btnVisit_Click(sender As Object, e As EventArgs) Handles btnVisit.Click
        If (radWinnipeg.Checked = True) Then
            lblInfo1.Text = "Maples Collegiate"
            lblInfo2.Text = "The Forks"
            lblInfo3.Text = "Osborne Village"
            lblInfo4.Text = "Museum of Human Rights"

        ElseIf (radSydney.Checked = True) Then
            lblInfo1.Text = "Sydney Opera House"
            lblInfo2.Text = "Sydney Harbour Bridge"
            lblInfo3.Text = "Bondi Beach"
            lblInfo4.Text = "Darling Harbour"

        ElseIf (radLondon.Checked = True) Then
            lblInfo1.Text = "Big Ben"
            lblInfo2.Text = "Coca-Cola London Eye"
            lblInfo3.Text = "Tower of London"
            lblInfo4.Text = "Tower Bridge"

        ElseIf (radChicago.Checked = True) Then
            lblInfo1.Text = "Millennium Park"
            lblInfo2.Text = "Navy Pier"
            lblInfo3.Text = "Willis Tower"
            lblInfo4.Text = "The Art Institute of Chicago"
        End If

    End Sub
End Class
