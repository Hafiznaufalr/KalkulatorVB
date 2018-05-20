Public Class Form1

    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim AnswerNumber As Single
    Dim ArithmeticProcess As String

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtHasil.Text = txtHasil.Text & 0
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtHasil.Text = txtHasil.Text & 1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtHasil.Text = txtHasil.Text & 2
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtHasil.Text = txtHasil.Text & 3
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtHasil.Text = txtHasil.Text & 4
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtHasil.Text = txtHasil.Text & 5
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtHasil.Text = txtHasil.Text & 6
    End Sub

    Private Sub btn7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtHasil.Text = txtHasil.Text & 7
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtHasil.Text = txtHasil.Text & 8
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtHasil.Text = txtHasil.Text & 9
    End Sub

    Private Sub btnBagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBagi.Click
        FirstNumber = Val(txtHasil.Text)
        txtHasil.Text = "0"
        ArithmeticProcess = "/"
    End Sub

    Private Sub btnKali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKali.Click
        FirstNumber = Val(txtHasil.Text)
        txtHasil.Text = "0"
        ArithmeticProcess = "*"
    End Sub

    Private Sub btnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKurang.Click
        FirstNumber = Val(txtHasil.Text)
        txtHasil.Text = "0"
        ArithmeticProcess = "-"
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        FirstNumber = Val(txtHasil.Text)
        txtHasil.Text = "0"
        ArithmeticProcess = "+"
    End Sub

    Private Sub btnHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHasil.Click
        SecondNumber = Val(txtHasil.Text)
        If ArithmeticProcess = "+" Then
            AnswerNumber = FirstNumber + SecondNumber
        End If
        If ArithmeticProcess = "-" Then
            AnswerNumber = FirstNumber - SecondNumber
        End If
        If ArithmeticProcess = "*" Then
            AnswerNumber = FirstNumber * SecondNumber
        End If
        If ArithmeticProcess = "/" Then
            AnswerNumber = FirstNumber / SecondNumber
        End If
        txtHasil.Text = AnswerNumber
    End Sub

    
End Class
