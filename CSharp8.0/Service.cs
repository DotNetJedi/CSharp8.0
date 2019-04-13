using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp8._0
{
    class Service
    {
        private static IEnumerable<Person> _people = new List<Person>()
        {
            new Person("Tracey", "Jaron", "Downer"),
            new Person("Thorburn", "Wat", "Tuft"),
            new Person("Marisa", "Waters"),
            new Person("Rosy", "Christy", "Bannister"),
            new Person("Dominick", "Maximillian", "Ayers"),
            //new Person (null, "Monique", "Smalls"),
            //new Person ("Corrina", null, null),
            //new Person ("America", "Randy", null),
            //new Person (null, null, "Dwerryhouse"),
            //new Person (null, "Kaleigh", null),
            //new Person (null, null, null)
        };

        public static IEnumerable<Person> GetSubscribers()
        {
            foreach (var p in _people)
            {
                Thread.Sleep(500);
                yield return p;
            }
        }

        async public static IAsyncEnumerable<Person> GetSubscribersAsync()
        {
            foreach (var p in GetSubscribers())
            {
                await Task.Delay(500);
                yield return p;
            }
        }
    }
}
