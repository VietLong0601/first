/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace week_8_1
{
    public class Employee
    {
        private string name, id;
        private double Birth, basicsalary, sal;
        public string Name
        {
            get {return name; }
            set {name = value; }
        }
        public string ID
        {
            get {return id; }
            set {id = value; }
        }
        public double BirthYear
        {
            get {return Birth; }
            set {Birth = value; }
        }
        public double BasicSalary
        {
            get {return basicsalary; }
            set {basicsalary = value; }
        }
        public double Salary
        {
            get {return sal; }
            set {sal = value; }
        }

        public Employee()
        {
            this.Name = Name;
            this.ID = ID;
            this.BirthYear = BirthYear;
            this.BasicSalary = BasicSalary;
            this.Salary = Salary;
        }
        public virtual void Input()
        {
            Console.Write("\nName: ");
            this.name = Console.ReadLine();
            Console.Write("ID: ");
            this.id = Console.ReadLine();
            Console.Write("Birth Year: ");
            this.Birth = int.Parse(Console.ReadLine());
            Console.Write("Basic Salary: ");
            this.basicsalary = int.Parse(Console.ReadLine());
        }
        public void fixSalary(double salary)
        {
            this.Salary = salary;
        }
        public virtual void caculateSalary()
        {
            this.sal = this.basicsalary;
        }
        public virtual void Print()
        {
            Console.WriteLine("\nName: " + this.Name);
            Console.WriteLine("ID: " + this.ID);
            Console.WriteLine("Birth Year: " + this.BirthYear);
            Console.WriteLine("Basic Salary: " + this.BasicSalary);
            Console.WriteLine("Salary: " + this.Salary);
        }
    }



    public class Accountant : Employee
    {
        private double alw;

        public double Allowance
        {
            get {return alw; }
            set {alw = value; }
        }

        public Accountant() : base()
        {
            this.Allowance = Allowance;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Allowance: ");
            this.alw = int.Parse(Console.ReadLine());
        }
        public override void caculateSalary()
        {
            base.caculateSalary();
            base.Salary += this.Allowance;
        }
        public override void Print()
        { 
            base.Print();
            Console.WriteLine("Allowance: " + this.Allowance);
        }
    }



    public class BusinessStaff : Employee
    {
        private int contNum;

        public int contactNum
        {
            get{return contNum; }
            set{this.contNum = value;}
        }

        public BusinessStaff() : base()
        {
            this.contactNum = contactNum;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Number of Contacts: ");
            this.contNum = int.Parse(Console.ReadLine());
        }
        public override void caculateSalary()
        {
            base.caculateSalary();
            base.Salary += this.contactNum * 100;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Number of Contacts: " + this.contactNum);
        }
    }



    public class GuardingStaff : Employee
    {
        private string workSes;

        public string workingSession
        {
            get{return workSes; }
            set{this.workSes = value;}
        }

        public GuardingStaff() : base()
        {
            this.workingSession = workingSession;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Working Session: ");
            this.workSes = Console.ReadLine();
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Working Session: " + this.workingSession);
        }
    }



    public class Company
    {
        private string name;
        private int accNum, bussNum, guardNum;
        private double totalSalary = 0;
        List<Accountant> acc = new List<Accountant>();
        List<BusinessStaff> buss = new List<BusinessStaff>();
        List<GuardingStaff> guard = new List<GuardingStaff>();

        public string companyName
        {
            get{return name; }
            set{this.name = value;}
        }
        public List<Accountant> accList
        {
            get{return acc; }
            set{this.acc = value;}
        }
        public List<BusinessStaff> bussList
        {
            get{return buss; }
            set{this.buss = value;}
        }
        public List<GuardingStaff> guardList
        {
            get{return guard; }
            set{this.guard = value;}
        }        

        public Company()
        {
            this.companyName = companyName;
            this.accList = accList;
            this.bussList = bussList;
            this.guardList = guardList;
        }
        public void Input()
        {
            Console.Write("Company name: ");
            this.name = Console.ReadLine();

            Console.Write("\nAccountants Number: ");
            this.accNum = int.Parse(Console.ReadLine());
            for(int i = 0; i < accNum; i++)
            {
                Accountant acc = new Accountant();
                acc.Input();
                this.accList.Add(acc);
            }

            Console.Write("\nNumber of Bussiness Staffs: ");
            this.bussNum = int.Parse(Console.ReadLine());
            for(int i = 0; i < bussNum; i++)
            {
                BusinessStaff buss = new BusinessStaff();
                buss.Input();
                this.bussList.Add(buss);
            }

            Console.Write("\nNumber of Guarding Staffs: ");
            this.guardNum = int.Parse(Console.ReadLine());
            for(int i = 0; i < guardNum; i++)
            {
                GuardingStaff guard = new GuardingStaff();
                guard.Input();
                this.guardList.Add(guard);
            }
        }

        public void Print()
        {
            Console.WriteLine("\n** " + this.companyName + " Company **\n");

            for(int i = 0; i < accNum; i++)
            {
                this.accList[i].caculateSalary();
                this.accList[i].Print();
                this.totalSalary += this.accList[i].Salary;
            }

            for(int i = 0; i < bussNum; i++)
            {
                this.bussList[i].caculateSalary();
                this.bussList[i].Print();
                this.totalSalary += this.bussList[i].Salary;
            }

            for(int i = 0; i < guardNum; i++)
            {
                this.guardList[i].caculateSalary();
                this.guardList[i].Print();
                this.totalSalary += this.guardList[i].Salary;
            }
        }
        public void Salary()
        {
            Console.WriteLine("\nTotal Salary of All Employees is " + this.totalSalary);
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            Company main = new Company();
            main.Input();
            main.Print();
            main.Salary();
        }
    }
}
*/