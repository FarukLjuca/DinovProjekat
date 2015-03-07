Public Class DodajArtikal
    Private artikli As List(Of Artikal)

    Public Sub New(ByRef artikli As List(Of Artikal))
        InitializeComponent()
        Me.artikli = artikli
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        Me.Close()
    End Sub

    Private Sub btnDodaj_Click(sender As Object, e As EventArgs) Handles btnDodaj.Click
        Dim greska As Boolean = False
        greska = Prazno(tbxSifra)
        greska = Prazno(tbxIme)

        If tbxSifra.Text = "0000" Or tbxSifra.Text.Length <> 4 Then
            epError.SetError(tbxSifra, "Šifra mora imati 4 cifre i ne smije biti 0.")
            greska = True
        End If

        If greska = False Then
            artikli.Add(New Artikal(Integer.Parse(tbxSifra.Text), tbxIme.Text, nudCijena.Value, nudPoreznaStopa.Value))
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function ValidirajSifru() As Boolean
        Dim greska As Boolean = False

        If tbxSifra.Text = "0000" Or tbxSifra.Text.Length <> 4 Then
            epError.SetError(tbxSifra, "Šifra mora imati 4 cifre i ne smije biti 0.")
            greska = True
        End If

        greska = Prazno(tbxSifra)

        Return greska
    End Function

    Private Function Prazno(ByRef textBox As TextBox) As Boolean
        If textBox.Text.Length = 0 Then
            epError.SetError(textBox, "Polje ne smije ostati prazno.")
            Return True
        End If
        Return False
    End Function
End Class