Public Class VBTetris

    Private Sub VBTetris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetBlockTypes()
        Dim blockA As New Block(ListBlockTypes, 1)
        Label6.Text = (blockA.SquarePositions.Length())
    End Sub

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        ButtonStart.Enabled = False
    End Sub
End Class
