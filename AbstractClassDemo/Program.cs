using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public abstract class Parent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SayHello()
        {
            return "Hello World";
        }
        public abstract decimal GetSalary();
    }
    public class Child : Parent
    {
        public override decimal GetSalary()
        {
            return 3250.50m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child()
            {
                FirstName = "Jarno",
                LastName = "Maes",
                Age = 25,
            };
            Console.WriteLine($"First Name: {c.FirstName}, Last Name: {c.LastName}, Age: {c.Age}");
            decimal salary = c.GetSalary();
            Console.WriteLine(salary);
        }
    }
}
