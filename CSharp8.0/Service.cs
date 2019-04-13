using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8._0
{
    class Service
    {
        public static IEnumerable<Person> GetSubscribers()
        {
            yield return new Person("Tracey", "Jaron", "Downer");
            yield return new Person("Thorburn", "Wat", "Tuft");
            yield return new Person("Marisa", "Sukie", "Waters");
            yield return new Person("Rosy", "Christy", "Bannister");
            yield return new Person("Dominick", "Maximillian", "Ayers");
        }
    }
}
