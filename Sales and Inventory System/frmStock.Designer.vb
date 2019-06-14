<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbatch = New System.Windows.Forms.TextBox()
        Me.txtinvoiceno = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpExpDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStockDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtMRP = New System.Windows.Forms.TextBox()
        Me.txtCartons = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update_Record = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StockVal = New System.Windows.Forms.Label()
        Me.StockValue = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbatch)
        Me.GroupBox1.Controls.Add(Me.txtinvoiceno)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtStockID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpExpDate)
        Me.GroupBox1.Controls.Add(Me.dtpStockDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.txtMRP)
        Me.GroupBox1.Controls.Add(Me.txtCartons)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.txtProductCode)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1286, 170)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Details"
        '
        'txtbatch
        '
        Me.txtbatch.Location = New System.Drawing.Point(605, 118)
        Me.txtbatch.Name = "txtbatch"
        Me.txtbatch.Size = New System.Drawing.Size(91, 24)
        Me.txtbatch.TabIndex = 4
        Me.txtbatch.Text = "..."
        '
        'txtinvoiceno
        '
        Me.txtinvoiceno.Location = New System.Drawing.Point(111, 118)
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.Size = New System.Drawing.Size(91, 24)
        Me.txtinvoiceno.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Invoice No."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 25)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtStockID
        '
        Me.txtStockID.BackColor = System.Drawing.SystemColors.Control
        Me.txtStockID.Enabled = False
        Me.txtStockID.Location = New System.Drawing.Point(113, 23)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(189, 24)
        Me.txtStockID.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Stock ID"
        '
        'dtpExpDate
        '
        Me.dtpExpDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpDate.Location = New System.Drawing.Point(838, 119)
        Me.dtpExpDate.Name = "dtpExpDate"
        Me.dtpExpDate.Size = New System.Drawing.Size(108, 24)
        Me.dtpExpDate.TabIndex = 5
        Me.dtpExpDate.Value = New Date(2030, 1, 1, 0, 0, 0, 0)
        '
        'dtpStockDate
        '
        Me.dtpStockDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpStockDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStockDate.Location = New System.Drawing.Point(372, 119)
        Me.dtpStockDate.Name = "dtpStockDate"
        Me.dtpStockDate.Size = New System.Drawing.Size(108, 24)
        Me.dtpStockDate.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(776, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Exp Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Receive Date"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(821, 68)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(91, 24)
        Me.txtWeight.TabIndex = 10
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(1084, 120)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(108, 24)
        Me.txtRate.TabIndex = 6
        Me.txtRate.Text = "00.00"
        '
        'txtMRP
        '
        Me.txtMRP.Location = New System.Drawing.Point(1158, 67)
        Me.txtMRP.Name = "txtMRP"
        Me.txtMRP.Size = New System.Drawing.Size(91, 24)
        Me.txtMRP.TabIndex = 1
        '
        'txtCartons
        '
        Me.txtCartons.Location = New System.Drawing.Point(1015, 67)
        Me.txtCartons.Name = "txtCartons"
        Me.txtCartons.Size = New System.Drawing.Size(91, 24)
        Me.txtCartons.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(322, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 25)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(458, 70)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(300, 24)
        Me.txtProductName.TabIndex = 9
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(113, 68)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(189, 24)
        Me.txtProductCode.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(992, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 17)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Purchase Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1112, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "MRP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(538, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Batch No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(929, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "No. of Units"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(764, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Packing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 222)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1286, 435)
        Me.DataGridView1.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGray
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 22)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Stock Entry"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 22)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Current Stock"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Delete)
        Me.GroupBox2.Controls.Add(Me.Update_Record)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Controls.Add(Me.NewRecord)
        Me.GroupBox2.Location = New System.Drawing.Point(784, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 56)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(328, 15)
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
        Me.Update_Record.Location = New System.Drawing.Point(220, 15)
        Me.Update_Record.Name = "Update_Record"
        Me.Update_Record.Size = New System.Drawing.Size(99, 29)
        Me.Update_Record.TabIndex = 2
        Me.Update_Record.Text = "&Update"
        Me.Update_Record.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(113, 15)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(99, 29)
        Me.Save.TabIndex = 0
        Me.Save.Text = "&Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'NewRecord
        '
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(5, 15)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(99, 29)
        Me.NewRecord.TabIndex = 1
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1147, 539)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(5, 5)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "&c"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StockVal
        '
        Me.StockVal.AutoSize = True
        Me.StockVal.Location = New System.Drawing.Point(155, 17)
        Me.StockVal.Name = "StockVal"
        Me.StockVal.Size = New System.Drawing.Size(0, 13)
        Me.StockVal.TabIndex = 54
        '
        'StockValue
        '
        Me.StockValue.AutoSize = True
        Me.StockValue.Location = New System.Drawing.Point(252, 17)
        Me.StockValue.Name = "StockValue"
        Me.StockValue.Size = New System.Drawing.Size(0, 13)
        Me.StockValue.TabIndex = 55
        '
        'frmStock
        '
        Me.AcceptButton = Me.Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(1315, 661)
        Me.Controls.Add(Me.StockValue)
        Me.Controls.Add(Me.StockVal)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCartons As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtStockID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpStockDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Update_Record As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dtpExpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMRP As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtinvoiceno As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbatch As System.Windows.Forms.TextBox
    Friend WithEvents StockVal As System.Windows.Forms.Label
    Friend WithEvents StockValue As System.Windows.Forms.Label
End Class
