Public Class PregledajKupce
    Private kupci As List(Of Kupac)

    Public Sub New(ByRef kupci As List(Of Kupac))
        InitializeComponent()
        Me.kupci = kupci
        dgwKupci.Columns.Add("", "Šifra")
        dgwKupci.Columns.Add("", "Ime")
        dgwKupci.Columns.Add("", "Prezime")
        dgwKupci.Columns.Add("", "Adresa")
        dgwKupci.Columns.Add("", "Mjesto")
        dgwKupci.Columns.Add("", "Matični broj")
        dgwKupci.Columns.Add("", "Poštanski broj")
        Dim check As New DataGridViewCheckBoxColumn
        dgwKupci.Columns.Add(check)
        dgwKupci.Columns(0).Width = 40
        dgwKupci.Columns(1).Width = 70
        dgwKupci.Columns(2).Width = 70
        dgwKupci.Columns(3).Width = 70
        dgwKupci.Columns(4).Width = 70
        dgwKupci.Columns(5).Width = 100
        dgwKupci.Columns(6).Width = 60
        dgwKupci.Columns(7).Width = 37
        dgwKupci.Columns(0).ReadOnly = True
        dgwKupci.Columns(1).ReadOnly = True
        dgwKupci.Columns(2).ReadOnly = True
        dgwKupci.Columns(3).ReadOnly = True
        dgwKupci.Columns(4).ReadOnly = True
        dgwKupci.Columns(5).ReadOnly = True
        dgwKupci.Columns(6).ReadOnly = True
        For Each k As Kupac In kupci
            dgwKupci.Rows.Add(k.sifra, k.ime, k.prezime, k.adresa, k.mjesto, k.maticniBroj, k.postanskiBroj)
        Next
        dgwKupci.AllowUserToAddRows = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = dgwKupci.Rows.Count - 1 To 0 Step -1
            If dgwKupci.Rows(i).Cells(7).Value = True Then
                kupci.RemoveAt(i)
                dgwKupci.Rows.RemoveAt(i)
                If i <> dgwKupci.Rows.Count Then
                    i += 1
                End If
            End If
        Next
        Prepisi()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = dgwKupci.Rows.Count - 1 To 0 Step -1
            If dgwKupci.Rows(i).Cells(7).Value = True Then
                Dim forma As PromjeniKupca
                forma = New PromjeniKupca(kupci, i)
                If forma.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    dgwKupci.Rows.RemoveAt(i)
                    dgwKupci.Rows.Add(kupci(kupci.Count - 1).sifra, kupci(kupci.Count - 1).ime, kupci(kupci.Count - 1).prezime, kupci(kupci.Count - 1).adresa, kupci(kupci.Count - 1).mjesto, kupci(kupci.Count - 1).maticniBroj, kupci(kupci.Count - 1).postanskiBroj)
                    i += 1
                End If
            End If
        Next
        Prepisi()
    End Sub

    Private Sub Prepisi()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(AppDomain.CurrentDomain.BaseDirectory + "kupci.txt", False)
        Dim tekst As String = ""
        For Each k In kupci
            tekst += k.sifra.ToString() + "|" + k.ime + "|" + k.prezime + "|" + k.adresa + "|" + k.mjesto + "|" + k.maticniBroj + "|" + k.postanskiBroj.ToString() + "|" + vbNewLine
        Next
        file.Write(tekst)
        file.Close()
    End Sub
End Class