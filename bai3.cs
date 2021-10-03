using System;
using System.Collections.Generic;

namespace exerciseW4_bai3
{
    public class Product
    {
        private string id, name, color;
        private double price;

        public string ID
        {
            get {return id;}
            set {this.id = value;}
        }
        public string productName
        {
            get {return name;}
            set {this.name = value;}
        }
        public string productColor
        {
            get {return color;}
            set {this.color = value;}
        }
        public double productPrice
        {
            get {return price;}
            set {this.price = value;}
        }

        public Product()
        {
            this.ID = ID;
            this.productName = productName;
            this.productColor = productColor;
            this.productPrice = productPrice;
        }
        public virtual void Input()
        {
            Console.Write("\nInput the ID of product: ");
            this.id = Console.ReadLine();
            Console.Write("Input the name of product: ");
            this.name = Console.ReadLine();
            Console.Write("Input the color of product: ");
            this.color = Console.ReadLine();
            Console.Write("Input the price of product: ");
            this.price = double.Parse(Console.ReadLine());
        }
        public virtual void Print()
        {
            Console.WriteLine("The ID of product: " + this.ID);
            Console.WriteLine("The name of product: " + this.productName);
            Console.WriteLine("The color of product: " + this.productColor);
        }
    }



    public class TiVi : Product
    {
        private int size;

        public int tvSize 
        {
            get {return size;}
            set {this.size = value;}
        }

        public TiVi() : base()
        {
            this.tvSize = tvSize;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Input the size of TV: ");
            this.size = int.Parse(Console.ReadLine());
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("The size of TV: " + this.tvSize);
            Console.WriteLine("Price: " + (base.productPrice + (this.size * 0.1)));
        }
    }



    public class Phone : Product
    {
        private int memSto;

        public int phoneMemory 
        {
            get {return memSto;}
            set {this.memSto = value;}
        }

        public Phone() : base()
        {
            this.phoneMemory = phoneMemory;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Input the memory storage of the phone: ");
            this.memSto = int.Parse(Console.ReadLine());
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("The memory storage of the phone: " + this.phoneMemory);
            Console.WriteLine("Price: " + (base.productPrice + (this.phoneMemory * 0.2)));
        }
    }



    public class AirConditioner : Product
    {
        private int watt;

        public int acWattage 
        {
            get {return watt;}
            set {this.watt = value;}
        }

        public AirConditioner() : base()
        {
            this.acWattage = acWattage;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Input the wattage of the air conditioner: ");
            this.watt = int.Parse(Console.ReadLine());
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("The wattage of the air conditioner: " + this.acWattage);
            Console.WriteLine("Price: " + (base.productPrice + (this.acWattage * 0.1)));
        }
    }



    public class Company
    {
        private string name;
        private int pNum, acNum, tvNum;
        List<Phone> phone = new List<Phone>();
        List<TiVi> tv = new List<TiVi>();
        List<AirConditioner> ac = new List<AirConditioner>();

        public string companyName
        {
            get {return name;}
            set {this.name = value;}
        }
        public List<Phone> phoneList
        {
            get {return phone;}
            set {this.phone = value;}
        }
        public List<TiVi> tvList
        {
            get {return tv;}
            set {this.tv = value;}
        }
        public List<AirConditioner> acList
        {
            get {return ac;}
            set {this.ac = value;}
        }

        public Company()
        {
            this.phoneList = phoneList;
            this.tvList = tvList;
            this.acList = acList;
            this.companyName = companyName;
        }
        public void InputProduct()
        {
            Console.Write("Company Name: ");
            this.name = Console.ReadLine();

            Console.Write("\nNumber of Phones: ");
            pNum = int.Parse(Console.ReadLine());
            for(int i = 0; i < pNum; i++)
            {
                Phone phone = new Phone();
                phone.Input();
                this.phoneList.Add(phone);
            }

            Console.Write("\nNumber of TVs: ");
            tvNum = int.Parse(Console.ReadLine());
            for(int i = 0; i < tvNum; i++)
            {
                TiVi tv = new TiVi();
                tv.Input();
                this.tvList.Add(tv);
            }

            Console.Write("\nNumber of Air-conditioners: ");
            acNum = int.Parse(Console.ReadLine());
            for(int i = 0; i < acNum; i++)
            {
                AirConditioner ac = new AirConditioner();
                ac.Input();
                this.acList.Add(ac);
            }
        }
        // public void PrintProduct()
        // {
        //     Console.WriteLine("\n***List of products of " + this.companyName + " company***\n");

        //     for(int i = 0; i < pNum; i++)
        //     {
        //         this.phoneList[i].Print();
        //     }

        //     for(int i = 0; i < tvNum; i++)
        //     {
        //         this.tvList[i].Print();
        //     }

        //     for(int i = 0; i < acNum; i++)
        //     {
        //         this.acList[i].Print();
        //     }
        // }
    }



    // public class runProgram
    // {
    //     static void Main(string[] args)
    //     {
    //         Company main = new Company();
    //         main.InputProduct();
    //         main.PrintProduct();
    //     }
    // }
}