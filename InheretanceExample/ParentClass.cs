using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceExample
{
    class ParentClass
    {
        public int num = 10;

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class ChildClass : ParentClass
    {
        public int GetNumFromParent()
        {
            return this.num;
        }
    }

    public class Person : IEquatable<Person>
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public bool Equals(Person person)
        {
            if (this.Name == person.Name)
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
