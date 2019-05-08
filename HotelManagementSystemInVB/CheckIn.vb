Imports System.Data
Imports System.Data.SqlClient

Public Class CheckIn
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim getemp As String
    Dim dr As SqlDataReader

    

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles button_insert.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MS\Downloads\SEM project\HotelManagementSystemInVB\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        com = New SqlCommand("insert into CheckInOut(id,check_in,room_num)values('" & text_id.Text & "','" & DateTimePicker1.Value.Date & "','" & text_r_no.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Check In Data inserted successfully..")
        Hide()
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles text_id.TextChanged
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MS\Downloads\SEM project\HotelManagementSystemInVB\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        con.Open()

        Try
            getemp = "select name,mobile,nation,gender,city,state from customer where id='" & text_id.Text & "'"
            com = New SqlCommand(getemp, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                label_name.Text = dr.GetValue(0).ToString()
                label_mobile.Text = dr.GetValue(1).ToString()
                label_nationality.Text = dr.GetValue(2).ToString()
                label_gender.Text = dr.GetValue(3).ToString()
                label_city.Text = dr.GetValue(4).ToString()
                label_state.Text = dr.GetValue(5).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles button_update.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MS\Downloads\SEM project\HotelManagementSystemInVB\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value.ToString("dd/MM/yyy"))

        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value.ToString("dd/MM/yyy"))

        Dim ts As TimeSpan = dt2.Subtract(dt1)
        com = New SqlCommand(" update CheckInOut set check_out='" + DateTimePicker2.Value.Date + "',total_days='" + text_total_days.Text + "' where id= '" & text_id.Text & "'", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Check Out Data updated successfully..")
        Hide()
        con.Close()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value.ToString("dd/MM/yyy"))

        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value.ToString("dd/MM/yyy"))

        Dim ts As TimeSpan = dt2.Subtract(dt1)
        text_total_days.Text = Convert.ToInt32(ts.Days)
    End Sub

    Private Sub button_check_availability_Click(sender As Object, e As EventArgs) Handles button_check_availability.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MS\Downloads\SEM project\HotelManagementSystemInVB\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        con.Open()

        Try
            getemp = "select r_availability from room where r_no='" & text_r_no.Text & "'"
            com = New SqlCommand(getemp, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                If dr.GetValue(0).ToString() Like "0" Then
                    MsgBox("Room is not available.")
                    button_insert.Enabled = False
                    button_update.Enabled = False
                ElseIf dr.GetValue(0).ToString() Like "1" Then
                    MsgBox("Room is available.")
                    button_insert.Enabled = True
                    button_update.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        label_name.Text = ""
        label_mobile.Text = ""
        label_nationality.Text = ""
        label_gender.Text = ""
        label_city.Text = ""
        label_state.Text = ""
        text_id.Text = ""
        text_total_days.Text = ""
        text_r_no.Text = ""

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value.ToString("dd/MM/yyy"))

        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value.ToString("dd/MM/yyy"))

        Dim ts As TimeSpan = dt2.Subtract(dt1)
        text_total_days.Text = Convert.ToInt32(ts.Days)
    End Sub
End Class
