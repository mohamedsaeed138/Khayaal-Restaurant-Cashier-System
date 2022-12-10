<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Licensing1 = New Guna.UI2.Licensing.Licensing()
        Me.SuspendLayout()
        '
        'Licensing1
        '
        Me.Licensing1.BackColor = System.Drawing.Color.White
        Me.Licensing1.Location = New System.Drawing.Point(0, 0)
        Me.Licensing1.MaximumSize = New System.Drawing.Size(348, 485)
        Me.Licensing1.MinimumSize = New System.Drawing.Size(348, 485)
        Me.Licensing1.Name = "Licensing1"
        Me.Licensing1.Size = New System.Drawing.Size(348, 485)
        Me.Licensing1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 485)
        Me.Controls.Add(Me.Licensing1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guna UI WinForms"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Licensing1 As Guna.UI2.Licensing.Licensing
End Class
