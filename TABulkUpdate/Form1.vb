Public Class Form1

    Private datePicker As DateTimePicker
    Private timePicker As DateTimePicker
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtBoolean As New DataTable
        dtBoolean.Columns.Add("Display", GetType(String))
        dtBoolean.Columns.Add("Value", GetType(Integer))

        dtBoolean.Rows.Add("Yes", 1)
        dtBoolean.Rows.Add("No", 0)

        Dim dtHwt As New DataTable
        dtHwt.Columns.Add("Name", GetType(String))
        dtHwt.Columns.Add("Type", GetType(Integer))

        dtHwt.Rows.Add("Clocking", 1)
        dtHwt.Rows.Add("Shift", 2)
        dtHwt.Rows.Add("Manual", 3)
        dtHwt.Rows.Add("Leave", 5)

        DataGridView1.ColumnCount = 2
        DataGridView1.Columns(0).Name = "Field"
        DataGridView1.Columns(1).Name = "Value"

        Dim ChkBox As New DataGridViewCheckBoxColumn With {
            .FlatStyle = FlatStyle.Standard
        }
        DataGridView1.Columns.Insert(0, ChkBox)

        DataGridView1.Columns(0).Width = 40
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 85

        'stateCell.Items.AddRange(New String() {"Yes", "NO"})
        Dim stateCell As New DataGridViewComboBoxCell With {
            .DisplayMember = "Display",
            .ValueMember = "Value",
            .DataSource = dtBoolean
        }
        Dim row As New DataGridViewRow()
        row.CreateCells(DataGridView1)
        row.Cells(0).Value = False
        row.Cells(1).Value = "Use Time and Attendance"
        row.Cells(2) = stateCell
        DataGridView1.Rows.Add(row)

        'cityCell.Items.AddRange(New String() {"Clocking", "Shift", "Manual", "Leave"})
        Dim cityCell As New DataGridViewComboBoxCell() With {
            .DisplayMember = "Name",
            .ValueMember = "Type",
            .DataSource = dtHwt
        }
        Dim cityrow As New DataGridViewRow()
        cityrow.CreateCells(DataGridView1)
        cityrow.Cells(0).Value = False
        cityrow.Cells(1).Value = "Hours Worked From"
        cityrow.Cells(2) = cityCell
        DataGridView1.Rows.Add(cityrow)

        Dim staterow As New DataGridViewRow()
        staterow.CreateCells(DataGridView1)
        staterow.Cells(0).Value = False
        staterow.Cells(1).Value = "Shift Base Date"
        staterow.Cells(2).Value = Format(Today, "dd/MM/yyyy")
        DataGridView1.Rows.Add(staterow)

        Dim minFlex As New DataGridViewRow()
        minFlex.CreateCells(DataGridView1)
        minFlex.Cells(0).Value = False
        minFlex.Cells(1).Value = "Minimum Flexitime Hours"
        minFlex.Cells(2).Value = "0.00"
        DataGridView1.Rows.Add(minFlex)

        ' Auto Allocate Slots - combobox for Yes/No then another multiselect dropdown for applicable slots 
        Dim autoSlots As New DataGridViewRow()
        autoSlots.CreateCells(DataGridView1)
        autoSlots.Cells(0).Value = False
        autoSlots.Cells(1).Value = "Auto Allocate Slots"
        Dim cmbAutoSlots As New DataGridViewComboBoxCell With {
            .DisplayMember = "Display",
            .ValueMember = "Value",
            .DataSource = dtBoolean
        }
        autoSlots.Cells(2) = cmbAutoSlots
        DataGridView1.Rows.Add(autoSlots)

        ' Allowed Access Time From --- picktime
        Dim accessTime As New DataGridViewRow()
        accessTime.CreateCells(DataGridView1)
        accessTime.Cells(0).Value = False
        accessTime.Cells(1).Value = "Allowed Access Time From"
        accessTime.Cells(2).Value = Now.Hour.ToString("00") + ":00:00"
        DataGridView1.Rows.Add(accessTime)

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False

        Dim pnl As New Panel()
        Me.Controls.Add(pnl)
        pnl.Name = "pnl"
        pnl.Visible = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 2 Then
            If DataGridView1.Rows(e.RowIndex).Cells(1).Value = "Shift Base Date" Then
                datePicker = New DateTimePicker()
                DataGridView1.Controls.Add(datePicker)
                datePicker.Format = DateTimePickerFormat.Custom
                datePicker.CustomFormat = "dd/MM/yyyy"

                Dim rectangle As Rectangle = DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                datePicker.Size = New Size(rectangle.Width, rectangle.Height)
                datePicker.Location = New Point(rectangle.X, rectangle.Y)
                AddHandler datePicker.CloseUp, New EventHandler(AddressOf datepicker_closeup)
                AddHandler datePicker.TextChanged, New EventHandler(AddressOf datepicker_textchanged)

                datePicker.Visible = True
            ElseIf DataGridView1.Rows(e.RowIndex).Cells(1).Value = "Allowed Access Time From" Then
                timePicker = New DateTimePicker()
                DataGridView1.Controls.Add(timePicker)
                timePicker.Format = DateTimePickerFormat.Time
                timePicker.ShowUpDown = True
                timePicker.Value = New DateTime(Today.Year, Today.Month, Today.Day).AddHours(Now.Hour)

                Dim rectangle As Rectangle = DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                timePicker.Size = New Size(rectangle.Width, rectangle.Height)
                timePicker.Location = New Point(rectangle.X, rectangle.Y)
                'AddHandler timePicker.ValueChanged, New EventHandler(AddressOf timepicker_valuechanged)
                AddHandler timePicker.TextChanged, New EventHandler(AddressOf timepicker_textchanged)

                timePicker.Visible = True
            End If
        End If
    End Sub

    Private Sub datepicker_textchanged(sender As Object, e As EventArgs)
        DataGridView1.CurrentCell.Value = datePicker.Text.ToString()
    End Sub

    Private Sub datepicker_closeup(sender As Object, e As EventArgs)
        datePicker.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            If DirectCast(row.Cells(0).Value, Boolean) Then
                MsgBox("Field: " + row.Cells(1).Value + " Value: " + row.Cells(2).Value.ToString())
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.ColumnIndex = 2 Then
            If DataGridView1.Rows(e.RowIndex).Cells(1).Value = "Minimum Flexitime Hours" Then
                Dim d As Double = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString())
                DataGridView1.CurrentCell.Value = d.ToString("N2")
            End If
        End If
    End Sub
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 2.
        If DataGridView1.CurrentCell.ColumnIndex = 2 Then
            If DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value = "Auto Allocate Slots" Then
                Dim combo As ComboBox = CType(e.Control, ComboBox)
                If combo IsNot Nothing Then
                    ' Remove an existing event-handler, if present, to avoid 
                    ' adding multiple handlers when the editing control is reused.
                    RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                    ' Add the event handler. 
                    AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
                End If
            ElseIf DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value = "Allowed Access Time From" Then
                'Dim timepicker As DateTimePicker = CType(e.Control, DateTimePicker)
                'If timepicker IsNot Nothing Then
                '    RemoveHandler timepicker.ValueChanged, New EventHandler(AddressOf timepicker_valuechanged)
                '    AddHandler timepicker.ValueChanged, New EventHandler(AddressOf timepicker_valuechanged)
                'End If

            End If
        End If
    End Sub

    Private Sub timepicker_valuechanged(sender As Object, e As EventArgs)
        DataGridView1.CurrentCell.Value = timePicker.Value.ToString("HH:mm:ss")
    End Sub

    Private Sub timepicker_textchanged(sender As Object, e As EventArgs)
        DataGridView1.CurrentCell.Value = timePicker.Text.ToString()
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        chkUseAutoAllocationGroups.Visible = CBool(combo.SelectedValue)
        lvwEmployeeSlots.Visible = CBool(combo.SelectedValue)
        If combo.Text.ToUpper() = "YES" Then
            Dim rectangle As Rectangle = DataGridView1.GetCellDisplayRectangle(DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentCell.RowIndex, True)
            chkUseAutoAllocationGroups.Location = New Point(rectangle.X + 200, rectangle.Y + 10)
            lvwEmployeeSlots.Location = New Point(rectangle.X + 200, rectangle.Y + 34)
            FillSlots()
        End If
    End Sub

    Private Sub FillSlots()
        Dim dtSlots As New DataTable
        dtSlots.Columns.Add("ID", GetType(Integer))
        dtSlots.Columns.Add("Name", GetType(String))

        dtSlots.Rows.Add(1, "Admin Normal")
        dtSlots.Rows.Add(2, "Admin Friday")
        dtSlots.Rows.Add(3, "Workshop Morning")
        dtSlots.Rows.Add(4, "Workshop Night")
        dtSlots.Rows.Add(5, "Workshop Weekend")

        lvwEmployeeSlots.Items.Clear()
        For Each dRow As DataRow In dtSlots.Rows
            Dim lvItem = New ListViewItem With {
                .Text = CStr(dRow("ID"))
            }
            lvItem.SubItems.Add(CStr(dRow("Name")))
            lvwEmployeeSlots.Items.Add(lvItem)
        Next
    End Sub

    Private Sub chkUseAutoAllocationGroups_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseAutoAllocationGroups.CheckedChanged
        lvwEmployeeSlots.Enabled = chkUseAutoAllocationGroups.Checked
        If Not chkUseAutoAllocationGroups.Checked Then
            For Each lvItem As ListViewItem In lvwEmployeeSlots.CheckedItems
                lvItem.Checked = False
            Next
        End If
    End Sub
End Class
