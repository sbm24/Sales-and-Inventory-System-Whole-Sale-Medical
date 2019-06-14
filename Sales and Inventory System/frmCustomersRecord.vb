Imports System.Data.OleDB
Public Class frmCustomersRecord

    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"
    Dim DispQuery As String = "SELECT (customerNo) as [Distributor ID],(B_name) as [B_Name],(b_address) as [B_Address],(b_city) as [B_City],(email)as [Email],(mobileno) as [Mobile No],(notes)as [Notes],(Cdisc)as [Disc],(InvType) as [Invoice Type]"

    Private ReadOnly Property Connection() As OleDbConnection
        Get
            Dim ConnectionToFetch As New OleDbConnection(cs)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property
    Public Function GetData() As DataView
        Dim SelectQry = DispQuery & " from Customer order by customerno"

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
        Me.Show()
        txtCustomer.Focus()

        fillName()
        DataGridView1.DataSource = GetData()
    End Sub









    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click

        txtCustomer.Text = ""
        txtName.Text = ""
        DataGridView2.DataSource = Nothing
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
            frmSales.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmSales.txtCustomerNo.Text = dr.Cells(0).Value.ToString()
            frmSales.txtCustomerName.Text = dr.Cells(1).Value.ToString()
            frmSales.txtDisc.Text = dr.Cells(7).Value.ToString()
            If dr.Cells(8).Value.ToString() <> "" Then
                If dr.Cells(8).Value.ToString() = "SALE" Then
                    frmSales.cmbInvType.SelectedIndex = 0
                ElseIf dr.Cells(8).Value.ToString() = "TAX" Then
                    frmSales.cmbInvType.SelectedIndex = 1
                End If
            End If
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
            frmSales.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmSales.txtCustomerNo.Text = dr.Cells(0).Value.ToString()
            frmSales.txtCustomerName.Text = dr.Cells(1).Value.ToString()
            frmSales.txtDisc.Text = dr.Cells(7).Value.ToString()
            If dr.Cells(8).Value.ToString() <> "" Then
                If dr.Cells(8).Value.ToString() = "SALE" Then
                    frmSales.cmbInvType.SelectedIndex = 0
                ElseIf dr.Cells(8).Value.ToString() = "TAX" Then
                    frmSales.cmbInvType.SelectedIndex = 1
                End If
            End If
            Me.Close()





        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand(DispQuery & " from Customer where B_Name like '" & txtCustomer.Text & "%'  order by CustomerNo", con)



            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Customer")

            DataGridView2.DataSource = myDataSet.Tables("Customer").DefaultView



            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        txtCustomer.Text = ""
        txtName.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub txtName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand(DispQuery & " from Customer where B_Name = '" & txtName.Text & "'  order by CustomerNo", con)



            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Customer")

            DataGridView2.DataSource = myDataSet.Tables("Customer").DefaultView



            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class