﻿// See https://aka.ms/new-console-template for more information
using System;
namespace Calculator
{
    class Program
    {
        static void Main()
        {            
            Console.WriteLine("Enter values:");
            Console.Write("First number: ");
            string firstUserValue = Console.ReadLine();
            Console.Write("Second number: ");
            string secondUserValue = Console.ReadLine();

            decimal firstNumber=Convert.ToDecimal(firstUserValue);
            decimal secondNumber=Convert.ToDecimal(secondUserValue);
            Console.WriteLine("Here are your results: ");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
            Console.WriteLine($"{firstNumber} : {secondNumber} = {firstNumber/secondNumber}");
            Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber*secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber%secondNumber}");
        }
    }
}
