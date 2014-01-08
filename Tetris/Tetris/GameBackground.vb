Public Class GameBackground
    '' A class designed to store information about boundaries and the block pile
    Private _width As Integer
    Private _height As Integer
    Private _nextBlockPicWidth As Integer
    Private _nextBlockPicHeight As Integer
    Private _blockPile(,) As Integer

    Public ReadOnly Property Width() As Integer
        Get
            Return Me._width
        End Get
    End Property

    Public ReadOnly Property Height() As Integer
        Get
            Return Me._height
        End Get
    End Property

    Public ReadOnly Property NextBlockPicWidth() As Integer
        Get
            Return Me._nextBlockPicWidth
        End Get
    End Property

    Public ReadOnly Property NextBlockPicHeight() As Integer
        Get
            Return Me._nextBlockPicHeight
        End Get
    End Property

    Public Sub New()
        Me._width = 10
        Me._height = 20
        Me._nextBlockPicWidth = 5
        Me._nextBlockPicHeight = 5
        Me._blockPile = New Integer(Me._width - 1, Me._height - 1) {}
    End Sub

    Public Sub Draw(ByVal WinHandle As System.IntPtr)
        For x As Integer = 0 To Me._width - 1
            For y As Integer = 0 To Me._height - 1
                If _blockPile(x, y) <> 0 Then
                    DrawSquare.Draw(WinHandle, x, y)
                End If
            Next
        Next
    End Sub

    Public Function Collision(ByVal b As Block) As Boolean
        '' Check if a block is in collision with the boundary or block pile.
        Dim r As Boolean = False
        For Each p As Point In b.SquarePositions()
            ''Loop through all square positions
            If p.X >= 0 And p.X < Me._width And p.Y < Me._height Then
                ''First check if x is within the range and y is higher than the bottom line
                If p.Y >= 0 Then
                    ''Then check if y is lower than the top line
                    If _blockPile(p.X, p.Y) <> 0 Then
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

    Public Function BlockToPile(ByVal b As Block) As Boolean
        '' Transform a block into the block pile.
        '' Return True if the block is within the boundary, False if out of boundary or in collision with the pile
        Dim r As Boolean = True
        '' Check if the block is in collision with the left, right, bottom boundary and the pile
        If Me.Collision(b) Then
            r = False
        Else
            For Each p As Point In b.SquarePositions
                '' Check if the point is within the boundary
                If p.X >= 0 And p.X < Me._width And p.Y < Me._height And p.Y >= 0 Then
                    Me._blockPile(p.X, p.Y) = 1
                Else
                    r = False
                End If
            Next
        End If
        Return r
    End Function

    Private Function checkLineComplete(ByVal y As Integer) As Boolean
        '' Check if a certain line is complete or not
        Dim complete As Boolean = True
        If y >= 0 And y < Me._height Then
            For x As Integer = 0 To Me._width - 1
                If Me._blockPile(x, y) = 0 Then
                    complete = False
                    Exit For
                End If
            Next
        Else
            MsgBox("Wrong Line Number", MsgBoxStyle.Critical)
        End If
        Return complete
    End Function

    Public Function RemoveCompleteLines() As Integer
        '' Remove all the complete lines
        '' First, check complete lines and add to completed
        Dim completed As New List(Of Integer)
        For y As Integer = 0 To Me.Height() - 1
            If checkLineComplete(y) Then
                completed.Add(y)
            End If
        Next

        If completed.Count() > 0 Then
            '' Then, scan from bottom to top, move incomplete lines down
            Dim moveDown As Integer = 0
            For y As Integer = Me.Height() - 1 To 0 Step -1
                Dim toFind As Integer = y
                If completed.Exists(Function(value As Integer) value = toFind) Then
                    '' If a line is complete
                    moveDown += 1
                Else
                    '' If a line is incomplete, move it down by integer moveDown
                    '' Note that y + moveDown is guaranteed to be smaller than Me._height
                    For x As Integer = 0 To Me.Width() - 1
                        Me._blockPile(x, y + moveDown) = Me._blockPile(x, y)
                    Next
                End If
            Next

            '' In the end, fill in the top severl lines with 0
            For y As Integer = 0 To moveDown - 1
                For x As Integer = 0 To Me.Width() - 1
                    Me._blockPile(x, y) = 0
                Next
            Next
        End If
        Return completed.Count()
    End Function
End Class
