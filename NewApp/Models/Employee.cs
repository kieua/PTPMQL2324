namespace NewApp.Models 
{
    public class Employyee
    {
        // khai bao thuoc tinh
        public string MaNV { get; set;}
        public string TenNV { get; set;}
        public int Tuoi { get; set;}
        public string Luong { get; set;}
       // khai bao phuong thuc
        public void NhapThongTin()
        {
            System.Console.Write("Ma NV");
            MaNV = Console.ReadLine();
            System.Console.Write("Ten NV");
            TenNV = Console.ReadLine();
            System.Console.Write("Tuoi");
            Tuoi = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Luong");
            Luong = Console.ReadLine();
        }
        public void HienThi()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi - {3} VNĐ", MaNV,TenNV,Tuoi,Luong);
        }
    }
}