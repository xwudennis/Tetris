Public Class VBTetris
    Dim Game1 As TetrisGame

    Private Sub VBTetris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = 0
        Label4.Text = 1
    End Sub

    Private Sub VBTetris_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Game1 Is Nothing Then
            MsgBox("Error. Tetris game hasn't been instantiated.", MsgBoxStyle.Critical)
        Else
            Select Case e.KeyValue
                Case Keys.Left
                    Game1.CBMoveLeft()
                Case Keys.Right
                    Game1.CBMoveRight()
                Case Keys.Up
                    Game1.CBRotate()
                Case Keys.Down
                    Game1.CBMoveDown()
            End Select
        End If
        updateFormComponentes()
    End Sub

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        Me.StartANewGame()
        ButtonStart.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Game1.GameInProgress() Then
            Game1.CBMoveDown()
            Me.updateFormComponentes()
        Else
            Timer1.Enabled = False
            Dim response = MsgBox(String.Format("Game Over. Your score: {0}.", Game1.Score) & vbNewLine & "Would like to start a new game?", MsgBoxStyle.YesNo, "GameOver")
            If response = MsgBoxResult.Yes Then
                Me.StartANewGame()
            Else
                ''Do nothing
            End If
        End If
    End Sub

    Private Sub StartANewGame()
        Game1 = New TetrisGame()
        Timer1.Enabled = True
        Timer1.Interval = Game1.MoveDownInteval()
        Label2.Text = Game1.Score()
        Label4.Text = Game1.Level()
    End Sub

    Private Sub updateFormComponentes()
        Refresh()
        Game1.Draw(PictureBoxGame.Handle, PictureBoxNext.Handle)
        Timer1.Interval = Game1.MoveDownInteval()
        Label2.Text = Game1.Score()
        Label4.Text = Game1.Level()
    End Sub
End Class
