Imports System.Data.OleDB
Imports System.Security.Cryptography
Imports System.Text

Public Class frmOrder
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable

    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"
 
    Private Sub auto()
        con = New OleDbConnection(cs)


        If cmbInvType.Text = "ORDER" Then
            con.Open()
            Dim ct As String = "select Max(orderno) as OrdNo from orderInfo where orderNo like 'OR%'"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            rdr.Read()
            If rdr("ordno").ToString() <> "" Then
                Dim exinv As String = New String((From c As Char In rdr("ordno").ToString() Select c Where Char.IsDigit(c)).ToArray())
                txtOrderNo.Text = "OR-" & (Integer.Parse(exinv) + 1).ToString("000000")
            Else
                txtOrderNo.Text = "OR-" & "000001"
            End If
            con.Close()
            rdr.Close()
        ElseIf cmbInvType.Text = "ESTIMATE" Then
            con.Open()
            Dim ct As String = "select Max(orderno) as OrdNo from orderInfo where orderNo like 'ES%'"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            rdr.Read()
            If rdr("ordno").ToString() <> "" Then
                Dim exinv As String = New String((From c As Char In rdr("ordno").ToString() Select c Where Char.IsDigit(c)).ToArray())
                txtOrderNo.Text = "ES-" & (Integer.Parse(exinv) + 1).ToString("000000")
            Else
                txtOrderNo.Text = "ES-" & "000001"
            End If
            con.Close()
            rdr.Close()

            End If


    End Sub

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
        'txtDisc.Text = "0" def disc for customer
        txtBatchno.Text = ""
        txtStockID.Text = ""
    End Sub





    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
    Sub clear()
        txtOrderNo.Text = ""
        txtCustomerNo.Text = ""
        txtCustomerName.Text = ""
        dtpOrderDate.Text = Today
        txtProductCode.Text = ""
        txtProductName.Text = ""
        txtPacking.Text = ""
        txtAvlUnits.Text = ""
        txtUnits.Text = ""
        txtRate.Text = ""
        txtMRP.Text = ""
        txtTotalAmount.Text = "0"
        txtFree.Text = "0"
        txtSubTotal.Text = ""
        txtTaxAmt.Text = ""
        txtDiscAmt.Text = ""
        txtTotal.Text = ""
        cmbOrderStatus.Text = ""

    End Sub
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        clear()
        chkIgnore.Checked = False
        btnPrint.Enabled = False
        ListView1.Items.Clear()
        Save.Enabled = True
        Delete.Enabled = False
        cmbOrderStatus.Enabled = False
        btnRemove.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub frmOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FrmMain.Show()
    End Sub

   

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        If Len(Trim(txtCustomerNo.Text)) = 0 Then
            MessageBox.Show("Select Customer id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Button2.Focus()
            Exit Sub
        End If
        If Len(Trim(txtCustomerName.Text)) = 0 Then
            MessageBox.Show("Select Customer name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCustomerName.Focus()
            Exit Sub
        End If

        If ListView1.Items.Count = 0 Then
            MessageBox.Show("sorry no product added", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Block to check Stock, while saving order; not required here . already is done while saving invoice 
        'Try
        '    For j = 0 To ListView1.Items.Count - 1
        '        Dim con As New OleDbConnection(cs)
        '        con.Open()
        '        Dim cmd As New OleDbCommand("SELECT units  from stock where stockid ='" & ListView1.Items(j).SubItems(13).Text & "'", con)
        '        Dim da As New OleDbDataAdapter(cmd)
        '        Dim ds As DataSet = New DataSet()
        '        da.Fill(ds)
        '        If ds.Tables(0).Rows.Count > 0 Then
        '            lblCartons.Text = ds.Tables(0).Rows(0)("Units")
        '            If ((Val(ListView1.Items(j).SubItems(4).Text) + Val(ListView1.Items(j).SubItems(5).Text)) > Val(lblCartons.Text)) Then
        '                MessageBox.Show("added quantity to cart are more than" & vbCrLf & "available quantity of product code '" & ListView1.Items(j).SubItems(1).Text & "' and Name = " & ListView1.Items(j).SubItems(2).Text & "' and stockid = " & ListView1.Items(j).SubItems(13).Text & "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                Exit Sub
        '            End If
        '        End If
        '        con.Close()
        '    Next
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        Try
            auto()
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select OrderNo from Orderinfo where Orderno=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "OrderNo"))
            cmd.Parameters("@find").Value = txtOrderNo.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Order No. Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else



                con = New OleDbConnection(cs)
                con.Open()

                Dim cb As String = "insert Into orderinfo(OrderNo,OrderDate,OrderStatus,CustomerNo,CustomerName,SubTotal,DiscAmount,TaxAmount,TotalAmount) VALUES ('" & txtOrderNo.Text & "','" & dtpOrderDate.Text & "','Uncompleted','" & txtCustomerNo.Text & "','" & txtCustomerName.Text & "','" & Val(txtSubTotal.Text) & "','" & Val(txtDiscAmt.Text) & "','" & Val(txtTaxAmt.Text) & "','" & Val(txtTotal.Text) & "')"

                cmd = New OleDbCommand(cb)

                cmd.Connection = con

                cmd.ExecuteReader()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()





                For i = 0 To ListView1.Items.Count - 1
                    con = New OleDbConnection(cs)

                    Dim cd As String = "insert Into OrderedProduct(OrderNo,ProductCode,ProductName,packing,billQty,free,batchno,expdate,mrp,rate,disc,tax,amount,stockid) VALUES (@o1,@o2,@o3,@o4,@o5,@o6,@o7,@o8,@o9,@o10,@o11,@o12,@o13,@o14)"

                    cmd = New OleDbCommand(cd)

                    cmd.Connection = con
                    cmd.Parameters.AddWithValue("o1", txtOrderNo.Text)
                    cmd.Parameters.AddWithValue("o2", ListView1.Items(i).SubItems(1).Text)
                    cmd.Parameters.AddWithValue("o3", ListView1.Items(i).SubItems(2).Text)
                    cmd.Parameters.AddWithValue("o4", ListView1.Items(i).SubItems(3).Text)
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
                Save.Enabled = False
                MessageBox.Show("Successfully placed", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbOrderStatus.Text = "Uncompleted"
            End If

            btnPrint.Enabled = True


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub delete_records()
        Try



            Dim RowsAffected As Integer = 0




            con = New OleDbConnection(cs)

            con.Open()


            Dim cq1 As String = "delete from orderedproduct where orderno=@DELETE1;"


            cmd = New OleDbCommand(cq1)

            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDB.OleDBType.VarChar, 20, "orderNo"))


            cmd.Parameters("@DELETE1").Value = Trim(txtOrderNo.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)

            con.Open()


            Dim cq As String = "delete from orderinfo where orderno=@DELETE1;"


            cmd = New OleDbCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDB.OleDBType.VarChar, 20, "orderNo"))


            cmd.Parameters("@DELETE1").Value = Trim(txtOrderNo.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
                cmbOrderStatus.Enabled = False
                Delete.Enabled = False
                btnUpdate.Enabled = False
                btnPrint.Enabled = False
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)


                clear()
                cmbOrderStatus.Enabled = False
                Delete.Enabled = False
                btnUpdate.Enabled = False
                btnPrint.Enabled = False



                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try



            If MessageBox.Show("Do you really want to delete the record?", "Order Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                delete_records()



            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        frmCustomersRecord2.Show()
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
            LblItems.Text = ListView1.Items.Count
            txtSubTotal.Text = Format(totamt, "0.00")
            txtDiscAmt.Text = Format(totdisc, "0.00")
            txtTaxAmt.Text = Format(tottax, "0.00")
            txtTotal.Text = Format(grdamt, "0.00")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.clear()
        frmOrderRecord1.fillorderNo()
        frmOrderRecord1.fillProductName()
        frmOrderRecord1.fillCustomerName()
        frmOrderRecord1.DataGridView1.DataSource = Nothing
        frmOrderRecord1.dtpOrderDateFrom.Text = Today
        frmOrderRecord1.dtpOrderDateTo.Text = Today
        frmOrderRecord1.DataGridView6.DataSource = Nothing
        frmOrderRecord1.cmbCustomerName.Text = ""
        frmOrderRecord1.DataGridView3.DataSource = Nothing
        frmOrderRecord1.cmbStatus.Text = ""
        frmOrderRecord1.DataGridView2.DataSource = Nothing
        frmOrderRecord1.cmbOrderNo.Text = ""
        frmOrderRecord1.cmbProductName.Text = ""
        frmOrderRecord1.DataGridView5.DataSource = Nothing
        frmOrderRecord1.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
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

            If Len(Trim(txtTaxPer.Text)) = 0 Then
                MessageBox.Show("Please enter Tax %", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRate.Focus()
                Exit Sub
            End If
           
            If Val(txtUnits.Text) <= 0 Then
                MessageBox.Show("Please enter Quantity of item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUnits.Focus()
                Exit Sub
            ElseIf (Val(txtAvlUnits.Text) < Val(txtFree.Text) + Val(txtUnits.Text)) And Not chkIgnore.Checked Then
                MessageBox.Show("Quantity entered is more than Available in Stock", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAvlUnits.Focus()
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
                    ListView1.Items(j).SubItems(1).Text = txtProductCode.Text
                    ListView1.Items(j).SubItems(2).Text = txtProductName.Text.ToUpper
                    ListView1.Items(j).SubItems(3).Text = txtPacking.Text
                    ListView1.Items(j).SubItems(4).Text = txtUnits.Text
                    ListView1.Items(j).SubItems(5).Text = txtFree.Text
                    ListView1.Items(j).SubItems(6).Text = txtBatchno.Text.ToUpper
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

    Private Sub txtUnits_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnits.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then
            e.Handled = True

        End If
    End Sub



    Private Sub txtUnits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnits.TextChanged
        updatelisting()
    End Sub

    Private Sub txtTaxPer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTaxPer.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtTaxPer.Text
            Dim selectionStart = Me.txtTaxPer.SelectionStart
            Dim selectionLength = Me.txtTaxPer.SelectionLength

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

    Private Sub txtTaxPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaxPer.TextChanged
              updatelisting()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSearchProduct.txtProductName.Text = ""
        frmSearchProduct.cmbProductName.Text = ""
        frmSearchProduct.DataGridView1.DataSource = Nothing
        frmSearchProduct.cmbWeight.Text = ""
        frmSearchProduct.DataGridView3.DataSource = Nothing
     
        frmSearchProduct.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            con = New OleDbConnection(cs)
            con.Open()

            Dim cb As String = "update orderinfo set orderstatus = '" & cmbOrderStatus.Text & "' where Orderno ='" & txtOrderNo.Text & "'"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con


            cmd.ExecuteReader()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbOrderStatus.Enabled = False
            btnUpdate.Enabled = False
            btnPrint.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If (e.KeyCode.Equals(Keys.Delete)) Then
                   btnRemove.PerformClick()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        btnRemove.Enabled = True
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtFree_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFree.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtDisc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisc.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtDisc_TextChanged(sender As Object, e As EventArgs) Handles txtDisc.TextChanged
              updatelisting()

    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
              updatelisting()

    End Sub

    Private Sub updatelisting()
        Try

            txtTotalAmount.Text = Format((Val(txtUnits.Text) * (Val(txtRate.Text)) * (1 - (Val(txtDisc.Text) / 100)) * (1 + (Val(txtTaxPer.Text) / 100))), "0.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtLess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLess.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then
            e.Handled = True

        End If
    End Sub

    Public Sub txtLess_TextChanged(sender As Object, e As EventArgs) Handles txtLess.TextChanged
        txtRate.Text = Format((Val(txtMRP.Text) * (1 - (Val(txtLess.Text) / 100))), "0.00")

    End Sub

   
   
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmEstimate.Show()

    End Sub

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbInvType.SelectedIndex = 0
        LblItems.Text = ListView1.Items.Count
    End Sub

    Private Sub frmOrder_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cmbInvType.SelectedIndex = 0

        LblItems.Text = ListView1.Items.Count
    End Sub
End Class