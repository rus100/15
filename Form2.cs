Public Class Form2
    Public SLOJ As Integer
    Public dT As Integer
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            SLOJ = 10
            dT = 900000
        End If
        If RadioButton2.Checked = True Then
            SLOJ = 50
            dT = 600000
        End If
        If RadioButton3.Checked = True Then
            SLOJ = 100
            dT = 300000
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Form1.imya = TextBox1.Text
    End Sub
    Private Sub Form2_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
        Threading.Thread.CurrentThread.Abort()
    End Sub
End Class
