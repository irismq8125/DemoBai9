using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBai8
{

    public class SoNguyen
    {
        public int ThuTu { get; set; }
        public int GiaTri { get; set; }
    }
    internal class Program
    {
        static List<SinhVien> listSV = new List<SinhVien>();
        static void Main(string[] args)
        {
            //int[] arr = new int[3]; //5 3 9
            //Array.Sort(arr); //tang dan 3 5 9
            //Array.Reverse(arr); //dao mang 9 5 3

            while (true)
            {
                HienThiThongBao();
                Console.Write("Chon chuc nang can thuc hien: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        NhapThongTinSV();
                        break;
                    case 4:
                        XemDanhSach();
                        break;
                    case 5:
                        TimKiemTheoMSSV();
                        break;
                    case 6:
                        SapXepTangDan();
                        break;
                    case 7:
                        SapXepGiamDan();
                        break;
                    default:
                        Console.WriteLine("Chuc nang khong ton tai");
                        break;
                }
                
                Console.WriteLine("Nhan Y de thoat!");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }
            //Console.ReadKey();
        }

        public static void HienThiThongBao()
        {
            Console.WriteLine("1. Nhap thong tin sinh vien");
            Console.WriteLine("2. Xoa thong tin sinh vien");
            Console.WriteLine("3. Cap nhat thong tin sinh vien");
            Console.WriteLine("4. Xem danh sach thong tin sinh vien");
            Console.WriteLine("5. Tim kiem sinh vien theo MSSV");
            Console.WriteLine("6. Hien thi danh sach sinh vien theo nam sinh tang dan");
            Console.WriteLine("7. Hien thi danh sach sinh vien theo nam sinh giam dan");
        }

        public static void NhapThongTinSV()
        {
            Console.Write("Nhap MSSV: ");
            int mssv = int.Parse(Console.ReadLine());

            Console.Write("Nhap Ho ten: ");
            string hoten = Console.ReadLine();
            
            Console.Write("Nhap nam sinh: ");
            int namsinh = int.Parse(Console.ReadLine());   

            Console.Write("Nhap dia chi: ");
            string diachi = Console.ReadLine();

            SinhVien sv = new SinhVien(mssv, hoten,namsinh, diachi);
            listSV.Add(sv);
        }

        public static void XoaThongTin()
        {
            Console.Write("Nhap MSSV can xoa: ");
            int mssv = int.Parse(Console.ReadLine());
            //string hoten = Console.ReadLine(); //Van
            //Nguyen Van A
            //Nguyen Van B
            //Nguyen Van C
            //listSV.RemoveAll(c => c.HoTen.ToLower().Contains(hoten.ToLower()));
            listSV.RemoveAll(_ => _.MSSV == mssv);
        }

        public static void TimKiemTheoMSSV()
        {
            Console.Write("Nhap MSSV can tim: ");
            int mssv = int.Parse(Console.ReadLine());
            var item = listSV.FirstOrDefault(c => c.MSSV == mssv );
            if(item is null)
            {
                Console.WriteLine("MSSV can tim khong hop le!");
            }
            else
            {
                Console.WriteLine("MSSV: {0}", item.MSSV);
                Console.WriteLine("Ho ten: {0}", item.HoTen);
                Console.WriteLine("Nam sinh: {0}", item.NamSinh);
                Console.WriteLine("Dia chi: {0}", item.DiaChi);
                Console.WriteLine();
            }
        }

        public static void SapXepTangDan()
        {
            var temp = listSV.OrderBy(c => c.NamSinh).ToList();
            foreach (var item in temp)
            {
                Console.WriteLine("MSSV: {0}", item.MSSV);
                Console.WriteLine("Ho ten: {0}", item.HoTen);
                Console.WriteLine("Nam sinh: {0}", item.NamSinh);
                Console.WriteLine("Dia chi: {0}", item.DiaChi);
                Console.WriteLine();
            }
        }

        public static void SapXepGiamDan()
        {
            var temp = listSV.OrderByDescending(c => c.NamSinh).ToList();

            foreach (var item in temp)
            {
                Console.WriteLine("MSSV: {0}", item.MSSV);
                Console.WriteLine("Ho ten: {0}", item.HoTen);
                Console.WriteLine("Nam sinh: {0}", item.NamSinh);
                Console.WriteLine("Dia chi: {0}", item.DiaChi);
                Console.WriteLine();
            }
        }

        public static void XemDanhSach()
        {
            foreach (var item in listSV)
            {
                Console.WriteLine("MSSV: {0}", item.MSSV);
                Console.WriteLine("Ho ten: {0}", item.HoTen);
                Console.WriteLine("Nam sinh: {0}", item.NamSinh);
                Console.WriteLine("Dia chi: {0}", item.DiaChi);
                Console.WriteLine();
            }
        }
    }
}
