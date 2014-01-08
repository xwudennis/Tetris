Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class TetrisGame
    Private _level As Integer
    Private _score As Integer
    Private _gameInProgress As Boolean
    Private _listBlockTypes As List(Of BlockType)
    Public Background As GameBackground
    Public CurrentBlock As Block
    Public NextBlock As Block

    Public ReadOnly Property Level() As Integer
        Get
            Return Me._level
        End Get
    End Property

    Public ReadOnly Property Score() As Integer
        Get
            Return Me._score
        End Get
    End Property

    Public ReadOnly Property GameInProgress() As Boolean
        Get
            Return Me._gameInProgress
        End Get
    End Property

    Public ReadOnly Property MoveDownInteval() As Integer
        Get
            Return 500 / Me._level
        End Get
    End Property

    Public Sub New()
        Me._level = 1
        Me._score = 0
        Me._gameInProgress = True
        Me.setListBlockTypes()
        Me.Background = New GameBackground()
        Randomize()
        Me.CurrentBlock = New Block(_listBlockTypes, randomBlockType())
        Me.CurrentBlock.StartFall(Me.Background)
        Me.NextBlock = New Block(_listBlockTypes, randomBlockType())
        Me.NextBlock.PutOnNext(Me.Background)
    End Sub

    Private Function randomBlockType() As Integer
        Return CInt(Int(_listBlockTypes.Count() * Rnd()))
    End Function

    Private Sub updateScore(ByVal removedLines As Integer)
        Select Case removedLines
            Case 0
                '' Do nothing
            Case 1
                Me._score += 100
            Case 2
                Me._score += 200
            Case 3
                Me._score += 500
            Case 4
                Me._score += 1000
            Case Else
                MsgBox("Error. Can not remove more than 4 lines with one block", MsgBoxStyle.Critical)
        End Select
    End Sub

    Private Sub updateLevel()
        Me._level = CInt(Int(Me.Score() / 2000.0)) + 1
    End Sub

    Private Sub setListBlockTypes()
        _listBlockTypes = New List(Of BlockType)

        Dim IName As String = "I"
        Dim INorth = New Point() {New Point(0, -1), New Point(0, 1), New Point(0, 2)}
        Dim IEast = New Point() {New Point(-1, 0), New Point(1, 0), New Point(2, 0)}
        Dim ISouth = INorth
        Dim IWest = IEast
        Dim BlockI As New BlockType(IName, INorth, IEast, ISouth, IWest)
        _listBlockTypes.Add(BlockI)

        Dim JName As String = "J"
        Dim JNorth = New Point() {New Point(-1, 0), New Point(0, -1), New Point(0, -2)}
        Dim JEast = New Point() {New Point(0, -1), New Point(1, 0), New Point(2, 0)}
        Dim JSouth = New Point() {New Point(1, 0), New Point(0, 1), New Point(0, 2)}
        Dim JWest = New Point() {New Point(0, 1), New Point(-1, 0), New Point(-2, 0)}
        Dim BlockJ As New BlockType(JName, JNorth, JEast, JSouth, JWest)
        _listBlockTypes.Add(BlockJ)

        Dim LName As String = "L"
        Dim LNorth = New Point() {New Point(1, 0), New Point(0, -1), New Point(0, -2)}
        Dim LEast = New Point() {New Point(0, 1), New Point(1, 0), New Point(2, 0)}
        Dim LSouth = New Point() {New Point(-1, 0), New Point(0, 1), New Point(0, 2)}
        Dim LWest = New Point() {New Point(0, -1), New Point(-1, 0), New Point(-2, 0)}
        Dim BlockL As New BlockType(LName, LNorth, LEast, LSouth, LWest)
        _listBlockTypes.Add(BlockL)

        Dim OName As String = "O"
        Dim ONorth = New Point() {New Point(1, 0), New Point(0, 1), New Point(1, 1)}
        Dim OEast = ONorth
        Dim OSouth = ONorth
        Dim OWest = ONorth
        Dim BlockO As New BlockType(OName, ONorth, OEast, OSouth, OWest)
        _listBlockTypes.Add(BlockO)

        Dim SName As String = "S"
        Dim SNorth = New Point() {New Point(-1, 0), New Point(0, -1), New Point(1, -1)}
        Dim SEast = New Point() {New Point(0, -1), New Point(1, 0), New Point(1, 1)}
        Dim SSouth = SNorth
        Dim SWest = SEast
        Dim BlockS As New BlockType(SName, SNorth, SEast, SSouth, SWest)
        _listBlockTypes.Add(BlockS)

        Dim TName As String = "T"
        Dim TNorth = New Point() {New Point(-1, 0), New Point(1, 0), New Point(0, 1)}
        Dim TEast = New Point() {New Point(0, -1), New Point(0, 1), New Point(-1, 0)}
        Dim TSouth = New Point() {New Point(1, 0), New Point(-1, 0), New Point(0, -1)}
        Dim TWest = New Point() {New Point(0, 1), New Point(0, -1), New Point(1, 0)}
        Dim BlockT As New BlockType(TName, TNorth, TEast, TSouth, TWest)
        _listBlockTypes.Add(BlockT)

        Dim ZName As String = "Z"
        Dim ZNorth = New Point() {New Point(-1, 0), New Point(0, 1), New Point(1, 1)}
        Dim ZEast = New Point() {New Point(0, -1), New Point(-1, 0), New Point(-1, 1)}
        Dim ZSouth = ZNorth
        Dim ZWest = ZEast
        Dim BlockZ As New BlockType(ZName, ZNorth, ZEast, ZSouth, ZWest)
        _listBlockTypes.Add(BlockZ)

    End Sub

    Private Sub switchBlock()
        CurrentBlock = NextBlock
        CurrentBlock.StartFall(Me.Background)
        NextBlock = New Block(_listBlockTypes, randomBlockType())
        NextBlock.PutOnNext(Me.Background)
    End Sub

    Public Sub Draw(ByVal PictureBoxGameHandle As System.IntPtr, ByVal PictureBoxNextHandle As System.IntPtr)
        Me.Background.Draw(PictureBoxGameHandle)
        Me.CurrentBlock.Draw(PictureBoxGameHandle)
        Me.NextBlock.Draw(PictureBoxNextHandle)
    End Sub

    Public Sub CBMoveLeft()
        Me.CurrentBlock.MoveLeft(Me.Background)
    End Sub

    Public Sub CBMoveRight()
        Me.CurrentBlock.MoveRight(Me.Background)
    End Sub

    Public Sub CBRotate()
        Me.CurrentBlock.Rotate(Me.Background)
    End Sub

    Public Sub CBMoveDown()
        Dim canMoveDown As Boolean
        canMoveDown = Me.CurrentBlock.MoveDown(Me.Background)
        If canMoveDown = False Then
            Dim cBWithinBoundary As Boolean
            cBWithinBoundary = Me.Background.BlockToPile(CurrentBlock)
            If cBWithinBoundary Then
                Me.switchBlock()
                Dim lines As Integer = Me.Background.RemoveCompleteLines()
                Me.updateScore(lines)
                Me.updateLevel()
            Else
                '' Pause game.
                Me._gameInProgress = False
            End If
        End If
    End Sub
End Class
