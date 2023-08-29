using System.Security.Cryptography;
using System.Reflection.Metadata;
using System.Collections.Specialized;
using NewApp.Models;
// person
Person ps1 = new Person();
Person ps2 = new Person();
ps1.Fullname= "Nguyen Van a";
ps1.Address = " Ha Noi";
ps1.Age = 16;
ps1.Display();
// Employee
Employyee Em1 = new Employyee();
Em1.MaNV ="NV1";
Em1.TenNV = "Nguyen Van A";
Em1.Tuoi = 25;
Em1.Luong = "20000000";
Em1.HienThi();
//phuong thuc co tham so
string str = " Nguyen Van B";
int a = 22;
ps2.Display2(str,a);
//kieu tra ve cua phuong thuc int
Console.WriteLine("{0} sinh nam {1}",str,ps2.GetYearOfBirth(a));
//tao doi tuong std class Student ke thua Class Person
Student std = new Student();
std.EnterData();
std.StudentCode = "12345678";
std.Display();

