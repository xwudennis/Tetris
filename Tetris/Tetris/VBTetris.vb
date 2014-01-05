Public Class VBTetris
    Dim Game1 As TetrisGame

    Private Sub VBTetris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VBTetris_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Left
                Game1.blockA.MoveLeft()
            Case Keys.Right
                Game1.blockA.MoveRight()
            Case Keys.Up
                Game1.blockA.Rotate()
            Case Keys.Down
                Game1.blockA.MoveDown()
        End Select
        Refresh()
        Game1.blockA.Draw(PictureBoxGame.Handle)
    End Sub

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        Game1 = New TetrisGame()
        ButtonStart.Enabled = False
    End Sub
End Class
