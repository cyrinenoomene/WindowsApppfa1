Imports System.Data.SqlClient


Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	'login****'


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim con As New SqlConnection
		Dim cmd As New SqlCommand
		Dim Password As String
		Dim Password2 As String
		Dim userName As String
		Try

			con.ConnectionString = "server=DESKTOP-9CS4D7I;Database=Authentification;Integrated Security=True "
			con.Open()
			cmd.Connection = con
			cmd.CommandText = " SELECT  UserName, Password FROM dbo.LOGIN WHERE UserName='user' and Password='123'"
			Dim rd As SqlDataReader = cmd.ExecuteReader()
			If rd.HasRows Then
				While rd.Read()
					Password = rd("Password").ToString()
					userName = rd("UserName").ToString()
					Password2 = txtPassword.Text()

					If Password = Password2 And userName = TxtUsername.Text Then

						MessageBox.Show("Logged in successfully as " & userName, "", MessageBoxButtons.OK, MessageBoxIcon.Information
									)
						frmMain.Show()
						Me.Hide()
						TxtPassword.Text = ""
						TxtUsername.Text = ""

					End If


				End While
			Else
				MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

				TxtPassword.Text = ""
				TxtUsername.Text = ""
			End If
		Catch ex As Exception
			MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
		Finally
			con.Close()

		End Try


	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		TxtUsername.Text = ""
		TxtPassword.Text = ""
		TxtUsername.Focus()

	End Sub

	Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

	End Sub
End Class
