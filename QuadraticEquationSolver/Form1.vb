Public Class QESolver
    ReadOnly vali As Validation = New Validation()
    Private Sub QESolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim stringA As String = TxtA.Text
        Dim stringB As String = TxtB.Text
        Dim stringC As String = TxtC.Text

        If (vali.isNumber(stringA) And vali.isNumber(stringB) And vali.isNumber(stringC)) And (Not stringA.Equals("0")) And (Not stringA.Equals("") Or Not stringB.Equals("") Or Not stringC.Equals("")) Then
            Dim doubleA As Double = Double.Parse(stringA)


            If stringB.Equals("") Then
                stringB = "0"
            ElseIf stringC.Equals("") Then
                stringC = "0"
            End If

            Dim doubleB As Double = Double.Parse(stringB)
            Dim doubleC As Double = Double.Parse(stringC)

            Dim discriminant As Double = (doubleB ^ 2) - (4 * doubleA * doubleC)

            If discriminant < 0 Then
                LblNoSoloutions.Visible = True
                LblXOne.Visible = False
                LblXTwo.Visible = False

                LblNoSoloutions.Text = "No Real Soloutions"
            ElseIf discriminant = 0 Then
                LblXTwo.Visible = False
                Dim top As Decimal = (-1 * doubleB) + (Math.Sqrt(discriminant))

                Dim value = top / (2 * doubleA)

                Dim decimalPlaces As Integer = txtDecimalPlaces.Value

                value = Decimal.Round(Decimal.Parse(value.ToString), decimalPlaces)


                LblXOne.Visible = True
                LblNoSoloutions.Visible = False

                LblXOne.Text = vali.addZeroes(value.ToString, decimalPlaces)
            Else
                Dim topPlus As Decimal = (-1 * doubleB) + (Math.Sqrt(discriminant))
                Dim topMinus As Decimal = (-1 * doubleB) - (Math.Sqrt(discriminant))

                Dim plusValue = topPlus / (2 * doubleA)
                Dim minusValue = topMinus / (2 * doubleA)

                Dim decimalPlaces As Integer = txtDecimalPlaces.Value


                plusValue = Decimal.Round(Decimal.Parse(plusValue.ToString), decimalPlaces)
                minusValue = Decimal.Round(Decimal.Parse(minusValue.ToString), decimalPlaces)





                LblXOne.Visible = True
                LblXTwo.Visible = True
                LblNoSoloutions.Visible = False

                LblXOne.Text = vali.addZeroes(plusValue.ToString, decimalPlaces)
                LblXTwo.Text = vali.addZeroes(minusValue.ToString, decimalPlaces)


            End If






        Else
            LblNoSoloutions.Visible = True
            LblXOne.Visible = False
            LblXTwo.Visible = False

            LblNoSoloutions.Text = "All values must be numbers " + vbNewLine + "and A must be greater than 0"
        End If

    End Sub

    Private Sub txtDecimalPlaces_ValueChanged(sender As Object, e As EventArgs) Handles txtDecimalPlaces.ValueChanged
        BtnCalc_Click(New Object, New EventArgs)
    End Sub



End Class
