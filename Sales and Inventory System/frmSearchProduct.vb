Imports System.Data.OleDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmSearchProduct
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT (StockID) as [Stock ID],(Product.ProductCode) as [Product Code],(Product.ProductName) as [Product Name], (Product.packing) as [Packing], (Product.category) as [Category], (Product.tax) as [Tax], (MRP) as [Mrp], (units) as [Units Available], (expdate) as [EXP Date], (batchno) as [Batch No] from product, Stock  where product.productcode=stock.productcode and Product.ProductName= '" & cmbProductName.Text & "' group by Product.ProductCode,Product.Productname,Product.packing,Product.Category,product.tax,MRP,stockID,units,batchno,expdate order by expdate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView1.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Stock").DefaultView
            DataGridView1.AutoResizeColumn(2)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmSearchProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        txtProductName.Focus()
        fillProductName()
    End Sub

    Sub fillProductName()

        Try

            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (ProductName) FROM Stock", CN)
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

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        txtProductName.Text = ""
        cmbProductName.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click

        txtProductName.Text = ""
        cmbProductName.Text = ""
        DataGridView1.DataSource = Nothing
        cmbWeight.Text = ""
        DataGridView3.DataSource = Nothing
        
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
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

 




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DataGridView3.DataSource = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT (StockID) as [Stock ID],(Product.ProductCode) as [Product Code],(Product.ProductName) as [Product Name], (Product.packing) as [Packing], (Product.category) as [Category], (Product.tax) as [Tax], (MRP) as [Mrp], (units) as [Units Available], (expdate) as [EXP Date], (batchno) as [Batch No] from product, Stock  where product.productcode=stock.productcode and units > 0 group by Product.ProductCode,Product.Productname,Product.packing,Product.Category,product.tax,MRP,stockID,units,batchno,expdate order by Product.Productname, expdate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView3.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView3.DataSource = myDataSet.Tables("Stock").DefaultView
            DataGridView3.AutoResizeColumn(2)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtProductName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT (StockID) as [Stock ID],(Product.ProductCode) as [Product Code],(Product.ProductName) as [Product Name], (Product.packing) as [Packing], (Product.category) as [Category], (Product.tax) as [Tax], (MRP) as [Mrp], (units) as [Units Available], (expdate) as [EXP Date], (batchno) as [Batch No] from product, Stock  where product.productcode=stock.productcode and Product.ProductName like '" & txtProductName.Text & "%' group by Product.ProductCode,Product.Productname,Product.packing,Product.Category,product.tax,MRP,stockID,units,batchno,expdate order by expdate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView1.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Stock").DefaultView
            DataGridView1.AutoResizeColumn(2)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            DataGridView1.CurrentRow.Selected = True
            e.Handled = True
            DGV1()
        End If
    End Sub
  
    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        DGV1()
    End Sub

    Private Sub DGV1()
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            frmOrder.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmOrder.txtStockID.Text = dr.Cells(0).Value()

            frmOrder.txtProductCode.Text = dr.Cells(1).Value()
            frmOrder.txtProductName.Text = dr.Cells(2).Value()
            frmOrder.txtPacking.Text = dr.Cells(3).Value()
            frmOrder.txtTaxPer.Text = dr.Cells(5).Value()
            frmOrder.txtAvlUnits.Text = dr.Cells(7).Value()
            frmOrder.txtMRP.Text = dr.Cells(6).Value()
            frmOrder.txtExp.Text = dr.Cells(8).Value()
            frmOrder.txtBatchno.Text = dr.Cells(9).Value()
            If dr.Cells(4).Value() = "GLD" Then
                frmOrder.txtLess.Text = "16.49"
            Else
                frmOrder.txtLess.Text = "16.66"
            End If
            If frmOrder.txtDisc.Text = "" Then
                frmOrder.txtDisc.Text = "0"
            End If

            frmOrder.txtUnits.Focus()
            frmOrder.txtLess_TextChanged(frmOrder.txtLess, EventArgs.Empty)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView3.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            DataGridView3.CurrentRow.Selected = True
            e.Handled = True
            DGV3()
        End If

    End Sub

    Private Sub DataGridView3_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.RowHeaderMouseClick
        DGV3()
    End Sub

    Private Sub DGV3()
        Try
            Dim dr As DataGridViewRow = DataGridView3.SelectedRows(0)
            Me.Hide()
            frmOrder.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmOrder.txtStockID.Text = dr.Cells(0).Value()
            frmOrder.txtProductCode.Text = dr.Cells(1).Value()
            frmOrder.txtProductName.Text = dr.Cells(2).Value()
            frmOrder.txtPacking.Text = dr.Cells(3).Value()
            frmOrder.txtTaxPer.Text = dr.Cells(5).Value()
            frmOrder.txtAvlUnits.Text = dr.Cells(7).Value()
            frmOrder.txtMRP.Text = dr.Cells(6).Value()
            frmOrder.txtExp.Text = dr.Cells(8).Value()
            frmOrder.txtBatchno.Text = dr.Cells(9).Value()

            If dr.Cells(4).Value() = "GLD" Then
                frmOrder.txtLess.Text = "16.49"
            Else
                frmOrder.txtLess.Text = "16.66"
            End If
            If frmOrder.txtDisc.Text = "" Then
                frmOrder.txtDisc.Text = "0"
            End If
            frmOrder.txtUnits.Focus()
            frmOrder.txtLess_TextChanged(frmOrder.txtLess, EventArgs.Empty)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   


End Class