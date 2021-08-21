using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project02
{
    class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }
        public string SpecializationFiels { get; set; }
        public string CellNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        Dicipline dicipline;
        public Student(string name, string regno, double gpa, string field, string cell, string email, string address, string disName)
        {

            this.Name = name;
            this.RegNo = regno;
            this.CGPA = gpa;
            this.SpecializationFiels = field;
            this.CellNo = cell;
            this.Email = email;
            this.Address = address;
            if (disName.Equals("BSCS"))
            {
                dicipline = new ComputerScience();
            }
            else if (disName.Equals("Management"))
            {
                dicipline = new Web();
            }
            else if (disName.Equals("Eng"))
            {
                dicipline = new Engineering();
            }
        }
        public void Display()
        {
            Console.WriteLine("Reg No :\t" + this.RegNo);
            Console.WriteLine("Name :\t\t" + this.Name);
            Console.WriteLine("CGPA :\t\t" + this.CGPA);
            Console.WriteLine("Field:\t\t" + this.SpecializationFiels);
            Console.WriteLine("Cell No:\t" + this.CellNo);
            Console.WriteLine("Email:\t\t" + this.Email);
            Console.WriteLine("Address:\t" + this.Address);
            this.dicipline.dicipline();
        }
        public void ApplyForScholarship()
        {
            Console.WriteLine("Apply for Scholarship");
        }
        public void RegisterCourse()
        {
            Console.WriteLine("Course Registered");
        }
        public void PrintDCM()
        {
            Console.WriteLine("DCM Printed");
        }
    }
}
