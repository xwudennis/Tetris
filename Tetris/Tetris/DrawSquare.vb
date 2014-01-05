﻿Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class DrawSquare
    Public Shared SquareSize As Integer = 15

    Public Shared Sub Draw(ByVal WinHandle As System.IntPtr, ByVal Position As Point)
        Dim GameGraphics As Graphics
        GameGraphics = Graphics.FromHwnd(WinHandle)
        GameGraphics.FillRectangle(Brushes.Black, Position.X * SquareSize, Position.Y * SquareSize, SquareSize, SquareSize)
        GameGraphics.Dispose()
    End Sub
End Class