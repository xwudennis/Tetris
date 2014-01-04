Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class BlockType
    Private _typeName As String
    Private _northOffsets As Point()
    Private _eastOffsets As Point()
    Private _southOffsets As Point()
    Private _westOffsets As Point()
    Public Shared NumberOfBlocks As Integer = 4

    Public ReadOnly Property TypeName() As String
        Get
            Return _typeName
        End Get
    End Property

    Public ReadOnly Property NorthOffsets() As Point()
        Get
            Return _northOffsets
        End Get
    End Property

    Public ReadOnly Property EastOffsets() As Point()
        Get
            Return _eastOffsets
        End Get
    End Property

    Public ReadOnly Property SouthOffsets() As Point()
        Get
            Return _southOffsets
        End Get
    End Property

    Public ReadOnly Property WestOffsets() As Point()
        Get
            Return _westOffsets
        End Get
    End Property

    Public Sub New(ByVal TypeName As String, ByVal NorthOffsets As Point(), ByVal EastOffsets As Point(), ByVal SouthOffsets As Point(), ByVal WestOffsets As Point())
        Me._typeName = TypeName
        Me._northOffsets = NorthOffsets
        Me._eastOffsets = EastOffsets
        Me._southOffsets = SouthOffsets
        Me._westOffsets = WestOffsets
        If Me._northOffsets.Length() = NumberOfBlocks - 1 And Me._eastOffsets.Length() = NumberOfBlocks - 1 And Me._southOffsets.Length() = NumberOfBlocks - 1 And Me._westOffsets.Length() = NumberOfBlocks - 1 Then
            ''Do nothing
        Else
            MsgBox("Check Integrity of Input Data of Block Types", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
