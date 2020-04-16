<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtPassword = New System.Windows.Forms.TextBox()
		Me.TxtUsername = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(23, 159)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 15)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Username"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(23, 246)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 15)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Password"
		'
		'TxtPassword
		'
		Me.TxtPassword.Location = New System.Drawing.Point(127, 243)
		Me.TxtPassword.Name = "TxtPassword"
		Me.TxtPassword.Size = New System.Drawing.Size(135, 20)
		Me.TxtPassword.TabIndex = 2
		'
		'TxtUsername
		'
		Me.TxtUsername.Location = New System.Drawing.Point(127, 152)
		Me.TxtUsername.Name = "TxtUsername"
		Me.TxtUsername.Size = New System.Drawing.Size(135, 20)
		Me.TxtUsername.TabIndex = 3
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(26, 326)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(95, 36)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Entrer"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(188, 325)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(91, 37)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "Réessayer"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.WindowsApppfa1.My.Resources.Resources._3513330
		Me.ClientSize = New System.Drawing.Size(308, 450)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TxtUsername)
		Me.Controls.Add(Me.TxtPassword)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtPassword As TextBox
	Friend WithEvents TxtUsername As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
