<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Public Class Form4
    Public Property Panel5 As Object

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(85, 84)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(83, 82)
    End Sub

    Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
        Panel3.Size = New Size(86, 84)
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Panel3.Size = New Size(83, 81)
    End Sub
    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
        Panel4.Size = New Size(85, 90)
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave
        Panel4.Size = New Size(82, 87)
    End Sub
End Class