<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBTetris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBoxGame = New System.Windows.Forms.PictureBox()
        Me.PictureBoxNext = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxGame
        '
        Me.PictureBoxGame.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBoxGame.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxGame.Name = "PictureBoxGame"
        Me.PictureBoxGame.Size = New System.Drawing.Size(150, 300)
        Me.PictureBoxGame.TabIndex = 0
        Me.PictureBoxGame.TabStop = False
        '
        'PictureBoxNext
        '
        Me.PictureBoxNext.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBoxNext.Location = New System.Drawing.Point(180, 81)
        Me.PictureBoxNext.Name = "PictureBoxNext"
        Me.PictureBoxNext.Size = New System.Drawing.Size(75, 75)
        Me.PictureBoxNext.TabIndex = 1
        Me.PictureBoxNext.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Score:"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(180, 177)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Level:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(177, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Next Block"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'VBTetris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 329)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxNext)
        Me.Controls.Add(Me.PictureBoxGame)
        Me.Name = "VBTetris"
        Me.Text = "VBTetris"
        CType(Me.PictureBoxGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxGame As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxNext As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
