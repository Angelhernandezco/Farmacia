Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString()
        ToolStripStatusLabel2.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub RegistroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeClientesToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CatálogosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogosToolStripMenuItem.Click
        Form4.Show()

    End Sub
End Class
