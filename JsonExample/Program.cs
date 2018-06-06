using System;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Lad
            {
                firstName = "Markoff",
                lastName = "Chaney",
                dateOfBirth = new MyDate
                {
                    year = 1901,
                    month = 4,
                    day = 30
                }
            };
            //var json = new JavaScriptSerializer().Serialize(obj);
            //Console.WriteLine(json);
        }
    }
}
