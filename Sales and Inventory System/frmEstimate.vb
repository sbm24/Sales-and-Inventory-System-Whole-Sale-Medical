Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmEstimate

    Private Sub frmEstimate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try

        Dim rpt As New rptEstimate() 'The report you created.
        Dim myConnection As OleDbConnection
        Dim MyCommand As New OleDbCommand()
        Dim myDA As New OleDbDataAdapter()
        Dim myDS As New DataSet 'The DataSet you created.


        myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;")
        myConnection.Open()
        MyCommand.Connection = myConnection
        MyCommand.CommandText = "select  orderinfo.orderno,orderinfo.orderDate,orderinfo.customername,orderedproduct.ProductCode,orderedproduct.ProductName,orderedproduct.Packing,orderedproduct.BillQty,orderedproduct.Free,orderedproduct.BatchNo,orderedproduct.ExpDate,orderedproduct.MRP,orderedproduct.Rate,orderedproduct.Disc,orderedproduct.Tax,orderedproduct.Amount,orderedproduct.stockid,orderinfo.SubTotal,orderinfo.DiscAmount,orderinfo.TaxAmount,orderinfo.TotalAmount,Customer.B_name,Customer.B_address,Customer.B_city,Customer.email,Customer.MobileNo,customer.tin from orderinfo,orderedproduct,Customer where orderinfo.orderno=orderedproduct.orderno and Customer.CustomerNo=orderinfo.CustomerNo and orderedproduct.orderno= '" & frmOrder.txtOrderNo.Text & "'"
        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand
        myDA.Fill(myDS, "orderinfo")
        myDA.Fill(myDS, "orderedproduct")
        myDA.Fill(myDS, "Customer")
        rpt.SetDataSource(myDS)
        CrystalReportViewer1.ReportSource = rpt
        myConnection.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class