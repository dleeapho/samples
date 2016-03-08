using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Personal;

namespace PersonByAge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("John", 21),
                new Person("Joe", 35),
                new Person("Jane", 30)
                
            };

            var sortedByAge = people.OrderByDescending(x => x.Age);
            foreach (var item in sortedByAge)
            {
                Console.WriteLine("{0} is {1} years old", item.Name, item.Age);
            }


        }
    }
}
