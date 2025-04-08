//  Initialize two numbers
double num1;
double num2;
Console.Write("Please enter a first number: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter a second number: ");
num2 = Convert.ToDouble(Console.ReadLine());

// Make sure the loop runs once
do
{
    // Print the menu
    Console.WriteLine("Please choose an operation to perform:");
    Console.WriteLine("+: Addition");
    Console.WriteLine("-: Subtraction");
    Console.WriteLine("*: Multiplication");
    Console.WriteLine("/: Division");

    // Take user input and execute the requested operation
    switch (Console.ReadLine())
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            break;
        case "/":
            Console.WriteLine($"{num1} / {num2} = {num1/num2}");
            break;
        default:
            Console.WriteLine("That is not a valid input!");
            break;
    }
    // Check if the user wants to keep going and exit if not
    Console.WriteLine("Would you like to do another operation? (y/n)");
} while(Console.ReadLine().ToLower() != "n");
