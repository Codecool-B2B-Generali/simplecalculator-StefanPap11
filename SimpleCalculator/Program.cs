using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading.Tasks;namespace SimpleCalculator

class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        string operand;
        // ConsoleKeyInfo status;
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
                answer = a / b;
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




