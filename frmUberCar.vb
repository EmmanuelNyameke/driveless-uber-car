' Program: Driveless Uber Car
' Date: September 22, 2024
' Author: K Bola
' Purpose: This program calculates the cost of driveless uber car fare
Public Class frmUberCar
    Const _cdecCostPerMile As Decimal = 1.8D
    Const _cdecFlatRate As Decimal = 2.8D
    Dim strNumberOfMiles As String
    Dim intNumberOfMiles As Integer
    Dim decTotal As Decimal

    Private Sub btnDisplayFare_Click(sender As Object, e As EventArgs) Handles btnDisplayFare.Click
        strNumberOfMiles = txtNumberOfMiles.Text
        intNumberOfMiles = Convert.ToInt32(strNumberOfMiles)
        decTotal = intNumberOfMiles * _cdecCostPerMile * _cdecFlatRate
        lblFare.Text = decTotal.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberOfMiles.Clear()
        lblFare.Text = ""
        txtNumberOfMiles.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmUberCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumberOfMiles.Focus()
        lblCostPerMile.Text = _cdecCostPerMile.ToString("C") & " Cost Per Mile"
        lblFlatRate.Text = _cdecFlatRate.ToString("C") & " flat rate charged at pickup"
        lblFare.Text = ""
    End Sub
End Class
