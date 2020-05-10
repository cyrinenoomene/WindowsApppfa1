Public Class frmMain
	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		HideSubMenu()


	End Sub

	Private Sub HideSubMenu()

		Panel3.Visible = False
		Panel4.Visible = False
		Panel5.Visible = False



	End Sub
	Private Sub showSubMenu(SubMenu As Panel)

		If SubMenu.Visible = False Then

			HideSubMenu()
			SubMenu.Visible = True

		Else
			SubMenu.Visible = False
		End If


	End Sub





	Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

	End Sub

	Private Sub btnsap_Click(sender As Object, e As EventArgs) Handles btnsap.Click
		showSubMenu(Panel3)


	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		'code'
		HideSubMenu()

	End Sub






	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		HideSubMenu()

	End Sub

	Private Sub btngraf_Click(sender As Object, e As EventArgs) Handles btngraf.Click
		showSubMenu(Panel4)

	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		HideSubMenu()

	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		HideSubMenu()

	End Sub
	Private Sub btnapi_Click(sender As Object, e As EventArgs) Handles btnapi.Click
		showSubMenu(Panel5)


	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		HideSubMenu()

	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		HideSubMenu()

	End Sub
	Private Sub exbtn_Click(sender As Object, e As EventArgs) Handles exbtn.Click
		Application.Exit()
	End Sub

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		Dim fr As Form2
		fr = New Form2()

		fr.Show()
	End Sub
End Class