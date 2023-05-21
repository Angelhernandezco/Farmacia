Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString()
        ToolStripStatusLabel2.Text = DateTime.Now.ToLongDateString()
    End Sub
End Class
