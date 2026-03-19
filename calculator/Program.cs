namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HistoryItem> history = new List<HistoryItem>();
            char operation;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("----- Calculator -----");
                Console.WriteLine("1 - Addition\r\n2 - Subtraction\r\n3 - Multiplication\r\n4 - Division\r\n5 - Exponentiation\r\n6 - Square Root\r\n7 - Operation History\r\n8 - Clear History\r\n0 - Exit");
                Console.WriteLine("--------------------------------");

                Console.Write("Select an operation: ");
                operation = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("--------------------------------");


                if (operation == '0')
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                double firstNumber = 0;
                double secondNumber = 0;

                if (operation == '1' || operation == '2' || operation == '3' || operation == '4' || operation == '5')
                {
                    Console.Write("Enter first number: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                }
                else if (operation == '6')
                {
                    Console.Write("Enter number: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                }

                double result = 0;

                switch (operation)
                {
                    case '1':
                        result = firstNumber + secondNumber;
                        history.Add(new HistoryItem
                        {
                            Operation = "+",
                            FirstNumber = firstNumber,
                            SecondNumber = secondNumber,
                            Result = result
                        });

                        break;

                    case '2':
                        result = firstNumber - secondNumber;
                        history.Add(new HistoryItem
                        {
                            Operation = "-",
                            FirstNumber = firstNumber,
                            SecondNumber = secondNumber,
                            Result = result
                        });
                        break;

                    case '3':
                        result = firstNumber * secondNumber;
                        history.Add(new HistoryItem
                        {
                            Operation = "*",
                            FirstNumber = firstNumber,
                            SecondNumber = secondNumber,
                            Result = result
                        });
                        break;

                    case '4':
                        if (secondNumber != 0) { 
                            result = firstNumber / secondNumber;
                            history.Add(new HistoryItem
                            {
                            Operation = "/",
                            FirstNumber = firstNumber,
                            SecondNumber = secondNumber,
                            Result = result
                            }); 
                        }
                        else
                        {
                            Console.WriteLine("Division by zero error!");
                            continue;
                        }
                        break;

                    case '5':
                        result = Math.Pow(firstNumber, secondNumber);
                        history.Add(new HistoryItem
                        {
                            Operation = "^",
                            FirstNumber = firstNumber,
                            SecondNumber = secondNumber,
                            Result = result
                        });
                        break;

                    case '6':
                        result = Math.Sqrt(firstNumber);
                        history.Add(new HistoryItem
                        {
                            Operation = "√",
                            FirstNumber = firstNumber,
                            SecondNumber = secondNumber,
                            Result = result
                        });
                        break;

                    case '7':
                        Console.WriteLine("History");
                        foreach (var item in history)
                        {
                            Console.WriteLine(item);
                        }
                        continue;

                    case '8':
                        history.Clear();
                        Console.WriteLine("History cleared.");
                        continue;

                    default:
                        Console.WriteLine("Invalid operation!");
                        continue;
                }

                Console.WriteLine("Result: " + result);
            }
        }
    }
}