﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CookieClicker
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_cookie_click = New System.Windows.Forms.Button()
        Me.Cookie_Value = New System.Windows.Forms.Label()
        Me.PassiveCookieTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btn_click_upgrade = New System.Windows.Forms.Button()
        Me.btn_passive_one_upgrade = New System.Windows.Forms.Button()
        Me.lbl_Click_Level_Value = New System.Windows.Forms.Label()
        Me.lbl_Passive_One_Level = New System.Windows.Forms.Label()
        Me.lbl_Click_Upgrade_Cost = New System.Windows.Forms.Label()
        Me.lbl_Passive_One_Upgrade_Cost = New System.Windows.Forms.Label()
        Me.RoundButton1 = New FirstProject.RoundButton()
        Me.SuspendLayout()
        '
        'btn_cookie_click
        '
        Me.btn_cookie_click.Location = New System.Drawing.Point(617, 121)
        Me.btn_cookie_click.Name = "btn_cookie_click"
        Me.btn_cookie_click.Size = New System.Drawing.Size(321, 105)
        Me.btn_cookie_click.TabIndex = 0
        Me.btn_cookie_click.Text = "Click to increase cookies by 1"
        Me.btn_cookie_click.UseVisualStyleBackColor = True
        '
        'Cookie_Value
        '
        Me.Cookie_Value.AutoSize = True
        Me.Cookie_Value.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cookie_Value.Location = New System.Drawing.Point(363, 9)
        Me.Cookie_Value.Name = "Cookie_Value"
        Me.Cookie_Value.Size = New System.Drawing.Size(239, 62)
        Me.Cookie_Value.TabIndex = 1
        Me.Cookie_Value.Text = "Cookies: 0"
        Me.Cookie_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PassiveCookieTimer
        '
        Me.PassiveCookieTimer.Interval = 1000
        '
        'btn_click_upgrade
        '
        Me.btn_click_upgrade.Location = New System.Drawing.Point(12, 58)
        Me.btn_click_upgrade.Name = "btn_click_upgrade"
        Me.btn_click_upgrade.Size = New System.Drawing.Size(113, 73)
        Me.btn_click_upgrade.TabIndex = 2
        Me.btn_click_upgrade.Text = "Increase Value Of Click"
        Me.btn_click_upgrade.UseVisualStyleBackColor = True
        '
        'btn_passive_one_upgrade
        '
        Me.btn_passive_one_upgrade.Location = New System.Drawing.Point(12, 243)
        Me.btn_passive_one_upgrade.Name = "btn_passive_one_upgrade"
        Me.btn_passive_one_upgrade.Size = New System.Drawing.Size(113, 73)
        Me.btn_passive_one_upgrade.TabIndex = 3
        Me.btn_passive_one_upgrade.Text = "Passive One Upgrade"
        Me.btn_passive_one_upgrade.UseVisualStyleBackColor = True
        '
        'lbl_Click_Level_Value
        '
        Me.lbl_Click_Level_Value.AutoSize = True
        Me.lbl_Click_Level_Value.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Click_Level_Value.Location = New System.Drawing.Point(12, 134)
        Me.lbl_Click_Level_Value.Name = "lbl_Click_Level_Value"
        Me.lbl_Click_Level_Value.Size = New System.Drawing.Size(100, 45)
        Me.lbl_Click_Level_Value.TabIndex = 4
        Me.lbl_Click_Level_Value.Text = "LvL: 0"
        Me.lbl_Click_Level_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Passive_One_Level
        '
        Me.lbl_Passive_One_Level.AutoSize = True
        Me.lbl_Passive_One_Level.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Passive_One_Level.Location = New System.Drawing.Point(12, 319)
        Me.lbl_Passive_One_Level.Name = "lbl_Passive_One_Level"
        Me.lbl_Passive_One_Level.Size = New System.Drawing.Size(100, 45)
        Me.lbl_Passive_One_Level.TabIndex = 5
        Me.lbl_Passive_One_Level.Text = "LvL: 0"
        Me.lbl_Passive_One_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Click_Upgrade_Cost
        '
        Me.lbl_Click_Upgrade_Cost.AutoSize = True
        Me.lbl_Click_Upgrade_Cost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Click_Upgrade_Cost.Location = New System.Drawing.Point(12, 27)
        Me.lbl_Click_Upgrade_Cost.Name = "lbl_Click_Upgrade_Cost"
        Me.lbl_Click_Upgrade_Cost.Size = New System.Drawing.Size(74, 28)
        Me.lbl_Click_Upgrade_Cost.TabIndex = 6
        Me.lbl_Click_Upgrade_Cost.Text = "Price: 2"
        Me.lbl_Click_Upgrade_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Passive_One_Upgrade_Cost
        '
        Me.lbl_Passive_One_Upgrade_Cost.AutoSize = True
        Me.lbl_Passive_One_Upgrade_Cost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Passive_One_Upgrade_Cost.Location = New System.Drawing.Point(12, 212)
        Me.lbl_Passive_One_Upgrade_Cost.Name = "lbl_Passive_One_Upgrade_Cost"
        Me.lbl_Passive_One_Upgrade_Cost.Size = New System.Drawing.Size(85, 28)
        Me.lbl_Passive_One_Upgrade_Cost.TabIndex = 7
        Me.lbl_Passive_One_Upgrade_Cost.Text = "Price: 10"
        Me.lbl_Passive_One_Upgrade_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundButton1
        '
        Me.RoundButton1.Location = New System.Drawing.Point(382, 253)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(198, 162)
        Me.RoundButton1.TabIndex = 8
        Me.RoundButton1.Text = "RoundButton1"
        Me.RoundButton1.UseVisualStyleBackColor = True
        '
        'CookieClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(982, 470)
        Me.Controls.Add(Me.RoundButton1)
        Me.Controls.Add(Me.lbl_Passive_One_Upgrade_Cost)
        Me.Controls.Add(Me.lbl_Click_Upgrade_Cost)
        Me.Controls.Add(Me.lbl_Passive_One_Level)
        Me.Controls.Add(Me.lbl_Click_Level_Value)
        Me.Controls.Add(Me.btn_passive_one_upgrade)
        Me.Controls.Add(Me.btn_click_upgrade)
        Me.Controls.Add(Me.Cookie_Value)
        Me.Controls.Add(Me.btn_cookie_click)
        Me.Name = "CookieClicker"
        Me.Text = "Cookie Clicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cookie_click As Button
    Friend WithEvents Cookie_Value As Label
    Friend WithEvents PassiveCookieTimer As Timer
    Friend WithEvents btn_click_upgrade As Button
    Friend WithEvents btn_passive_one_upgrade As Button
    Friend WithEvents lbl_Click_Level_Value As Label
    Friend WithEvents lbl_Passive_One_Level As Label
    Friend WithEvents lbl_Click_Upgrade_Cost As Label
    Friend WithEvents lbl_Passive_One_Upgrade_Cost As Label
    Friend WithEvents RoundButton1 As RoundButton
End Class
