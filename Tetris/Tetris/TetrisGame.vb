Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class TetrisGame
    Private ListBlockTypes As List(Of BlockType)
    Public blockA As Block

    Public Sub New()
        Me.SetBlockTypes()
        Me.blockA = New Block(ListBlockTypes, 1)
    End Sub

    Public Sub SetBlockTypes()
        ListBlockTypes = New List(Of BlockType)

        Dim IName As String = "I"
        Dim INorth = New Point() {New Point(0, -1), New Point(0, 1), New Point(0, 2)}
        Dim IEast = New Point() {New Point(-1, 0), New Point(1, 0), New Point(2, 0)}
        Dim ISouth = INorth
        Dim IWest = IEast
        Dim BlockI As New BlockType(IName, INorth, IEast, ISouth, IWest)
        ListBlockTypes.Add(BlockI)

        Dim JName As String = "J"
        Dim JNorth = New Point() {New Point(-1, 0), New Point(0, -1), New Point(0, -2)}
        Dim JEast = New Point() {New Point(0, -1), New Point(1, 0), New Point(2, 0)}
        Dim JSouth = New Point() {New Point(1, 0), New Point(0, 1), New Point(0, 2)}
        Dim JWest = New Point() {New Point(0, 1), New Point(-1, 0), New Point(-2, 0)}
        Dim BlockJ As New BlockType(JName, JNorth, JEast, JSouth, JWest)
        ListBlockTypes.Add(BlockJ)

        Dim LName As String = "L"
        Dim LNorth = New Point() {New Point(1, 0), New Point(0, -1), New Point(0, -2)}
        Dim LEast = New Point() {New Point(0, 1), New Point(1, 0), New Point(2, 0)}
        Dim LSouth = New Point() {New Point(-1, 0), New Point(0, 1), New Point(0, 2)}
        Dim LWest = New Point() {New Point(0, -1), New Point(-1, 0), New Point(-2, 0)}
        Dim BlockL As New BlockType(LName, LNorth, LEast, LSouth, LWest)
        ListBlockTypes.Add(BlockL)

        Dim OName As String = "O"
        Dim ONorth = New Point() {New Point(1, 0), New Point(0, 1), New Point(1, 1)}
        Dim OEast = ONorth
        Dim OSouth = ONorth
        Dim OWest = ONorth
        Dim BlockO As New BlockType(OName, ONorth, OEast, OSouth, OWest)
        ListBlockTypes.Add(BlockO)

        Dim SName As String = "S"
        Dim SNorth = New Point() {New Point(-1, 0), New Point(0, -1), New Point(1, -1)}
        Dim SEast = New Point() {New Point(0, -1), New Point(1, 0), New Point(1, 1)}
        Dim SSouth = SNorth
        Dim SWest = SEast
        Dim BlockS As New BlockType(SName, SNorth, SEast, SSouth, SWest)
        ListBlockTypes.Add(BlockS)

        Dim TName As String = "T"
        Dim TNorth = New Point() {New Point(-1, 0), New Point(1, 0), New Point(0, 1)}
        Dim TEast = New Point() {New Point(0, -1), New Point(0, 1), New Point(-1, 0)}
        Dim TSouth = New Point() {New Point(1, 0), New Point(-1, 0), New Point(0, -1)}
        Dim TWest = New Point() {New Point(0, 1), New Point(0, -1), New Point(1, 0)}
        Dim BlockT As New BlockType(TName, TNorth, TEast, TSouth, TWest)
        ListBlockTypes.Add(BlockT)

        Dim ZName As String = "Z"
        Dim ZNorth = New Point() {New Point(-1, 0), New Point(0, 1), New Point(1, 1)}
        Dim ZEast = New Point() {New Point(0, -1), New Point(-1, 0), New Point(-1, 1)}
        Dim ZSouth = ZNorth
        Dim ZWest = ZEast
        Dim BlockZ As New BlockType(ZName, ZNorth, ZEast, ZSouth, ZWest)
        ListBlockTypes.Add(BlockZ)

    End Sub

End Class
