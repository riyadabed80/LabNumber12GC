using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12GC
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Riyad = new Person("Riyad", "1234 Elm St");
            Student Dennis = new Student("Dennis","123 Main","Computer Science",2018,2500);
            Staff Kamel = new Staff("Kamel","1570 Woodward Ave","Grand Circus",1000000);

            List<Person> Everyone = new List<Person> { Riyad, Dennis, Kamel };
            foreach (Person c in Everyone)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
