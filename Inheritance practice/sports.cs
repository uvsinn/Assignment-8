using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_practice
{
    internal class Sports:Student
    {
        string sp_name;
        protected int score;

        public void Get_details()
        {
            base.Get_details();
            Console.WriteLine("Enter sports name");
            this.sp_name = Console.ReadLine();
            Console.WriteLine("Enter score");
            this.score = Convert.ToInt32(Console.ReadLine());
        }
        public void Display_details()
        {
            base.Display_details();
            Console.WriteLine($"Sports name: {this.sp_name}\n");
            Console.WriteLine($"Score: {this.score}\n");
        }
    }
}
