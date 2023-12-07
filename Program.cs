// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!")
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows for the pyramid");
        int numrows=int.Parse(Console.ReadLine());
        for(int i=1; i<=numrows;i++)
        {
            for (int j = 1; j <= numrows - i; j++)
            {
                Console.Write( "");
            }
            for (int k=1;k<=i;k++)
            {
                Console.Write(  "*");
            }
            Console.WriteLine();
        }
    }
}









