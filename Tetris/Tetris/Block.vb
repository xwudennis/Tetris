Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Block
    Public Enum RotationDirections
        North = 1
        East = 2
        South = 3
        West = 4
    End Enum

    Private _direction As RotationDirections
    Private _type As BlockType
    Private _center As Point
    Private _squarePositions As Point()

    Public ReadOnly Property Type() As BlockType
        Get
            Return _type
        End Get
    End Property

    Public ReadOnly Property SquarePositions() As Point()
        Get
            Return _squarePositions
        End Get
    End Property

    Public Sub New(ByVal BlockTypeList As List(Of BlockType), ByVal i As Integer)
        If i < BlockTypeList.Count() Then
            Me._direction = RotationDirections.North
            Me._type = BlockTypeList(i)
            Me._center = New Point(0, 0)
            Me._squarePositions = New Point(BlockType.NumberOfBlocks - 1) {}

            For j As Integer = 0 To BlockType.NumberOfBlocks - 1
                Dim newPoint As New Point(0, 0)
                Me._squarePositions(j) = newPoint
            Next
            Me.updatePositions()
        Else
            MsgBox("Error on Block Type", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub updatePositions()
        For j As Integer = 0 To BlockType.NumberOfBlocks - 2
            Select Case Me._direction
                Case RotationDirections.North
                    Me._squarePositions(j).X = Me._center.X + Me._type.NorthOffsets(j).X
                    Me._squarePositions(j).Y = Me._center.Y + Me._type.NorthOffsets(j).Y
                Case RotationDirections.East
                    Me._squarePositions(j).X = Me._center.X + Me._type.EastOffsets(j).X
                    Me._squarePositions(j).Y = Me._center.Y + Me._type.EastOffsets(j).Y
                Case RotationDirections.South
                    Me._squarePositions(j).X = Me._center.X + Me._type.SouthOffsets(j).X
                    Me._squarePositions(j).Y = Me._center.Y + Me._type.SouthOffsets(j).Y
                Case RotationDirections.West
                    Me._squarePositions(j).X = Me._center.X + Me._type.WestOffsets(j).X
                    Me._squarePositions(j).Y = Me._center.Y + Me._type.WestOffsets(j).Y
                Case Else
                    MsgBox("Error on Block Direction", MsgBoxStyle.Critical)
            End Select
        Next
        Me._squarePositions(BlockType.NumberOfBlocks - 1).X = Me._center.X
        Me._squarePositions(BlockType.NumberOfBlocks - 1).Y = Me._center.Y
    End Sub

    Public Sub Rotate()
        If Me._direction < 4 Then
            Me._direction += 1
        Else
            Me._direction = 1
        End If
        Me.updatePositions()
    End Sub

    Public Sub MoveDown()
        Me._center.Y += 1
        Me.updatePositions()
    End Sub

    Public Sub MoveLeft()
        Me._center.X -= 1
        Me.updatePositions()
    End Sub

    Public Sub MoveRight()
        Me._center.X += 1
        Me.updatePositions()
    End Sub

    Public Sub Draw(ByVal WinHandle As System.IntPtr)
        Me.updatePositions()
        For Each p As Point In Me._squarePositions
            DrawSquare.Draw(WinHandle, p)
        Next
    End Sub
End Class
