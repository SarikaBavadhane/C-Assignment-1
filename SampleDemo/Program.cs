using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //You create a code comment by prefixing a line of code with a two forward slashes //.
            //This instructs the compiler to ignore all the instructions on that line.
            //Code comments are helpful when you're not ready to delete the code yet, but you want to ignore it for now. 
            //Console.WriteLine("Welcome To C# Programmming");

            //WriteLine is used to print data along with printing the new line.

            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome To C# Programmming!");

            Console.Write("Congratulations!");
           // Write is used to print data without printing the new line, while Console.
            Console.Write(" ");
            Console.WriteLine(" You wrote your first lines of code!");

            //Challenge 1
            Console.WriteLine("This is the first line.");
            Console.Write("This is ");
            Console.Write("the ");
            Console.Write("Second Line ");

            //**********  Variable Declaration *********
            string fname = "Sarika";
            string lname = "Bavadhane";
            //"+" is used to build string from Variable and constant.
            Console.WriteLine("\nMy Name is :" +fname + " and Lastname is:" +lname);

            //**********String Interpolation*************
            //"$" Symbol indicates that these uses interpolation
            //{ and } character to tell c# to replace that text with the value of variable
            Console.WriteLine($"My First Name is: {fname} and Last Name is: {lname}");


            //without "$" symbol using
            Console.WriteLine("My First Name is: {fname} and Last Name is: {lname}");

            //********* Interpolation of 2 string ************
            string Afriend = "Samarth";
            string Bfriend = "Bob";
            Console.WriteLine($"My friends are {Afriend} and {Bfriend}");

            //********* Length Propety ************
            //Length is the property of string.
            //and it returns the no of character in the string.

            Console.WriteLine($"The Name {Afriend} has {Afriend.Length} Letters.");
            Console.WriteLine($"The Name {Bfriend} has {Bfriend.Length} Letters.");

            //********** Trim Function ************
            //The Trim method and related method TrimStart and TrimEnd.
            //These method Used to remove leading and trailing spaces

            string greeting = "     Hello World!!!      ";
            Console.WriteLine($"***{greeting}***");

            //Remove Starting spaces
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            //Remove ending spaces
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            //Remove starting and ending spaces from string.
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            //*********** Replace Function ********
            //It searches for the substring and replace it with different text.
            //The replace takes 2 parameters.
            //The first string is the text to search for.
            //The second string is the text o replace it with.

            string sayHello = "Hello World!!";
            Console.WriteLine(sayHello);

            sayHello = sayHello.Replace("Hello","Greeting");
            Console.WriteLine(sayHello);

            string Name = "Sunita";
            Console.WriteLine(Name.ToUpper());
            Console.WriteLine(Name.ToLower());
            Console.WriteLine(Name);


            //******************** Contains Function *************************
            //contains methods used for searching
            //It tells you if a string contains a substring inside it.
            //The contains methos returns the Boolean value.
            //It returns true if the searching string is found else return false. 
            
            string songlyrics = "You say Goodbye! I am say Hello";
            Console.WriteLine(songlyrics.Contains("Hello"));
            //Console.WriteLine(songlyrics.Contains("Greeting"));

            //OR
            var  result= songlyrics.Contains("Greeting");
            Console.WriteLine(result);

            
            string Message = "Wash hand Regulary,Waer Mask";
            Console.WriteLine(Message.StartsWith("Wash"));
            Console.WriteLine(Message.EndsWith("Mask"));
           

            Console.Read();

        }
    }
}
