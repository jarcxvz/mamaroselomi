<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.login = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.lgnbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'login
        '
        Me.login.AutoSize = True
        Me.login.BackColor = System.Drawing.Color.Transparent
        Me.login.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.White
        Me.login.Location = New System.Drawing.Point(171, 138)
        Me.login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(104, 37)
        Me.login.TabIndex = 0
        Me.login.Text = "LOGIN"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(108, 226)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(236, 30)
        Me.Username.TabIndex = 1
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(104, 201)
        Me.label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(95, 23)
        Me.label.TabIndex = 0
        Me.label.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 277)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password:"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(108, 303)
        Me.Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(236, 30)
        Me.Password.TabIndex = 1
        '
        'lgnbutton
        '
        Me.lgnbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lgnbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lgnbutton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lgnbutton.Location = New System.Drawing.Point(177, 356)
        Me.lgnbutton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lgnbutton.Name = "lgnbutton"
        Me.lgnbutton.Size = New System.Drawing.Size(88, 36)
        Me.lgnbutton.TabIndex = 2
        Me.lgnbutton.Text = "Login"
        Me.lgnbutton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lgnbutton)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.login)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Mamaroselomi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents lgnbutton As Button
End Class
