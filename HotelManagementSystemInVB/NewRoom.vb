Imports System.Data
Imports System.Data.SqlClient

Public Class NewRoom
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MS\Downloads\SEM project\HotelManagementSystemInVB\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        com = New SqlCommand("insert into room(r_type,r_no,r_rate,no_person,no_bed)values('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Record inserted successfully..")
        Hide()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = "--Select Room--"
        ComboBox2.Text = "--Select Person--"
        ComboBox3.Text = "--Select Bed--"
    End Sub
End Class