<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.label_name = New System.Windows.Forms.Label()
        Me.label_mobile = New System.Windows.Forms.Label()
        Me.label_nationality = New System.Windows.Forms.Label()
        Me.label_gender = New System.Windows.Forms.Label()
        Me.label_city = New System.Windows.Forms.Label()
        Me.label_state = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.text_total_days = New System.Windows.Forms.TextBox()
        Me.button_insert = New System.Windows.Forms.Button()
        Me.button_update = New System.Windows.Forms.Button()
        Me.button_reset = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.label_r_no = New System.Windows.Forms.Label()
        Me.text_r_no = New System.Windows.Forms.TextBox()
        Me.button_check_availability = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 28)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Check In - Check Out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nationality"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Mobile"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(390, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Check In Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(378, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Check Out Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(414, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total Days"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(47, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 21)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "City"
        '
        'text_id
        '
        Me.text_id.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.Location = New System.Drawing.Point(132, 54)
        Me.text_id.Name = "text_id"
        Me.text_id.Size = New System.Drawing.Size(153, 28)
        Me.text_id.TabIndex = 19
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(128, 106)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(0, 21)
        Me.label_name.TabIndex = 20
        '
        'label_mobile
        '
        Me.label_mobile.AutoSize = True
        Me.label_mobile.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_mobile.Location = New System.Drawing.Point(128, 149)
        Me.label_mobile.Name = "label_mobile"
        Me.label_mobile.Size = New System.Drawing.Size(0, 21)
        Me.label_mobile.TabIndex = 21
        '
        'label_nationality
        '
        Me.label_nationality.AutoSize = True
        Me.label_nationality.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nationality.Location = New System.Drawing.Point(128, 192)
        Me.label_nationality.Name = "label_nationality"
        Me.label_nationality.Size = New System.Drawing.Size(0, 21)
        Me.label_nationality.TabIndex = 22
        '
        'label_gender
        '
        Me.label_gender.AutoSize = True
        Me.label_gender.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_gender.Location = New System.Drawing.Point(128, 234)
        Me.label_gender.Name = "label_gender"
        Me.label_gender.Size = New System.Drawing.Size(0, 21)
        Me.label_gender.TabIndex = 23
        '
        'label_city
        '
        Me.label_city.AutoSize = True
        Me.label_city.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_city.Location = New System.Drawing.Point(128, 277)
        Me.label_city.Name = "label_city"
        Me.label_city.Size = New System.Drawing.Size(0, 21)
        Me.label_city.TabIndex = 24
        '
        'label_state
        '
        Me.label_state.AutoSize = True
        Me.label_state.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_state.Location = New System.Drawing.Point(128, 318)
        Me.label_state.Name = "label_state"
        Me.label_state.Size = New System.Drawing.Size(0, 21)
        Me.label_state.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(544, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(544, 134)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker2.TabIndex = 27
        '
        'text_total_days
        '
        Me.text_total_days.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_days.Location = New System.Drawing.Point(544, 199)
        Me.text_total_days.Name = "text_total_days"
        Me.text_total_days.ReadOnly = True
        Me.text_total_days.Size = New System.Drawing.Size(153, 28)
        Me.text_total_days.TabIndex = 28
        '
        'button_insert
        '
        Me.button_insert.Enabled = False
        Me.button_insert.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_insert.Location = New System.Drawing.Point(203, 372)
        Me.button_insert.Name = "button_insert"
        Me.button_insert.Size = New System.Drawing.Size(112, 31)
        Me.button_insert.TabIndex = 29
        Me.button_insert.Text = "Check In"
        Me.button_insert.UseVisualStyleBackColor = True
        '
        'button_update
        '
        Me.button_update.Enabled = False
        Me.button_update.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_update.Location = New System.Drawing.Point(339, 372)
        Me.button_update.Name = "button_update"
        Me.button_update.Size = New System.Drawing.Size(112, 31)
        Me.button_update.TabIndex = 30
        Me.button_update.Text = "Check Out"
        Me.button_update.UseVisualStyleBackColor = True
        '
        'button_reset
        '
        Me.button_reset.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_reset.Location = New System.Drawing.Point(475, 372)
        Me.button_reset.Name = "button_reset"
        Me.button_reset.Size = New System.Drawing.Size(112, 31)
        Me.button_reset.TabIndex = 31
        Me.button_reset.Text = "Reset"
        Me.button_reset.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(415, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(347, 16)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "when customer check out only that time select below check out date "
        '
        'label_r_no
        '
        Me.label_r_no.AutoSize = True
        Me.label_r_no.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_r_no.Location = New System.Drawing.Point(387, 263)
        Me.label_r_no.Name = "label_r_no"
        Me.label_r_no.Size = New System.Drawing.Size(113, 21)
        Me.label_r_no.TabIndex = 33
        Me.label_r_no.Text = "Room Number"
        '
        'text_r_no
        '
        Me.text_r_no.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_r_no.Location = New System.Drawing.Point(544, 260)
        Me.text_r_no.Name = "text_r_no"
        Me.text_r_no.Size = New System.Drawing.Size(153, 28)
        Me.text_r_no.TabIndex = 34
        '
        'button_check_availability
        '
        Me.button_check_availability.Location = New System.Drawing.Point(704, 263)
        Me.button_check_availability.Name = "button_check_availability"
        Me.button_check_availability.Size = New System.Drawing.Size(58, 23)
        Me.button_check_availability.TabIndex = 35
        Me.button_check_availability.Text = "Check"
        Me.button_check_availability.UseVisualStyleBackColor = True
        '
        'CheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 421)
        Me.Controls.Add(Me.button_check_availability)
        Me.Controls.Add(Me.text_r_no)
        Me.Controls.Add(Me.label_r_no)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.button_reset)
        Me.Controls.Add(Me.button_update)
        Me.Controls.Add(Me.button_insert)
        Me.Controls.Add(Me.text_total_days)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.label_state)
        Me.Controls.Add(Me.label_city)
        Me.Controls.Add(Me.label_gender)
        Me.Controls.Add(Me.label_nationality)
        Me.Controls.Add(Me.label_mobile)
        Me.Controls.Add(Me.label_name)
        Me.Controls.Add(Me.text_id)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "CheckIn"
        Me.Text = "CheckIn-CheckOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents text_id As System.Windows.Forms.TextBox
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents label_mobile As System.Windows.Forms.Label
    Friend WithEvents label_nationality As System.Windows.Forms.Label
    Friend WithEvents label_gender As System.Windows.Forms.Label
    Friend WithEvents label_city As System.Windows.Forms.Label
    Friend WithEvents label_state As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents text_total_days As System.Windows.Forms.TextBox
    Friend WithEvents button_insert As System.Windows.Forms.Button
    Friend WithEvents button_update As System.Windows.Forms.Button
    Friend WithEvents button_reset As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents label_r_no As Label
    Friend WithEvents text_r_no As TextBox
    Friend WithEvents button_check_availability As Button
End Class
