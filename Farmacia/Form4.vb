<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Public Class Form4

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(85, 84)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(83, 82)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class