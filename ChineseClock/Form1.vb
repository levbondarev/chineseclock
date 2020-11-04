Public Class Form1
    Public formtext As String
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer2_Tick(New Object, System.EventArgs.Empty)
        Timer1_Tick(New Object, System.EventArgs.Empty)
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If formtext = "乙" Then
            Icon = My.Resources.Йи
        ElseIf formtext = "甲" Then
            Icon = My.Resources.Цзя
        ElseIf formtext = "丙" Then
            Icon = My.Resources.Бинь
        ElseIf formtext = "丁" Then
            Icon = My.Resources.Динь
        ElseIf formtext = "戊" Then
            Icon = My.Resources.У
        ElseIf formtext = "己" Then
            Icon = My.Resources.Цзи
        ElseIf formtext = "庚" Then
            Icon = My.Resources.Гэн
        ElseIf formtext = "辛" Then
            Icon = My.Resources.Син
        ElseIf formtext = "壬" Then
            Icon = My.Resources.Жэн
        ElseIf formtext = "癸" Then
            Icon = My.Resources.Гуй
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim milliseconds As Double = (Now.Hour * 60 * 60) + (Now.Minute * 60) + (Now.Second) '+ (Now.Millisecond / 100)
        Dim miao As Double = milliseconds / 86400 * 100000
        Dim wenmiao = Math.Round(miao).ToString
rt:
        If wenmiao.Length < 5 Then
            wenmiao = "0" + wenmiao
            GoTo rt
        End If
        If wenmiao(0) = "0" Then
            formtext = "丙"
        ElseIf wenmiao(0) = "1" Then
            formtext = "丁"
        ElseIf wenmiao(0) = "2" Then
            formtext = "戊"
        ElseIf wenmiao(0) = "3" Then
            formtext = "己"
        ElseIf wenmiao(0) = "4" Then
            formtext = "庚" '+ wenmiao.Substring(1)
        ElseIf wenmiao(0) = "5" Then
            formtext = "辛" '+ wenmiao.Substring(1)
        ElseIf wenmiao(0) = "6" Then
            formtext = "壬" '+ wenmiao.Substring(1)
        ElseIf wenmiao(0) = "7" Then
            formtext = "癸" '+ wenmiao.Substring(1)
        ElseIf wenmiao(0) = "8" Then
            formtext = "甲" '+ wenmiao.Substring(1)
        ElseIf wenmiao(0) = "9" Then
            formtext = "乙" '+ wenmiao.Substring(1)
        End If
        Text = wenmiao.Substring(1, 2) + ":" + wenmiao.Substring(3, 2) ' + "." + wenmiao.Substring(4, 2)
    End Sub

    Private Sub Form1_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Location = New Point(My.Computer.Screen.WorkingArea.Height, My.Computer.Screen.WorkingArea.Width)

    End Sub
End Class
