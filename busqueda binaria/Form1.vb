Public Class Form1
    Dim x(999) As Integer



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 999
            x(i) = i
            ListBox1.Items.Add(x(i))
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim izq As Integer = 0
        Dim der As Integer = 999
        Dim indice As Integer = 0
        Dim band As Boolean = True
        Dim val As Integer = CInt(TextBox1.Text)
        If val < 0 Then
            MessageBox.Show("Se esperaba un numero positivo y entero")
        Else
            For j As Integer = 0 To 9
                indice = (izq + der) / 2
                If x(indice) = val Then
                    band = False
                    j = 9
                ElseIf x(indice) < val Then
                    izq = indice + 1
                Else
                    der = indice - 1
                End If


            Next
        End If
        
        If band = True AndAlso x(indice) <> val Then
            MessageBox.Show("El valor no se encuentra en la lista")
        Else
            MessageBox.Show("El valor buscado se encuentra en la posicion:" & indice)
        End If
        TextBox1.Text = ""

    End Sub
End Class
