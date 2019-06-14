Imports System.IO


Public Class frmSetting



    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = AppDomain.CurrentDomain.GetData("DataDirectory")
        Label4.Text = Path.Combine(My.Settings.Bpath, "Backup_Database\")
    End Sub


    Private Sub Label2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Label2.LinkClicked
        Try
            Process.Start("explorer.exe", Label2.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Label4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Label4.LinkClicked
        Try
            Process.Start("explorer.exe", Label4.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.MyComputer
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Application Configeration Files Path"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.Bpath = dialog.SelectedPath
            My.Settings.Save()
            Label4.Text = Path.Combine(My.Settings.Bpath, "Backup_Database\")
        End If

    End Sub
End Class