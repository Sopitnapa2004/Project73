<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplies
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
        Me.PanelSupplies = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDispenseReport = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnManageSupplies = New System.Windows.Forms.Button()
        Me.btnDispense = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSupplies.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSupplies
        '
        Me.PanelSupplies.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelSupplies.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelSupplies.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelSupplies.Controls.Add(Me.PictureBox1)
        Me.PanelSupplies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSupplies.Location = New System.Drawing.Point(0, 0)
        Me.PanelSupplies.Name = "PanelSupplies"
        Me.PanelSupplies.Size = New System.Drawing.Size(992, 562)
        Me.PanelSupplies.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnDispenseReport, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(378, 289)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(230, 125)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btnDispenseReport
        '
        Me.btnDispenseReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDispenseReport.Location = New System.Drawing.Point(3, 3)
        Me.btnDispenseReport.Name = "btnDispenseReport"
        Me.btnDispenseReport.Size = New System.Drawing.Size(224, 119)
        Me.btnDispenseReport.TabIndex = 0
        Me.btnDispenseReport.Text = "Dispense Report"
        Me.btnDispenseReport.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnManageSupplies, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDispense, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(306, 114)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(384, 142)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnManageSupplies
        '
        Me.btnManageSupplies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnManageSupplies.Location = New System.Drawing.Point(3, 3)
        Me.btnManageSupplies.Name = "btnManageSupplies"
        Me.btnManageSupplies.Size = New System.Drawing.Size(186, 136)
        Me.btnManageSupplies.TabIndex = 0
        Me.btnManageSupplies.Text = "Manage Supplies "
        Me.btnManageSupplies.UseVisualStyleBackColor = True
        '
        'btnDispense
        '
        Me.btnDispense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDispense.Location = New System.Drawing.Point(195, 3)
        Me.btnDispense.Name = "btnDispense"
        Me.btnDispense.Size = New System.Drawing.Size(186, 136)
        Me.btnDispense.TabIndex = 1
        Me.btnDispense.Text = "Dispense"
        Me.btnDispense.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.Screenshot_2025_08_08_161313
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(992, 562)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Supplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 562)
        Me.Controls.Add(Me.PanelSupplies)
        Me.Name = "Supplies"
        Me.Text = "Supplies"
        Me.PanelSupplies.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSupplies As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDispenseReport As Button
    Friend WithEvents btnManageSupplies As Button
    Friend WithEvents btnDispense As Button
End Class
