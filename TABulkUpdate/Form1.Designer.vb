<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.chkUseAutoAllocationGroups = New System.Windows.Forms.CheckBox()
        Me.lvwEmployeeSlots = New System.Windows.Forms.ListView()
        Me.colGroupShiftID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGroupShiftName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.colFromValueTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFieldDataType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFieldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNewValue = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colFieldDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChecked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gridEmployeeFields = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEmployeeFields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(826, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(72, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(622, 241)
        Me.DataGridView1.TabIndex = 1
        '
        'chkUseAutoAllocationGroups
        '
        Me.chkUseAutoAllocationGroups.AutoSize = True
        Me.chkUseAutoAllocationGroups.Location = New System.Drawing.Point(729, 147)
        Me.chkUseAutoAllocationGroups.Margin = New System.Windows.Forms.Padding(4)
        Me.chkUseAutoAllocationGroups.Name = "chkUseAutoAllocationGroups"
        Me.chkUseAutoAllocationGroups.Size = New System.Drawing.Size(239, 20)
        Me.chkUseAutoAllocationGroups.TabIndex = 138
        Me.chkUseAutoAllocationGroups.Text = "Applicable Shifts for Auto Allocation"
        Me.chkUseAutoAllocationGroups.UseVisualStyleBackColor = True
        Me.chkUseAutoAllocationGroups.Visible = False
        '
        'lvwEmployeeSlots
        '
        Me.lvwEmployeeSlots.CheckBoxes = True
        Me.lvwEmployeeSlots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colGroupShiftID, Me.colGroupShiftName})
        Me.lvwEmployeeSlots.Enabled = False
        Me.lvwEmployeeSlots.FullRowSelect = True
        Me.lvwEmployeeSlots.HideSelection = False
        Me.lvwEmployeeSlots.Location = New System.Drawing.Point(728, 171)
        Me.lvwEmployeeSlots.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwEmployeeSlots.Name = "lvwEmployeeSlots"
        Me.lvwEmployeeSlots.Size = New System.Drawing.Size(253, 133)
        Me.lvwEmployeeSlots.TabIndex = 137
        Me.lvwEmployeeSlots.UseCompatibleStateImageBehavior = False
        Me.lvwEmployeeSlots.View = System.Windows.Forms.View.Details
        Me.lvwEmployeeSlots.Visible = False
        '
        'colGroupShiftID
        '
        Me.colGroupShiftID.Text = ""
        Me.colGroupShiftID.Width = 22
        '
        'colGroupShiftName
        '
        Me.colGroupShiftName.Text = "Shift"
        Me.colGroupShiftName.Width = 155
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(739, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 139
        '
        'dtpDatePicker
        '
        Me.dtpDatePicker.CustomFormat = "dd/MM/yyyy"
        Me.dtpDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDatePicker.Location = New System.Drawing.Point(728, 392)
        Me.dtpDatePicker.Name = "dtpDatePicker"
        Me.dtpDatePicker.Size = New System.Drawing.Size(200, 22)
        Me.dtpDatePicker.TabIndex = 354
        Me.dtpDatePicker.Visible = False
        '
        'colFromValueTable
        '
        Me.colFromValueTable.HeaderText = "ForeignValueTable"
        Me.colFromValueTable.MinimumWidth = 6
        Me.colFromValueTable.Name = "colFromValueTable"
        Me.colFromValueTable.Visible = False
        Me.colFromValueTable.Width = 125
        '
        'colFieldDataType
        '
        Me.colFieldDataType.HeaderText = "DataType"
        Me.colFieldDataType.MinimumWidth = 6
        Me.colFieldDataType.Name = "colFieldDataType"
        Me.colFieldDataType.Visible = False
        Me.colFieldDataType.Width = 125
        '
        'colFieldName
        '
        Me.colFieldName.HeaderText = "FieldName"
        Me.colFieldName.MinimumWidth = 6
        Me.colFieldName.Name = "colFieldName"
        Me.colFieldName.Visible = False
        Me.colFieldName.Width = 125
        '
        'colNewValue
        '
        Me.colNewValue.HeaderText = "New Value"
        Me.colNewValue.MinimumWidth = 6
        Me.colNewValue.Name = "colNewValue"
        Me.colNewValue.Width = 200
        '
        'colFieldDescription
        '
        Me.colFieldDescription.HeaderText = "Field"
        Me.colFieldDescription.MinimumWidth = 6
        Me.colFieldDescription.Name = "colFieldDescription"
        Me.colFieldDescription.ReadOnly = True
        Me.colFieldDescription.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFieldDescription.Width = 220
        '
        'colChecked
        '
        Me.colChecked.HeaderText = ""
        Me.colChecked.MinimumWidth = 6
        Me.colChecked.Name = "colChecked"
        Me.colChecked.Width = 22
        '
        'gridEmployeeFields
        '
        Me.gridEmployeeFields.AllowUserToAddRows = False
        Me.gridEmployeeFields.AllowUserToDeleteRows = False
        Me.gridEmployeeFields.AllowUserToResizeColumns = False
        Me.gridEmployeeFields.AllowUserToResizeRows = False
        Me.gridEmployeeFields.ColumnHeadersHeight = 28
        Me.gridEmployeeFields.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colChecked, Me.colFieldDescription, Me.colNewValue, Me.colFieldName, Me.colFieldDataType, Me.colFromValueTable})
        Me.gridEmployeeFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.gridEmployeeFields.Location = New System.Drawing.Point(72, 288)
        Me.gridEmployeeFields.Margin = New System.Windows.Forms.Padding(4)
        Me.gridEmployeeFields.MultiSelect = False
        Me.gridEmployeeFields.Name = "gridEmployeeFields"
        Me.gridEmployeeFields.RowHeadersVisible = False
        Me.gridEmployeeFields.RowHeadersWidth = 51
        Me.gridEmployeeFields.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridEmployeeFields.RowTemplate.Height = 25
        Me.gridEmployeeFields.Size = New System.Drawing.Size(622, 193)
        Me.gridEmployeeFields.TabIndex = 353
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 503)
        Me.Controls.Add(Me.dtpDatePicker)
        Me.Controls.Add(Me.gridEmployeeFields)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.chkUseAutoAllocationGroups)
        Me.Controls.Add(Me.lvwEmployeeSlots)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEmployeeFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents chkUseAutoAllocationGroups As CheckBox
    Friend WithEvents lvwEmployeeSlots As ListView
    Friend WithEvents colGroupShiftID As ColumnHeader
    Friend WithEvents colGroupShiftName As ColumnHeader
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dtpDatePicker As DateTimePicker
    Friend WithEvents colFromValueTable As DataGridViewTextBoxColumn
    Friend WithEvents colFieldDataType As DataGridViewTextBoxColumn
    Friend WithEvents colFieldName As DataGridViewTextBoxColumn
    Friend WithEvents colNewValue As DataGridViewComboBoxColumn
    Friend WithEvents colFieldDescription As DataGridViewTextBoxColumn
    Friend WithEvents colChecked As DataGridViewCheckBoxColumn
    Friend WithEvents gridEmployeeFields As DataGridView
End Class
