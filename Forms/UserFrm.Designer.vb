<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserFrm))
        Me.bClose = New System.Windows.Forms.Button()
        Me.bChange = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tConf = New System.Windows.Forms.TextBox()
        Me.tPass = New System.Windows.Forms.TextBox()
        Me.tFullnym = New System.Windows.Forms.TextBox()
        Me.tId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bClose
        '
        Me.bClose.Location = New System.Drawing.Point(214, 128)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(79, 32)
        Me.bClose.TabIndex = 15
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'bChange
        '
        Me.bChange.Location = New System.Drawing.Point(123, 128)
        Me.bChange.Name = "bChange"
        Me.bChange.Size = New System.Drawing.Size(85, 32)
        Me.bChange.TabIndex = 14
        Me.bChange.Text = "Add User"
        Me.bChange.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Confirmed Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Username"
        '
        'tConf
        '
        Me.tConf.Location = New System.Drawing.Point(119, 102)
        Me.tConf.Name = "tConf"
        Me.tConf.Size = New System.Drawing.Size(165, 20)
        Me.tConf.TabIndex = 13
        Me.tConf.UseSystemPasswordChar = True
        '
        'tPass
        '
        Me.tPass.Location = New System.Drawing.Point(119, 76)
        Me.tPass.Name = "tPass"
        Me.tPass.Size = New System.Drawing.Size(165, 20)
        Me.tPass.TabIndex = 12
        Me.tPass.UseSystemPasswordChar = True
        '
        'tFullnym
        '
        Me.tFullnym.Location = New System.Drawing.Point(119, 50)
        Me.tFullnym.Name = "tFullnym"
        Me.tFullnym.Size = New System.Drawing.Size(275, 20)
        Me.tFullnym.TabIndex = 11
        Me.tFullnym.Text = "Full Name"
        '
        'tId
        '
        Me.tId.Location = New System.Drawing.Point(119, 24)
        Me.tId.Name = "tId"
        Me.tId.Size = New System.Drawing.Size(139, 20)
        Me.tId.TabIndex = 10
        Me.tId.Text = "Id Number"
        '
        'UserFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 167)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bChange)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tConf)
        Me.Controls.Add(Me.tPass)
        Me.Controls.Add(Me.tFullnym)
        Me.Controls.Add(Me.tId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents bChange As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tConf As System.Windows.Forms.TextBox
    Friend WithEvents tPass As System.Windows.Forms.TextBox
    Friend WithEvents tFullnym As System.Windows.Forms.TextBox
    Friend WithEvents tId As System.Windows.Forms.TextBox
End Class
