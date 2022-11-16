using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class KhachHangRepository : IKhachHang
    {
        private FpolyDBContext _DBContext;
        private List<KhachHang> _lstKH;

        public KhachHangRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstKH = new List<KhachHang>();
            KhachHangGetAll();
        }
        public bool Add(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            _DBContext.KhachHangs.Add(kh);
            _DBContext.SaveChanges();
            return true;

        }

        public bool Delete(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            var temp = _DBContext.KhachHangs.FirstOrDefault(c => c.Id == kh.Id);
            _DBContext.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<KhachHang> KhachHangGetAll()
        {
            _lstKH = _DBContext.KhachHangs.ToList();
            return _lstKH;

        }

        public bool Update(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            var temp = _DBContext.KhachHangs.FirstOrDefault(c => c.Id == kh.Id);
            temp.ThanhPho=kh.ThanhPho;
            temp.NgaySinh=kh.NgaySinh;
            temp.Ho=kh.Ho;
            temp.DiaChi=kh.DiaChi;
            temp.QuocGia=kh.QuocGia;
            temp.Ma=kh.Ma;
            temp.Sdt=kh.Sdt;
            temp.TenDem=kh.TenDem;
            temp.Ten=kh.Ten;
            temp.MatKhau=kh.MatKhau;
            _DBContext.KhachHangs.Add(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
