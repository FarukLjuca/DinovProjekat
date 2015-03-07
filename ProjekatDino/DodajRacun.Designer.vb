<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DodajRacun
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
        Me.btnDodajArtikal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDodajArtikal
        '
        Me.btnDodajArtikal.Location = New System.Drawing.Point(112, 3)
        Me.btnDodajArtikal.Name = "btnDodajArtikal"
        Me.btnDodajArtikal.Size = New System.Drawing.Size(120, 23)
        Me.btnDodajArtikal.TabIndex = 0
        Me.btnDodajArtikal.Text = "Dodaj artikal"
        Me.btnDodajArtikal.UseVisualStyleBackColor = True
        '
        'DodajRacun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDodajArtikal)
        Me.Name = "DodajRacun"
        Me.Size = New System.Drawing.Size(345, 30)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDodajArtikal As System.Windows.Forms.Button

End Class
