using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableImplementation
{
    class Person : IEquatable<Person>
    {
        public string FirstName { get; set; }

        public Person(string name)
        {
            this.FirstName = name;
        }
        public bool Equals(Person person)
        {
            if (this.FirstName == person.FirstName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
