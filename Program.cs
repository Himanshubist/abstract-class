using System;

namespace abstractclass
{
   public abstract class Person
    {
        private int id;
        private string name;
        private double salary;
        public int Id{ get; set; }
        public  string Name { get; set; }
        public double Salary;
        private void showSalary()
        {
            double salary=20000;
            Console.WriteLine("Salary of person is Rs. " + salary );
        }
        public abstract void info();

        

    }
  public class Officer:Person
   {
        public override void info()
        {
            Console.WriteLine("name: " +Name);
            Console.WriteLine("Id : " +Id);
        }
    }



   class Program
    {
        static void Main(string[] args)
        {
            Officer o = new Officer();
            Console.WriteLine("Enter id for person:" +
                "");
            o.Id = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter name for person:" +
                "");
            o.Name = Console.ReadLine();
                
            o.info();
           // o.Salary();
            
        }
    }
}
