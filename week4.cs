/*using System;
using System.Collections;

namespace week4
{
    public class course
    {
        private string Cname,CID;
        private int Credit;
        public string CourseName
        {
           get{return Cname;}
           set{Cname=value;}
        }
        public string CourseID
        {
            get{return CID;}
            set{CID= value;}
        }
        public int CreditNumber
        {
            get{return Credit;}
            set{Credit=value;}
        }
        public course(string CourseName, string CourseID, int CreditNumber)
        {
            this.CourseName=CourseName;
            this.CourseID = CourseID;
            this.CreditNumber = CreditNumber;
        }
        public string print()
        {
             return "Course Name:" + CourseName + "\nCourse ID: " + CourseID + "\nCredit Number: " + CreditNumber;
        }
    }
    public class program
    {
        private int num;
        private ArrayList Info = new ArrayList();
        public void InputNunberOfCourse()
        {
            Console.WriteLine("input number of course");
            num=Convert.ToInt32(Console.ReadLine());
        }
        public void AddCourse()
        {
            String name, ID;
            int cre;
            {
                for (int i=0;i<num;i++)
                {
                    Console.WriteLine("course "+i+1);
                    Console.Write("Course Name: ");
                    name = Console.ReadLine();

                    Console.Write("Course ID: ");
                    ID = Console.ReadLine();

                    Console.Write("Credit Number: ");
                    cre = Convert.ToInt32(Console.ReadLine());
                

                    Info.Add(new course(name, ID, cre));
                }
                Console.WriteLine("\nCOURSE LIST\n");
                foreach(course item in Info)
            {
                Console.WriteLine(item.print() + "\n");
            }
            
            }

        }

        static void Main(string[] agrs)
        {
            program xl=new program();
            xl.InputNunberOfCourse();
            xl.AddCourse();
        }

    }
}

*/ 