using System;

namespace Csharpexample2
{
    class Program
    {
        static void Main(string[] args)


        
        {
            //methods
            string input= GetInput();
            input =AddSmileyToEnd(input);
            input = AddsmileyToBeginning(input);
            WriteName(input);
       
        


            //print your name
            Console.WriteLine("Hello World!");
            Console.WriteLine ("Please enter your name");
            string username = Console.ReadLine();
            Console.WriteLine(":)"  + username + ":)");
        }

        static string GetInput()
        {
            Console.WriteLine("please input some text");
            return Console.ReadLine();

        }
        static string AddSmileyToEnd(string input)
        {
            input=input+":)";
            return input;
        
        }

        static string AddsmileyToBeginning(string input)
        {
            input=input+":(";
            return input;
        }

        static void WriteName(string input)
        {
            Console.WriteLine(input);
        }




        
    
    }
    

}
