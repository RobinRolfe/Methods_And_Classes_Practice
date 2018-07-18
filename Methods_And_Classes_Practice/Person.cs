using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Classes_Practice
{
    class Person
    {
        //method the accepts 2 string parameters and appends some text in between first name and surname and returns the result as a list
        public List<String> GetPerson(string firstName, string surname)
        {
            List<String> person = new List<String>();

            person.Add(firstName + " 'the rock' ");
            person.Add(surname);

            return person;
        }

        //method that adds 10 years onto the parameter and returns the result
        public int GetPersonAge(int age)
        {

            int ammendedAge = age + 10;

            return ammendedAge;

        }


    }
}
