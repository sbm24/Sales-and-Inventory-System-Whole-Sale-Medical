﻿Imports System.Data.OleDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmOrderRecord1

    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Try

            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (OrderInfo.OrderNo)as [Order No],(OrderDate)as [Order Date],(OrderStatus) as [Order Status],(CustomerNo) as [Customer ID],(CustomerName) as [Customer Name], (TotalAmount) as [Total Amount] from orderinfo where  OrderDate between #" & dtpOrderDateFrom.Value.ToString("MM/dd/yyyy") & "# And #" & dtpOrderDateTo.Value.ToString("MM/dd/yyyy") & "# order by OrderNo,OrderDate", con)



            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()


            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")


            DataGridView1.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("OrderedProduct").DefaultView


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        dtpOrderDateFrom.Text = Today
        dtpOrderDateTo.Text = Today
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub



    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        DataGridView2.DataSource = Nothing
        cmbOrderNo.Text = ""
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If DataGridView2.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView2.RowCount - 1
            colsTotal = DataGridView2.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView2.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView2.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try

            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (OrderInfo.OrderNo)as [Order No],(OrderDate)as [Order Date],(OrderStatus) as [Order Status],(CustomerNo) as [Customer ID],(CustomerName) as [Customer Name], (TotalAmount) as [Total Amount] from orderinfo where  orderstatus = '" & cmbStatus.Text & "' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView3.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView3.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        DataGridView3.DataSource = Nothing
        cmbStatus.Text = ""
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If DataGridView3.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView3.RowCount - 1
            colsTotal = DataGridView3.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView3.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView3.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DataGridView5.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView5.RowCount - 1
            colsTotal = DataGridView5.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView5.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView5.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If DataGridView6.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView6.RowCount - 1
            colsTotal = DataGridView6.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView6.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView6.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        txtCustomer.Text = ""
        DataGridView6.DataSource = Nothing
        cmbCustomerName.Text = ""
    End Sub




    Sub fillProductName()

        Try

            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (ProductName) FROM orderedProduct", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbProductName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbProductName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillCustomerName()

        Try

            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (CustomerName) FROM orderinfo", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCustomerName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbCustomerName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillorderNo()

        Try

            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (orderno) FROM orderinfo", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbOrderNo.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbOrderNo.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmOrderRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        fillCustomerName()
        fillorderNo()
        fillProductName()
        Button1.PerformClick()
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        DataGridView1.DataSource = Nothing
        dtpOrderDateFrom.Text = Today
        dtpOrderDateTo.Text = Today
        DataGridView6.DataSource = Nothing
        cmbCustomerName.Text = ""
        txtCustomer.Text = ""
        DataGridView3.DataSource = Nothing
        cmbStatus.Text = ""
        DataGridView2.DataSource = Nothing
        cmbOrderNo.Text = ""
        cmbProductName.Text = ""
        txtProduct.Text = ""
        DataGridView5.DataSource = Nothing
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cmbProductName.Text = ""
        txtProduct.Text = ""
        DataGridView5.DataSource = Nothing
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            frmOrder.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmOrder.txtOrderNo.Text = dr.Cells(0).Value.ToString()
            frmOrder.dtpOrderDate.Text = dr.Cells(1).Value.ToString()
            frmOrder.cmbOrderStatus.Text = dr.Cells(2).Value.ToString()
            frmOrder.txtCustomerNo.Text = dr.Cells(3).Value.ToString()
            frmOrder.txtCustomerName.Text = dr.Cells(4).Value.ToString()
            frmOrder.txtTotal.Text = dr.Cells(5).Value.ToString()

            frmOrder.Delete.Enabled = True
            frmOrder.btnUpdate.Enabled = True
            frmOrder.Save.Enabled = False
            frmOrder.cmbOrderStatus.Enabled = True
            frmOrder.btnPrint.Enabled = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            Me.Hide()
            frmOrder.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmOrder.txtOrderNo.Text = dr.Cells(0).Value.ToString()
            frmOrder.dtpOrderDate.Text = dr.Cells(1).Value.ToString()
            frmOrder.cmbOrderStatus.Text = dr.Cells(2).Value.ToString()
            frmOrder.txtCustomerNo.Text = dr.Cells(3).Value.ToString()
            frmOrder.txtCustomerName.Text = dr.Cells(4).Value.ToString()
            frmOrder.txtTotal.Text = dr.Cells(5).Value.ToString()

            frmOrder.Delete.Enabled = True
            frmOrder.btnUpdate.Enabled = True
            frmOrder.Save.Enabled = False
            frmOrder.cmbOrderStatus.Enabled = True
            frmOrder.btnPrint.Enabled = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView3_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView3.SelectedRows(0)
            Me.Hide()
            frmOrder.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmOrder.txtOrderNo.Text = dr.Cells(0).Value.ToString()
            frmOrder.dtpOrderDate.Text = dr.Cells(1).Value.ToString()
            frmOrder.cmbOrderStatus.Text = dr.Cells(2).Value.ToString()
            frmOrder.txtCustomerNo.Text = dr.Cells(3).Value.ToString()
            frmOrder.txtCustomerName.Text = dr.Cells(4).Value.ToString()
            frmOrder.txtTotal.Text = dr.Cells(5).Value.ToString()

            frmOrder.Delete.Enabled = True
            frmOrder.btnUpdate.Enabled = True
            frmOrder.Save.Enabled = False
            frmOrder.cmbOrderStatus.Enabled = True
            frmOrder.btnPrint.Enabled = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView5_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView5.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView5.SelectedRows(0)
            Me.Hide()
            frmOrder.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmOrder.txtOrderNo.Text = dr.Cells(0).Value.ToString()
            frmOrder.dtpOrderDate.Text = dr.Cells(1).Value.ToString()
            frmOrder.cmbOrderStatus.Text = dr.Cells(2).Value.ToString()
            frmOrder.txtCustomerNo.Text = dr.Cells(3).Value.ToString()
            frmOrder.txtCustomerName.Text = dr.Cells(4).Value.ToString()
            frmOrder.txtTotal.Text = dr.Cells(5).Value.ToString()

            frmOrder.Delete.Enabled = True
            frmOrder.btnUpdate.Enabled = True
            frmOrder.Save.Enabled = False
            frmOrder.cmbOrderStatus.Enabled = True
            frmOrder.btnPrint.Enabled = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView6_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView6.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView6.SelectedRows(0)
            Me.Hide()
            frmOrder.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmOrder.txtOrderNo.Text = dr.Cells(0).Value.ToString()
            frmOrder.dtpOrderDate.Text = dr.Cells(1).Value.ToString()
            frmOrder.cmbOrderStatus.Text = dr.Cells(2).Value.ToString()
            frmOrder.txtCustomerNo.Text = dr.Cells(3).Value.ToString()
            frmOrder.txtCustomerName.Text = dr.Cells(4).Value.ToString()
            frmOrder.txtTotal.Text = dr.Cells(5).Value.ToString()

            frmOrder.Delete.Enabled = True
            frmOrder.btnUpdate.Enabled = True
            frmOrder.Save.Enabled = False
            frmOrder.cmbOrderStatus.Enabled = True
            frmOrder.btnPrint.Enabled = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.TextChanged
        Try

            con = New OleDbConnection(cs)

            con.Open()

            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (OrderInfo.OrderNo)as [Order No],(OrderDate)as [Order Date],(OrderStatus) as [Order Status],(CustomerNo) as [Customer ID],(CustomerName) as [Customer Name], (TotalAmount) as [Total Amount] from orderinfo where CustomerName like '" & txtCustomer.Text & "%' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView6.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView6.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.TextChanged
        Try

            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (OrderInfo.OrderNo) as [Order No],(OrderInfo.OrderDate) as [Order Date],(OrderInfo.OrderStatus) as [Order Status],(OrderInfo.CustomerNo) as [Customer ID],(OrderInfo.CustomerName) as [Customer Name], (OrderInfo.TotalAmount) as [Total Amount], (OrderedProduct.productname) as [Product], (OrderedProduct.packing) as [Packing], (OrderedProduct.billqty) as [Bill Qty], (OrderedProduct.free) as [Free Qty] from orderinfo, orderedproduct where orderinfo.orderno=orderedproduct.orderno and orderedproduct.ProductName like '" & txtProduct.Text & "%' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView5.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView5.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged
        Try

            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (OrderInfo.OrderNo) as [Order No],(OrderInfo.OrderDate) as [Order Date],(OrderInfo.OrderStatus) as [Order Status],(OrderInfo.CustomerNo) as [Customer ID],(OrderInfo.CustomerName) as [Customer Name], (OrderInfo.TotalAmount) as [Total Amount], (OrderedProduct.productname) as [Product], (OrderedProduct.packing) as [Packing], (OrderedProduct.billqty) as [Bill Qty], (OrderedProduct.free) as [Free Qty] from orderinfo, orderedproduct where orderinfo.orderno=orderedproduct.orderno and orderedproduct.productname= '" & cmbProductName.Text & "'  order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView5.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView5.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomerName.SelectedIndexChanged
        Try

            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (OrderInfo.OrderNo)as [Order No],(OrderDate)as [Order Date],(OrderStatus) as [Order Status],(CustomerNo) as [Customer ID],(CustomerName) as [Customer Name], (TotalAmount) as [Total Amount] from orderinfo where CustomerName = '" & cmbCustomerName.Text & "' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView6.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView6.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbOrderNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrderNo.SelectedIndexChanged
        Try

            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (OrderInfo.OrderNo)as [Order No],(OrderDate)as [Order Date],(OrderStatus) as [Order Status],(CustomerNo) as [Customer ID],(CustomerName) as [Customer Name], (TotalAmount) as [Total Amount] from orderinfo where  orderinfo.Orderno = '" & cmbOrderNo.Text & "' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView2.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView2.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


  
End Class