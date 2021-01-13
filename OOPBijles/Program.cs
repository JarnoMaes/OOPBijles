using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBijles
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        

        public Person()
        {
            Age = 15;
        }
        public Person(string fullName):this()
        {
            this.FullName = fullName;
        }
        public Person(string fullName, int age):this(fullName)
        {
            this.FullName = fullName;
            this.Age = age;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Name: {FullName}, Age: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Jarno Maes", 50);
            Person p = new Person()
            {
                FullName = "Jarno Maes",
                Age = 21,
            }; 
            p.GetDetails();
        }
    }
}
