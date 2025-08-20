<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.PanelDashboard = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelDashboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDashboard
        '
        Me.PanelDashboard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelDashboard.Controls.Add(Me.Label1)
        Me.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDashboard.Location = New System.Drawing.Point(0, 0)
        Me.PanelDashboard.Name = "PanelDashboard"
        Me.PanelDashboard.Size = New System.Drawing.Size(991, 562)
        Me.PanelDashboard.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "🏥 Wellmeadows Hospital Dashboard "
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 562)
        Me.Controls.Add(Me.PanelDashboard)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.PanelDashboard.ResumeLayout(False)
        Me.PanelDashboard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents Label1 As Label
End Class
