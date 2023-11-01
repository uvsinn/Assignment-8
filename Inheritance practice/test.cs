using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Inheritance_practice
{
    internal class Test:Sports
    {
        int[] marks= new int[] { 90, 50, 36,58, 80};
        protected int totalmks;
       

        public void Get_details()
        {
            base.Get_details();
            Console.WriteLine("Enter mks of 5 subjects\n");
            int s1=Byte.Parse(Console.ReadLine());
            int s2 = Byte.Parse(Console.ReadLine());
            int s3 = Byte.Parse(Console.ReadLine());
            int s4 = Byte.Parse(Console.ReadLine());
            int s5 = Byte.Parse(Console.ReadLine());

            this.totalmks = s1+s2+s3+s4+s5;
        }
        public void Displaydetails()
        {
            base.Display_details();
            Console.WriteLine($"Toatal mks: {this.totalmks}");

        }
    }
}
