<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipment_Order
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
        Me.Inventory = New System.Windows.Forms.Button()
        Me.CheckEquipmentIn = New System.Windows.Forms.Button()
        Me.CheckEquipmentOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Inventory
        '
        Me.Inventory.Location = New System.Drawing.Point(31, 24)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Size = New System.Drawing.Size(232, 156)
        Me.Inventory.TabIndex = 0
        Me.Inventory.Text = "Inventory"
        Me.Inventory.UseVisualStyleBackColor = True
        '
        'CheckEquipmentIn
        '
        Me.CheckEquipmentIn.Location = New System.Drawing.Point(486, 24)
        Me.CheckEquipmentIn.Name = "CheckEquipmentIn"
        Me.CheckEquipmentIn.Size = New System.Drawing.Size(244, 156)
        Me.CheckEquipmentIn.TabIndex = 1
        Me.CheckEquipmentIn.Text = "Check Equipment In"
        Me.CheckEquipmentIn.UseVisualStyleBackColor = True
        '
        'CheckEquipmentOut
        '
        Me.CheckEquipmentOut.Location = New System.Drawing.Point(278, 265)
        Me.CheckEquipmentOut.Name = "CheckEquipmentOut"
        Me.CheckEquipmentOut.Size = New System.Drawing.Size(244, 156)
        Me.CheckEquipmentOut.TabIndex = 2
        Me.CheckEquipmentOut.Text = "Check Equipment Out"
        Me.CheckEquipmentOut.UseVisualStyleBackColor = True
        '
        'Equipment_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 686)
        Me.Controls.Add(Me.CheckEquipmentOut)
        Me.Controls.Add(Me.CheckEquipmentIn)
        Me.Controls.Add(Me.Inventory)
        Me.Name = "Equipment_Order"
        Me.Text = "Equipment_Order"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Inventory As Button
    Friend WithEvents CheckEquipmentIn As Button
    Friend WithEvents CheckEquipmentOut As Button
End Class
