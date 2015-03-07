Public Class Form1
    Private kupci As List(Of Kupac)
    Private artikli As List(Of Artikal)

    Private Sub IzlazToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IzlazToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DodajToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajToolStripMenuItem.Click
        Dim forma As DodajKupca
        forma = New DodajKupca(kupci)
        If forma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(AppDomain.CurrentDomain.BaseDirectory + "kupci.txt", True)
            Dim tekst As String = ""
            Dim k As Kupac = kupci(kupci.Count - 1)
            tekst += k.sifra.ToString() + "|" + k.ime + "|" + k.prezime + "|" + k.adresa + "|" + k.mjesto + "|" + k.maticniBroj + "|" + k.postanskiBroj.ToString() + "|" + vbNewLine
            file.Write(tekst)
            file.Close()
        End If
    End Sub


    Private Sub DodajToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DodajToolStripMenuItem1.Click
        Dim forma As DodajArtikal
        forma = New DodajArtikal(artikli)
        If forma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(AppDomain.CurrentDomain.BaseDirectory + "artikli.txt", True)
            Dim tekst As String = ""
            Dim a As Artikal = artikli(artikli.Count - 1)
            tekst += a.sifra.ToString() + "|" + a.ime + "|" + a.cijena.ToString() + "|" + a.poreznaStopa.ToString() + "|" + vbNewLine
            file.Write(tekst)
            file.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kupci = New List(Of Kupac)
        artikli = New List(Of Artikal)
        Dim tekst As String
        tekst = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "kupci.txt")
        Dim k As Kupac = Nothing
        Dim rijec, sifra, ime, prezime, adresa, mjesto, maticniBroj, postanskiBroj As String
        Dim brojac As Integer = 0
        rijec = ""
        sifra = ""
        ime = ""
        prezime = ""
        adresa = ""
        mjesto = ""
        maticniBroj = ""
        postanskiBroj = ""
        For Each c As Char In tekst
            If c = "|" Then
                If brojac = 0 Then
                    sifra = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 1 Then
                    ime = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 2 Then
                    prezime = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 3 Then
                    adresa = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 4 Then
                    mjesto = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 5 Then
                    maticniBroj = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 6 Then
                    postanskiBroj = rijec
                    rijec = ""
                    brojac = brojac + 1
                End If
            ElseIf brojac = 7 Then
                kupci.Add(New Kupac(Integer.Parse(sifra), ime, prezime, adresa, mjesto, maticniBroj, Integer.Parse(postanskiBroj)))
                rijec = ""
                brojac = 0
            ElseIf c <> vbNewLine Then
                rijec = rijec + c
            End If
        Next

        tekst = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "artikli.txt")
        Dim a As Artikal = Nothing
        Dim cijena, poreznaStopa As String
        brojac = 0
        rijec = ""
        sifra = ""
        ime = ""
        cijena = ""
        poreznaStopa = ""
        For Each c As Char In tekst
            If c = "|" Then
                If brojac = 0 Then
                    sifra = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 1 Then
                    ime = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 2 Then
                    cijena = rijec
                    rijec = ""
                    brojac = brojac + 1
                ElseIf brojac = 3 Then
                    poreznaStopa = rijec
                    rijec = ""
                    brojac = brojac + 1
                End If
            ElseIf brojac = 4 Then
                artikli.Add(New Artikal(Integer.Parse(sifra), ime, Decimal.Parse(cijena), Decimal.Parse(poreznaStopa)))
                rijec = ""
                brojac = 0
            ElseIf c <> vbNewLine Then
                rijec = rijec + c
            End If
        Next
    End Sub

    Private Sub PregledajToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PregledajToolStripMenuItem.Click
        Dim forma As PregledajKupce
        forma = New PregledajKupce(kupci)
        forma.Show()
    End Sub

    Private Sub PregledajToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PregledajToolStripMenuItem1.Click
        Dim forma As PregledajArtikle
        forma = New PregledajArtikle(artikli)
        forma.Show()
    End Sub

    Private Sub KreirajToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KreirajToolStripMenuItem.Click
        Dim forma As NapraviRacun
        forma = New NapraviRacun(kupci, artikli)
        forma.ShowDialog()
    End Sub
End Class
