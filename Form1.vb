Public Class Form1
    Private x(14), y(14) As Integer
    Private i, m, x1, y1, x2, y2, T1, T2 As Integer
    Public imya As String
    Sub razmes()
        For Me.m = 1 To Form2.SLOJ
            For Me.i = 0 To 13
                If i + 2 <= 14 Then
                    x1 = Me.Controls.Item(i).Left
                    y1 = Me.Controls.Item(i).Top
                    x2 = Me.Controls.Item(i + 2).Left
                    y2 = Me.Controls.Item(i + 2).Top
                    Me.Controls.Item(i).Left = x2
                    Me.Controls.Item(i).Top = y2
                    Me.Controls.Item(i + 2).Left = x1
                    Me.Controls.Item(i + 2).Top = y1
                End If
            Next
        Next
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form2.Close()
        Me.Close()
        Threading.Thread.CurrentThread.Abort()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        razmes()
        T1 = My.Computer.Clock.TickCount()
    End Sub
    Private Sub Button_GotFocus(sender As Object, e As System.EventArgs) Handles Button1.GotFocus, Button2.GotFocus, Button3.GotFocus, Button4.GotFocus, Button5.GotFocus, Button6.GotFocus, Button7.GotFocus, Button8.GotFocus, Button9.GotFocus, Button10.GotFocus, Button11.GotFocus, Button12.GotFocus, Button13.GotFocus, Button14.GotFocus, Button15.GotFocus
        For Me.i = 0 To 14
            If Me.Controls.Item(i).Focused Then

                Me.Controls.Item(i).BackColor = Color.SpringGreen
            Else
                Me.Controls.Item(i).BackColor = Color.Yellow

            End If
        Next
    End Sub
    Private Sub Form1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

        For Me.i = 0 To 14
            x(i) = Me.Controls.Item(i).Location.X
            y(i) = Me.Controls.Item(i).Location.Y
            If Me.Controls.Item(i).Focused = True Then
                If x(i) < 309 Then
                    If e.X - x(i) > 100 And (e.Y - y(i) > 0 And e.Y - y(i) < 100) Then
                        Me.Controls.Item(i).Left = x(i) + 100
                    End If
                End If
                If y(i) > 9 Then
                    If (e.Y - y(i) < 0 And y(i) - e.Y < 100) And (e.X - x(i) > 0 And e.X - x(i) < 100) Then
                        Me.Controls.Item(i).Top = y(i) - 100
                    End If
                End If
                If x(i) > 9 Then
                    If (e.X - x(i) < 0 And x(i) - e.X < 100) And (e.Y - y(i) > 0 And e.Y - y(i) < 100) Then
                        Me.Controls.Item(i).Left = x(i) - 100
                    End If
                End If
                If y(i) < 309 Then
                    If (e.Y - y(i) > 100) And (e.X - x(i) > 0 And e.X - x(i) < 100) Then
                        Me.Controls.Item(i).Top = y(i) + 100
                    End If
                End If
            End If
        Next
        T2 = My.Computer.Clock.TickCount
        If (Button1.Left = 9 And Button1.Top = 9) And (Button2.Left = 109 And Button2.Top = 9) And (Button3.Left = 209 And Button3.Top = 9) And (Button4.Left = 309 And Button4.Top = 9) And (Button5.Left = 9 And Button5.Top = 109) And (Button6.Left = 109 And Button6.Top = 109) And (Button7.Left = 209 And Button7.Top = 109) And (Button8.Left = 309 And Button8.Top = 109) And (Button9.Left = 9 And Button9.Top = 209) And (Button10.Left = 109 And Button10.Top = 209) And (Button11.Left = 209 And Button11.Top = 209) And (Button12.Left = 309 And Button12.Top = 209) And (Button13.Left = 9 And Button13.Top = 309) And (Button14.Left = 109 And Button14.Top = 309) And (Button15.Left = 209 And Button15.Top = 309) Then
            MsgBox("ВЫ ВЫИГРАЛИ " & imya & " ВАШЕ ВРЕМЯ:" & ((T2 - T1) / 1000) & " секунд")
            Form2.Close()
            Me.Close()
            Threading.Thread.CurrentThread.Abort()
        End If
        If T2 > T1 + Form2.dT Then
            MsgBox("ВЫ ПРОИГРАЛИ" & imya)
            Form2.Close()
            Me.Close()
            Threading.Thread.CurrentThread.Abort()
        End If
    End Sub
End Class
