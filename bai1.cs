
using System;
namespace bai1
{
    class program
    {
        int[] a= new int[100];
        int s;
        void inputarray()
        {
            try
            {
                Console.WriteLine("input arraysize");
                s=Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<s;i++)
                a[i]=Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                inputarray();
            }

        }
    
        void excute()
        { int tmp;
            for (int i=0;i<s-1;i++)
            for (int j=i+1;j<s;j++)
                if(a[i]<a[j])
            {
                tmp=a[i];
                a[i]=a[j];
                a[j]=tmp;
            }
            Console.WriteLine("The biggest number is " + a[0]);
            Console.WriteLine("The smallest number is " + a[s-1]);
        }
    static void Main(string[] args)
        {
            program v1= new program();
            v1.inputarray();
            v1.excute();

    
        }
    }
}

//-----------------------------------------------------------------------------
/*
using System;
using System.Collections;

namespace course_Management
{
    public class course
    {
        private string cName, cID;
        private int creNum;
        public string courseName
        {
            get { return cName; }
            set { cName = value; }
        }

        public string courseID
        {
            get { return cID; }
            set { cID = value; }
        }

        public int creditNumber
        {
            get { return creNum; }
            set { creNum = value; }
        }

        public course(String courseName, String courseID, int creditNumber)
        {
            this.courseName = courseName;
            this.courseID = courseID;
            this.creditNumber = creditNumber;
        }

        public string print()
        {
            return "Course Name:" + courseName + "\nCourse ID: " + courseID + "\nCredit Number: " + creditNumber;
        }
    }

    

    public class runMain
    {
        private int num;
        private ArrayList cInfo = new ArrayList();

        public void inputNumberOfStudents()
        {
            Console.Write("\nCourse's amount: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public void addStudents()
        {
            String name, ID;
            int cre;
            try
            {
                for(int i = 0; i < num; i++)
                {
                    Console.WriteLine("#"+(i+1));
                    Console.Write("Course Name: ");
                    name = Console.ReadLine();

                    Console.Write("Course ID: ");
                    ID = Console.ReadLine();

                    Console.Write("Credit Number: ");
                    cre = Convert.ToInt32(Console.ReadLine());

                    cInfo.Add(new course(name, ID, cre));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please input again !!");
                addStudents();
            }
            

            Console.WriteLine("\nCOURSE LIST\n");
            foreach(course item in cInfo)
            {
                Console.WriteLine(item.print() + "\n");
            }
        }

        static void Main(string[] args)
        {
            runMain run = new runMain();
            run.inputNumberOfStudents();
            run.addStudents();
        }
    }
}
*/