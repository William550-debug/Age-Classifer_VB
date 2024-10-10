Module AgeClassifier
    Sub Main()
        Dim age As Integer = 0

        Do
            Try
                Console.Write("Enter your age: ")
                age = Convert.ToInt32(Console.ReadLine())


                If age < 0 Then
                    Console.WriteLine("Input a valid age that is greater than 0")

                End If

            Catch ex As Exception
                Console.WriteLine("Invalid input please enter a valid integer")


            End Try
        Loop Until age > 0


        'Age classification criteria'
        If age < 13 Then
            Console.WriteLine("You are child")
        ElseIf age >= 13 And age <= 19 Then
            Console.WriteLine("You are a teeenager")

        Else
            Console.WriteLine("You are an adult")

        End If

        Console.WriteLine("Even numbers from 1 to your age")
        For i As Integer = 1 To age
            If i Mod 2 = 0 Then
                Console.WriteLine(i)

            End If
        Next


        Console.WriteLine("Press any key to exit")
        Console.ReadKey()

    End Sub
End Module