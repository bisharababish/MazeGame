<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Shot = New System.Windows.Forms.PictureBox()
        Me.Shooter = New System.Windows.Forms.PictureBox()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Shot
        '
        Me.Shot.BackColor = System.Drawing.Color.DarkRed
        Me.Shot.Location = New System.Drawing.Point(449, 262)
        Me.Shot.Name = "Shot"
        Me.Shot.Size = New System.Drawing.Size(10, 20)
        Me.Shot.TabIndex = 3
        Me.Shot.TabStop = False
        '
        'Shooter
        '
        Me.Shooter.BackColor = System.Drawing.Color.White
        Me.Shooter.Image = CType(resources.GetObject("Shooter.Image"), System.Drawing.Image)
        Me.Shooter.Location = New System.Drawing.Point(2, 482)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(88, 110)
        Me.Shooter.TabIndex = 2
        Me.Shooter.TabStop = False
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(829, 598)
        Me.Controls.Add(Me.Shot)
        Me.Controls.Add(Me.Shooter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.Text = "Stage3 - Shooting"
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Shot As PictureBox
    Friend WithEvents Shooter As PictureBox
    Friend WithEvents TimerMain As Timer
End Class
