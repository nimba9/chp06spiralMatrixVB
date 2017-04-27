Module Module1

    Public Class SpiralMatrix

        Public Shared Sub Main()
            Console.WriteLine("Please enter a positive number: ")
            Dim userInp As String = Console.ReadLine()
            Dim num As Integer = 0
            Dim checkInput As Boolean = Integer.TryParse(userInp, num)
            If checkInput <> True Then
                Console.WriteLine("Your entry is not valid")
            End If

            Dim row As Integer = 0
            Dim column As Integer = 0
            Dim table As Integer(,) = New Integer(num - 1, num - 1) {}
            Dim direction As String = "right"
            Dim maxvalue As Integer = num * num
            For start As Integer = 1 To maxvalue
                If direction = "right" AndAlso (column > num - 1 OrElse table(row, column) <> 0) Then
                    direction = "down"
                    column -= 1
                    row += 1
                End If

                If direction = "down" AndAlso (row > num - 1 OrElse table(row, column) <> 0) Then
                    direction = "left"
                    column -= 1
                    row -= 1
                End If

                If direction = "left" AndAlso (column < 0 OrElse table(row, column) <> 0) Then
                    direction = "up"
                    column += 1
                    row -= 1
                End If

                If direction = "up" AndAlso (row < 0 OrElse table(row, column) <> 0) Then
                    direction = "right"
                    column += 1
                    row += 1
                End If

                table(row, column) = start
                Select Case direction
                    Case "right"
                        column += 1
                    Case "down"
                        row += 1
                    Case "left"
                        column -= 1
                    Case "up"
                        row -= 1
                End Select
            Next

            For i As Integer = 0 To num - 1
                For j As Integer = 0 To num - 1
                    Console.Write("{0,4}", table(i, j))
                Next

                Console.WriteLine()
            Next
        End Sub
    End Class

End Module
