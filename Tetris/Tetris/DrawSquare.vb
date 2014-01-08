Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class DrawSquare
    Public Shared SquareSize As Integer = 15

    Public Shared Sub Draw(ByVal WinHandle As System.IntPtr, ByVal Position As Point)
        Dim GameGraphics As Graphics
        GameGraphics = Graphics.FromHwnd(WinHandle)
        GameGraphics.FillRectangle(Brushes.Black, Position.X * SquareSize, Position.Y * SquareSize, SquareSize, SquareSize)
        GameGraphics.Dispose()

        'Dim GameGraphics As Graphics
        'GameGraphics = Graphics.FromHwnd(WinHandle)

        'Dim GraphPath As GraphicsPath
        'GraphPath = New GraphicsPath

        'Dim BrushSquare As PathGradientBrush
        'Dim SurroundColor() As Color
        'Dim RectSquare As Rectangle

        'RectSquare = New Rectangle(Position.X * SquareSize, Position.Y * SquareSize, SquareSize, SquareSize)
        'GraphPath.AddRectangle(RectSquare)

        'BrushSquare = New PathGradientBrush(GraphPath)
        'BrushSquare.CenterColor = Color.Black
        'SurroundColor = New Color() {Color.DarkSlateGray}
        'BrushSquare.SurroundColors = SurroundColor

        'GameGraphics.FillPath(BrushSquare, GraphPath)
        'GameGraphics.Dispose()
    End Sub

    Public Shared Sub Draw(ByVal WinHandle As System.IntPtr, ByVal X As Integer, ByVal Y As Integer)
        Dim GameGraphics As Graphics
        GameGraphics = Graphics.FromHwnd(WinHandle)
        GameGraphics.FillRectangle(Brushes.Black, X * SquareSize, Y * SquareSize, SquareSize, SquareSize)
        GameGraphics.Dispose()
        'Dim GameGraphics As Graphics
        'GameGraphics = Graphics.FromHwnd(WinHandle)

        'Dim GraphPath As GraphicsPath
        'GraphPath = New GraphicsPath

        'Dim BrushSquare As PathGradientBrush
        'Dim SurroundColor() As Color
        'Dim RectSquare As Rectangle

        'RectSquare = New Rectangle(X * SquareSize, Y * SquareSize, SquareSize, SquareSize)
        'GraphPath.AddRectangle(RectSquare)

        'BrushSquare = New PathGradientBrush(GraphPath)
        'BrushSquare.CenterColor = Color.Black
        'SurroundColor = New Color() {Color.DarkSlateGray}
        'BrushSquare.SurroundColors = SurroundColor

        'GameGraphics.FillPath(BrushSquare, GraphPath)
        'GameGraphics.Dispose()
    End Sub
End Class
