<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bnt1 = New System.Windows.Forms.Button()
        Me.userName = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.output = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bnt1
        '
        Me.bnt1.Location = New System.Drawing.Point(184, 195)
        Me.bnt1.Name = "bnt1"
        Me.bnt1.Size = New System.Drawing.Size(75, 23)
        Me.bnt1.TabIndex = 0
        Me.bnt1.Text = "Button1"
        Me.bnt1.UseVisualStyleBackColor = True
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(184, 125)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(100, 20)
        Me.userName.TabIndex = 1
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(184, 151)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(100, 20)
        Me.password.TabIndex = 2
        '
        'output
        '
        Me.output.AutoSize = True
        Me.output.Location = New System.Drawing.Point(334, 132)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(39, 13)
        Me.output.TabIndex = 3
        Me.output.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.bnt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bnt1 As Button
    Friend WithEvents userName As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents output As Label
End Class
