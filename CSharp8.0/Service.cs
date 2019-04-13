using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp8._0
{
    class Service
    {
        public static IEnumerable<Person> GetSubscribers()
        {
            yield return new Person("Tracey", "Jaron", "Downer");
            Thread.Sleep(1000);
            yield return new Person("Thorburn", "Wat", "Tuft");
            Thread.Sleep(1000);
            yield return new Person("Marisa", "Waters");
            Thread.Sleep(1000);
            yield return new Person("Rosy", "Christy", "Bannister");
            Thread.Sleep(1000);
            yield return new Person("Dominick", "Maximillian", "Ayers");
        }

        async public static IAsyncEnumerable<Person> GetSubscribersAsync()
        {
            yield return await Task.Factory.StartNew(() => new Person("Tracey", "Jaron", "Downer"));
            Thread.Sleep(1000);
            yield return await Task.Factory.StartNew(() => new Person("Thorburn", "Wat", "Tuft"));
            Thread.Sleep(1000);
            yield return await Task.Factory.StartNew(() => new Person("Marisa", "Waters"));
            Thread.Sleep(1000);
            yield return await Task.Factory.StartNew(() => new Person("Rosy", "Christy", "Bannister"));
            Thread.Sleep(1000);
            yield return await Task.Factory.StartNew(() => new Person("Dominick", "Maximillian", "Ayers"));
        }
    }
}
