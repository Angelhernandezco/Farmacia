Imports System.Runtime.InteropServices
Public Class form5
    Private txtUser As Object
    Private txtPass As Object
#Region "Form Behaviors"
    Private Sub botton_closed_Paint(sender As Object, e As PaintEventArgs) Handles botton_closed.Paint
        Application.Exit()
    End Sub
    Private Sub botton_minimized_Paint(sender As Object, e As PaintEventArgs) Handles botton_minimized.Paint
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hEnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Form5_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CustomizeComponents()
        CustomizeComponents(txtUser)
    End Sub

#End Region
#Region "Customize Controls"
    Private Sub CustomizeComponents(txtUser As Object)
        txtUser.AutoSide = False
        txtUser.Size = New Size(290, 40)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(290, 40)
        txtPass.UseSystemPasswordChar = True


    End Sub
#End Region
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Button1.ClientRectangle
        myRectangle.Inflate(0, 22)
        buttonPath.AddEllipse(myRectangle)
        Button1.Region = New Region(buttonPath)

    End Sub
End Class