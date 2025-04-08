﻿//  Initialize two numbers
int num1 = 7;
int num2 = 3;

// Make sure the loop runs once
do
{
    // Print the menu
    Console.WriteLine("Please choose an operation to perform:");
    Console.WriteLine("1: Addition");
    Console.WriteLine("2: Subtraction");
    Console.WriteLine("3: Multiplication");
    Console.WriteLine("4: Division");

    // Take user input and execute the requested operation
    int selection = Convert.ToInt32(Console.ReadLine());
    switch (selection)
    {
        case 1:
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case 2:
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        case 3:
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            break;
        case 4:
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}r{num1 % num2}");
            break;
    }
    // Check if the user wants to keep going and exit if not
    Console.WriteLine("Would you like to do another operation? (y/n)");
} while(Console.ReadLine() != "n");
