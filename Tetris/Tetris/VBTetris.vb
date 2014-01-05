Public Class VBTetris
    Dim Game1 As TetrisGame

    Private Sub VBTetris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VBTetris_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Game1 Is Nothing Then
            MsgBox("Error. Tetris game hasn't been instantiated", MsgBoxStyle.Critical)
        Else
            Select Case e.KeyValue
                Case Keys.Left
                    Game1.CurrentBlock.MoveLeft()
                Case Keys.Right
                    Game1.CurrentBlock.MoveRight()
                Case Keys.Up
                    Game1.CurrentBlock.Rotate()
                Case Keys.Down
                    Game1.CurrentBlock.MoveDown()
            End Select
            Refresh()
            Game1.CurrentBlock.Draw(PictureBoxGame.Handle)
        End If
    End Sub

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        Game1 = New TetrisGame()
        ButtonStart.Enabled = False
    End Sub
End Class
