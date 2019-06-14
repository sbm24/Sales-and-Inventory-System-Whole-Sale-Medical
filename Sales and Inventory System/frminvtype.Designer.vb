<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminvtype
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sale = New System.Windows.Forms.Button()
        Me.Tax = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale Invoice or Tax Invoice ?"
        '
        'Sale
        '
        Me.Sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sale.Location = New System.Drawing.Point(52, 90)
        Me.Sale.Name = "Sale"
        Me.Sale.Size = New System.Drawing.Size(93, 41)
        Me.Sale.TabIndex = 1
        Me.Sale.Text = "Sale"
        Me.Sale.UseVisualStyleBackColor = True
        '
        'Tax
        '
        Me.Tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tax.Location = New System.Drawing.Point(160, 90)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(85, 41)
        Me.Tax.TabIndex = 2
        Me.Tax.Text = "Tax"
        Me.Tax.UseVisualStyleBackColor = True
        '
        'frminvtype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 170)
        Me.Controls.Add(Me.Tax)
        Me.Controls.Add(Me.Sale)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frminvtype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sale or Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Sale As System.Windows.Forms.Button
    Friend WithEvents Tax As System.Windows.Forms.Button
End Class
