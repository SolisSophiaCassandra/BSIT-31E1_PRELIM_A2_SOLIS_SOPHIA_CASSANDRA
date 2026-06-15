while (true)
{
    Console.Write("Enter first number (or 'exit' to quit): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        break;
    }

    double num1 = Convert.ToDouble(input);

    Console.Write("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter operation (+, -, *, /): ");
    string op = Console.ReadLine();

    if (op == "+")
    {
        Console.WriteLine("Result: " + (num1 + num2));
    }
    else if (op == "-")
    {
        Console.WriteLine("Result: " + (num1 - num2));
    }
    else if (op == "*")
    {
        Console.WriteLine("Result: " + (num1 * num2));
    }
    else if (op == "/")
    {
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine("Result: " + (num1 / num2));
        }
    }
    else
    {
        Console.WriteLine("Invalid operation.");
    }

    Console.WriteLine();
}