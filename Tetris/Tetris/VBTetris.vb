Public Class VBTetris

    Dim blockA As Block

    Private Sub VBTetris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetBlockTypes()
        blockA = New Block(ListBlockTypes, 1)
        For Each p As Point In blockA.SquarePositions
            Label6.Text += p.X.ToString() + " " + p.Y.ToString() + " "
        Next
    End Sub

    Private Sub VBTetris_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Left
                blockA.MoveLeft()
            Case Keys.Right
                blockA.MoveRight()
            Case Keys.Up
                blockA.Rotate()
            Case Keys.Down
                blockA.MoveDown()
        End Select
        Refresh()
        blockA.Draw(PictureBoxGame.Handle)
    End Sub

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        ButtonStart.Enabled = False
    End Sub
End Class
