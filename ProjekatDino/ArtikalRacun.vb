Public Class ArtikalRacun
    Private artikli As List(Of Artikal)
    Private lblUkupno As Label
    Private flpArtikli As FlowLayoutPanel

    Public Sub New(ByVal artikli As List(Of Artikal), ByVal redniBroj As Integer, ByRef lblUkupno As Label, ByRef flpArtikli As FlowLayoutPanel)
        InitializeComponent()
        Me.artikli = artikli
        Me.lblUkupno = lblUkupno
        Me.flpArtikli = flpArtikli
        For Each a As Artikal In artikli
            cbbSifre.Items.Add(a.sifra)
            cbbImena.Items.Add(a.ime)
        Next
        lblRedniBroj.Text = redniBroj.ToString()
    End Sub
    Private Sub cbbSifra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSifre.SelectedIndexChanged
        cbbImena.SelectedIndex = cbbSifre.SelectedIndex
    End Sub

    Private Sub cbbImena_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbImena.SelectedIndexChanged
        cbbSifre.SelectedIndex = cbbImena.SelectedIndex
    End Sub

    Private Sub nudKolicina_ValueChanged(sender As Object, e As EventArgs) Handles nudKolicina.ValueChanged
        Dim suma As Decimal = 0
        For Each c As Control In flpArtikli.Controls
            If TypeOf c Is ArtikalRacun Then
                suma += DirectCast(c, ArtikalRacun).DajSumu()
            End If
        Next
        lblUkupno.Text = Decimal.Round(suma, 2)
    End Sub

    Private Function DajSumu() As Decimal
        Return nudCijena.Value * nudKolicina.Value
    End Function

    Private Sub nudCijena_ValueChanged(sender As Object, e As EventArgs) Handles nudCijena.ValueChanged
        Dim suma As Decimal = 0
        For Each c As Control In flpArtikli.Controls
            If TypeOf c Is ArtikalRacun Then
                suma += DirectCast(c, ArtikalRacun).DajSumu()
            End If
        Next
        lblUkupno.Text = Decimal.Round(suma, 2)
    End Sub
End Class
