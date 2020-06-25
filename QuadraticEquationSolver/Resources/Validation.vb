Public Class Validation

    Function isNumber(inp As String)
        Dim check As Double

        Return Double.TryParse(inp, check)
    End Function

    Function addZeroes(inp As String, reqLength As Integer)

        If inp.Contains(".") Then
            Dim number As Array = inp.Split(".")
            Dim decimals As String = number(1).ToString

            If decimals.Length < reqLength Then
                Do
                    decimals += "0"
                Loop Until decimals.Length = reqLength
            End If

            Dim newNumber As String = number(0).ToString + "." + decimals

            Return newNumber
        Else
            inp = inp + "."
            Do
                inp = inp + "0"
            Loop Until inp.Length = (reqLength + 3)
            Return inp
        End If

    End Function

End Class
