<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.btnWard = New System.Windows.Forms.Button()
        Me.btnSupplies = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnRequisition = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlMainMenu = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMainMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 365)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaff, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPatient, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnWard, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSupplies, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSuppliers, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRequisition, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDashboard, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(99, 363)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnStaff
        '
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStaff.Location = New System.Drawing.Point(2, 47)
        Me.btnStaff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(95, 41)
        Me.btnStaff.TabIndex = 1
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnPatient
        '
        Me.btnPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPatient.Location = New System.Drawing.Point(2, 92)
        Me.btnPatient.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(95, 41)
        Me.btnPatient.TabIndex = 2
        Me.btnPatient.Text = "Patient"
        Me.btnPatient.UseVisualStyleBackColor = True
        '
        'btnWard
        '
        Me.btnWard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWard.Location = New System.Drawing.Point(2, 137)
        Me.btnWard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnWard.Name = "btnWard"
        Me.btnWard.Size = New System.Drawing.Size(95, 41)
        Me.btnWard.TabIndex = 3
        Me.btnWard.Text = "Ward"
        Me.btnWard.UseVisualStyleBackColor = True
        '
        'btnSupplies
        '
        Me.btnSupplies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSupplies.Location = New System.Drawing.Point(2, 182)
        Me.btnSupplies.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSupplies.Name = "btnSupplies"
        Me.btnSupplies.Size = New System.Drawing.Size(95, 41)
        Me.btnSupplies.TabIndex = 4
        Me.btnSupplies.Text = "Supplies"
        Me.btnSupplies.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSuppliers.Location = New System.Drawing.Point(2, 227)
        Me.btnSuppliers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(95, 41)
        Me.btnSuppliers.TabIndex = 5
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnRequisition
        '
        Me.btnRequisition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRequisition.Location = New System.Drawing.Point(2, 272)
        Me.btnRequisition.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRequisition.Name = "btnRequisition"
        Me.btnRequisition.Size = New System.Drawing.Size(95, 41)
        Me.btnRequisition.TabIndex = 6
        Me.btnRequisition.Text = "Requisition"
        Me.btnRequisition.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDashboard.Location = New System.Drawing.Point(2, 317)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(95, 44)
        Me.btnDashboard.TabIndex = 7
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlMainMenu.Controls.Add(Me.PictureBox2)
        Me.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainMenu.Location = New System.Drawing.Point(99, 0)
        Me.pnlMainMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Size = New System.Drawing.Size(562, 365)
        Me.pnlMainMenu.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.pj._73.My.Resources.Resources.Screenshot_2025_08_08_161313
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(562, 365)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 365)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMainMenu.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnPatient As Button
    Friend WithEvents btnWard As Button
    Friend WithEvents btnSupplies As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnRequisition As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnlMainMenu As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
