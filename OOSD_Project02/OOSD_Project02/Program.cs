using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We used OpenClosedPrinciple in it\n");
            Student Abubakar = new Student("AbubakarShf", "18-NTU-1050", 3.00, "OOSD", "03216022930", "AbubakarShf@gmail.com", "Faisalabad", "BSCS");
            Abubakar.Display();
            Abubakar.ApplyForScholarship();
            Abubakar.PrintDCM();
            Abubakar.RegisterCourse();
            Console.ReadKey();
        }
    }
}
