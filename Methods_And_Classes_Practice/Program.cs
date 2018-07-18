using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Classes_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of type string
            List<String> person = new List<String>();


            // create an instance of the Person class called 'names'
            Person names = new Person();


            //prompt the user for values, initialize and assign said values
            Console.WriteLine("please enter a firstname");

            string firstName = Console.ReadLine();

            Console.WriteLine("please enter a surname");

            string surname = Console.ReadLine();

            Console.WriteLine("Please enter the persons age");

            //initialize the int variable: 'age', call the 'GetPersonAge' method and pass the user input as an argument and assign the returned value to 'age' (10 years older)  
            int age = names.GetPersonAge(Convert.ToInt32(Console.ReadLine()));

            // call the 'GetPerson' method passing the user input as arguments and assigning the returned values to the person list
            person = names.GetPerson(firstName, surname);

            //output the result
            Console.Write(person[0] + person[1] + " and the ajusted age is " + age);
            


            //stop the cmd from closing!
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("end of program");
            Console.ReadLine();










        }
    }
}
