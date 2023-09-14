using PersonLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Person objects
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);

            string ginasInfo = person2.DisplayGina();
            Console.WriteLine(ginasInfo);

            // Display Mike's information
            string mikesInfo = person3.ToString();
            Console.WriteLine(mikesInfo);

            // Change Ian's favorite color to white
            person1.ChangeFavoriteColor();

            string ianInfo = person1.DisplayGina();
            Console.WriteLine(ianInfo);

            // Display Mary's age in 10 years
            int marysAgeTenYears = person4.GetAgeInTenYears();
            Console.WriteLine("Mary Beals’s Age in 10 years is: " + marysAgeTenYears);

            // Create Relation instances (linking Person instances together)
            Relation relation1 = new Relation("Sisterhood", person2, "Sisterhood", person4);
            Relation relation2 = new Relation("Brotherhood", person1, "Brotherhood", person3);

            // Display first relation
            Console.WriteLine(relation1.ToString());
            Console.WriteLine(relation2.ToString());

            // Create and populate list of people
            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            // Determine average age
            int sum = 0;

            // Get sum of everyone's age
            foreach (Person person in people)
            {
                sum += person.Age;
            }

            double average = sum / (double)people.Count;


            Console.WriteLine("Average age: " + average);

            // display youngest person
            int minAge = int.MaxValue;
            Person youngest = null;
            foreach (Person person in people)
            {
                if (person.Age < minAge)
                {
                    minAge = person.Age;
                    youngest = person;
                }   
            }
            Console.WriteLine("The youngest person is: " + youngest.FirstName);

            // display oldest person
            int maxAge = 0;
            Person oldest = null;
            foreach (Person person in people)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    oldest = person;
                }
            }
            Console.WriteLine("The oldest person is: " + oldest.FirstName);

            // display person whose first name starts with an M
            foreach (Person person in people)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    Console.WriteLine("Person with firstname start with an M");
                    Console.WriteLine(person.ToString());
                }
            }
            // display person who likes blue
            foreach (Person person in people)
            {
                if (person.FavoriteColor == "Blue")
                {
                    Console.WriteLine("Person who likes blue");
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}