Imports System.IO
Public Class Form1
    Dim txtfilereader As StreamReader
    Dim checker As String
    Dim turn As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfilereader = My.Computer.FileSystem.OpenTextFileReader("ContactTracerOutput.txt")

        RichTextBoxDisplay.Text = txtfilereader.ReadToEnd()

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        txtfilereader = My.Computer.FileSystem.OpenTextFileReader("ContactTracerOutput.txt")
        While Not txtfilereader.EndOfStream
            checker = txtfilereader.ReadLine()
            If checker.Equals("FullName: " & TextBoxSearch.Text) Then
                checker &= vbCrLf & txtfilereader.ReadLine()
                checker &= vbCrLf & txtfilereader.ReadLine()
                checker &= vbCrLf & txtfilereader.ReadLine()
                checker &= vbCrLf & txtfilereader.ReadLine()
                RichTextBoxDisplay.Text = checker
                turn = True
                Exit While
            End If
        End While
        If turn <> True Then
            MessageBox.Show("no record found")

        End If
        turn = False
    End Sub
End Class
