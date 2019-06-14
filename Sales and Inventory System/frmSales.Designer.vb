<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCustomerNo = New System.Windows.Forms.TextBox()
        Me.dtpTransactionDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPaymentDue = New System.Windows.Forms.TextBox()
        Me.txtTotalPayment = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.payment = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDiscAmt = New System.Windows.Forms.TextBox()
        Me.txtTaxAmt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblCartons = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtLess = New System.Windows.Forms.TextBox()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtBatchno = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtExp = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtFree = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTaxPer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPacking = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtAvlUnits = New System.Windows.Forms.TextBox()
        Me.txtMRP = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtpayrec = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbInvType = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.LblItems = New System.Windows.Forms.Label()
        Me.txtCurrPay = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.grpAdj = New System.Windows.Forms.GroupBox()
        Me.btnRem = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpAdj.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.NewRecord)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Save)
        Me.Panel1.Location = New System.Drawing.Point(1033, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(127, 152)
        Me.Panel1.TabIndex = 10
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(3, 113)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(119, 34)
        Me.btnUpdate.TabIndex = 100
        Me.btnUpdate.Text = "&Update Payment"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'NewRecord
        '
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(14, 8)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(99, 29)
        Me.NewRecord.TabIndex = 0
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(14, 78)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(99, 29)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "&Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(14, 43)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(99, 29)
        Me.Save.TabIndex = 1
        Me.Save.Text = "&Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(354, 42)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 21)
        Me.Button4.TabIndex = 90
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(861, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 21)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.Location = New System.Drawing.Point(662, 81)
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.ReadOnly = True
        Me.txtCustomerNo.Size = New System.Drawing.Size(185, 20)
        Me.txtCustomerNo.TabIndex = 2
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpTransactionDate.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTransactionDate.Location = New System.Drawing.Point(151, 74)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.Size = New System.Drawing.Size(114, 24)
        Me.dtpTransactionDate.TabIndex = 1
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Enabled = False
        Me.txtInvoiceNo.Location = New System.Drawing.Point(151, 43)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(185, 20)
        Me.txtInvoiceNo.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Invoice Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Invoice No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(546, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(546, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Customer ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 22)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Billing"
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(914, 397)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(99, 29)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "&Print Invoice"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.txtPaymentDue)
        Me.Panel2.Controls.Add(Me.txtTotalPayment)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.payment)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txtDiscAmt)
        Me.Panel2.Controls.Add(Me.txtTaxAmt)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txtSubTotal)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(836, 202)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 189)
        Me.Panel2.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(166, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 17)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "Disc"
        '
        'txtPaymentDue
        '
        Me.txtPaymentDue.Location = New System.Drawing.Point(169, 150)
        Me.txtPaymentDue.Name = "txtPaymentDue"
        Me.txtPaymentDue.ReadOnly = True
        Me.txtPaymentDue.Size = New System.Drawing.Size(127, 20)
        Me.txtPaymentDue.TabIndex = 98
        Me.txtPaymentDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPayment
        '
        Me.txtTotalPayment.Location = New System.Drawing.Point(169, 116)
        Me.txtTotalPayment.Name = "txtTotalPayment"
        Me.txtTotalPayment.Size = New System.Drawing.Size(127, 20)
        Me.txtTotalPayment.TabIndex = 1
        Me.txtTotalPayment.Text = "0"
        Me.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 17)
        Me.Label19.TabIndex = 96
        Me.Label19.Text = "Payment Due"
        '
        'payment
        '
        Me.payment.AutoSize = True
        Me.payment.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment.Location = New System.Drawing.Point(20, 116)
        Me.payment.Name = "payment"
        Me.payment.Size = New System.Drawing.Size(89, 17)
        Me.payment.TabIndex = 95
        Me.payment.Text = "Total Payment"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(169, 82)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(129, 20)
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 17)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Grand Total"
        '
        'txtDiscAmt
        '
        Me.txtDiscAmt.Location = New System.Drawing.Point(203, 47)
        Me.txtDiscAmt.Name = "txtDiscAmt"
        Me.txtDiscAmt.ReadOnly = True
        Me.txtDiscAmt.Size = New System.Drawing.Size(97, 20)
        Me.txtDiscAmt.TabIndex = 2
        Me.txtDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaxAmt
        '
        Me.txtTaxAmt.Location = New System.Drawing.Point(57, 48)
        Me.txtTaxAmt.Name = "txtTaxAmt"
        Me.txtTaxAmt.ReadOnly = True
        Me.txtTaxAmt.Size = New System.Drawing.Size(83, 20)
        Me.txtTaxAmt.TabIndex = 0
        Me.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 17)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Tax"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(116, 14)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(184, 20)
        Me.txtSubTotal.TabIndex = 7
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 17)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Sub Total"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(662, 112)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(353, 20)
        Me.txtCustomerName.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ProductCode, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader8, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(14, 432)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1119, 227)
        Me.ListView1.TabIndex = 96
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ProductCode
        '
        Me.ProductCode.Text = "Product Code"
        Me.ProductCode.Width = 11
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Packing"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 126
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "BillQty"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 104
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Free"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 95
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Batch No."
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 4
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ExpDate"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 3
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MRP"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Rate"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 102
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Disc"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 68
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Tax"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 59
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Amount"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 134
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Stock ID"
        Me.ColumnHeader13.Width = 5
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(820, 397)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(86, 29)
        Me.btnRemove.TabIndex = 12
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(591, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 17)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Order No."
        '
        'Timer1
        '
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(662, 42)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.Size = New System.Drawing.Size(144, 20)
        Me.txtOrderNo.TabIndex = 1
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(851, 40)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 100
        Me.BtnSubmit.Text = "&Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(815, 42)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 21)
        Me.Button3.TabIndex = 101
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblCartons
        '
        Me.lblCartons.AutoSize = True
        Me.lblCartons.Location = New System.Drawing.Point(533, 177)
        Me.lblCartons.Name = "lblCartons"
        Me.lblCartons.Size = New System.Drawing.Size(43, 13)
        Me.lblCartons.TabIndex = 102
        Me.lblCartons.Text = "Cartons"
        Me.lblCartons.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtLess)
        Me.GroupBox1.Controls.Add(Me.txtStockID)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtBatchno)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtExp)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDisc)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox1.Controls.Add(Me.txtFree)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTaxPer)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtProductCode)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPacking)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtUnits)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtAvlUnits)
        Me.GroupBox1.Controls.Add(Me.txtMRP)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 234)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(465, 107)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 17)
        Me.Label30.TabIndex = 104
        Me.Label30.Text = "Less %"
        '
        'txtLess
        '
        Me.txtLess.AutoCompleteCustomSource.AddRange(New String() {"16.66", "16.49"})
        Me.txtLess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtLess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLess.Location = New System.Drawing.Point(524, 105)
        Me.txtLess.Name = "txtLess"
        Me.txtLess.Size = New System.Drawing.Size(90, 20)
        Me.txtLess.TabIndex = 103
        Me.txtLess.Text = "16.66"
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(493, 23)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.ReadOnly = True
        Me.txtStockID.Size = New System.Drawing.Size(122, 20)
        Me.txtStockID.TabIndex = 100
        Me.txtStockID.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(432, 25)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 17)
        Me.Label26.TabIndex = 101
        Me.Label26.Text = "Stock ID"
        '
        'txtBatchno
        '
        Me.txtBatchno.Location = New System.Drawing.Point(524, 81)
        Me.txtBatchno.Name = "txtBatchno"
        Me.txtBatchno.ReadOnly = True
        Me.txtBatchno.Size = New System.Drawing.Size(91, 20)
        Me.txtBatchno.TabIndex = 5
        Me.txtBatchno.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(462, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 17)
        Me.Label23.TabIndex = 99
        Me.Label23.Text = "Batch No."
        Me.Label23.Visible = False
        '
        'txtExp
        '
        Me.txtExp.Location = New System.Drawing.Point(159, 81)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.ReadOnly = True
        Me.txtExp.Size = New System.Drawing.Size(91, 20)
        Me.txtExp.TabIndex = 4
        Me.txtExp.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(64, 85)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 17)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "Expiry"
        Me.Label22.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(223, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 20)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "%"
        '
        'txtDisc
        '
        Me.txtDisc.Location = New System.Drawing.Point(159, 178)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(52, 20)
        Me.txtDisc.TabIndex = 11
        Me.txtDisc.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(47, 180)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 17)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "Discount"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(674, 141)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(94, 20)
        Me.txtTotalAmount.TabIndex = 93
        Me.txtTotalAmount.TabStop = False
        '
        'txtFree
        '
        Me.txtFree.Location = New System.Drawing.Point(344, 141)
        Me.txtFree.Name = "txtFree"
        Me.txtFree.Size = New System.Drawing.Size(89, 20)
        Me.txtFree.TabIndex = 9
        Me.txtFree.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(278, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 17)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "Free Unit"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(410, 177)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(23, 20)
        Me.Label24.TabIndex = 92
        Me.Label24.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 17)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Qty (Billed)"
        '
        'txtTaxPer
        '
        Me.txtTaxPer.Location = New System.Drawing.Point(346, 177)
        Me.txtTaxPer.Name = "txtTaxPer"
        Me.txtTaxPer.Size = New System.Drawing.Size(52, 20)
        Me.txtTaxPer.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 17)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Tax"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(678, 193)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 32)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "&Add To List"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Product Code"
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(159, 25)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(185, 20)
        Me.txtProductCode.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(159, 57)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(366, 20)
        Me.txtProductName.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(365, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 21)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(568, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 17)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Packing"
        '
        'txtPacking
        '
        Me.txtPacking.Location = New System.Drawing.Point(631, 57)
        Me.txtPacking.Name = "txtPacking"
        Me.txtPacking.ReadOnly = True
        Me.txtPacking.Size = New System.Drawing.Size(77, 20)
        Me.txtPacking.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(465, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 17)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Rate"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(159, 141)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(94, 20)
        Me.txtUnits.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Available Unit"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(525, 140)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(89, 20)
        Me.txtRate.TabIndex = 10
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(675, 121)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 17)
        Me.Label25.TabIndex = 76
        Me.Label25.Text = "Total Amount"
        '
        'txtAvlUnits
        '
        Me.txtAvlUnits.Location = New System.Drawing.Point(159, 104)
        Me.txtAvlUnits.Name = "txtAvlUnits"
        Me.txtAvlUnits.ReadOnly = True
        Me.txtAvlUnits.Size = New System.Drawing.Size(93, 20)
        Me.txtAvlUnits.TabIndex = 6
        '
        'txtMRP
        '
        Me.txtMRP.Location = New System.Drawing.Point(334, 105)
        Me.txtMRP.Name = "txtMRP"
        Me.txtMRP.ReadOnly = True
        Me.txtMRP.Size = New System.Drawing.Size(89, 20)
        Me.txtMRP.TabIndex = 7
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(281, 108)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 17)
        Me.Label27.TabIndex = 88
        Me.Label27.Text = "MRP"
        '
        'txtpayrec
        '
        Me.txtpayrec.Location = New System.Drawing.Point(149, 104)
        Me.txtpayrec.Multiline = True
        Me.txtpayrec.Name = "txtpayrec"
        Me.txtpayrec.ReadOnly = True
        Me.txtpayrec.Size = New System.Drawing.Size(361, 86)
        Me.txtpayrec.TabIndex = 108
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(35, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(101, 17)
        Me.Label28.TabIndex = 109
        Me.Label28.Text = "Payment History"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(279, 78)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 17)
        Me.Label29.TabIndex = 110
        Me.Label29.Text = "Invoice Type"
        '
        'cmbInvType
        '
        Me.cmbInvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvType.FormattingEnabled = True
        Me.cmbInvType.Items.AddRange(New Object() {"SALE", "TAX"})
        Me.cmbInvType.Location = New System.Drawing.Point(377, 76)
        Me.cmbInvType.Name = "cmbInvType"
        Me.cmbInvType.Size = New System.Drawing.Size(78, 21)
        Me.cmbInvType.TabIndex = 111
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.Label31.Location = New System.Drawing.Point(1036, 401)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 21)
        Me.Label31.TabIndex = 112
        Me.Label31.Text = "Items"
        '
        'LblItems
        '
        Me.LblItems.AutoSize = True
        Me.LblItems.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.LblItems.Location = New System.Drawing.Point(1085, 401)
        Me.LblItems.Name = "LblItems"
        Me.LblItems.Size = New System.Drawing.Size(22, 21)
        Me.LblItems.TabIndex = 113
        Me.LblItems.Text = "--"
        '
        'txtCurrPay
        '
        Me.txtCurrPay.Location = New System.Drawing.Point(914, 162)
        Me.txtCurrPay.Name = "txtCurrPay"
        Me.txtCurrPay.Size = New System.Drawing.Size(101, 20)
        Me.txtCurrPay.TabIndex = 114
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(772, 160)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(151, 20)
        Me.Label32.TabIndex = 115
        Me.Label32.Text = "Current Paymnet (+)"
        '
        'grpAdj
        '
        Me.grpAdj.Controls.Add(Me.btnRem)
        Me.grpAdj.Controls.Add(Me.btnAdd)
        Me.grpAdj.Enabled = False
        Me.grpAdj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAdj.Location = New System.Drawing.Point(1140, 488)
        Me.grpAdj.Name = "grpAdj"
        Me.grpAdj.Size = New System.Drawing.Size(82, 143)
        Me.grpAdj.TabIndex = 116
        Me.grpAdj.TabStop = False
        Me.grpAdj.Text = "Item Adjust"
        '
        'btnRem
        '
        Me.btnRem.Location = New System.Drawing.Point(7, 93)
        Me.btnRem.Name = "btnRem"
        Me.btnRem.Size = New System.Drawing.Size(69, 32)
        Me.btnRem.TabIndex = 1
        Me.btnRem.Text = "-"
        Me.btnRem.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(7, 54)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(69, 33)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmSales
        '
        Me.AcceptButton = Me.Button7
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(1269, 669)
        Me.Controls.Add(Me.grpAdj)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtCurrPay)
        Me.Controls.Add(Me.LblItems)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cmbInvType)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtpayrec)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCartons)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.dtpTransactionDate)
        Me.Controls.Add(Me.txtCustomerNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpAdj.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDiscAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProductCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPaymentDue As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents payment As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblCartons As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStockID As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtBatchno As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtExp As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtFree As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTaxPer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPacking As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtAvlUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtMRP As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtpayrec As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbInvType As System.Windows.Forms.ComboBox
    Friend WithEvents txtLess As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents LblItems As System.Windows.Forms.Label
    Friend WithEvents txtCurrPay As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents grpAdj As System.Windows.Forms.GroupBox
    Friend WithEvents btnRem As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
