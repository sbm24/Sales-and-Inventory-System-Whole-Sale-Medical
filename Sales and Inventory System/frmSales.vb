Imports System.Data.OleDB
Imports System.Security.Cryptography
Imports System.Text

Public Class frmSales
    Dim rdr As OleDbDataReader = Nothing
    Dim rdri As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim coni As OleDbConnection = Nothing

    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim sSql As String

    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"
    Private Sub auto()
        If cmbInvType.Text = "TAX" Then

            con = New OleDbConnection(cs)

            con.Open()

            Dim ct As String = "select Max(InvoiceNo) as InvNo from BillInfo where InvoiceNo like 'T%'"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            rdr.Read()

            If rdr("InvNo").ToString() <> "" Then
                Dim exinv As String = New String((From c As Char In rdr("InvNo").ToString() Select c Where Char.IsDigit(c)).ToArray())
                txtInvoiceNo.Text = "T-" & (Integer.Parse(exinv) + 1).ToString("000000")
            Else
                txtInvoiceNo.Text = "T-" & "000001"
            End If
            con.Close()
            rdr.Close()

        ElseIf cmbInvType.Text = "SALE" Then

            con = New OleDbConnection(cs)

            con.Open()

            Dim ct As String = "select Max(InvoiceNo) as InvNo from BillInfo where InvoiceNo like 'S%'"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            rdr.Read()

            If rdr("InvNo").ToString() <> "" Then
                Dim exinv As String = New String((From c As Char In rdr("InvNo").ToString() Select c Where Char.IsDigit(c)).ToArray())
                txtInvoiceNo.Text = "S-" & (Integer.Parse(exinv) + 1).ToString("000000")
            Else
                txtInvoiceNo.Text = "S-" & "000001"
            End If
            con.Close()
            rdr.Close()



        End If

        '    con = New OleDbConnection(cs)

        '    con.Open()

        '    Dim ct As String = "select Max(InvoiceNo) as InvNo from BillInfo"

        '    cmd = New OleDbCommand(ct)
        '    cmd.Connection = con
        '    rdr = cmd.ExecuteReader()
        '    rdr.Read()

        '    If rdr("CatID").ToString() <> "" Then
        '        txtCategoryID.Text = Integer.Parse(rdr("CatID").ToString()) + 1
        '    Else
        '        txtCategoryID.Text = 1
        '    End If
        '    con.Close()
        '    rdr.Close()
        '    'txtInvoiceNo.Text = "INV-" & GetUniqueKey(8)

    End Sub
    'Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
    '    Dim chars As Char() = New Char(61) {}
    '    chars = "123456789".ToCharArray()
    '    Dim data As Byte() = New Byte(0) {}
    '    Dim crypto As New RNGCryptoServiceProvider()
    '    crypto.GetNonZeroBytes(data)
    '    data = New Byte(maxSize - 1) {}
    '    crypto.GetNonZeroBytes(data)
    '    Dim result As New StringBuilder(maxSize)
    '    For Each b As Byte In data
    '        result.Append(chars(b Mod (chars.Length)))
    '    Next
    '    Return result.ToString()
    'End Function

    Private Sub clearp()
        txtProductCode.Text = ""
        txtProductName.Text = ""
        txtUnits.Text = ""
        txtPacking.Text = ""
        txtRate.Text = ""
        txtAvlUnits.Text = ""
        txtMRP.Text = ""
        txtFree.Text = "0"
        txtTotalAmount.Text = "0"
        txtTaxPer.Text = ""
        txtExp.Text = ""
        'txtDisc.Text = "0" depends on customer
        txtBatchno.Text = ""
        txtStockID.Text = ""
    End Sub

    Sub clear()

        txtOrderNo.Text = ""
        clearo()

    End Sub
    Sub clearo()

        cmbInvType.SelectedItem = Nothing
        txtInvoiceNo.Text = ""
        txtCustomerNo.Text = ""
        txtCustomerName.Text = ""
        dtpTransactionDate.Text = Today
        txtProductCode.Text = ""
        txtProductName.Text = ""
        txtPacking.Text = ""
        txtBatchno.Text = ""
        txtStockID.Text = ""
        txtExp.Text = ""
        txtAvlUnits.Text = ""
        txtUnits.Text = ""
        txtRate.Text = ""
        txtMRP.Text = ""
        txtFree.Text = "0"
        txtTotalAmount.Text = "0"
        txtSubTotal.Text = ""
        txtTaxAmt.Text = ""
        txtTotal.Text = ""
        txtDiscAmt.Text = ""
        txtTotalPayment.Text = "0"
        txtPaymentDue.Text = ""
        txtpayrec.Text = ""
        txtCurrPay.Text = "0"
        LblItems.Text = "0"

    End Sub
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        clear()
        clearp()

        btnPrint.Enabled = False
        Save.Enabled = True
        Delete.Enabled = False
        btnUpdate.Enabled = False
        ListView1.Items.Clear()
        btnRemove.Enabled = False
        Button7.Enabled = True
        grpAdj.Enabled = False

    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        If Len(Trim(txtCustomerNo.Text)) = 0 Then
            MessageBox.Show("Select Customer id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCustomerNo.Focus()
            Exit Sub
        End If
        If Len(Trim(txtCustomerName.Text)) = 0 Then
            MessageBox.Show("Select Customer name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Button1.Focus()
            Exit Sub
        End If



        If Len(Trim(txtTotalPayment.Text)) = 0 Then
            MessageBox.Show("Please enter total payment", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTotalPayment.Focus()
            Exit Sub
        End If
        If ListView1.Items.Count = 0 Then
            MessageBox.Show("sorry no product added", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Len(Trim(cmbInvType.Text)) = 0 Then
            Me.Hide()
            frminvtype.ShowDialog()
        End If
        
        If cmbInvType.Text = "TAX" Then
            ''CHECK FOR CUSTOMERS TIN NO.
            Try
                Dim con As New OleDbConnection(cs)
                con.Open()
                Dim cmd As New OleDbCommand("SELECT TIN  from CUSTOMER where CUSTOMERNO ='" & txtCustomerNo.Text & "'", con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim ds As DataSet = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    If Len(Trim(ds.Tables(0).Rows(0).Item(0).ToString)) = 0 Then
                        MessageBox.Show("TIN no. for this customer not found. Save TIN in CUSTOMER form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Try
            For j = 0 To ListView1.Items.Count - 1
                Dim con As New OleDbConnection(cs)
                con.Open()
                Dim cmd As New OleDbCommand("SELECT units  from stock where stockid ='" & ListView1.Items(j).SubItems(13).Text & "'", con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim ds As DataSet = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    lblCartons.Text = ds.Tables(0).Rows(0)("Units")
                    If ((Val(ListView1.Items(j).SubItems(4).Text) + Val(ListView1.Items(j).SubItems(5).Text)) > Val(lblCartons.Text)) Then
                        MessageBox.Show("added quantity to cart are more than" & vbCrLf & "available quantity of product code '" & ListView1.Items(j).SubItems(1).Text & "' and Name = " & ListView1.Items(j).SubItems(2).Text & "' and stockid = " & ListView1.Items(j).SubItems(13).Text & "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Exit Sub
                End If
                End If
                con.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If txtInvoiceNo.Text = "" Then
            auto()
        ElseIf (cmbInvType.Text = "TAX") And (txtInvoiceNo.Text.StartsWith("S")) Then
            auto()
        ElseIf (cmbInvType.Text = "SALE") And (txtInvoiceNo.Text.StartsWith("T")) Then
            auto()
        End If


        con = New OleDbConnection(cs)
        con.Open()
        Dim ct As String = "select invoiceno from billinfo where invoiceno=@find"

        cmd = New OleDbCommand(ct)
        cmd.Connection = con
        cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "invoiceno"))
        cmd.Parameters("@find").Value = txtInvoiceNo.Text
        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Invoice No. Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If Not rdr Is Nothing Then
                rdr.Close()
            End If

        Else



            con = New OleDbConnection(cs)
            con.Open()

            Dim cb As String = "insert Into billinfo(InvoiceNo,BillingDate,CustomerNo,CustomerName,SubTotal,DiscAmount,TaxAmount,GrandTotal,TotalPayment,PaymentDue,OrderNo,Notes,Type) VALUES ('" & txtInvoiceNo.Text & "','" & dtpTransactionDate.Text & "','" & txtCustomerNo.Text & "','" & txtCustomerName.Text & "','" & CDec(txtSubTotal.Text) & "','" & CDbl(txtDiscAmt.Text) & "','" & CDec(txtTaxAmt.Text) & "','" & CDec(txtTotal.Text) & "','" & CDec(txtTotalPayment.Text) & "','" & CDec(txtPaymentDue.Text) & "','" & txtOrderNo.Text & "','" & CDec(txtTotalPayment.Text) & " on " & dtpTransactionDate.Text & "; ','" & cmbInvType.Text & "' )"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con


            cmd.ExecuteReader()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()

            For i = 0 To ListView1.Items.Count - 1

                con = New OleDbConnection(cs)

                Dim cd As String = "insert Into ProductSold(InvoiceNo,ProductCode,ProductName,packing,billQty,free,batchno,expdate,mrp,rate,disc,tax,amount,stockid) VALUES (@InvoiceNo,@ProductCode,@ProductName,@packing,@o5,@o6,@o7,@o8,@o9,@o10,@o11,@o12,@o13,@o14)"

                cmd = New OleDbCommand(cd)

                cmd.Connection = con



                cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text)
                cmd.Parameters.AddWithValue("ProductCode", ListView1.Items(i).SubItems(1).Text)
                cmd.Parameters.AddWithValue("ProductName", ListView1.Items(i).SubItems(2).Text)
                cmd.Parameters.AddWithValue("packing", ListView1.Items(i).SubItems(3).Text)
                cmd.Parameters.AddWithValue("o5", ListView1.Items(i).SubItems(4).Text)
                cmd.Parameters.AddWithValue("o6", ListView1.Items(i).SubItems(5).Text)
                cmd.Parameters.AddWithValue("o7", ListView1.Items(i).SubItems(6).Text)
                cmd.Parameters.AddWithValue("o8", ListView1.Items(i).SubItems(7).Text)
                cmd.Parameters.AddWithValue("o9", ListView1.Items(i).SubItems(8).Text)
                cmd.Parameters.AddWithValue("o10", ListView1.Items(i).SubItems(9).Text)
                cmd.Parameters.AddWithValue("o11", ListView1.Items(i).SubItems(10).Text)
                cmd.Parameters.AddWithValue("o12", ListView1.Items(i).SubItems(11).Text)
                cmd.Parameters.AddWithValue("o13", ListView1.Items(i).SubItems(12).Text)
                cmd.Parameters.AddWithValue("o14", ListView1.Items(i).SubItems(13).Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Next


            Try

                For i = 0 To ListView1.Items.Count - 1

                    con = New OleDbConnection(cs)
                    con.Open()

                    Dim cb1 As String = "update stock set Units = Units - " & Val(ListView1.Items(i).SubItems(4).Text) + Val(ListView1.Items(i).SubItems(5).Text) & "   where productcode= '" & ListView1.Items(i).SubItems(1).Text & "' and stockid = '" & ListView1.Items(i).SubItems(13).Text & "'"

                    cmd = New OleDbCommand(cb1)

                    cmd.Connection = con


                    cmd.ExecuteNonQuery()
                    con.Close()
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
           
            con = New OleDbConnection(cs)
            con.Open()

            Dim cb3 As String = "update orderinfo set orderstatus = 'Completed' where orderNo ='" & txtOrderNo.Text & "'"

            cmd = New OleDbCommand(cb3)

            cmd.Connection = con


            cmd.ExecuteReader()
            con.Close()
            Button7.Enabled = False
            btnRemove.Enabled = False
            Save.Enabled = False
            btnPrint.Enabled = True
            Delete.Enabled = True
            grpAdj.Enabled = True
            Button7.Enabled = False
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCustomersRecord.Show()
        txtCustomerName.Text = ""
        txtCustomerNo.Text = ""

    End Sub




    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Len(Trim(txtProductCode.Text)) = 0 Then
                MessageBox.Show("Please select product code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Button1.Focus()
                Exit Sub
            End If
            If Len(Trim(txtUnits.Text)) = 0 Then
                MessageBox.Show("Please enter Quantity of item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUnits.Focus()
                Exit Sub
            End If
            If Len(Trim(txtRate.Text)) = 0 Then
                MessageBox.Show("Please enter Rate", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRate.Focus()
                Exit Sub
            End If

            If Val(txtUnits.Text) <= 0 Then
                MessageBox.Show("Please enter Quantity of item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUnits.Focus()
                Exit Sub
            ElseIf Val(txtAvlUnits.Text) < Val(txtFree.Text) + Val(txtUnits.Text) Then
                MessageBox.Show("Quantity entered is more than Available in Stock", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAvlUnits.Focus()
                Exit Sub
            End If


            Dim temp As Integer
            temp = ListView1.Items.Count()
            If temp = 0 Then
                Dim i As Integer
                Dim lst As New ListViewItem(i)
                lst.SubItems.Add(txtProductCode.Text)
                lst.SubItems.Add(txtProductName.Text)
                lst.SubItems.Add(txtPacking.Text)
                lst.SubItems.Add(txtUnits.Text)
                lst.SubItems.Add(txtFree.Text)
                lst.SubItems.Add(txtBatchno.Text)
                lst.SubItems.Add(txtExp.Text)
                lst.SubItems.Add(txtMRP.Text)
                lst.SubItems.Add(txtRate.Text)
                lst.SubItems.Add(txtDisc.Text)
                lst.SubItems.Add(txtTaxPer.Text)
                lst.SubItems.Add(txtTotalAmount.Text)
                lst.SubItems.Add(txtStockID.Text)
                ListView1.Items.Add(lst)
                i = i + 1
                updatetotal()
                clearp()


                Exit Sub
            End If
            '' to update already entered entry
            For j = 0 To temp - 1
                If (ListView1.Items(j).SubItems(1).Text = txtProductCode.Text And ListView1.Items(j).SubItems(13).Text = txtStockID.Text) Then
                    ListView1.Items(j).SubItems(1).Text = txtProductCode.Text
                    ListView1.Items(j).SubItems(2).Text = txtProductName.Text
                    ListView1.Items(j).SubItems(3).Text = txtPacking.Text
                    ListView1.Items(j).SubItems(4).Text = txtUnits.Text
                    ListView1.Items(j).SubItems(5).Text = txtFree.Text
                    ListView1.Items(j).SubItems(6).Text = txtBatchno.Text
                    ListView1.Items(j).SubItems(7).Text = txtExp.Text
                    ListView1.Items(j).SubItems(8).Text = txtMRP.Text
                    ListView1.Items(j).SubItems(10).Text = txtRate.Text
                    ListView1.Items(j).SubItems(10).Text = txtDisc.Text
                    ListView1.Items(j).SubItems(11).Text = txtTaxPer.Text
                    ListView1.Items(j).SubItems(12).Text = txtTotalAmount.Text
                    ListView1.Items(j).SubItems(13).Text = txtStockID.Text

                    updatetotal()

                    clearp()
                    Exit Sub

                End If
            Next j
            Dim k As Integer
            Dim lst1 As New ListViewItem(k)

            lst1.SubItems.Add(txtProductCode.Text)
            lst1.SubItems.Add(txtProductName.Text)
            lst1.SubItems.Add(txtPacking.Text)
            lst1.SubItems.Add(txtUnits.Text)
            lst1.SubItems.Add(txtFree.Text)
            lst1.SubItems.Add(txtBatchno.Text)
            lst1.SubItems.Add(txtExp.Text)
            lst1.SubItems.Add(txtMRP.Text)
            lst1.SubItems.Add(txtRate.Text)
            lst1.SubItems.Add(txtDisc.Text)
            lst1.SubItems.Add(txtTaxPer.Text)
            lst1.SubItems.Add(txtTotalAmount.Text)
            lst1.SubItems.Add(txtStockID.Text)

            ListView1.Items.Add(lst1)
            k = k + 1
            updatetotal()

            clearp()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub updatetotal()

        Dim i, j As Integer
        Dim totamt, tottax, totdisc, grdamt As Double
        i = 0
        j = 0
        totamt = 0
        tottax = 0
        totdisc = 0

        Try
            j = ListView1.Items.Count
            For i = 0 To j - 1
                totamt = totamt + (CDbl(ListView1.Items(i).SubItems(9).Text) * CDbl(ListView1.Items(i).SubItems(4).Text))
                totdisc = totdisc + (CDbl(ListView1.Items(i).SubItems(9).Text) * CDbl(ListView1.Items(i).SubItems(4).Text) * (CDbl(ListView1.Items(i).SubItems(10).Text) / 100))
                tottax = tottax + (CDbl(ListView1.Items(i).SubItems(9).Text) * CDbl(ListView1.Items(i).SubItems(4).Text) * (1 - CDbl(ListView1.Items(i).SubItems(10).Text) / 100) * (CDbl(ListView1.Items(i).SubItems(11).Text) / 100))
                grdamt = grdamt + (CDbl(ListView1.Items(i).SubItems(12).Text))

            Next
            LblItems.Text = j
            txtSubTotal.Text = Format(totamt, "##0.00")
            txtDiscAmt.Text = Format(totdisc, "##0.00")
            txtTaxAmt.Text = Format(tottax, "##0.00")
            txtTotal.Text = Format(grdamt, "##0")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    

    



    'Public Function subtot() As Double

    '    Dim i, j, k As Integer
    '    i = 0
    '    j = 0
    '    k = 0

    '    Try
    '        j = ListView1.Items.Count
    '        For i = 0 To j - 1
    '            k = k + CDec(ListView1.Items(i).SubItems(8).Text)
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Return k

    'End Function

    Private Sub frmSales_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FrmMain.Show()
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try

            If ListView1.Items.Count = 0 Then
                MsgBox("No items to remove", MsgBoxStyle.Critical, "Error")
            Else
                For Each i As ListViewItem In ListView1.SelectedItems
                    ListView1.Items.Remove(i)
                Next

                updatetotal()

            End If

            btnRemove.Enabled = False
            If ListView1.Items.Count = 0 Then
                txtSubTotal.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCartons_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then

            e.Handled = True

        End If
    End Sub

    Private Sub updatelisting()
        Try

            txtTotalAmount.Text = Format((Val(txtUnits.Text) * (Val(txtRate.Text)) * (1 - (Val(txtDisc.Text) / 100)) * (1 + (Val(txtTaxPer.Text) / 100))), "##0.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtTaxPer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTaxAmt.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtTaxAmt.Text
            Dim selectionStart = Me.txtTaxAmt.SelectionStart
            Dim selectionLength = Me.txtTaxAmt.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an Integereger that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                'Reject a real number with two many decimal places.
                e.Handled = False
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    'Private Sub txtTaxAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaxAmt.TextChanged
    '    Try
    '        If txtTaxAmt.Text = "" Then
    '            txtDiscAmt.Text = ""
    '            txtTotal.Text = ""
    '            Exit Sub
    '        End If
    '        txtTotal.Text = Val(txtSubTotal.Text) - Val(txtDiscAmt.Text) + Val(txtTaxAmt.Text)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Cursor = Cursors.WaitCursor
        Timer1.Enabled = True
        frmBillingReport.Show()
    End Sub





    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click

        If MessageBox.Show("Do you really want to delete the record?", "Sales Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            delete_records()
        End If

        grpAdj.Enabled = False
        Button7.Enabled = True
    End Sub

    Private Sub delete_records()
        Dim stock_id As String
        
        Dim RowsAffected As Integer = 0

        'stockupdate


        For i = 0 To ListView1.Items.Count - 1
            'tryagain:
            Try
                con = New OleDbConnection(cs)
                con.Open()
                Dim ct As String = "select stockid from Stock where productcode= '" & ListView1.Items(i).SubItems(1).Text & " and MRP=" & ListView1.Items(i).SubItems(8).Text & "' "

                cmd = New OleDbCommand(ct)
                cmd.Connection = con
                
                rdr = cmd.ExecuteReader()

                If rdr.Read Then
                    stock_id = rdr.GetString(0)
                    If Not rdr Is Nothing Then
                        rdr.Close()
                    End If

                    con = New OleDbConnection(cs)
                    con.Open()

                    Dim cb1 As String = "update stock set Units = Units + " & Val(ListView1.Items(i).SubItems(4).Text) + Val(ListView1.Items(i).SubItems(5).Text) & "   where stockid = '" & stock_id & "'"

                    cmd = New OleDbCommand(cb1)

                    cmd.Connection = con


                    cmd.ExecuteNonQuery()
                    con.Close()
                Else
                    If Not rdr Is Nothing Then
                        rdr.Close()
                    End If

                    con = New OleDbConnection(cs)
                    con.Open()
                    '' todo
                    Dim cb1 As String = "insert into stock(StockID,invoiceno,productcode,productname,packing,units,stockdate,batchno,expdate,mrp,purrate) VALUES ('" & ListView1.Items(i).SubItems(13).Text & "','" & "FromDeletedBill" & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & CDec(Val(ListView1.Items(i).SubItems(4).Text) + Val(ListView1.Items(i).SubItems(5).Text)) & "','" & Now.Date & "','" & ListView1.Items(i).SubItems(6).Text & "','" & ListView1.Items(i).SubItems(7).Text & "','" & CDec(ListView1.Items(i).SubItems(8).Text) & "','0')"

                    cmd = New OleDbCommand(cb1)

                    cmd.Connection = con


                    cmd.ExecuteNonQuery()
                    con.Close()


                End If
            Catch ex As Exception
                'MessageBox.Show("Press OK to try again" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'GoTo tryagain
            End Try

        Next




        'change order status to uncompleted




        'delete from product sold
        Try

            con = New OleDbConnection(cs)

            con.Open()


            Dim cq1 As String = "delete from productsold where invoiceno=@DELETE1;"


            cmd = New OleDbCommand(cq1)

            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 20, "InvoiceNo"))


            cmd.Parameters("@DELETE1").Value = Trim(txtInvoiceNo.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)

            con.Open()

            'delete from bill info

            Dim cq As String = "delete from billinfo where invoiceno=@DELETE1;"


            cmd = New OleDbCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 20, "InvoiceNo"))


            cmd.Parameters("@DELETE1").Value = Trim(txtInvoiceNo.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Save.Enabled = True
                Delete.Enabled = False
                btnUpdate.Enabled = False
                btnPrint.Enabled = False
                btnRemove.Enabled = True
                Button7.Enabled = True
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Save.Enabled = True
                Delete.Enabled = False
                btnUpdate.Enabled = False
                btnPrint.Enabled = False
                btnRemove.Enabled = True
                Button7.Enabled = True



                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListView1.Items.Clear()
        Me.clear()
        frmSalesRecord1.fillCustomerName()
        frmSalesRecord1.fillInvoiceNo()
        frmSalesRecord1.DataGridView4.DataSource = Nothing
        frmSalesRecord1.cmbInvoiceNo.Text = ""
        frmSalesRecord1.GroupBox5.Visible = False
        frmSalesRecord1.DataGridView3.DataSource = Nothing
        frmSalesRecord1.cmbCustomerName.Text = ""
        frmSalesRecord1.GroupBox4.Visible = False
        frmSalesRecord1.DateTimePicker1.Text = Today
        frmSalesRecord1.DateTimePicker2.Text = Today
        frmSalesRecord1.DataGridView2.DataSource = Nothing
        frmSalesRecord1.GroupBox10.Visible = False
        frmSalesRecord1.DataGridView1.DataSource = Nothing
        frmSalesRecord1.dtpInvoiceDateFrom.Text = Today
        frmSalesRecord1.dtpInvoiceDateTo.Text = Today
        frmSalesRecord1.GroupBox3.Visible = False
        frmSalesRecord1.Show()
    End Sub




    'Public Sub FillList()
    '    'With ListView1
    '    '    .Clear()
    '    '    .Columns.Add("Column11", 0)
    '    '    .Columns.Add("Product Code", 90)
    '    '    .Columns.Add("Product Name", 250, HorizontalAlignment.Center)
    '    '    .Columns.Add("Weight/Qty", 90, HorizontalAlignment.Center)
    '    '    .Columns.Add("Unit Price", 80, HorizontalAlignment.Center)
    '    '    .Columns.Add("Cartons", 85, HorizontalAlignment.Center)
    '    '    .Columns.Add("Packets/Carton", 100, HorizontalAlignment.Center)
    '    '    .Columns.Add("Total packets", 90, HorizontalAlignment.Center)
    '    '    .Columns.Add("Total Amount", 92, HorizontalAlignment.Center)
    '    FillListView(ListView1, GetData(sSql))

    '    'End With
    'End Sub
    Public Function GetData(ByVal sSQL As String)

        Dim sqlCmd As OleDbCommand = New OleDbCommand(sSQL)
        Dim myData As OleDbDataReader

        con = New OleDbConnection(cs)

        Try
            con.Open()

            sqlCmd.Connection = con

            myData = sqlCmd.ExecuteReader

            Return myData
        Catch ex As Exception
            Return ex
        End Try
    End Function

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If (e.KeyCode.Equals(Keys.Delete)) Then
            btnRemove.PerformClick()
        End If
    End Sub


    'Sub tot()
    '    Dim dblTotal As Double = 0
    '    Dim dblTemp As Double

    '    For Each lvItem As ListViewItem In ListView1.Items
    '        If Double.TryParse(lvItem.SubItems(5).Text, dblTemp) Then
    '            dblTotal += dblTemp
    '        End If
    '    Next

    '    txtSubTotal.Text = dblTotal
    'End Sub




    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If Save.Enabled Then
            btnRemove.Enabled = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchProductsales.fillProductName()
        frmSearchProductsales.txtProductName.Text = ""
        frmSearchProductsales.cmbProductName.Text = ""
        frmSearchProductsales.DataGridView1.DataSource = Nothing
        frmSearchProductsales.DataGridView3.DataSource = Nothing
        frmSearchProductsales.Show()
    End Sub

    Private Sub txtTotalPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalPayment.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtTotalPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalPayment.TextChanged
        Try
            txtPaymentDue.Text = Format((Val(txtTotal.Text) - Val(txtTotalPayment.Text)), "##,##0")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtTotalPayment_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTotalPayment.Validating
        If Val(txtTotalPayment.Text) > Val(txtTotal.Text) Then
            MessageBox.Show("Total payment can not be more than grand total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTotalPayment.Text = ""
            txtTotalPayment.Focus()
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            txtTotalPayment.Text = Format((Val(txtTotalPayment.Text) + Val(txtCurrPay.Text)), "##,##0.00")
            con = New OleDbConnection(cs)
            con.Open()
            txtpayrec.Text = vbCr & txtpayrec.Text & txtTotalPayment.Text & " on " & Today & "; "
            Dim cb As String = "update billinfo set GrandTotal= '" & CDec(txtTotal.Text) & "',TotalPayment= '" & CDec(txtTotalPayment.Text) & "',PaymentDue= '" & CDec(txtPaymentDue.Text) & "', notes = '" & txtpayrec.Text & "' where Invoiceno= '" & txtInvoiceNo.Text & "'"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con

            cmd.ExecuteReader()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtCurrPay.Text = "0"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub

    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        cmbInvType.Text = ""
        Try
            If (txtOrderNo.Text = "") Then
                MessageBox.Show("Retrieve order no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Button3.Focus()
                Exit Sub
            End If

            ListView1.Items.Clear()

            sSql = "SELECT Orderno,ProductCode,ProductName,Packing,BillQty,Free,BatchNO,ExpDate,MRP,Rate,Disc,Tax,Amount,StockID from orderedProduct  where orderno = '" & txtOrderNo.Text & "'"

            FillListView(ListView1, GetData(sSql))
            con = New OleDbConnection(cs)

            con.Open()


            Dim ct As String = "select CustomerNo,CustomerName,subtotal,DiscAmount,TaxAmount,TotalAmount from orderinfo where orderno=@find"


            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "orderno"))
            cmd.Parameters("@find").Value = Trim(txtOrderNo.Text)
            rdr = cmd.ExecuteReader()

            clearo()


            If rdr.Read Then


                txtCustomerNo.Text = Trim(rdr.GetString(0))
                txtCustomerName.Text = Trim(rdr.GetString(1))
                txtSubTotal.Text = Trim(rdr.GetValue(2))   ' problem
                txtTaxAmt.Text = Trim(rdr.GetValue(4))
                txtDiscAmt.Text = Trim(rdr.GetValue(3))
                txtTotal.Text = Trim(rdr.GetValue(5))
                txtTotalPayment.Text = "0"
            End If


            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            LblItems.Text = ListView1.Items.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Button7.Enabled = True
        grpAdj.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmOrders.DateTimePicker1.Text = Today
        frmOrders.DateTimePicker2.Text = Today
        frmOrders.DataGridView1.DataSource = Nothing
        frmOrders.Show()
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        frmSearchProduct.txtProductName.Text = ""
        frmSearchProduct.cmbProductName.Text = ""
        frmSearchProduct.DataGridView1.DataSource = Nothing
        frmSearchProduct.cmbWeight.Text = ""
        frmSearchProduct.DataGridView3.DataSource = Nothing

        frmSearchProductsales.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtUnits_TextChanged(sender As Object, e As EventArgs) Handles txtUnits.TextChanged
        updatelisting()
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        updatelisting()

    End Sub

    Private Sub txtDisc_TextChanged(sender As Object, e As EventArgs) Handles txtDisc.TextChanged
        updatelisting()

    End Sub

    Private Sub txtTaxPer_TextChanged_1(sender As Object, e As EventArgs) Handles txtTaxPer.TextChanged
        updatelisting()

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Try

            If Val(txtUnits.Text) = 0 Then
                MessageBox.Show("Please enter NonZero Quantity of item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUnits.Focus()
                Exit Sub
            ElseIf Val(txtAvlUnits.Text) < Val(txtFree.Text) + Val(txtUnits.Text) Then
                MessageBox.Show("Quantity entered is more than Available in Stock", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAvlUnits.Focus()
                Exit Sub
            End If
            If Val(txtUnits.Text) < 0 Then
                If MsgBox("Quantity is negative, Do you want to proceed?", vbYesNo) = vbNo Then
                    txtUnits.Focus()
                    Exit Sub
                End If
            End If
            If Len(Trim(txtProductCode.Text)) = 0 Then
                MessageBox.Show("Please select product code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Button1.Focus()
                Exit Sub
            End If
            If Len(Trim(txtUnits.Text)) = 0 Then
                MessageBox.Show("Please enter Quantity of item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUnits.Focus()
                Exit Sub
            End If
            If Len(Trim(txtRate.Text)) = 0 Then
                MessageBox.Show("Please enter Rate", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRate.Focus()
                Exit Sub
            End If

            If Len(Trim(txtTaxPer.Text)) = 0 Then
                MessageBox.Show("Please enter Tax %", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRate.Focus()
                Exit Sub
            End If
            If Len(Trim(txtFree.Text)) = 0 Then
                txtFree.Text = "0"
                Exit Sub
            End If




            Dim temp As Integer
            temp = ListView1.Items.Count()
            If temp = 0 Then
                Dim i As Integer
                Dim lst As New ListViewItem(i)
                lst.SubItems.Add(txtProductCode.Text)
                lst.SubItems.Add(txtProductName.Text.ToUpper)
                lst.SubItems.Add(txtPacking.Text)
                lst.SubItems.Add(txtUnits.Text)
                lst.SubItems.Add(txtFree.Text)
                lst.SubItems.Add(txtBatchno.Text.ToUpper)
                lst.SubItems.Add(txtExp.Text)
                lst.SubItems.Add(txtMRP.Text)
                lst.SubItems.Add(txtRate.Text)
                lst.SubItems.Add(txtDisc.Text)
                lst.SubItems.Add(txtTaxPer.Text)
                lst.SubItems.Add(txtTotalAmount.Text)
                lst.SubItems.Add(txtStockID.Text)
                ListView1.Items.Add(lst)
                i = i + 1
                updatetotal()
                clearp()


                Exit Sub
            End If
            '' to update already entered entry
            For j = 0 To temp - 1
                If (ListView1.Items(j).SubItems(1).Text = txtProductCode.Text And ListView1.Items(j).SubItems(13).Text = txtStockID.Text) Then
                    'ListView1.Items(j).SubItems(1).Text = txtProductCode.Text
                    'ListView1.Items(j).SubItems(2).Text = txtProductName.Text.ToUpper
                    'ListView1.Items(j).SubItems(3).Text = txtPacking.Text
                    'ListView1.Items(j).SubItems(4).Text = txtUnits.Text
                    'ListView1.Items(j).SubItems(5).Text = txtFree.Text
                    'ListView1.Items(j).SubItems(6).Text = txtBatchno.Text.ToUpper
                    'ListView1.Items(j).SubItems(7).Text = txtExp.Text
                    'ListView1.Items(j).SubItems(8).Text = txtMRP.Text
                    'ListView1.Items(j).SubItems(10).Text = txtRate.Text
                    'ListView1.Items(j).SubItems(10).Text = txtDisc.Text
                    'ListView1.Items(j).SubItems(11).Text = txtTaxPer.Text
                    'ListView1.Items(j).SubItems(12).Text = txtTotalAmount.Text
                    'ListView1.Items(j).SubItems(13).Text = txtStockID.Text

                    'updatetotal()

                    'clearp()

                    MsgBox("Product is Already added to the List, Remove from list and add again")
                    Exit Sub

                End If
            Next j
            Dim k As Integer
            Dim lst1 As New ListViewItem(k)

            lst1.SubItems.Add(txtProductCode.Text)
            lst1.SubItems.Add(txtProductName.Text.ToUpper)
            lst1.SubItems.Add(txtPacking.Text)
            lst1.SubItems.Add(txtUnits.Text)
            lst1.SubItems.Add(txtFree.Text)
            lst1.SubItems.Add(txtBatchno.Text.ToUpper)
            lst1.SubItems.Add(txtExp.Text)
            lst1.SubItems.Add(txtMRP.Text)
            lst1.SubItems.Add(txtRate.Text)
            lst1.SubItems.Add(txtDisc.Text)
            lst1.SubItems.Add(txtTaxPer.Text)
            lst1.SubItems.Add(txtTotalAmount.Text)
            lst1.SubItems.Add(txtStockID.Text)

            ListView1.Items.Add(lst1)
            k = k + 1
            updatetotal()

            clearp()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDiscAmt_TextChanged(sender As Object, e As EventArgs) Handles txtDiscAmt.TextChanged

    End Sub

    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        Try
            txtPaymentDue.Text = Val(txtTotal.Text) - Val(txtTotalPayment.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub txtLess_TextChanged(sender As Object, e As EventArgs) Handles txtLess.TextChanged
        txtRate.Text = Format((Val(txtMRP.Text) * (1 - (Val(txtLess.Text) / 100))), "0.00")

    End Sub

  
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblItems.Text = ListView1.Items.Count
    End Sub

    Private Sub frmSales_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LblItems.Text = ListView1.Items.Count
    End Sub

    'Private Sub txtCustomerNo_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerNo.TextChanged
    '    If txtCustomerNo.Text = "" Then
    '        Exit Sub
    '    End If

    '    '  Try
    '    coni = New OleDbConnection(cs)

    '    coni.Open()

    '    Dim ct As String = "select InvType as InvNo from customer where customerno='" & txtCustomerNo.Text & "'"

    '    cmd = New OleDbCommand(ct)
    '    cmd.Connection = coni
    '    rdri = cmd.ExecuteReader()
    '    rdri.Read()
    '    If rdri.HasRows Then
    '        If IsDBNull(rdri("InvNo")) Then

    '            Exit Sub

    '        End If
    '        If rdri("InvNo").ToString() = "SALE" Then
    '            cmbInvType.SelectedIndex = 0
    '        ElseIf rdri("InvNo").ToString() = "TAX" Then
    '            cmbInvType.SelectedIndex = 1
    '        End If
    '    End If
    '    coni.Close()
    '    rdri.Close()
    '    '   Catch ex As Exception
    '    ' End Try
    'End Sub

    Private Sub txtCurrPay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrPay.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(46) Then
            e.Handled = True
        End If
    End Sub

  
   
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim j As Integer = ListView1.Items.Count
        Button7.Enabled = 1
        Button7.PerformClick()
        Button7.Enabled = 0


        'remove from stock

        Dim i As Integer = ListView1.Items.Count
        If i = j + 1 Then
            i = i - 1
            con = New OleDbConnection(cs)
            con.Open()

            Dim cb1 As String = "update stock set Units = Units - " & Val(ListView1.Items(i).SubItems(4).Text) + Val(ListView1.Items(i).SubItems(5).Text) & "   where productcode= '" & ListView1.Items(i).SubItems(1).Text & "' and stockid = '" & ListView1.Items(i).SubItems(13).Text & "'"

            cmd = New OleDbCommand(cb1)

            cmd.Connection = con


            cmd.ExecuteNonQuery()
            con.Close()

            ' add to sold
            con = New OleDbConnection(cs)

            Dim cd As String = "insert Into ProductSold(InvoiceNo,ProductCode,ProductName,packing,billQty,free,batchno,expdate,mrp,rate,disc,tax,amount,stockid) VALUES (@InvoiceNo,@ProductCode,@ProductName,@packing,@o5,@o6,@o7,@o8,@o9,@o10,@o11,@o12,@o13,@o14)"

            cmd = New OleDbCommand(cd)

            cmd.Connection = con



            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text)
            cmd.Parameters.AddWithValue("ProductCode", ListView1.Items(i).SubItems(1).Text)
            cmd.Parameters.AddWithValue("ProductName", ListView1.Items(i).SubItems(2).Text)
            cmd.Parameters.AddWithValue("packing", ListView1.Items(i).SubItems(3).Text)
            cmd.Parameters.AddWithValue("o5", ListView1.Items(i).SubItems(4).Text)
            cmd.Parameters.AddWithValue("o6", ListView1.Items(i).SubItems(5).Text)
            cmd.Parameters.AddWithValue("o7", ListView1.Items(i).SubItems(6).Text)
            cmd.Parameters.AddWithValue("o8", ListView1.Items(i).SubItems(7).Text)
            cmd.Parameters.AddWithValue("o9", ListView1.Items(i).SubItems(8).Text)
            cmd.Parameters.AddWithValue("o10", ListView1.Items(i).SubItems(9).Text)
            cmd.Parameters.AddWithValue("o11", ListView1.Items(i).SubItems(10).Text)
            cmd.Parameters.AddWithValue("o12", ListView1.Items(i).SubItems(11).Text)
            cmd.Parameters.AddWithValue("o13", ListView1.Items(i).SubItems(12).Text)
            cmd.Parameters.AddWithValue("o14", ListView1.Items(i).SubItems(13).Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()



            'update bill info after update total
            updatetotal()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update billinfo set SubTotal= '" & CDec(txtSubTotal.Text) & "',taxamount= '" & CDec(txtTaxAmt.Text) & "',Discamount= '" & CDec(txtDiscAmt.Text) & "',GrandTotal= '" & CDec(txtTotal.Text) & "',TotalPayment= '" & CDec(txtTotalPayment.Text) & "',PaymentDue= '" & CDec(txtPaymentDue.Text) & "', notes = '" & txtpayrec.Text & "' where Invoiceno= '" & txtInvoiceNo.Text & "'"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con

            cmd.ExecuteReader()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb2 As String = "update billinfo set SubTotal= '" & CDec(txtSubTotal.Text) & "',taxamount= '" & CDec(txtTaxAmt.Text) & "',Discamount= '" & CDec(txtDiscAmt.Text) & "',GrandTotal= '" & CDec(txtTotal.Text) & "',TotalPayment= '" & CDec(txtTotalPayment.Text) & "',PaymentDue= '" & CDec(txtPaymentDue.Text) & "', notes = '" & txtpayrec.Text & "' where Invoiceno= '" & txtInvoiceNo.Text & "'"

            cmd = New OleDbCommand(cb2)

            cmd.Connection = con

            cmd.ExecuteReader()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()
        End If
    End Sub

    Private Sub btnRem_Click(sender As Object, e As EventArgs) Handles btnRem.Click
        If ListView1.SelectedItems.Count > 0 Then

            Try
                If ListView1.Items.Count = 0 Then
                    MsgBox("No items to remove", MsgBoxStyle.Critical, "Error")
                Else
                    con = New OleDbConnection(cs)
                    con.Open()
                    Dim ct As String = "delete from productsold where stockid= '" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(13).Text & "' "

                    cmd = New OleDbCommand(ct)
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    con.Close()


                End If



                ''update stock


                con = New OleDbConnection(cs)
                con.Open()
                Dim ct2 As String = "select stockid from Stock where productcode= '" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text & "' "

                cmd = New OleDbCommand(ct2)
                cmd.Connection = con

                rdr = cmd.ExecuteReader()

                If rdr.Read Then
                    Dim stock_id As String = rdr.GetString(0)
                    If Not rdr Is Nothing Then
                        rdr.Close()
                    End If

                    con = New OleDbConnection(cs)
                    con.Open()

                    Dim cb1 As String = "update stock set Units = Units + " & Val(ListView1.Items(ListView1.FocusedItem.Index).SubItems(4).Text) + Val(ListView1.Items(ListView1.FocusedItem.Index).SubItems(5).Text) & "   where stockid = '" & stock_id & "'"

                    cmd = New OleDbCommand(cb1)

                    cmd.Connection = con


                    cmd.ExecuteNonQuery()
                    con.Close()
                Else
                    If Not rdr Is Nothing Then
                        rdr.Close()
                    End If

                    con = New OleDbConnection(cs)
                    con.Open()

                    Dim cb1 As String = "insert into stock(StockID,invoiceno,productcode,productname,packing,units,stockdate,batchno,expdate,mrp,purrate) VALUES ('" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(13).Text & "','" & "removedFromBill" & "','" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text & "','" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text & "','" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text & "','" & CDec(Val(ListView1.Items(ListView1.FocusedItem.Index).SubItems(4).Text) + Val(ListView1.Items(ListView1.FocusedItem.Index).SubItems(5).Text)) & "','" & Now.Date & "','" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(6).Text & "','" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(7).Text & "','" & CDec(ListView1.Items(ListView1.FocusedItem.Index).SubItems(8).Text) & "','0')"

                    cmd = New OleDbCommand(cb1)

                    cmd.Connection = con


                    cmd.ExecuteNonQuery()
                    con.Close()


                End If
                ListView1.FocusedItem.Remove()
                'update bill
                updatetotal()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb As String = "update billinfo set SubTotal= '" & CDec(txtSubTotal.Text) & "',taxamount= '" & CDec(txtTaxAmt.Text) & "',Discamount= '" & CDec(txtDiscAmt.Text) & "',GrandTotal= '" & CDec(txtTotal.Text) & "',TotalPayment= '" & CDec(txtTotalPayment.Text) & "',PaymentDue= '" & CDec(txtPaymentDue.Text) & "', notes = '" & txtpayrec.Text & "' where Invoiceno= '" & txtInvoiceNo.Text & "'"

                cmd = New OleDbCommand(cb)

                cmd.Connection = con

                cmd.ExecuteReader()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb2 As String = "update billinfo set SubTotal= '" & CDec(txtSubTotal.Text) & "',taxamount= '" & CDec(txtTaxAmt.Text) & "',Discamount= '" & CDec(txtDiscAmt.Text) & "',GrandTotal= '" & CDec(txtTotal.Text) & "',TotalPayment= '" & CDec(txtTotalPayment.Text) & "',PaymentDue= '" & CDec(txtPaymentDue.Text) & "', notes = '" & txtpayrec.Text & "' where Invoiceno= '" & txtInvoiceNo.Text & "'"

                cmd = New OleDbCommand(cb2)

                cmd.Connection = con

                cmd.ExecuteReader()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()


                MessageBox.Show("Successfully Removed", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class