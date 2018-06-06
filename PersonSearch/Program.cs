using System;
using System.Collections.Generic;

namespace PersonSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPeople = new List<Person>()
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
                new Person("Juan", "Perez"),
                new Person("Pedro", "Arroyo"),
                new Person("Maria", "Gonzalez")
            };

            var wanted = new PersonSearch("Gonzalez");
            wanted.ShowResult(listOfPeople);

            Console.WriteLine('\n' + "Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
