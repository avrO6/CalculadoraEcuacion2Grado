﻿Public Class Form1

    'Boton de salir'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub


    'Boton de calcular'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcula.Click

        Dim a As Double
        Dim b As Double
        Dim c As Double


        'Lee los valores que introduces en los cuadros de texto y comprueba si son letras'
        If IsNumeric(datoA.Text) And IsNumeric(datoB.Text) And IsNumeric(datoC.Text) Then
            a = CDbl(datoA.Text)
            b = CDbl(datoB.Text)
            c = CDbl(datoC.Text)
        Else
            'Te muestra un mensaje de error si algún valor no es numérico'
            MsgBox("Ingrese valores numéricos para a, b y c")
            Exit Sub 'Se sale de la funcion si hay un error'
        End If
        'Lee el valor que introduces en A y comprueba que no sea 0'
        If a = 0 Then
            MsgBox("El valor de 'a' no puede ser 0 ")
        Else
            'Calcular el discriminante (la parte de la raiz cuadrada)'
            Dim ecuacion = New Ecuacion(a, b, c)
            Dim discriminante As Double = ecuacion.calcular()
            'Comprueba si la ecuación tiene soluciones reales o imaginarias'
            If discriminante > 0 Then
                'Te dice si la ecuación tiene dos soluciones reales'
                raiz1.Text = ecuacion.Rm11
                raiz2.Text = ecuacion.Rm21

                tipo.Text = "Soluciones reales"
                raiz1.ForeColor = Color.Green
            ElseIf discriminante = 0 Then
                'te dice si la ecuación tiene una solución real'
                raiz1.Text = ecuacion.Rm11
                raiz2.Text = ecuacion.Rm21

                tipo.Text = "Solución real"
            Else
                'te dice si la ecuación tiene soluciones imaginarias'
                raiz1.Text = ecuacion.Rm11 & " + " & ecuacion.Im11 & "i"
                raiz2.Text = ecuacion.Rm21 & " - " & ecuacion.Im21 & "i"

                tipo.Text = "Soluciones imaginarias"
            End If
        End If
    End Sub



    'Codigo del boton de limpiar los datos'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        datoA.Clear()
        datoB.Clear()
        datoC.Clear()
        raiz1.Clear()
        raiz2.Clear()
        tipo.Clear()
    End Sub
End Class