using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitLab4_5
{
    public class SanPhamService
    {
        private readonly List<SanPham> _sanPhams = new List<SanPham>();

        public void ThemSanPham(SanPham sp)
        {
            if (sp.SoLuong <= 0 || sp.SoLuong >= 100)
                throw new ArgumentException("So luong sp phai la so nguyen va no phai hon 100");

            _sanPhams.Add(sp);
        }


        public void SuaSanPham(string id, string newMaSanPham, string newTenSanPham, float newGia, string newMauSac, string newKichThuoc, int newSoLuong)
        {
            var sanPham = _sanPhams.FirstOrDefault(sp => sp.Id == id);
            if (sanPham == null)
            throw new ArgumentException("San pham ko ton tai ");

            if (!newMaSanPham.StartsWith("SP"))
            throw new ArgumentException("Ma sp phai bat dau = SP");

            if (_sanPhams.Any(sp => sp.MaSanPham == newMaSanPham && sp.Id != id))
            throw new ArgumentException("Ma san pham ko duoc trung nhau");

            sanPham.MaSanPham = newMaSanPham;
            sanPham.TenSanPham = newTenSanPham;
            sanPham.Gia = newGia;
            sanPham.MauSac = newMauSac;
            sanPham.KichThuoc = newKichThuoc;
            sanPham.SoLuong = newSoLuong;
        }

        public void XoaSanPham(string id)
        {
            var sanPham = _sanPhams.FirstOrDefault(sp => sp.Id == id);
            _sanPhams.Remove(sanPham);
        }
    }

}
