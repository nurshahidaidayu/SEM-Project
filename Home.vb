'Description: main interface that connected to other interface

Public Class Home

    Private Sub NewRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRoomToolStripMenuItem.Click
        NewRoom.Show()
    End Sub

    Private Sub NewCustToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustToolStripMenuItem.Click
        NewCust.Show()
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInToolStripMenuItem.Click
        Show()
    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutToolStripMenuItem.Click
        Employee.Show()
    End Sub

    Private Sub NewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEmployeeToolStripMenuItem.Click
        Hide()
    End Sub

    Private Sub UpdateRoomAvailabilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRoomAvailabilityToolStripMenuItem.Click
        UpdateRoomAvailability.Show()
    End Sub
End Class