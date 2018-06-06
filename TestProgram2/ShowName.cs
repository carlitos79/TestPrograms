using System;

namespace TestProgram2
{
    public partial class ShowName
    {
        private string name;
        public string GetName()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            return name;
        }
    }
}
