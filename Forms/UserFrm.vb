Option Explicit On
Imports System.IO
Imports System
Imports System.Net.Dns
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration.ConfigurationSettings

Public Class UserFrm
    Dim con As New OleDbConnection
    Dim conStr As String = EnrollSys.My.Settings.SkolDBFConnectionString.ToString
    Dim DES As New System.Security.Cryptography.TripleDESCryptoServiceProvider
    Dim Hash As New System.Security.Cryptography.MD5CryptoServiceProvider

    Private Sub bChange_Click(sender As System.Object, e As System.EventArgs) Handles bChange.Click
        If tId.Text = Nothing Or tFullnym.Text = Nothing Or tPass.Text = Nothing Or tConf.Text = Nothing Then
            MsgBox("Incomplete Data")
            tId.Focus()
            Exit Sub
        End If
        If tPass.Text <> tConf.Text Then
            MsgBox("Password and Confirm Password does not match")
            tPass.Text = ""
            tConf.Text = ""
            tPass.Focus()
            Exit Sub
        End If


        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand

        DES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(tPass.Text))
        DES.Mode = Security.Cryptography.CipherMode.ECB
        Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateEncryptor
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(tPass.Text)
        Dim sPass As String
        sPass = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))

        con.ConnectionString = conStr
        cmd.Connection = con

        cmd.CommandText = "INSERT INTO tblUser([Username],[Password],FullName, CreationDate) " &
                            " VALUES('" & tId.Text & "','" & sPass & "','" & tFullnym.Text & "',now())"
                            
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Successfully Save....")
        Catch ex As Exception
            MsgBox("error...Insert..." & ex.Message)
            con.Close()
            Exit Sub
        Finally
            con.Close()
        End Try



    End Sub

    Private Sub UserFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClose.Click
        If MessageBox.Show("Want to Quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class