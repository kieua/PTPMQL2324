using System;
namespace NewApp.Models
{
    public class Person 
    {
        public string Fullname { get; set;}//thuoc tinh
        public string Address { get; set;}
        public int Age { get; set;}
        public void EnterData()//phuong thuc nhap
        {
            System.Console.Write("Fullname =");
            Fullname = Console.ReadLine();
            System.Console.Write("Address =");
            Address = Console.ReadLine();
            System.Console.Write("Age =");
            Age = Convert.ToInt16(Console.ReadLine());

        }
        public void Display()//phuong thuc tra ve
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", Fullname, Address, Age);
        }
        public void Display2(string Ten, int Tuoi)// phuong thuc co tham so
        {
            System.Console.WriteLine("Sinh vien {0} - {1} tuoi", Ten, Tuoi);
        }
        public int GetYearOfBirth (int age)// kieu du lieu tra ve cua phuong thuc (int)
        {
            int YearOfBiirth = 2023 - age;
            return YearOfBiirth;
        }
        
    }
}