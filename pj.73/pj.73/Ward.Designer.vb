﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ward
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
        Me.PanelWard = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnWardList = New System.Windows.Forms.Button()
        Me.btnBedList = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelWard.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelWard
        '
        Me.PanelWard.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelWard.Controls.Add(Me.PictureBox1)
        Me.PanelWard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWard.Location = New System.Drawing.Point(0, 0)
        Me.PanelWard.Name = "PanelWard"
        Me.PanelWard.Size = New System.Drawing.Size(991, 562)
        Me.PanelWard.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnWardList, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBedList, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(262, 191)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(481, 154)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnWardList
        '
        Me.btnWardList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWardList.Location = New System.Drawing.Point(3, 3)
        Me.btnWardList.Name = "btnWardList"
        Me.btnWardList.Size = New System.Drawing.Size(234, 148)
        Me.btnWardList.TabIndex = 0
        Me.btnWardList.Text = "Ward List"
        Me.btnWardList.UseVisualStyleBackColor = True
        '
        'btnBedList
        '
        Me.btnBedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBedList.Location = New System.Drawing.Point(243, 3)
        Me.btnBedList.Name = "btnBedList"
        Me.btnBedList.Size = New System.Drawing.Size(235, 148)
        Me.btnBedList.TabIndex = 1
        Me.btnBedList.Text = "Bed List"
        Me.btnBedList.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.Screenshot_2025_08_08_161313
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(991, 562)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Ward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 562)
        Me.Controls.Add(Me.PanelWard)
        Me.Name = "Ward"
        Me.Text = "Ward"
        Me.PanelWard.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWard As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnWardList As Button
    Friend WithEvents btnBedList As Button
End Class
