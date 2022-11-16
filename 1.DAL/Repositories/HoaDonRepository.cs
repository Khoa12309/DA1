using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class HoaDonRepository : IHoaDon
    {
        private FpolyDBContext _DBContext;
        private List<HoaDon> _lstHD;
        public HoaDonRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstHD = new List<HoaDon>();
            HoaDonGetAll();
        }
        public bool Add(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            _DBContext.HoaDons.Add(hd);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            var temp = _DBContext.HoaDons.FirstOrDefault(c => c.Id == hd.Id);
            _DBContext.HoaDons.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<HoaDon> HoaDonGetAll()
        {
            _lstHD = _DBContext.HoaDons.ToList();
            return _lstHD;
        }

        public bool Update(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            var temp = _DBContext.HoaDons.FirstOrDefault(c => c.Id == hd.Id);
            temp.Sdt = hd.Sdt;
            temp.TinhTrang = hd.TinhTrang;
            temp.NgayThanhToan = hd.NgayThanhToan;
            temp.Ma = hd.Ma;
            temp.NgayTao = hd.NgayTao;
            temp.NgayNhan = hd.NgayNhan;
            temp.IdKh = hd.IdKh;
            temp.IdNv = hd.IdNv;
            temp.NgayShip = hd.NgayShip;
            temp.TenNguoiNhan = hd.TenNguoiNhan;
            temp.DiaChi = hd.Sdt;
            _DBContext.HoaDons.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
