Public Class PromjeniArtikal
    Private artikli As List(Of Artikal)
    Private i As Integer
    Public Sub New(ByRef artikli As List(Of Artikal), ByVal i As Integer)
        InitializeComponent()
        Me.artikli = artikli
        Me.i = i
        tbxSifra.Text = artikli(i).sifra.ToString()
        tbxIme.Text = artikli(i).ime
        nudCijena.Value = artikli(i).cijena
        nudPoreznaStopa.Value = artikli(i).poreznaStopa
    End Sub

    Private Sub btnPromjeni_Click(sender As Object, e As EventArgs) Handles btnPromjeni.Click
        Dim greska As Boolean = False
        greska = Prazno(tbxSifra)
        greska = Prazno(tbxIme)

        If tbxSifra.Text = "0000" Or tbxSifra.Text.Length <> 4 Then
            epError.SetError(tbxSifra, "Šifra mora imati 4 cifre i ne smije biti 0.")
            greska = True
        End If

        If greska = False Then
            artikli.RemoveAt(i)
            artikli.Add(New Artikal(Integer.Parse(tbxSifra.Text), tbxIme.Text, nudCijena.Value, nudPoreznaStopa.Value))
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function Prazno(ByRef textBox As TextBox) As Boolean
        If textBox.Text.Length = 0 Then
            epError.SetError(textBox, "Polje ne smije ostati prazno.")
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

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        Me.Close()
    End Sub
End Class