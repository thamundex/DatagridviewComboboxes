<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.chkUseAutoAllocationGroups = New System.Windows.Forms.CheckBox()
        Me.lvwEmployeeSlots = New System.Windows.Forms.ListView()
        Me.colGroupShiftID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGroupShiftName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 386)
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
        Me.DataGridView1.Size = New System.Drawing.Size(622, 349)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 450)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.chkUseAutoAllocationGroups)
        Me.Controls.Add(Me.lvwEmployeeSlots)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
