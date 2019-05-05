Imports System.Data
Imports System.Data.SqlClient

Public Class Employee
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MS\Downloads\SEM project\HotelManagementSystemInVB\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        com = New SqlCommand("insert into employee(name,mobile,gender,addr,role,join_date,shift,salary)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Value.Date & "','" & ComboBox3.Text & "','" & TextBox4.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Record inserted successfully..")
        Hide()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select Role--"
        ComboBox3.Text = "--Select Shift--"
    End Sub
End Class