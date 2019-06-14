<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.B_Address = New System.Windows.Forms.TextBox()
        Me.B_City = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCustomerNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update_Record = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.txtCdisc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Details"
        '
        'B_name
        '
        Me.B_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.B_name.Location = New System.Drawing.Point(173, 95)
        Me.B_name.Name = "B_name"
        Me.B_name.Size = New System.Drawing.Size(273, 20)
        Me.B_name.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "*Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "*Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "*City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Distributor ID"
        '
        'B_Address
        '
        Me.B_Address.Location = New System.Drawing.Point(173, 138)
        Me.B_Address.Name = "B_Address"
        Me.B_Address.Size = New System.Drawing.Size(273, 20)
        Me.B_Address.TabIndex = 1
        '
        'B_City
        '
        Me.B_City.Location = New System.Drawing.Point(173, 180)
        Me.B_City.Name = "B_City"
        Me.B_City.Size = New System.Drawing.Size(144, 20)
        Me.B_City.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(52, 270)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 17)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Email"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(359, 226)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 17)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Mobile No."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(550, 270)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 17)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Notes"
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.Location = New System.Drawing.Point(175, 56)
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.ReadOnly = True
        Me.txtCustomerNo.Size = New System.Drawing.Size(108, 20)
        Me.txtCustomerNo.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(173, 270)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 20)
        Me.txtEmail.TabIndex = 6
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(596, 240)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotes.Size = New System.Drawing.Size(231, 67)
        Me.txtNotes.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Delete)
        Me.GroupBox2.Controls.Add(Me.Update_Record)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Controls.Add(Me.NewRecord)
        Me.GroupBox2.Location = New System.Drawing.Point(680, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 178)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(16, 133)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(99, 29)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "&Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update_Record
        '
        Me.Update_Record.Enabled = False
        Me.Update_Record.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Record.Location = New System.Drawing.Point(16, 98)
        Me.Update_Record.Name = "Update_Record"
        Me.Update_Record.Size = New System.Drawing.Size(99, 29)
        Me.Update_Record.TabIndex = 1
        Me.Update_Record.Text = "&Update"
        Me.Update_Record.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(16, 63)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(99, 29)
        Me.Save.TabIndex = 0
        Me.Save.Text = "&Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'NewRecord
        '
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(16, 28)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(99, 29)
        Me.NewRecord.TabIndex = 2
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(301, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 21)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTin
        '
        Me.txtTin.Location = New System.Drawing.Point(449, 183)
        Me.txtTin.Name = "txtTin"
        Me.txtTin.Size = New System.Drawing.Size(144, 20)
        Me.txtTin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Tin No."
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(452, 224)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(126, 20)
        Me.txtMobileNo.TabIndex = 5
        '
        'txtCdisc
        '
        Me.txtCdisc.Location = New System.Drawing.Point(173, 225)
        Me.txtCdisc.Name = "txtCdisc"
        Me.txtCdisc.Size = New System.Drawing.Size(144, 20)
        Me.txtCdisc.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Default Disc %"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(523, 93)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 20)
        Me.RadioButton1.TabIndex = 57
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "SALE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(524, 122)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 20)
        Me.RadioButton2.TabIndex = 58
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "TAX"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AcceptButton = Me.Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(839, 319)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtCdisc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.txtTin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCustomerNo)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.B_City)
        Me.Controls.Add(Me.B_Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_name)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents B_Address As System.Windows.Forms.TextBox
    Friend WithEvents B_City As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Update_Record As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtTin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCdisc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
