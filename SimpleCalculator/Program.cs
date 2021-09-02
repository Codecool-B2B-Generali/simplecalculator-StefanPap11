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
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Kérem a második számot: ");
        b = Convert.ToInt32(Console.ReadLine());
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


