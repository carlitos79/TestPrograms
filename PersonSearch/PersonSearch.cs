using System;
using System.Collections.Generic;
using System.Text;

namespace PersonSearch
{
    class PersonSearch
    {
        string personToSearch;

        public PersonSearch(string personToSearch)
        {
            this.personToSearch = personToSearch;
        }
        public bool NameToSearchFor(Person person)
        {
            return person.firstName.StartsWith(personToSearch, StringComparison.CurrentCultureIgnoreCase);
        }

        public int FindIndex(List<Person> listToSearchThrough)
        {
            var index = listToSearchThrough.FindIndex(new PersonSearch(personToSearch).NameToSearchFor);

            return index;
        }

        public void ShowResult(List<Person> listToSearchThrough)
        {
            int index = FindIndex(listToSearchThrough);

            Console.WriteLine("Match at index: " + index);
            Console.WriteLine("Full Name: " + listToSearchThrough[index].firstName + " " + listToSearchThrough[index].lastName);
        }
    }
}
