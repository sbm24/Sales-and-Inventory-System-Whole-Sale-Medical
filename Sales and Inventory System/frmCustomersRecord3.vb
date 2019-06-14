﻿Imports System.Data.OleDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmCustomersRecord3

    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"
    Dim DispQuery As String = "SELECT (customerNo) as [Distributor ID],(B_name) as [B_Name],(b_address) as [B_Address],(b_city) as [B_City],(email)as [Email],(mobileno) as [Mobile No],(notes)as [Notes],(tin) as [Tin], (Cdisc) as [Def_Disc] , (InvType) as [InvType]"
    Private ReadOnly Property Connection() As OleDbConnection
        Get
            Dim ConnectionToFetch As New OleDbConnection(cs)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property
    Public Function GetData() As DataView
        Dim SelectQry = DispQuery & " from Customer order by CustomerNo"

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



    Private Sub frmCustomersRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillName()
        Me.Show()
        txtCustomer.Focus()


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DataGridView1.DataSource = GetData()
        DataGridView1.AutoResizeColumn(1)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        txtName.Text = ""
        txtCustomer.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click

        DataGridView1.DataSource = Nothing
        txtName.Text = ""
        txtCustomer.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub
    Sub fillName()

        Try

            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (B_Name) FROM Customer", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            txtName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                txtName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
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
            frmCustomer.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmCustomer.txtCustomerNo.Text = dr.Cells(0).Value.ToString()
            frmCustomer.B_name.Text = dr.Cells(1).Value.ToString()

            frmCustomer.B_Address.Text = dr.Cells(2).Value.ToString()
            frmCustomer.B_City.Text = dr.Cells(3).Value.ToString()
            frmCustomer.txtEmail.Text = dr.Cells(4).Value.ToString()
            frmCustomer.txtMobileNo.Text = dr.Cells(5).Value.ToString()
            frmCustomer.txtNotes.Text = dr.Cells(6).Value.ToString()
            frmCustomer.txtTin.Text = dr.Cells(7).Value.ToString()
            frmCustomer.txtCdisc.Text = dr.Cells(8).Value.ToString()
            If dr.Cells(9).Value.ToString() = "SALE" Then
                frmCustomer.RadioButton1.Checked = 1
            ElseIf dr.Cells(9).Value.ToString() = "TAX" Then
                frmCustomer.RadioButton2.Checked = 1
            Else
                frmCustomer.RadioButton1.Checked = 0
                frmCustomer.RadioButton2.Checked = 0
            End If
            frmCustomer.Update_Record.Enabled = True
            frmCustomer.Delete.Enabled = True
            frmCustomer.Save.Enabled = False
            Me.Close()

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
            frmCustomer.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmCustomer.txtCustomerNo.Text = dr.Cells(0).Value.ToString()
            frmCustomer.B_name.Text = dr.Cells(1).Value.ToString()

            frmCustomer.B_Address.Text = dr.Cells(2).Value.ToString()
            frmCustomer.B_City.Text = dr.Cells(3).Value.ToString()

            frmCustomer.txtEmail.Text = dr.Cells(4).Value.ToString()
            frmCustomer.txtMobileNo.Text = dr.Cells(5).Value.ToString()
            frmCustomer.txtNotes.Text = dr.Cells(6).Value.ToString()
            frmCustomer.txtTin.Text = dr.Cells(7).Value.ToString()
            frmCustomer.txtCdisc.Text = dr.Cells(8).Value.ToString()
            If dr.Cells(9).Value.ToString() = "SALE" Then
                frmCustomer.RadioButton1.Checked = 1
            ElseIf dr.Cells(9).Value.ToString() = "TAX" Then
                frmCustomer.RadioButton2.Checked = 1

            Else
                frmCustomer.RadioButton1.Checked = 0
                frmCustomer.RadioButton2.Checked = 0
            End If
            frmCustomer.Update_Record.Enabled = True
            frmCustomer.Delete.Enabled = True
            frmCustomer.Save.Enabled = False
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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

    Private Sub txtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand(DispQuery & " from Customer where B_Name like '" & txtCustomer.Text & "%'  order by CustomerNo", con)



            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Customer")

            DataGridView2.DataSource = myDataSet.Tables("Customer").DefaultView
            DataGridView2.AutoResizeColumn(1)


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand(DispQuery & " from Customer where B_Name = '" & txtName.Text & "' order by CustomerNo", con)



            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Customer")

            DataGridView2.DataSource = myDataSet.Tables("Customer").DefaultView
            DataGridView2.AutoResizeColumn(1)


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class