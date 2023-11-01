using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    internal class Result:Test
    {
        int total_score;
        public void Get_details()
        {
            base.Get_details();
            this.total_score = totalmks+score;
        }
        public void Display_details()
        {
            base.Display_details();
            Console.WriteLine($"Total score: {this.total_score}");
        }
    }
}
