using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBai8
{
    internal class SinhVien
    {
        public int MSSV { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public SinhVien() { } //mac dinh

        public SinhVien(int mSSV, string hoTen, int namSinh, string diaChi)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            NamSinh = namSinh;
            DiaChi = diaChi;
        }
    }
}
