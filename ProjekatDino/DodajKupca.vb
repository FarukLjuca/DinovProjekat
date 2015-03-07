Public Class DodajKupca
    Private kupci As List(Of Kupac)

    Public Sub New(ByRef kupci As List(Of Kupac))
        InitializeComponent()
        Me.kupci = kupci
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        Me.Close()
    End Sub

    Private Sub btnDodaj_Click(sender As Object, e As EventArgs) Handles btnDodaj.Click
        Dim greska As Boolean = False
        Prazno(tbxSifra, greska)
        Prazno(tbxAdresa, greska)
        Prazno(tbxIme, greska)
        Prazno(tbxMaticniBroj, greska)
        Prazno(tbxMjesto, greska)
        Prazno(tbxPrezime, greska)

        If tbxSifra.Text = "0000" Or tbxSifra.Text.Length <> 4 Then
            epError.SetError(tbxSifra, "Šifra mora imati 4 cifre i ne smije biti 0.")
            greska = True
        End If

        If tbxMaticniBroj.Text.Length <> 13 And tbxMaticniBroj.Text.Length <> 14 Then
            epError.SetError(tbxMaticniBroj, "Matični broj mora biti dužine 13 (osobe) ili 14 (firme).")
            greska = True
        End If

        If greska = False Then
            kupci.Add(New Kupac(Integer.Parse(tbxSifra.Text), tbxIme.Text, tbxPrezime.Text, tbxAdresa.Text, tbxMjesto.Text, tbxMaticniBroj.Text, Integer.Parse(tbxPostanskiBroj.Text)))
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function Prazno(ByRef textBox As TextBox, ByRef greska As Boolean) As Boolean
        If textBox.Text.Length = 0 Then
            epError.SetError(textBox, "Polje ne smije ostati prazno.")
            greska = True
            Return True
        End If
        Return False
    End Function

    Private Sub tbxSifra_TextChanged(sender As Object, e As EventArgs) Handles tbxSifra.TextChanged
        epError.SetError(sender, "")
    End Sub

    Private Sub tbxIme_TextChanged(sender As Object, e As EventArgs) Handles tbxIme.TextChanged
        epError.SetError(sender, "")
    End Sub

    Private Sub tbxPrezime_TextChanged(sender As Object, e As EventArgs) Handles tbxPrezime.TextChanged
        epError.SetError(sender, "")
    End Sub

    Private Sub tbxAdresa_TextChanged(sender As Object, e As EventArgs) Handles tbxAdresa.TextChanged
        epError.SetError(sender, "")
    End Sub

    Private Sub tbxMjesto_TextChanged(sender As Object, e As EventArgs) Handles tbxMjesto.TextChanged
        epError.SetError(sender, "")
    End Sub

    Private Sub tbxMaticniBroj_TextChanged(sender As Object, e As EventArgs) Handles tbxMaticniBroj.TextChanged
        epError.SetError(sender, "")
    End Sub
End Class