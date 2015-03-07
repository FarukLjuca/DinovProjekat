<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PregledajArtikle
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnObrisiOznacene = New System.Windows.Forms.Button()
        Me.btnPromjeniOznacene = New System.Windows.Forms.Button()
        Me.dgwArtikli = New System.Windows.Forms.DataGridView()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        CType(Me.dgwArtikli,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnObrisiOznacene)
        Me.Panel1.Controls.Add(Me.btnPromjeniOznacene)
        Me.Panel1.Controls.Add(Me.dgwArtikli)
        Me.Panel1.Controls.Add(Me.btnIzlaz)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 262)
        Me.Panel1.TabIndex = 1
        '
        'btnObrisiOznacene
        '
        Me.btnObrisiOznacene.Location = New System.Drawing.Point(148, 227)
        Me.btnObrisiOznacene.Name = "btnObrisiOznacene"
        Me.btnObrisiOznacene.Size = New System.Drawing.Size(130, 23)
        Me.btnObrisiOznacene.TabIndex = 3
        Me.btnObrisiOznacene.Text = "Obriši označene"
        Me.btnObrisiOznacene.UseVisualStyleBackColor = true
        '
        'btnPromjeniOznacene
        '
        Me.btnPromjeniOznacene.Location = New System.Drawing.Point(12, 227)
        Me.btnPromjeniOznacene.Name = "btnPromjeniOznacene"
        Me.btnPromjeniOznacene.Size = New System.Drawing.Size(130, 23)
        Me.btnPromjeniOznacene.TabIndex = 2
        Me.btnPromjeniOznacene.Text = "Promjeni označene"
        Me.btnPromjeniOznacene.UseVisualStyleBackColor = true
        '
        'dgwArtikli
        '
        Me.dgwArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwArtikli.Location = New System.Drawing.Point(12, 12)
        Me.dgwArtikli.Name = "dgwArtikli"
        Me.dgwArtikli.Size = New System.Drawing.Size(408, 209)
        Me.dgwArtikli.TabIndex = 1
        '
        'btnIzlaz
        '
        Me.btnIzlaz.Location = New System.Drawing.Point(345, 227)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(75, 23)
        Me.btnIzlaz.TabIndex = 0
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = true
        '
        'PregledajArtikle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PregledajArtikle"
        Me.Text = "PregledajArtikle"
        Me.Panel1.ResumeLayout(false)
        CType(Me.dgwArtikli,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnObrisiOznacene As System.Windows.Forms.Button
    Friend WithEvents btnPromjeniOznacene As System.Windows.Forms.Button
    Friend WithEvents dgwArtikli As System.Windows.Forms.DataGridView
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
End Class
