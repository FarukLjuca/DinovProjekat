Imports System.Drawing.Printing

Public Class NapraviRacun
    Private artikli As List(Of Artikal)
    Private kupci As List(Of Kupac)
    Private printDocument1 As New PrintDocument()
    Private stringToPrint As String = "Dino je car"

    Public Sub New(ByVal kupci As List(Of Kupac), ByVal artikli As List(Of Artikal))
        InitializeComponent()
        Me.kupci = kupci
        Me.artikli = artikli
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        Me.Close()
    End Sub

    Private Sub NapraviRacun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each k As Kupac In kupci
            cbbSifre.Items.Add(k.sifra)
            cbbImenaIPrezimena.Items.Add(k.ime + " " + k.prezime)
        Next
        flpArtikli.Controls.Add(New HeaderRacun())
        flpArtikli.Controls.Add(New DodajRacun(flpArtikli, artikli, lblUkupno))

        Dim pkInstalledPrinters As String
        For Each pkInstalledPrinters In PrinterSettings.InstalledPrinters
            cbbPrinter.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters
        cbbPrinter.SelectedIndex = 0

    End Sub

    Private Sub cbbSifre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSifre.SelectedIndexChanged
        cbbImenaIPrezimena.SelectedIndex = cbbSifre.SelectedIndex
        lblPodaci.Text = kupci(cbbSifre.SelectedIndex).ToString()
    End Sub

    Private Sub cbbImenaIPrezimena_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbImenaIPrezimena.SelectedIndexChanged
        cbbSifre.SelectedIndex = cbbImenaIPrezimena.SelectedIndex
        lblPodaci.Text = kupci(cbbImenaIPrezimena.SelectedIndex).ToString()
    End Sub

    Private Sub btnPregledajKupce_Click(sender As Object, e As EventArgs) Handles btnPregledajKupce.Click
        Dim forma As PregledajKupce
        forma = New PregledajKupce(kupci)
        forma.Show()
    End Sub

    Private Sub btnPrintaj_Click(sender As Object, e As EventArgs) Handles btnPrintaj.Click
        printDocument1.Print()
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim charactersOnPage As Integer = 0
        Dim linesPerPage As Integer = 0

        e.Graphics.MeasureString(stringToPrint, Me.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, charactersOnPage, linesPerPage)

        e.Graphics.DrawString(stringToPrint, Me.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)

        stringToPrint = stringToPrint.Substring(charactersOnPage)

        e.HasMorePages = stringToPrint.Length > 0

    End Sub

End Class