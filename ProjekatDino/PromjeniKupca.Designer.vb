<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromjeniKupca
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromjeniKupca))
        Me.pnlDodajKupca = New System.Windows.Forms.Panel()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.btnPromjeni = New System.Windows.Forms.Button()
        Me.gbxDodajKupca = New System.Windows.Forms.GroupBox()
        Me.tbxPostanskiBroj = New System.Windows.Forms.TextBox()
        Me.tbxMaticniBroj = New System.Windows.Forms.TextBox()
        Me.tbxMjesto = New System.Windows.Forms.TextBox()
        Me.tbxAdresa = New System.Windows.Forms.TextBox()
        Me.tbxPrezime = New System.Windows.Forms.TextBox()
        Me.tbxIme = New System.Windows.Forms.TextBox()
        Me.tbxSifra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlDodajKupca.SuspendLayout
        Me.gbxDodajKupca.SuspendLayout
        CType(Me.epError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pnlDodajKupca
        '
        Me.pnlDodajKupca.Controls.Add(Me.btnIzlaz)
        Me.pnlDodajKupca.Controls.Add(Me.btnPromjeni)
        Me.pnlDodajKupca.Controls.Add(Me.gbxDodajKupca)
        Me.pnlDodajKupca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDodajKupca.Location = New System.Drawing.Point(0, 0)
        Me.pnlDodajKupca.Name = "pnlDodajKupca"
        Me.pnlDodajKupca.Size = New System.Drawing.Size(304, 282)
        Me.pnlDodajKupca.TabIndex = 1
        '
        'btnIzlaz
        '
        Me.btnIzlaz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIzlaz.Location = New System.Drawing.Point(217, 247)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(75, 23)
        Me.btnIzlaz.TabIndex = 2
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = True
        '
        'btnPromjeni
        '
        Me.btnPromjeni.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPromjeni.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnPromjeni.Location = New System.Drawing.Point(136, 247)
        Me.btnPromjeni.Name = "btnPromjeni"
        Me.btnPromjeni.Size = New System.Drawing.Size(75, 23)
        Me.btnPromjeni.TabIndex = 1
        Me.btnPromjeni.Text = "Promjeni"
        Me.btnPromjeni.UseVisualStyleBackColor = True
        '
        'gbxDodajKupca
        '
        Me.gbxDodajKupca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDodajKupca.Controls.Add(Me.tbxPostanskiBroj)
        Me.gbxDodajKupca.Controls.Add(Me.tbxMaticniBroj)
        Me.gbxDodajKupca.Controls.Add(Me.tbxMjesto)
        Me.gbxDodajKupca.Controls.Add(Me.tbxAdresa)
        Me.gbxDodajKupca.Controls.Add(Me.tbxPrezime)
        Me.gbxDodajKupca.Controls.Add(Me.tbxIme)
        Me.gbxDodajKupca.Controls.Add(Me.tbxSifra)
        Me.gbxDodajKupca.Controls.Add(Me.Label7)
        Me.gbxDodajKupca.Controls.Add(Me.Label6)
        Me.gbxDodajKupca.Controls.Add(Me.Label5)
        Me.gbxDodajKupca.Controls.Add(Me.Label4)
        Me.gbxDodajKupca.Controls.Add(Me.Label3)
        Me.gbxDodajKupca.Controls.Add(Me.Label2)
        Me.gbxDodajKupca.Controls.Add(Me.Label1)
        Me.gbxDodajKupca.Location = New System.Drawing.Point(12, 12)
        Me.gbxDodajKupca.Name = "gbxDodajKupca"
        Me.gbxDodajKupca.Size = New System.Drawing.Size(280, 229)
        Me.gbxDodajKupca.TabIndex = 0
        Me.gbxDodajKupca.TabStop = False
        Me.gbxDodajKupca.Text = "Promjenite podatke o kupcu:"
        '
        'tbxPostanskiBroj
        '
        Me.tbxPostanskiBroj.Location = New System.Drawing.Point(93, 187)
        Me.tbxPostanskiBroj.Name = "tbxPostanskiBroj"
        Me.tbxPostanskiBroj.Size = New System.Drawing.Size(160, 20)
        Me.tbxPostanskiBroj.TabIndex = 16
        '
        'tbxMaticniBroj
        '
        Me.tbxMaticniBroj.Location = New System.Drawing.Point(93, 161)
        Me.tbxMaticniBroj.Name = "tbxMaticniBroj"
        Me.tbxMaticniBroj.Size = New System.Drawing.Size(160, 20)
        Me.tbxMaticniBroj.TabIndex = 15
        '
        'tbxMjesto
        '
        Me.tbxMjesto.Location = New System.Drawing.Point(93, 135)
        Me.tbxMjesto.Name = "tbxMjesto"
        Me.tbxMjesto.Size = New System.Drawing.Size(160, 20)
        Me.tbxMjesto.TabIndex = 14
        '
        'tbxAdresa
        '
        Me.tbxAdresa.Location = New System.Drawing.Point(93, 109)
        Me.tbxAdresa.Name = "tbxAdresa"
        Me.tbxAdresa.Size = New System.Drawing.Size(160, 20)
        Me.tbxAdresa.TabIndex = 13
        '
        'tbxPrezime
        '
        Me.tbxPrezime.Location = New System.Drawing.Point(93, 83)
        Me.tbxPrezime.Name = "tbxPrezime"
        Me.tbxPrezime.Size = New System.Drawing.Size(160, 20)
        Me.tbxPrezime.TabIndex = 12
        '
        'tbxIme
        '
        Me.tbxIme.Location = New System.Drawing.Point(93, 57)
        Me.tbxIme.Name = "tbxIme"
        Me.tbxIme.Size = New System.Drawing.Size(160, 20)
        Me.tbxIme.TabIndex = 11
        '
        'tbxSifra
        '
        Me.tbxSifra.Location = New System.Drawing.Point(93, 31)
        Me.tbxSifra.Name = "tbxSifra"
        Me.tbxSifra.Size = New System.Drawing.Size(160, 20)
        Me.tbxSifra.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Poštanski broj:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Matični broj:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Mjesto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Adresa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Prezime:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ime:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Šifra:"
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'PromjeniKupca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 282)
        Me.Controls.Add(Me.pnlDodajKupca)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "PromjeniKupca"
        Me.Text = "Promjeni kupca"
        Me.pnlDodajKupca.ResumeLayout(false)
        Me.gbxDodajKupca.ResumeLayout(false)
        Me.gbxDodajKupca.PerformLayout
        CType(Me.epError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents pnlDodajKupca As System.Windows.Forms.Panel
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents btnPromjeni As System.Windows.Forms.Button
    Friend WithEvents gbxDodajKupca As System.Windows.Forms.GroupBox
    Friend WithEvents tbxPostanskiBroj As System.Windows.Forms.TextBox
    Friend WithEvents tbxMaticniBroj As System.Windows.Forms.TextBox
    Friend WithEvents tbxMjesto As System.Windows.Forms.TextBox
    Friend WithEvents tbxAdresa As System.Windows.Forms.TextBox
    Friend WithEvents tbxPrezime As System.Windows.Forms.TextBox
    Friend WithEvents tbxIme As System.Windows.Forms.TextBox
    Friend WithEvents tbxSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
End Class
