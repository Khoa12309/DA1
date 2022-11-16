using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class HoaDonChiTietRepository :IHoaDonChiTiet
    {
        private FpolyDBContext _DBContext;
        private List<HoaDonChiTiet> _lsthdct;
        public HoaDonChiTietRepository()
        {
            _DBContext = new FpolyDBContext();
            _lsthdct = new List<HoaDonChiTiet>();
            HDCTGetAll();
        }
        public bool Add(HoaDonChiTiet hdct)
        {
            if (hdct == null)
            {
                return false;
            }
          _DBContext.HoaDonChiTiets.Add(hdct);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet hdct)
        {
            if (hdct == null)
            {
                return false;
            }
            var temp = _DBContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == hdct.IdHoaDon);
            _DBContext.HoaDonChiTiets.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> HDCTGetAll()
        {
            _lsthdct = _DBContext.HoaDonChiTiets.ToList();
            return _lsthdct;
        }

        public bool Update(HoaDonChiTiet hdct)
        {
            if (hdct == null)
            {
                return false;
            }
            var temp = _DBContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == hdct.IdHoaDon);
            temp.SoLuong=hdct.SoLuong;
            temp.DonGia=hdct.DonGia;
            _DBContext.HoaDonChiTiets.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
