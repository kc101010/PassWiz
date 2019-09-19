Module Module1

    '58
    Dim passwordRes = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "Y", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "!", "?", "*", "@", "&", "^", "/", "\"}
    Dim FinishedPassw As String

    Dim passwordPart1 As String
    Dim passwordPart2 As String
    Dim passwordPart3 As Integer
    Dim passwordNumber1 As Integer
    Dim passwordNumber2 As Integer
    Dim PasswordStringPart(8) As Integer

    Sub Main()
        Console.Title = "PassWiz 0.3 - Password Generator"
        Console.WriteLine("Welcome to PassWiz Password Generator")
        Dim IsKeyword As Char

        Console.WriteLine("Would you like to base your password on a key word? (Y/N)")
        IsKeyword = Console.ReadLine

        Do Until IsKeyword = "Y" Or IsKeyword = "N" Or IsKeyword = "y" Or IsKeyword = "n"
            Console.WriteLine("INVALID INPUT - PLEASE TRY AGAIN")
            Console.WriteLine("Would you like to base your password on a key word? (Y/N)")
            IsKeyword = Console.ReadLine
        Loop

        If IsKeyword = "Y" Or IsKeyword = "y" Then
            Call GeneratePasswordOnKeyword()
            Call AppendFinalPassword()
            Console.WriteLine("Your password is: " & FinishedPassw)
        ElseIf IsKeyword = "N" Or IsKeyword = "n" Then
            Call GeneratePassword()
            Call AppendFinalPassword()
            Console.WriteLine("Your password is: " & FinishedPassw)

        End If


        Dim isMore As Char
        Console.WriteLine("Would you like to re-generate your password? (Y/N)")
        isMore = Console.ReadLine

        Do Until isMore = "Y" Or isMore = "N" Or isMore = "y" Or isMore = "n"
            Console.WriteLine("INVALID INPUT - PLEASE TRY AGAIN")
            Console.WriteLine("Would you like to re-generate your password? (Y/N)")
            isMore = Console.ReadLine
        Loop

        If isMore = "Y" Or isMore = "y" Then
            Dim passwordQuantity As Integer
            Console.WriteLine("How many passwords would you like to generate? (MAX:100)")
            passwordQuantity = Console.ReadLine

            Do While passwordQuantity < 1 Or passwordQuantity > 100
                Console.WriteLine("INVALID INPUT - PLEASE TRY AGAIN")
                Console.WriteLine("How many passwords would you like to generate? (MAX:100)")
                passwordQuantity = Console.ReadLine
            Loop

            For x = 1 To passwordQuantity
                Call GeneratePassword()
                Call AppendFinalPassword()
                Console.WriteLine("Your password is: " & FinishedPassw)
            Next
        ElseIf isMore = "N" Or isMore = "n" Then



        End If
        Call CloseProgram()


    End Sub

    Function GeneratePasswordOnKeyword()
        Dim KeyWord As String

        Console.WriteLine("Please enter your key word - Min 2 characters, Max 8")
        KeyWord = Console.ReadLine


        Do While Len(KeyWord) < 2 Or Len(KeyWord) > 8
            Console.WriteLine("INVALID INPUT - PLEASE TRY AGAIN")
            Console.WriteLine("Please enter your key word - Min 2 characters, Max 8")
            KeyWord = Console.ReadLine
        Loop

        Dim keyWordSubString(Len(KeyWord)) As Char
        For x = 1 To Len(KeyWord)
            keyWordSubString(x) = Mid(KeyWord, x, x)
        Next x

        Randomize()

        If Len(passwordPart1) < 8 Then
            For x = 1 To 8
                PasswordStringPart(x) = Int(Rnd() * 58)
                Do While PasswordStringPart(x) < 1
                    PasswordStringPart(x) = Int(Rnd() * 58)
                Loop
                passwordPart1 += passwordRes(PasswordStringPart(x))


            Next

        End If

        For x = 1 To Len(KeyWord)
            PasswordStringPart(x) = Int(Rnd() * Len(KeyWord))
            passwordPart1 += keyWordSubString(PasswordStringPart(x))

        Next



        passwordNumber1 = Int(Rnd() * 80)
        passwordNumber2 = Int(Rnd() * 16)

        Do
            passwordNumber1 = Int(Rnd() * 80)
            passwordNumber2 = Int(Rnd() * 16)

        Loop Until passwordNumber1 <> passwordNumber2



        passwordPart2 = Len(KeyWord)


        If passwordPart2 = 0 Then
            passwordPart2 = Int(Rnd() * 50)
        End If


        passwordPart3 = AscW(KeyWord)


        Return passwordPart1
        Return passwordPart2
        Return passwordPart3
        Return FinishedPassw


    End Function

    Function GeneratePassword()
        passwordPart1 = ""
        passwordPart2 = 0

        Randomize()

        For x = 1 To 8
            PasswordStringPart(x) = Int(Rnd() * 58)
            passwordPart1 += passwordRes(PasswordStringPart(x))
        Next

        passwordPart2 = Int(Rnd() * 80)
        passwordPart3 = Int(Rnd() * Len(passwordPart1) * 2)


        Return passwordPart1
        Return passwordPart2
        Return FinishedPassw




    End Function

    Function AppendFinalPassword()
        Randomize()
        Dim PassWordOrder As Integer

        PassWordOrder = Int(Rnd() * 3)

        Do While PassWordOrder = 0
            PassWordOrder = Int(Rnd() * 3)
        Loop



        If PassWordOrder = 3 Then
            FinishedPassw = passwordPart3 & passwordPart1 & passwordPart2
        ElseIf PassWordOrder = 2 Then
            FinishedPassw = passwordPart2 & passwordPart1 & passwordPart3
        ElseIf PassWordOrder = 1 Then
            FinishedPassw = passwordPart1 & passwordPart2 & passwordPart3
        End If

        FinishedPassw = FinishedPassw.Replace(" ", String.Empty)

        Return FinishedPassw
        Console.WriteLine(FinishedPassw)

    End Function

    Sub CloseProgram()





        Console.WriteLine("Thank you for using PassWiz")
        System.Threading.Thread.Sleep(100)
        Console.WriteLine("Press any key to close...")
        Console.ReadKey()


    End Sub


End Module
