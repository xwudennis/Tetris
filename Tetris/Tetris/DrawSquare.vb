Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class DrawSquare
    '' A Class designed to draw squares
    Public Shared SquareSize As Integer = 15

    Public Shared Sub Draw(ByVal WinHandle As System.IntPtr, ByVal Position As Point)
        Dim GameGraphics As Graphics
        GameGraphics = Graphics.FromHwnd(WinHandle)
        GameGraphics.FillRectangle(Brushes.Black, Position.X * SquareSize, Position.Y * SquareSize, SquareSize, SquareSize)
        GameGraphics.Dispose()
    End Sub

    Public Shared Sub Draw(ByVal WinHandle As System.IntPtr, ByVal X As Integer, ByVal Y As Integer)
        Dim GameGraphics As Graphics
        GameGraphics = Graphics.FromHwnd(WinHandle)
        GameGraphics.FillRectangle(Brushes.Black, X * SquareSize, Y * SquareSize, SquareSize, SquareSize)
        GameGraphics.Dispose()
    End Sub
End Class
