<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NapraviRacun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NapraviRacun))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUkupno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.flpArtikli = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbbPrinter = New System.Windows.Forms.ComboBox()
        Me.btnPrintaj = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPregledajKupce = New System.Windows.Forms.Button()
        Me.lblPodaci = New System.Windows.Forms.Label()
        Me.cbbSifre = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbImenaIPrezimena = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblUkupno)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnPrintaj)
        Me.Panel1.Controls.Add(Me.btnIzlaz)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 562)
        Me.Panel1.TabIndex = 0
        '
        'lblUkupno
        '
        Me.lblUkupno.AutoSize = true
        Me.lblUkupno.ForeColor = System.Drawing.Color.Red
        Me.lblUkupno.Location = New System.Drawing.Point(325, 425)
        Me.lblUkupno.Name = "lblUkupno"
        Me.lblUkupno.Size = New System.Drawing.Size(28, 13)
        Me.lblUkupno.TabIndex = 7
        Me.lblUkupno.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(359, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "KM"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.flpArtikli)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 224)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Odaberite artikle:"
        '
        'flpArtikli
        '
        Me.flpArtikli.AutoScroll = true
        Me.flpArtikli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpArtikli.Location = New System.Drawing.Point(9, 19)
        Me.flpArtikli.Name = "flpArtikli"
        Me.flpArtikli.Size = New System.Drawing.Size(361, 199)
        Me.flpArtikli.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(253, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Ukupno:  "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbbPrinter)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 441)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 80)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Odaberite printer:"
        '
        'cbbPrinter
        '
        Me.cbbPrinter.FormattingEnabled = true
        Me.cbbPrinter.Location = New System.Drawing.Point(61, 30)
        Me.cbbPrinter.Name = "cbbPrinter"
        Me.cbbPrinter.Size = New System.Drawing.Size(218, 21)
        Me.cbbPrinter.TabIndex = 0
        '
        'btnPrintaj
        '
        Me.btnPrintaj.Location = New System.Drawing.Point(232, 527)
        Me.btnPrintaj.Name = "btnPrintaj"
        Me.btnPrintaj.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintaj.TabIndex = 2
        Me.btnPrintaj.Text = "Printaj"
        Me.btnPrintaj.UseVisualStyleBackColor = true
        '
        'btnIzlaz
        '
        Me.btnIzlaz.Location = New System.Drawing.Point(313, 527)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(75, 23)
        Me.btnIzlaz.TabIndex = 1
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPregledajKupce)
        Me.GroupBox1.Controls.Add(Me.lblPodaci)
        Me.GroupBox1.Controls.Add(Me.cbbSifre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbbImenaIPrezimena)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Odaberite kupca:"
        '
        'btnPregledajKupce
        '
        Me.btnPregledajKupce.Location = New System.Drawing.Point(9, 120)
        Me.btnPregledajKupce.Name = "btnPregledajKupce"
        Me.btnPregledajKupce.Size = New System.Drawing.Size(120, 23)
        Me.btnPregledajKupce.TabIndex = 1
        Me.btnPregledajKupce.Text = "Pregledaj kupce"
        Me.btnPregledajKupce.UseVisualStyleBackColor = true
        '
        'lblPodaci
        '
        Me.lblPodaci.Location = New System.Drawing.Point(201, 16)
        Me.lblPodaci.Name = "lblPodaci"
        Me.lblPodaci.Size = New System.Drawing.Size(153, 130)
        Me.lblPodaci.TabIndex = 4
        '
        'cbbSifre
        '
        Me.cbbSifre.FormattingEnabled = true
        Me.cbbSifre.Location = New System.Drawing.Point(83, 28)
        Me.cbbSifre.Name = "cbbSifre"
        Me.cbbSifre.Size = New System.Drawing.Size(112, 21)
        Me.cbbSifre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ime i prezime:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Šifra:"
        '
        'cbbImenaIPrezimena
        '
        Me.cbbImenaIPrezimena.FormattingEnabled = true
        Me.cbbImenaIPrezimena.Location = New System.Drawing.Point(83, 55)
        Me.cbbImenaIPrezimena.Name = "cbbImenaIPrezimena"
        Me.cbbImenaIPrezimena.Size = New System.Drawing.Size(112, 21)
        Me.cbbImenaIPrezimena.TabIndex = 0
        '
        'NapraviRacun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "NapraviRacun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Napravi racun"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrintaj As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents flpArtikli As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents lblPodaci As System.Windows.Forms.Label
    Friend WithEvents cbbSifre As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbImenaIPrezimena As System.Windows.Forms.ComboBox
    Friend WithEvents btnPregledajKupce As System.Windows.Forms.Button
    Friend WithEvents lblUkupno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
