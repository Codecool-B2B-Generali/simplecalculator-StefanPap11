using System;
namespace SimpleCalculator
{ 
   class Program
   {
    static void Main(string[] args)
    {
        int a;
        int b;
        string operand;
        float answer;
        

        Console.Write("Kérem az első számot: ");

            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input. Please provide a number!");
            }
         
       Console.Write("Kérem a második számot: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Please provide a number!");
            }
           


        Console.Write("kérem az operátort (+, -, /, *): ");
        operand = Console.ReadLine();

      

            switch (operand)
        {
            case "-":
                answer = a - b;
                break;
            case "+":
                answer = a + b;
                break;
            case "/":
                    if (b == 0)
                    {
                        throw new NotImplementedException3("A b értéke nem lehet nulla.");
                    }
                    else
                    { answer = a / b; 
                    }
                        
                break;
            case "*":
                answer = a * b;
                break;
            default:
                answer = 0;
                break;

        }
        Console.Write("Eredmény: ");



        Console.WriteLine(a.ToString() + " " + operand + " " + b.ToString() + " = " + answer.ToString());



    }
   }

}


