﻿Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num1, num2 As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text


        If optSuma.Checked Then
            lblRespuesta.Text = num1 + num2
        End If
        If optResta.Checked Then
            lblRespuesta.Text = num1 - num2
        End If
        If optMul.Checked Then
            lblRespuesta.Text = num1 * num2
        End If
        If optDivsion.Checked Then
            lblRespuesta.Text = num1 / num2
        End If
        If optExponenciacion.Checked Then
            lblRespuesta.Text = num1 ^ num2
        End If
        If optResiduo.Checked Then
            lblRespuesta.Text = num1 Mod num2
        End If
        If optPorcentaje.Checked Then
            lblRespuesta.Text = num2 * num1 / 100
        End If
    End Sub
End Class
