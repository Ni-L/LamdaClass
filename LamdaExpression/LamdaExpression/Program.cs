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
     /// Retrieve teenage
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("*******Welcome to Lambda Expressions*********");
            //Creating Listof PersonClass
            List<PersonClass> list = new List<PersonClass>();
            IterateOverLoop(list);//Calling IterateOverLoop
            AddingPerson(list);//CAlling AddingPerson
            RetrieveTop2(list);//Calling RetrieveTop2
            RetrieveTeenageRecords(list);//Calling RetrieveTeenageRecords
            FindAvgAgeForAll(list);//Calling FindAvgAgeForAll
        }
        //UC1 Adding Details
        public static void AddingPerson(List<PersonClass> personList)//Adding Method to Add Person Details
        {
            personList.Add(new PersonClass() { SSN = 1, Age = 16, Name = "Naina", Address = "Pune" });
            personList.Add(new PersonClass() { SSN = 5, Age = 18, Name = "Nilima", Address = "Pune" });
            personList.Add(new PersonClass() { SSN = 7, Age = 25, Name = "Ashu", Address = "Pune" });
            personList.Add(new PersonClass() { SSN = 2, Age = 77, Name = "Snehal", Address = "Pune" });
            personList.Add(new PersonClass() { SSN = 6, Age = 15, Name = "Anku", Address = "Pune" });
            personList.Add(new PersonClass() { SSN = 8, Age = 75, Name = "Sneha", Address = "Pune" });
        }

        public static void IterateOverLoop(List<PersonClass> personList)//Adding Method to Iterate Person
        {
            //Create Foreach for PersonClass
            foreach (PersonClass person in personList)
            {
                Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                Console.ReadLine();
            }
        }

        //UC2 Retrieve top two age less than 60
        public static void RetrieveTop2(List<PersonClass> list)//Adding Method to Iterate Person
        {
            var result = list.FindAll(x => x.Age < 60).OrderBy(x => x.Age).Take(2);//Creating Lamda Function x
            //Creating Foreach loop
            foreach (PersonClass person in result)
            {
                Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                Console.ReadLine();
            }
        }

        //UC3 Retrieve age between 13 to 18 or less 
        public static void RetrieveTeenageRecords(List<PersonClass> list)
        {
            try
            {
                var result = list.FindAll(x => x.Age < 13 && x.Age > 18);//Teenage Record
                foreach (PersonClass person in result)
                {
                    Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void FindAvgAgeForAll(List<PersonClass> list)//Adding Method to find Average of All
        {
            try
            {
                var result = list.Average(x => x.Age);//Finding Average

                Console.WriteLine("Average age among all persons\t" + result);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
