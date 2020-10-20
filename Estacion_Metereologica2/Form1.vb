Public Class Estacion_Meteo
    Private cadena As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim cadena1 As String
        Dim cadena2 As String
        Dim cadena3 As String
        cadena = SerialPort1.ReadExisting()
        cadena1 = Mid(cadena, 1, 5)
        cadena2 = Mid(cadena, 6, 5)
        cadena3 = Mid(cadena, 11, 5)
        txttemp.Text = cadena1.Trim
        txthum.Text = cadena2.Trim
        txtluz.Text = cadena3.Trim
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub ºC_TextChanged(sender As Object, e As EventArgs) Handles ºC.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

