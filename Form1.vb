Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then Or TextBox2.Text = "" Then
            MsgBox("enter the number")
        Else
        TextBox3.Text = TextBox1.Text / TextBox2.Text ^ 2
        End


    End Sub