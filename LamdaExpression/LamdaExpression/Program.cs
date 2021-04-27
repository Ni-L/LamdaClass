using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{/// <summary>
/// MAin Method for Declaring Lambda Functions
/// </summary>
    class Program
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("*******Welcome to Lambda Expressions*********");
            List<PersonClass> list = new List<PersonClass>();
            IterateOverLoop(list);
            AddingPerson(list);
        }
        //UC1 Adding Details
        public static void AddingPerson(List<PersonClass> personList)
        {
            personList.Add(new PersonClass() { SSN = 1, Age = 16, Name = "Shalu", Address = "Chennai" });
            personList.Add(new PersonClass() { SSN = 5, Age = 18, Name = "Shivam", Address = "Chennai" });
            personList.Add(new PersonClass() { SSN = 7, Age = 25, Name = "Shiva", Address = "Chennai" });
            personList.Add(new PersonClass() { SSN = 2, Age = 85, Name = "Ranu", Address = "Chennai" });
            personList.Add(new PersonClass() { SSN = 6, Age = 15, Name = "Ajay", Address = "Chennai" });
            personList.Add(new PersonClass() { SSN = 8, Age = 75, Name = "Nithya", Address = "Chennai" });
            IterateOverLoop(personList);
        }

        public static void IterateOverLoop(List<PersonClass> personList)
        {
            foreach (PersonClass person in personList)
            {
                Console.WriteLine("Name\t" + person.Name + "Age\t" + person.Age + "\t" + "Address\t" + person.Address);

            }
            Console.ReadKey();
        }
    }
}
