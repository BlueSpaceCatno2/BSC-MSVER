int sum = 0;
int count = 0;
string input;
string CMD = null;
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("You have acquired a coppy of ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("BSC");
Console.ForegroundColor= ConsoleColor.Green;
Console.Write("-MSVER");
Console.WriteLine();
Console.WriteLine("Please choose one of the following commands:");
Console.WriteLine("Add");
Console.WriteLine("Subtract");
Console.WriteLine("Multiply");
Console.WriteLine("Divide");
Console.WriteLine("Average");
while (true)
{
    input = Console.ReadLine();
    if (input.ToUpper() == null || input.ToUpper() == "")
    {
        Console.WriteLine("No text detected");
    }
    else
    {
        if (input.ToUpper() == "ADD" || input.ToUpper() == "SUBTRACT" || input.ToUpper() == "AVERAGE" || input.ToUpper() == "MULTIPLY" || input.ToUpper() == "DIVIDE")
        {
            if (input.ToUpper() == "ADD")
            {
                ADD();
            }
            else
            {
                if (input.ToUpper() == "SUBTRACT")
                {
                    SUBTRACT();
                }
                else
                {
                    if (input.ToUpper() == "AVERAGE")
                    {
                        AVERAGE();
                    }
                    else
                    {
                        if (input.ToUpper() == "MULTIPLY")
                        {
                            MULTIPLY();
                        }
                        else
                        {
                            if (input.ToUpper() == "DIVIDE")
                            {
                                DIVIDE();
                            }
                            else
                            {
                                Console.WriteLine("You souldnt see this message. Please try again");
                            }
                        }
                    }
                }
            }
        }
        else
        {
            if (input.ToUpper() ==  "HELP" || input.ToUpper() == "-HELP")
            {
                Console.WriteLine("Mathsolver help:");
                Console.WriteLine("Showing mathematical commands list:");

                Console.Beep();

                Console.WriteLine("Add");

                Console.Beep();

                Console.WriteLine("Subtract");

                Console.Beep();

                Console.WriteLine("Multiply");

                Console.Beep();

                Console.WriteLine("Divide");

                Console.Beep();

                Console.WriteLine("Average");

            }
            else
            {
                Console.WriteLine("Invalid method revoking key");
            }
        }
    }
}
void DIVIDE()
{
    Console.Beep();
    Console.WriteLine("Enter numbers to divide, or \"end\" to stop:");
    input = Console.ReadLine();
    Console.Beep();
    int sum;
    if (int.TryParse(input, out sum))
    {
        count++;
    }
    else
    {
        Console.Beep();
        Console.WriteLine("Invalid input, please enter a number or \"end\".");
    }
    do
    {
        input = Console.ReadLine();
        Console.Beep();
        int number;
        if (int.TryParse(input, out number))
        {
            sum /= number;
            count++;
        }
        else if (input != "end")
        {
            Console.Beep();
            Console.WriteLine("Invalid input, please enter a number or \"end\".");
        }
    } while (input != "end");

    if (count > 0)
    {
        int total = sum;
        Console.Beep();
        Console.WriteLine("Total of {0} numbers after division is {1}", count, total);
    }
    else
    {
        Console.Beep();
        Console.WriteLine("No numbers were entered.");
    }

    Console.ReadKey();

}
void MULTIPLY()
{
    Console.Beep();
    Console.WriteLine("Enter numbers to multiply, or \"end\" to stop:");
    input = Console.ReadLine();
    Console.Beep();
    int sum;
    if (int.TryParse(input, out sum))
    {
        count++;
    }
    else
    {
        Console.Beep();
        Console.WriteLine("Invalid input, please enter a number or \"end\".");
    }
    do
    {
        input = Console.ReadLine();
        Console.Beep();
        int number;
        if (int.TryParse(input, out number))
        {
            sum *= number;
            count++;
        }
        else if (input != "end")
        {
            Console.Beep();
            Console.WriteLine("Invalid input, please enter a number or \"end\".");
        }
    } while (input != "end");

    if (count > 0)
    {
        int total = sum;
        Console.Beep();
        Console.WriteLine("Total of {0} numbers after multiplication is {1}", count, total);
    }
    else
    {
        Console.Beep();
        Console.WriteLine("No numbers were entered.");
    }

    Console.ReadKey();

}
void SUBTRACT()
{
    Console.Beep();
    Console.WriteLine("Enter numbers to subtract, or \"end\" to stop:");
    input = Console.ReadLine();
    Console.Beep();
    int sum;
    if (int.TryParse(input, out sum))
    {
        count++;
    }
    else
    {
        Console.Beep();
        Console.WriteLine("Invalid input, please enter a number or \"end\".");
    }
    do
    {
        input = Console.ReadLine();
        Console.Beep();
        int number;
        if (int.TryParse(input, out number))
        {
            sum -= number;
            count++;
        }
        else if (input != "end")
        {
            Console.Beep();
            Console.WriteLine("Invalid input, please enter a number or \"end\".");
        }
    } while (input != "end");

    if (count > 0)
    {
        int total = sum;
        Console.Beep();
        Console.WriteLine("Total of {0} numbers after subtraction is {1}", count, total);
    }
    else
    {
        Console.Beep();
        Console.WriteLine("No numbers were entered.");
    }

    Console.ReadKey();

}
void ADD()
{
    Console.Beep();
    Console.WriteLine("Enter numbers to add, or \"end\" to stop:");
    do
    {
        input = Console.ReadLine();
        Console.Beep();
        int number;
        if (int.TryParse(input, out number))
        {
            sum += number;
            count++;
        }
        else if (input != "end")
        {
            Console.Beep();
            Console.WriteLine("Invalid input, please enter a number or \"end\".");
        }
    } while (input != "end");

    if (count > 0)
    {
        int total = sum;
        Console.Beep();
        Console.WriteLine("Total of {0} numbers is {1}", count, total);
    }
    else
    {
        Console.Beep();
        Console.WriteLine("No numbers were entered.");
    }

    Console.ReadKey();

}

void AVERAGE()
{
    Console.Beep();
    Console.WriteLine("Enter numbers to average, or \"end\" to stop:");
    do
    {
        input = Console.ReadLine();
        Console.Beep();
        int number;
        if (int.TryParse(input, out number))
        {
            sum += number;
            count++;
        }
        else if (input != "end")
        {
            Console.Beep();
            Console.WriteLine("Invalid input, please enter a number or \"end\".");
        }
    } while (input != "end");

    if (count > 0)
    {
        double average = (double)sum / count;
        Console.Beep();
        Console.WriteLine("Average of {0} numbers is {1}", count, average);
    }
    else
    {
        Console.Beep();
        Console.WriteLine("No numbers were entered.");
    }

    Console.ReadKey();
}