<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtikalRacun
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.cbbSifre = New System.Windows.Forms.ComboBox()
        Me.cbbImena = New System.Windows.Forms.ComboBox()
        Me.nudKolicina = New System.Windows.Forms.NumericUpDown()
        Me.nudCijena = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRedniBroj = New System.Windows.Forms.Label()
        CType(Me.nudKolicina,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudCijena,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'cbbSifre
        '
        Me.cbbSifre.FormattingEnabled = true
        Me.cbbSifre.Location = New System.Drawing.Point(37, 3)
        Me.cbbSifre.Name = "cbbSifre"
        Me.cbbSifre.Size = New System.Drawing.Size(61, 21)
        Me.cbbSifre.TabIndex = 0
        '
        'cbbImena
        '
        Me.cbbImena.FormattingEnabled = True
        Me.cbbImena.Location = New System.Drawing.Point(104, 3)
        Me.cbbImena.Name = "cbbImena"
        Me.cbbImena.Size = New System.Drawing.Size(94, 21)
        Me.cbbImena.TabIndex = 1
        '
        'nudKolicina
        '
        Me.nudKolicina.Location = New System.Drawing.Point(204, 3)
        Me.nudKolicina.Name = "nudKolicina"
        Me.nudKolicina.Size = New System.Drawing.Size(64, 20)
        Me.nudKolicina.TabIndex = 2
        '
        'nudCijena
        '
        Me.nudCijena.DecimalPlaces = 2
        Me.nudCijena.Location = New System.Drawing.Point(274, 4)
        Me.nudCijena.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudCijena.Name = "nudCijena"
        Me.nudCijena.Size = New System.Drawing.Size(68, 20)
        Me.nudCijena.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblRedniBroj)
        Me.Panel1.Controls.Add(Me.nudCijena)
        Me.Panel1.Controls.Add(Me.cbbSifre)
        Me.Panel1.Controls.Add(Me.nudKolicina)
        Me.Panel1.Controls.Add(Me.cbbImena)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 30)
        Me.Panel1.TabIndex = 4
        '
        'lblRedniBroj
        '
        Me.lblRedniBroj.Location = New System.Drawing.Point(3, 7)
        Me.lblRedniBroj.Name = "lblRedniBroj"
        Me.lblRedniBroj.Size = New System.Drawing.Size(28, 17)
        Me.lblRedniBroj.TabIndex = 4
        '
        'ArtikalRacun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ArtikalRacun"
        Me.Size = New System.Drawing.Size(345, 30)
        CType(Me.nudKolicina,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudCijena,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents cbbSifre As System.Windows.Forms.ComboBox
    Friend WithEvents cbbImena As System.Windows.Forms.ComboBox
    Friend WithEvents nudKolicina As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCijena As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblRedniBroj As System.Windows.Forms.Label

End Class
