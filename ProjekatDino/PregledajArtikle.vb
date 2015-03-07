Public Class PregledajArtikle
    Private artikli As List(Of Artikal)

    Public Sub New(ByRef artikli As List(Of Artikal))
        InitializeComponent()
        Me.artikli = artikli
        dgwArtikli.Columns.Add("", "Šifra")
        dgwArtikli.Columns.Add("", "Ime")
        dgwArtikli.Columns.Add("", "Cijena")
        dgwArtikli.Columns.Add("", "Porezna stopa")
        Dim check As New DataGridViewCheckBoxColumn
        dgwArtikli.Columns.Add(check)
        dgwArtikli.Columns(0).Width = 40
        dgwArtikli.Columns(1).Width = 125
        dgwArtikli.Columns(2).Width = 70
        dgwArtikli.Columns(3).Width = 90
        dgwArtikli.Columns(4).Width = 40
        dgwArtikli.Columns(0).ReadOnly = True
        dgwArtikli.Columns(1).ReadOnly = True
        dgwArtikli.Columns(2).ReadOnly = True
        dgwArtikli.Columns(3).ReadOnly = True
        For Each a As Artikal In artikli
            dgwArtikli.Rows.Add(a.sifra, a.ime, a.cijena, a.poreznaStopa)
        Next
        dgwArtikli.AllowUserToAddRows = False
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        Me.Close()
    End Sub

    Private Sub btnObrisiOznacene_Click(sender As Object, e As EventArgs) Handles btnObrisiOznacene.Click
        For i As Integer = dgwArtikli.Rows.Count - 1 To 0 Step -1
            If dgwArtikli.Rows(i).Cells(4).Value = True Then
                artikli.RemoveAt(i)
                dgwArtikli.Rows.RemoveAt(i)
                If i <> dgwArtikli.Rows.Count Then
                    i += 1
                End If
            End If
        Next
        Prepisi()
    End Sub

    Private Sub btnPromjeniOznacene_Click(sender As Object, e As EventArgs) Handles btnPromjeniOznacene.Click
        For i As Integer = dgwArtikli.Rows.Count - 1 To 0 Step -1
            If dgwArtikli.Rows(i).Cells(4).Value = True Then
                Dim forma As PromjeniArtikal
                forma = New PromjeniArtikal(artikli, i)
                If forma.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    dgwArtikli.Rows.RemoveAt(i)
                    dgwArtikli.Rows.Add(artikli(artikli.Count - 1).sifra, artikli(artikli.Count - 1).ime, artikli(artikli.Count - 1).cijena, artikli(artikli.Count - 1).poreznaStopa)
                    i += 1
                End If
            End If
        Next
        Prepisi()
    End Sub

    Private Sub Prepisi()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(AppDomain.CurrentDomain.BaseDirectory + "artikli.txt", False)
        Dim tekst As String = ""
        For Each a In artikli
            tekst += a.sifra.ToString() + "|" + a.ime + "|" + a.cijena.ToString() + "|" + a.poreznaStopa.ToString() + "|" + vbNewLine
        Next
        file.Write(tekst)
        file.Close()
    End Sub
End Class