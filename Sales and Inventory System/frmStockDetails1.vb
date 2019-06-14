Imports System.Data.OleDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmStockDetails1
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"
    Sub fillProduct()

        Try

            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (ProductName) FROM stock", CN)
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
    Sub fillWeight()

        Try

            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (category) FROM product", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbWeight.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbWeight.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub frmStockDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()

        fillProduct()
        fillWeight()
        txtProduct.Focus()

    End Sub





    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cmbProductName.Text = ""
        txtProduct.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click

        cmbProductName.Text = ""
        txtProduct.Text = ""
        DataGridView2.DataSource = Nothing
        cmbWeight.Text = ""
        DataGridView4.DataSource = Nothing

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged
        Try


            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (StockID)as [Stock ID],(invoiceno) as [InvoiceNo],(ProductCode) as [Product Code],(ProductName) as [Product Name],(Packing) as [Packing per Unit],(Units) as [Units],(StockDate) as [Stock Date],(BatchNO) as [Batch No],(ExpDate) as [Expiry Date],(MRP) as [MRP],(PurRate) as [Purchase Rate] from Stock where Productname = '" & cmbProductName.Text & "'order by ProductName", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView2.DataSource = myDataSet.Tables("Stock").DefaultView
            DataGridView2.AutoResizeColumn(3)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.TextChanged
        Try


            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (StockID)as [Stock ID],(invoiceno) as [InvoiceNo],(ProductCode) as [Product Code],(ProductName) as [Product Name],(Packing) as [Packing per Unit],(Units) as [Units],(StockDate)as [Stock Date],(BatchNO) as [Batch No],(ExpDate) as [Expiry Date],(MRP) as [MRP],(PurRate)as[Purchase Rate] from Stock  where Productname like '" & txtProduct.Text & "%' order by ProductName", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView2.DataSource = myDataSet.Tables("Stock").DefaultView
            DataGridView2.AutoResizeColumn(3)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  


    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        cmbWeight.Text = ""
        DataGridView4.DataSource = Nothing
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If DataGridView4.RowCount = Nothing Then
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

            rowsTotal = DataGridView4.RowCount - 1
            colsTotal = DataGridView4.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView4.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView4.Rows(I).Cells(j).Value
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

  
    Private Sub cmbWeight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWeight.SelectedIndexChanged
        Try


            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (StockID)as [Stock ID],(invoiceno) as [InvoiceNo],(product.ProductCode) as [Product Code],(product.ProductName) as [Product Name],(product.Packing) as [Packing per Unit],(Units) as [Units],(StockDate)as [Stock Date],(BatchNO) as [Batch No],(ExpDate) as [Expiry Date],(MRP) as [MRP],(PurRate)as[Purchase Rate] from Stock, PRODUCT  where category = '" & cmbWeight.Text & "' and product.productcode= stock.productcode order by product.packing", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView4.DataSource = myDataSet.Tables("Stock").DefaultView
            DataGridView4.AutoResizeColumn(3)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView2.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            DataGridView2.CurrentRow.Selected = True
            e.Handled = True
            DGV2()
        End If

    End Sub


    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        DGV2()
    End Sub

    Private Sub DGV2()

        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            Me.Hide()
            frmStock.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmStock.txtStockID.Text = dr.Cells(0).Value.ToString()
            frmStock.dtpStockDate.Text = dr.Cells(6).Value.ToString()
            frmStock.txtProductCode.Text = dr.Cells(2).Value.ToString()
            frmStock.txtProductName.Text = dr.Cells(3).Value.ToString()
            frmStock.txtinvoiceno.Text = dr.Cells(1).Value.ToString()
            frmStock.txtWeight.Text = dr.Cells(4).Value.ToString()
            frmStock.dtpExpDate.Text = dr.Cells(8).Value.ToString()
            frmStock.txtCartons.Text = dr.Cells(5).Value.ToString()
            frmStock.txtbatch.Text = dr.Cells(7).Value.ToString()
            frmStock.txtMRP.Text = dr.Cells(9).Value.ToString()
            frmStock.txtRate.Text = dr.Cells(10).Value.ToString()
            frmStock.Update_Record.Enabled = True
            frmStock.Delete.Enabled = True
            frmStock.Save.Enabled = False
            frmStock.txtCartons.Focus()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView4_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView4.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            DataGridView4.CurrentRow.Selected = True
            e.Handled = True
            DGV4()
        End If

    End Sub

    Private Sub DataGridView4_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView4.RowHeaderMouseClick
        DGV4()
    End Sub
    Private Sub DGV4()

        Try
            Dim dr As DataGridViewRow = DataGridView4.SelectedRows(0)
            Me.Hide()
            frmStock.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmStock.txtStockID.Text = dr.Cells(0).Value.ToString()
            frmStock.dtpStockDate.Text = dr.Cells(6).Value.ToString()
            frmStock.txtProductCode.Text = dr.Cells(2).Value.ToString()
            frmStock.txtProductName.Text = dr.Cells(3).Value.ToString()
            frmStock.txtinvoiceno.Text = dr.Cells(1).Value.ToString()
            frmStock.txtWeight.Text = dr.Cells(4).Value.ToString()
            frmStock.dtpExpDate.Text = dr.Cells(8).Value.ToString()
            frmStock.txtCartons.Text = dr.Cells(5).Value.ToString()
            frmStock.txtbatch.Text = dr.Cells(7).Value.ToString()
            frmStock.txtMRP.Text = dr.Cells(9).Value.ToString()
            frmStock.txtRate.Text = dr.Cells(10).Value.ToString()
            frmStock.Update_Record.Enabled = True
            frmStock.Delete.Enabled = True
            frmStock.Save.Enabled = False
            frmStock.txtCartons.Focus()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try


            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (StockID)as [Stock ID],(invoiceno) as [InvoiceNo],(ProductCode) as [Product Code],(ProductName) as [Product Name],(Packing) as [Packing per Unit],(Units) as [Units],(StockDate)as [Stock Date],(BatchNO) as [Batch No],(ExpDate) as [Expiry Date],(MRP) as [MRP],(PurRate)as[Purchase Rate] from Stock  where units = 0 order by ProductName", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView1.DataSource = myDataSet.Tables("Stock").DefaultView
            DataGridView1.AutoResizeColumn(3)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
            frmStock.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmStock.txtStockID.Text = dr.Cells(0).Value.ToString()
            frmStock.dtpStockDate.Text = dr.Cells(6).Value.ToString()
            frmStock.txtProductCode.Text = dr.Cells(2).Value.ToString()
            frmStock.txtProductName.Text = dr.Cells(3).Value.ToString()
            frmStock.txtinvoiceno.Text = dr.Cells(1).Value.ToString()
            frmStock.txtWeight.Text = dr.Cells(4).Value.ToString()
            frmStock.dtpExpDate.Text = dr.Cells(8).Value.ToString()
            frmStock.txtCartons.Text = dr.Cells(5).Value.ToString()
            frmStock.txtbatch.Text = dr.Cells(7).Value.ToString()
            frmStock.txtMRP.Text = dr.Cells(9).Value.ToString()
            frmStock.txtRate.Text = dr.Cells(10).Value.ToString()
            frmStock.Update_Record.Enabled = True
            frmStock.Delete.Enabled = True
            frmStock.Save.Enabled = False
            frmStock.txtCartons.Focus()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class