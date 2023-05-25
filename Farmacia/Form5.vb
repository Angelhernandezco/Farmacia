Public Class form5
#Region "Fomr Behaviors"
    Private Sub botton_closed_Paint(sender As Object, e As PaintEventArgs) Handles botton_closed.Paint
        Application.Exit()
    End Sub
    Private Sub botton_minimized_Paint(sender As Object, e As PaintEventArgs) Handles botton_minimized.Paint
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form"
End Class