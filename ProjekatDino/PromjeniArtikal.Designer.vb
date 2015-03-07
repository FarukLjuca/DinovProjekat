<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromjeniArtikal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromjeniArtikal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPromjeni = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudPoreznaStopa = New System.Windows.Forms.NumericUpDown()
        Me.nudCijena = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxIme = New System.Windows.Forms.TextBox()
        Me.tbxSifra = New System.Windows.Forms.TextBox()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudPoreznaStopa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCijena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPromjeni)
        Me.Panel1.Controls.Add(Me.btnIzlaz)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 262)
        Me.Panel1.TabIndex = 1
        '
        'btnPromjeni
        '
        Me.btnPromjeni.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPromjeni.Location = New System.Drawing.Point(117, 227)
        Me.btnPromjeni.Name = "btnPromjeni"
        Me.btnPromjeni.Size = New System.Drawing.Size(75, 23)
        Me.btnPromjeni.TabIndex = 2
        Me.btnPromjeni.Text = "Promjeni"
        Me.btnPromjeni.UseVisualStyleBackColor = True
        '
        'btnIzlaz
        '
        Me.btnIzlaz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIzlaz.Location = New System.Drawing.Point(197, 227)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(75, 23)
        Me.btnIzlaz.TabIndex = 1
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nudPoreznaStopa)
        Me.GroupBox1.Controls.Add(Me.nudCijena)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbxIme)
        Me.GroupBox1.Controls.Add(Me.tbxSifra)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Promjenite podatke o artiklu:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "KM"
        '
        'nudPoreznaStopa
        '
        Me.nudPoreznaStopa.Location = New System.Drawing.Point(92, 109)
        Me.nudPoreznaStopa.Name = "nudPoreznaStopa"
        Me.nudPoreznaStopa.Size = New System.Drawing.Size(120, 20)
        Me.nudPoreznaStopa.TabIndex = 8
        '
        'nudCijena
        '
        Me.nudCijena.DecimalPlaces = 2
        Me.nudCijena.Location = New System.Drawing.Point(92, 83)
        Me.nudCijena.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCijena.Name = "nudCijena"
        Me.nudCijena.Size = New System.Drawing.Size(120, 20)
        Me.nudCijena.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ime:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cijena:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Porezna stopa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Šifra:"
        '
        'tbxIme
        '
        Me.tbxIme.Location = New System.Drawing.Point(92, 57)
        Me.tbxIme.Name = "tbxIme"
        Me.tbxIme.Size = New System.Drawing.Size(160, 20)
        Me.tbxIme.TabIndex = 1
        '
        'tbxSifra
        '
        Me.tbxSifra.Location = New System.Drawing.Point(92, 31)
        Me.tbxSifra.Name = "tbxSifra"
        Me.tbxSifra.Size = New System.Drawing.Size(160, 20)
        Me.tbxSifra.TabIndex = 0
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'PromjeniArtikal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PromjeniArtikal"
        Me.Text = "Promjeni artikal"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudPoreznaStopa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCijena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPromjeni As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudPoreznaStopa As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCijena As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxIme As System.Windows.Forms.TextBox
    Friend WithEvents tbxSifra As System.Windows.Forms.TextBox
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
End Class
