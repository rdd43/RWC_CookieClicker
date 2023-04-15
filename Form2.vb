Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CookieClicker.totalCookies = 1500
        CookieClicker.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CookieClicker.AchievementStatus Then
            lbl_Achievement1.Text = "Achievement Unlocked : Click 100 Times"
            pb_Achievement1.Image = Image.FromFile("C:\Users\rober\Downloads\Unlocked.png")
        Else
            lbl_Achievement1.Text = "Achievement Hint : Click More"
            pb_Achievement1.Image = Image.FromFile("C:\Users\rober\Downloads\Locked.png")
        End If
    End Sub
End Class