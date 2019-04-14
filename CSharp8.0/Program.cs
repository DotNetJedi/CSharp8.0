using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp8._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var subscribers = Service.GetSubscribers();
            var names = GetNames(subscribers);

            foreach (var name in names)
            {
                Console.WriteLine($"{name} has subscribed to the service");
            }
        }


        static IEnumerable<string> GetNames(IEnumerable<Person> people)
        {
            foreach (var p in people)
            {
                yield return GetName((p));
            }
        }

        static string GetName(Person p)
        {
            return $"{p.FirstName} {p.MiddleName[0]}. {p.LastName}";
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}
