
Imports System.Data.OleDB
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization
Public Class frmStock
    Dim rdr As OleDbDataReader = Nothing
    Dim rdrs As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim cons As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim cmds As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"

    Sub clear()
        txtStockID.Text = ""
        txtinvoiceno.Text = ""
        txtCartons.Text = ""
        txtbatch.Text = "..."
        txtWeight.Text = ""
        txtProductCode.Text = ""
        txtProductName.Text = ""
        txtMRP.Text = ""
        txtRate.Text = "00.00"
        dtpStockDate.Text = Today
        dtpExpDate.Text = "01/01/2030"
        Button2.Focus()
    End Sub
    Private Const ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"
    Private ReadOnly Property Connection() As OleDbConnection
        Get
            Dim ConnectionToFetch As New OleDbConnection(ConnectionString)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property

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


    Private Sub auto()
        cons = New OleDbConnection(cs)
        cons.Open()
        Dim cts As String = "select Max(Stockid) as STID from Stock where stockid like 'SK%'"

        cmds = New OleDbCommand(cts)
        cmds.Connection = cons
        rdrs = cmds.ExecuteReader()
        rdrs.Read()

        If rdrs("STID").ToString() <> "" Then
            Dim exinv As String = New String((From c As Char In rdrs("STID").ToString() Select c Where Char.IsDigit(c)).ToArray())
            txtStockID.Text = "SK-" & (Integer.Parse(exinv) + 1).ToString("000000")
        Else
            txtStockID.Text = "SK-" & "000001"
        End If
        cons.Close()
        rdrs.Close()

    End Sub

    Public Function GetData() As DataView

        Dim SelectQry = "SELECT (StockID) as [Stock ID],(InvoiceNo) as [invoice],(ProductCode) as [Product Code],(ProductName) as [Product Name],(Packing)as[packing], (BatchNo) as [Batch No], (ExpDate) as [ExpDate],(Units) as [Units], (MRP) as [MRP], (PurRate) as [Purchase Rate], (stockdate)as[Stock Date]FROM stock group by productname, batchno, invoiceno, stockid, ProductCode,ProductName, ExpDate, MRP, units,PurRate,stockdate,packing order by productname "
        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New OleDbCommand()
            Dim SampleDataAdapter = New OleDbDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
            
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TableView
    End Function

    Private Sub txtCarton_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCartons.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMRP.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57) Or e.KeyChar = Chr(47)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub



    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        clear()
        Save.Enabled = True
        Update_Record.Enabled = False
        Delete.Enabled = False
    End Sub
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click


        If Len(Trim(txtProductCode.Text)) = 0 Then
            MessageBox.Show("Please select product code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProductCode.Focus()
            Exit Sub
        End If
        If Len(Trim(txtProductName.Text)) = 0 Then
            MessageBox.Show("Please select product name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProductName.Focus()
            Exit Sub
        End If
        'If Len(Trim(txtinvoiceno.Text)) = 0 Then
        '    MessageBox.Show("Please enter invoice no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtWeight.Focus()
        '    Exit Sub
        'End If
        If Len(Trim(txtCartons.Text)) = 0 Then
            MessageBox.Show("Please enter No. of Units", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCartons.Focus()
            Exit Sub
        End If
        If Len(Trim(txtMRP.Text)) = 0 Then
            MessageBox.Show("Please enter MRP", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMRP.Focus()
            Exit Sub
        End If

        If Len(Trim(txtbatch.Text)) = 0 Then
            MessageBox.Show("Please enter Batch No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbatch.Focus()
            Exit Sub
        End If
        If Len(Trim(txtRate.Text)) = 0 Then
            MessageBox.Show("Please enter Purchase rate", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbatch.Focus()
            Exit Sub
        End If
        If dtpExpDate.Text = Today Then
            MessageBox.Show("Please select Expity Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpExpDate.Focus()
            Exit Sub
        End If
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select ProductCode and batchno from stock where ProductCode=@find and batchno=@find1"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "ProductCode"))
            cmd.Parameters("@find").Value = txtProductCode.Text

            cmd.Parameters.Add(New OleDbParameter("@find1", System.Data.OleDb.OleDbType.VarChar, 20, "InvoiceNo"))

            cmd.Parameters("@find1").Value = txtbatch.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Record already exists in stock" & vbCrLf & "Please update the old stock of product" & vbCrLf & "Or change Batch No. of new entry.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbatch.Focus()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If

            'con = New OleDbConnection(cs)
            'con.Open()
            'Dim ct1 As String = "select stockid from stock where stockid=@find"

            'cmd = New OleDbCommand(ct1)
            'cmd.Connection = con
            'cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "stockid"))
            'cmd.Parameters("@find").Value = txtStockID.Text
            'rdr = cmd.ExecuteReader()

            'If rdr.Read Then
            '    MessageBox.Show("Stock ID Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            '    If Not rdr Is Nothing Then
            '        rdr.Close()
            '    End If

            'Else


            con = New OleDbConnection(cs)
            con.Open()
            auto()

            Dim cb As String = "insert into stock(StockID,invoiceno,productcode,productname,packing,units,stockdate,batchno,expdate,mrp,purrate) VALUES ('" & txtStockID.Text & "','" & txtinvoiceno.Text & "','" & txtProductCode.Text & "','" & txtProductName.Text & "','" & txtWeight.Text & "','" & CDec(txtCartons.Text) & "','" & dtpStockDate.Text & "','" & txtbatch.Text & "','" & dtpExpDate.Text & "','" & CDec(txtMRP.Text) & "','" & txtRate.Text & "')"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con


            cmd.ExecuteReader()
            MessageBox.Show("Successfully saved", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Save.Enabled = False
            DataGridView1.DataSource = GetData()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Stockestimate()
            con.Close()
            'End If
            clear()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Stockestimate()
        Dim StockVal As Integer = 0
        'For i = 0 To DataGridView1.RowCount

        'Next

        For Each S As DataGridViewRow In Me.DataGridView1.Rows
            StockVal = StockVal + (S.Cells(7).Value * S.Cells(8).Value)
        Next
        StockValue.Text = "Total MRP of Current Stock: " & StockVal.ToString("C", CultureInfo.CreateSpecificCulture("en-IN"))
        ''Format(StockVal, "##,##,###.00")

    End Sub


    Private Sub frmStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FrmMain.Show()
    End Sub

    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetData()
        DataGridView1.AutoResizeColumn(3)
        Stockestimate()
    End Sub

    Private Sub Update_Record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Record.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()

            Dim cb As String = "update stock set invoiceno = '" & txtinvoiceno.Text & "', productcode = '" & txtProductCode.Text & "',productname='" & txtProductName.Text & "',packing='" & txtWeight.Text & "',units='" & CDec(txtCartons.Text) & "',stockdate='" & dtpStockDate.Text & "',batchno='" & txtbatch.Text & "',expdate='" & dtpExpDate.Text & "',mrp='" & CDec(txtMRP.Text) & "',purrate='" & CDec(txtRate.Text) & "' where stockid='" & txtStockID.Text & "'"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con


            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Update_Record.Enabled = True
            DataGridView1.DataSource = GetData()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Stockestimate()
            con.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try



            If MessageBox.Show("Do you really want to delete the record?", "Stock Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                delete_records()



            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        Try



            Dim RowsAffected As Integer = 0


            con = New OleDbConnection(cs)

            con.Open()


            Dim cq As String = "delete from stock where stockid=@DELETE1;"


            cmd = New OleDbCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 20, "stockid"))


            cmd.Parameters("@DELETE1").Value = Trim(txtStockID.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = GetData()
                clear()
                Stockestimate()
                Update_Record.Enabled = False
                Delete.Enabled = False

            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = GetData()
                clear()
                Update_Record.Enabled = False
                Delete.Enabled = False

                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.clear()
        Save.Enabled = 1
        frmProductsRecord.cmbProductName.Text = ""
        frmProductsRecord.txtProduct.Text = ""
        frmProductsRecord.DataGridView2.DataSource = Nothing
        frmProductsRecord.DataGridView1.DataSource = Nothing
        frmProductsRecord.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.clear()
        frmStockDetails1.fillProduct()
        frmStockDetails1.fillWeight()
        frmStockDetails1.cmbProductName.Text = ""
        frmStockDetails1.txtProduct.Text = ""
        frmStockDetails1.DataGridView2.DataSource = Nothing
        frmStockDetails1.cmbWeight.Text = ""
        frmStockDetails1.DataGridView4.DataSource = Nothing
        frmStockDetails1.DataGridView1.DataSource = Nothing
        frmStockDetails1.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("Calc.exe")
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

   
End Class
