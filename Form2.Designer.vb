﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.pb_Achievement1 = New System.Windows.Forms.PictureBox()
        Me.lbl_achievementsPage = New System.Windows.Forms.Label()
        Me.lbl_Achievement1 = New System.Windows.Forms.Label()
        CType(Me.pb_Achievement1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 94)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pb_Achievement1
        '
        Me.pb_Achievement1.Location = New System.Drawing.Point(316, 164)
        Me.pb_Achievement1.Name = "pb_Achievement1"
        Me.pb_Achievement1.Size = New System.Drawing.Size(195, 92)
        Me.pb_Achievement1.TabIndex = 1
        Me.pb_Achievement1.TabStop = False
        '
        'lbl_achievementsPage
        '
        Me.lbl_achievementsPage.AutoSize = True
        Me.lbl_achievementsPage.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_achievementsPage.Location = New System.Drawing.Point(145, 32)
        Me.lbl_achievementsPage.Name = "lbl_achievementsPage"
        Me.lbl_achievementsPage.Size = New System.Drawing.Size(537, 106)
        Me.lbl_achievementsPage.TabIndex = 2
        Me.lbl_achievementsPage.Text = "Achievements"
        '
        'lbl_Achievement1
        '
        Me.lbl_Achievement1.AutoSize = True
        Me.lbl_Achievement1.Location = New System.Drawing.Point(318, 273)
        Me.lbl_Achievement1.Name = "lbl_Achievement1"
        Me.lbl_Achievement1.Size = New System.Drawing.Size(53, 20)
        Me.lbl_Achievement1.TabIndex = 3
        Me.lbl_Achievement1.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_Achievement1)
        Me.Controls.Add(Me.lbl_achievementsPage)
        Me.Controls.Add(Me.pb_Achievement1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pb_Achievement1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents pb_Achievement1 As PictureBox
    Friend WithEvents lbl_achievementsPage As Label
    Friend WithEvents lbl_Achievement1 As Label
End Class
