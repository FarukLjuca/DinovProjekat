Public Class Kupac
    Public sifra As Integer
    Public ime As String
    Public prezime As String
    Public adresa As String
    Public mjesto As String
    Public maticniBroj As String
    Public postanskiBroj As Integer

    Public Sub New(ByVal sifra As Integer, ByVal ime As String, ByVal prezime As String, ByVal adresa As String, ByVal mjesto As String, ByVal maticniBroj As String, ByVal postanskiBroj As Integer)
        Me.sifra = sifra
        Me.ime = ime
        Me.prezime = prezime
        Me.adresa = adresa
        Me.mjesto = mjesto
        Me.maticniBroj = maticniBroj
        Me.postanskiBroj = postanskiBroj
    End Sub

    Public Overrides Function ToString() As String
        Return "Šifra: " + sifra.ToString() + vbNewLine + "Ime i prezime: " + ime + " " + prezime + vbNewLine + "Adresa: " + adresa + vbNewLine + "Mjesto: " + mjesto + vbNewLine + "Matični broj: " + maticniBroj + vbNewLine + "Poštanski broj: " + postanskiBroj.ToString()
    End Function
End Class
