using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class GioHangChiTietRepository : IGioHangChiTiet
    {
        private FpolyDBContext _DBContext;
        private List<GioHangChiTiet> _lstGHCT;

        public bool Add(GioHangChiTiet ghct)
        {
            if (ghct == null)
            {
                return false;
            }
          _DBContext.GioHangChiTiets.Add(ghct);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Delete(GioHangChiTiet ghct)
        {
            if (ghct == null)
            {
                return false;
            }
            var temp = _DBContext.GioHangChiTiets.FirstOrDefault(c => c.IdGioHang == ghct.IdGioHang);
            _DBContext.GioHangChiTiets.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<GioHangChiTiet> GHCTGetAll()
        {
            _lstGHCT = _DBContext.GioHangChiTiets.ToList();
            return _lstGHCT;
        }

        public bool Update(GioHangChiTiet ghct)
        {
            if (ghct == null)
            {
                return false;
            }
            var temp = _DBContext.GioHangChiTiets.FirstOrDefault(c => c.IdGioHang == ghct.IdGioHang);
            temp.DonGia=ghct.DonGia;
            temp.DonGiaKhiGiam=ghct.DonGiaKhiGiam;
            temp.SoLuong=ghct.SoLuong;
            _DBContext.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
