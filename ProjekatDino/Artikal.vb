Public Class Artikal
    Public sifra As Integer
    Public ime As String
    Public cijena As Decimal
    Public poreznaStopa As Decimal

    Public Sub New(ByVal sifra As Integer, ByVal ime As String, ByVal cijena As Decimal, ByVal poreznaStopa As Decimal)
        Me.sifra = sifra
        Me.ime = ime
        Me.cijena = cijena
        Me.poreznaStopa = poreznaStopa
    End Sub
End Class
