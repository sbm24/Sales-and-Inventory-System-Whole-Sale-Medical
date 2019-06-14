Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmBillingReport

    Private Sub frmBillingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim rpt As New rptInvoice() 'The report you created.
            Dim myConnection As OleDbConnection
            Dim MyCommand As New OleDbCommand()
            Dim myDA As New OleDbDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.


            myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;")
            myConnection.Open()
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select  Billinfo.Invoiceno,Billinfo.BillingDate,Billinfo.customername,ProductSold.ProductCode,ProductSold.ProductName,ProductSold.Packing,ProductSold.BillQty,ProductSold.Free,ProductSold.BatchNo,ProductSold.ExpDate,ProductSold.MRP,ProductSold.Rate,ProductSold.Disc,ProductSold.Tax,ProductSold.Amount,ProductSold.stockid,Billinfo.SubTotal,Billinfo.DiscAmount,Billinfo.TaxAmount,Billinfo.GrandTotal,Billinfo.TotalPayment,Billinfo.PaymentDue,Billinfo.Type,Customer.B_name,Customer.B_address,Customer.B_city,Customer.email,Customer.MobileNo,customer.tin from Billinfo,ProductSold,Customer where Billinfo.InvoiceNo=ProductSold.InvoiceNo and Customer.CustomerNo=Billinfo.CustomerNo and productsold.Invoiceno= '" & frmSales.txtInvoiceNo.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "BillInfo")
            myDA.Fill(myDS, "ProductSold")
            myDA.Fill(myDS, "Customer")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
            myConnection.Close()

            rpt.PrintOptions.PrinterName = "EPSON LX-310 ESC/P"
            rpt.PrintOptions.PaperSource = PaperSource.Tractor
            rpt.PrintOptions.PaperSize = PaperSize.DefaultPaperSize
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
