namespace Inheritance_practice
{
    internal class Student
    {
        int roll_no;
        string name;

        public virtual void Get_details()
        {
            Console.WriteLine("Enter roll no");
            this.roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            this.name = Console.ReadLine(); 
        }
        public virtual void Display_details()
        {
            Console.WriteLine($"Roll no: {this.roll_no}\n");
            Console.WriteLine($"Name: {this.name}\n");
        }
    }
}