
using System;
namespace NewApp.Models
{
    public class Person 
    {
        public string Fullname { get; set;}
        public string Address { get; set;}
        public int Age { get; set;}
        public void EnterData()
        {
            System.Console.Write("Fullname =");
            Fullname = Console.ReadLine();
            System.Console.Write("Address =");
            Address = Console.ReadLine();
            System.Console.Write("Age =");
            Age = Convert.ToInt16(Console.ReadLine());

        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", Fullname, Address, Age);
        }
    }
}