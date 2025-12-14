Module Module1

    Sub Main()
        Dim iNum1 As Int64, iNum2 As Int64
        Console.Clear()
        Console.WriteLine("Input the First Integer Number:")
        Dim strNum = Console.ReadLine()
        Int64.TryParse(strNum, iNum1)
        Console.WriteLine("Input The Second Integer Number:")
        strNum = Console.ReadLine()
        Int64.TryParse(strNum, iNum2)
        Dim iVal1 = Math.Abs(iNum1)
        Dim iVal2 = Math.Abs(iNum2)
        If (iVal1 > 0 And iVal2 > 0) Then
            Dim iVal3 = iVal1
            Dim iVal4 = iVal2
            Do While (iVal1 <> iVal2)
                If (iVal1 > iVal2) Then
                    iVal1 -= iVal2
                    iVal3 += iVal4
                Else
                    iVal2 -= iVal1
                    iVal4 += iVal3
                End If
            Loop
            Dim nLcm = (iVal3 + iVal4) / 2
            Console.WriteLine("The Lcm of the numbers {0} and {1} is {2}", iNum1, iNum2, nLcm)
        Else
            Console.WriteLine("The numbers must not be equal 0")
        End If
        Console.Read()
    End Sub

End Module
