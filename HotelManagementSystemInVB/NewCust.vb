Imports System.Data
Imports System.Data.SqlClient

Public Class NewCust
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim getcust As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MS\Downloads\SEM project\HotelManagementSystemInVB\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        com = New SqlCommand("insert into customer(name,mobile,nation,gender,city,state)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        getcust = "select max(id) from customer"
        com = New SqlCommand(getcust, con)
        dr = com.ExecuteReader()
        If dr.Read() Then
            MsgBox("Record inserted successfully..Your id is '" & dr.GetInt32(0) & "'")
            Hide()
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox2.Text = "--Select--"
    End Sub
End Class