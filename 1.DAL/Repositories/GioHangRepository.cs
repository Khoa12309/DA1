using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
   public class GioHangRepository :IGioHang
    {
        private FpolyDBContext _DBContext;
        private List<GioHang> _lstgh;
        public GioHangRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstgh = new List<GioHang>();
            GioHangGetAll();

        }
        
        public bool Add(GioHang gh)
        {
            if (gh == null)
            {
                return false;
            }
            _DBContext.Add(gh);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Delete(GioHang gh)
        {
            if (gh == null)
            {
                return false;
            }
            var temp = _DBContext.GioHangs.FirstOrDefault(c => c.Id == gh.Id);
            _DBContext.GioHangs.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<GioHang> GioHangGetAll()
        {
           _lstgh=_DBContext.GioHangs.ToList();
            return _lstgh;
        }

        public bool Update(GioHang gh)
        {
            if (gh == null)
            {
                return false;
            }
            var temp = _DBContext.GioHangs.FirstOrDefault(c => c.Id == gh.Id);
            temp.IdKh = gh.Id;
            temp.IdNv= gh.IdNv;
            temp.Ma= gh.Ma;
            temp.NgayTao= gh.NgayTao;
            temp.NgayThanhToan=gh.NgayThanhToan;
            temp.TenNguoiNhan = gh.TenNguoiNhan;
            temp.TinhTrang= gh.TinhTrang;
            temp.Sdt= gh.Sdt;
            temp.DiaChi= gh.DiaChi;
            _DBContext.GioHangs.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
