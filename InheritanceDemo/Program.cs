using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Parent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual decimal GetSalary()
        {
            Console.WriteLine("This is in Parent Class");
            return 1000.00m;
        }
    }
    public class Teacher:Parent
    {
        public string Subject { get; set; }
        public override decimal GetSalary()
        {
            Console.WriteLine("This is in Teacher Class");
            return 1600.00m;
        }
    }
    public class Administration:Parent
    {
        public string Function { get; set; }

        public override decimal GetSalary()
        {
            Console.WriteLine("This is in Administration Class");
            return base.GetSalary() + 300.25m;
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Marks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Parent p = new Parent()
            {
                FirstName = "Jarno",
                LastName = "Maes",
                Age = 21,               
            };           
            
            
            Teacher t = new Teacher()
            {
                FirstName = "Jarno",
                LastName = "Maes",
                Age = 21,
                Subject = "Math"
            };        
            
            
            Administration a = new Administration()
            {
                FirstName = "Jarno",
                LastName = "Maes",
                Age = 21,
                Function = "Book Keeping"
            };

            Student s = new Student()
            {
                Id = 1,
                FirstName = "Jarno",
                LastName = "Maes",
                Marks = 80
            };

            List<Parent> parents = new List<Parent>();
            parents.Add(p);
            parents.Add(t);
            parents.Add(a);
            

            foreach (var item in parents)
            {
                Console.WriteLine(item.GetSalary());
            }
        }
    }
}
