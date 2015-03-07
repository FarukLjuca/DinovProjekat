<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IzlazToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KupciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PregledajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PregledajToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RačunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KreirajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.KupciToolStripMenuItem, Me.ArtikliToolStripMenuItem, Me.RačunToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IzlazToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'IzlazToolStripMenuItem
        '
        Me.IzlazToolStripMenuItem.Name = "IzlazToolStripMenuItem"
        Me.IzlazToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.IzlazToolStripMenuItem.Text = "Izlaz"
        '
        'KupciToolStripMenuItem
        '
        Me.KupciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajToolStripMenuItem, Me.PregledajToolStripMenuItem})
        Me.KupciToolStripMenuItem.Name = "KupciToolStripMenuItem"
        Me.KupciToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.KupciToolStripMenuItem.Text = "Kupci"
        '
        'DodajToolStripMenuItem
        '
        Me.DodajToolStripMenuItem.Name = "DodajToolStripMenuItem"
        Me.DodajToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DodajToolStripMenuItem.Text = "Dodaj"
        '
        'PregledajToolStripMenuItem
        '
        Me.PregledajToolStripMenuItem.Name = "PregledajToolStripMenuItem"
        Me.PregledajToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PregledajToolStripMenuItem.Text = "Pregledaj"
        '
        'ArtikliToolStripMenuItem
        '
        Me.ArtikliToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajToolStripMenuItem1, Me.PregledajToolStripMenuItem1})
        Me.ArtikliToolStripMenuItem.Name = "ArtikliToolStripMenuItem"
        Me.ArtikliToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ArtikliToolStripMenuItem.Text = "Artikli"
        '
        'DodajToolStripMenuItem1
        '
        Me.DodajToolStripMenuItem1.Name = "DodajToolStripMenuItem1"
        Me.DodajToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DodajToolStripMenuItem1.Text = "Dodaj"
        '
        'PregledajToolStripMenuItem1
        '
        Me.PregledajToolStripMenuItem1.Name = "PregledajToolStripMenuItem1"
        Me.PregledajToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PregledajToolStripMenuItem1.Text = "Pregledaj"
        '
        'RačunToolStripMenuItem
        '
        Me.RačunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KreirajToolStripMenuItem})
        Me.RačunToolStripMenuItem.Name = "RačunToolStripMenuItem"
        Me.RačunToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.RačunToolStripMenuItem.Text = "Račun"
        '
        'KreirajToolStripMenuItem
        '
        Me.KreirajToolStripMenuItem.Name = "KreirajToolStripMenuItem"
        Me.KreirajToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KreirajToolStripMenuItem.Text = "Kreiraj"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program verzija 1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IzlazToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KupciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DodajToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PregledajToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DodajToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PregledajToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RačunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KreirajToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
