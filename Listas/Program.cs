using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = GetPeopleStrings();

            foreach (string person in people)
            {
                Console.WriteLine(person);    
            }

            Console.ReadLine();

            List<PersonModel> peopleModels = GetPeopleModels();

            foreach (PersonModel person in peopleModels)
            {
                Console.WriteLine($"Hello { person.FirstName} { person.LastName }");
            }

            Console.ReadLine();
        }

        private static List<PersonModel> GetPeopleModels()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Tim", LastName = "Co" });
            output.Add(new PersonModel { FirstName = "Dani", LastName = "AA" });

            return output;
        }

        private static List<string> GetPeopleStrings()
        {
            List<string> output = new List<string>();

            output.Add("Dani");
            output.Add("Adri");
            output.Add("222");

            return output;

        }
    }
}
