﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requisition
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
        Me.PanelRequisition = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRequisition = New System.Windows.Forms.Button()
        Me.btnRequisitionReport = New System.Windows.Forms.Button()
        Me.PanelRequisition.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRequisition
        '
        Me.PanelRequisition.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelRequisition.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelRequisition.Controls.Add(Me.PictureBox1)
        Me.PanelRequisition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRequisition.Location = New System.Drawing.Point(0, 0)
        Me.PanelRequisition.Name = "PanelRequisition"
        Me.PanelRequisition.Size = New System.Drawing.Size(991, 562)
        Me.PanelRequisition.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.Screenshot_2025_08_08_161313
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(991, 562)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnRequisition, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRequisitionReport, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(343, 176)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(322, 172)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnRequisition
        '
        Me.btnRequisition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRequisition.Location = New System.Drawing.Point(3, 3)
        Me.btnRequisition.Name = "btnRequisition"
        Me.btnRequisition.Size = New System.Drawing.Size(155, 166)
        Me.btnRequisition.TabIndex = 0
        Me.btnRequisition.Text = "Requisition"
        Me.btnRequisition.UseVisualStyleBackColor = True
        '
        'btnRequisitionReport
        '
        Me.btnRequisitionReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRequisitionReport.Location = New System.Drawing.Point(164, 3)
        Me.btnRequisitionReport.Name = "btnRequisitionReport"
        Me.btnRequisitionReport.Size = New System.Drawing.Size(155, 166)
        Me.btnRequisitionReport.TabIndex = 1
        Me.btnRequisitionReport.Text = "Requisition Report"
        Me.btnRequisitionReport.UseVisualStyleBackColor = True
        '
        'Requisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 562)
        Me.Controls.Add(Me.PanelRequisition)
        Me.Name = "Requisition"
        Me.Text = "Requisition"
        Me.PanelRequisition.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRequisition As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnRequisition As Button
    Friend WithEvents btnRequisitionReport As Button
End Class
