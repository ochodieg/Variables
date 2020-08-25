Option Strict On
'highight command and hit f1 to search online
Option Explicit On

Module Module1

    Sub Main()
        'variable. "myFirstNumber" is a variable
        Dim myFirstNumber As Int32
        Dim mysecondNumber As Integer
        Dim aLittleString As String
        Dim someSortOFTest As Boolean
        Dim result As Integer


        myFirstNumber = 42
        mysecondNumber = 8

        Console.WriteLine(myFirstNumber)

        aLittleString = "some text"

        Console.WriteLine(aLittleString)
        Console.ReadLine()
        Console.WriteLine(someSortOFTest)
        Console.ReadLine()
        'camelcase ^
        'regular grammar case is know as pascalcase. we will use camelcase conventio 
        'used for user or client interpretation
        'can also be spelled out as "integer"
        'reserved a memory as a number 
        'used as a replacement for binary or hex address
        'for example, you use website address instead of ip in 
        'search bar. This makes it easier for the user.

        'break it eith the wrong data type
        'mysecondNumber = "5"

        'x = 7
        'Console.WriteLine(x)
        'Console.ReadLine()


        'do math


        Console.WriteLine(myFirstNumber + mysecondNumber
                          )
        Console.ReadLine()

        result = myFirstNumber + mysecondNumber
        Console.WriteLine(result)
        Console.ReadLine()
        'red highlight stops ccode when play button is pressed
        'this will payuse program at this line when running code
        'hitting f11 will allow program to run for a single step




    End Sub

End Module
