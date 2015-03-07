Public Class DodajRacun
    Private flpArtikli As FlowLayoutPanel
    Private artikli As List(Of Artikal)
    Private redniBroj As Integer = 1
    Private lblUkupno As Label

    Public Sub New(ByRef flpArtikli As FlowLayoutPanel, ByRef artikli As List(Of Artikal), ByRef lblUkupno As Label)
        InitializeComponent()
        Me.flpArtikli = flpArtikli
        Me.artikli = artikli
        Me.lblUkupno = lblUkupno
    End Sub

    Private Sub btnDodajArtikal_Click(sender As Object, e As EventArgs) Handles btnDodajArtikal.Click
        flpArtikli.Controls.Add(New ArtikalRacun(artikli, redniBroj, lblUkupno, flpArtikli))
        flpArtikli.Controls.SetChildIndex(flpArtikli.Controls(flpArtikli.Controls.Count - 2), flpArtikli.Controls.GetChildIndex(flpArtikli.Controls(flpArtikli.Controls.Count - 2)) + 1)
        redniBroj += 1
    End Sub
End Class
