Public Class GameBackground
    Private width As Integer
    Private height As Integer
    Private blockPile(,) As Integer

    Public Sub New()
        Me.width = 10
        Me.height = 20
        Me.blockPile = New Integer(Me.width - 1, Me.height - 1) {}
    End Sub

    Public Sub Draw(ByVal WinHandle As System.IntPtr)
        For x As Integer = 0 To Me.width - 1
            For y As Integer = 0 To Me.height - 1
                If blockPile(x, y) <> 0 Then
                    DrawSquare.Draw(WinHandle, x, y)
                End If
            Next
        Next
    End Sub

    Public Function Collision(ByVal b As Block)
        Dim r As Boolean = False
        For Each p As Point In b.SquarePositions()
            ''Loop through all square positions
            If p.X >= 0 And p.X < Me.width And p.Y < Me.height Then
                ''First check if x is within the range and y is higher than the bottom line
                If p.Y >= 0 Then
                    ''Then check if y is lower than the top line
                    If blockPile(p.X, p.Y) <> 0 Then
                        ''Next check if the point is conflict with the block pile
                        r = True
                        Exit For
                    Else
                        ''Do nothing
                    End If
                Else
                    ''If y is higher than the top line, DO NOTHING
                End If
            Else
                r = True
                Exit For
            End If
        Next
        Return r
    End Function

    Public Sub BlockToPile(ByVal b As Block)
        If Me.Collision(b) Then
            MsgBox("Error. Collision detected. Cannot transform the block to pile", MsgBoxStyle.Critical)
        Else
            For Each p As Point In b.SquarePositions
                Me.blockPile(p.X, p.Y) = 1
            Next
        End If
    End Sub
End Class
