using System;

namespace OOPConsoleStudent
{
    abstract class StudentInformation
    {
        protected string studentName;
        protected int studentGrade;
        
        public void SetData(string studentName, int studentGrade)
        {
            this.studentName = studentName;
            this.studentGrade = studentGrade;
        }

        public abstract void DisplayInfo();
        public abstract void CheckStatus();
    }

    class CollegeStudent : StudentInformation
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("College Student:");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Student Grade: {studentGrade}");
        }

        public override void CheckStatus()
        {
            if (studentGrade > 3)
            {
                Console.WriteLine("Status: FAILED");
            }
            else
            {
                Console.WriteLine("Status: PASSED");
            }
        }
    }

    class SeniorStudent : StudentInformation
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Senior Student:");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Student Grade: {studentGrade}");
        }

        public override void CheckStatus()
        {
            if (studentGrade < 75)
            {
                Console.WriteLine("Status: FAILED");
            }
            else
            {
                Console.WriteLine("Status: PASSED");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation student1 = new CollegeStudent();
            student1.SetData("EDDIE", 1);
            student1.DisplayInfo();
            student1.CheckStatus();

            Console.WriteLine(" "); 

            StudentInformation student2 = new CollegeStudent();
            student2.SetData("GARCIA", 4);
            student2.DisplayInfo();
            student2.CheckStatus();

            Console.WriteLine("   "); 

            StudentInformation student3 = new SeniorStudent();
            student3.SetData("EDDIESON", 95);
            student3.DisplayInfo();
            student3.CheckStatus();

            Console.WriteLine(" "); 

            StudentInformation student4 = new SeniorStudent();
            student4.SetData("GARGARITANO", 74);
            student4.DisplayInfo();
            student4.CheckStatus();
        }
    }
}
