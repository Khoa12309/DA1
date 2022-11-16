using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;

namespace _1.DAL.Repositories
{
    internal class NhanVienRepository :INhanVien    
    {
        private FpolyDBContext _DBContext;
        private List<NhanVien> _lstNV;
        public NhanVienRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstNV= new List<NhanVien>();
            NhanVienGetAll();
        }

        public bool Add(NhanVien nv)
        {
            if (nv==null)
            {
                return false;
            }
            _DBContext.NhanViens.Add (nv);
            _DBContext.SaveChanges();
            return true;
            
        }

        public bool Delete(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            var temp = _DBContext.NhanViens.FirstOrDefault(c=>c.Id==nv.Id);
            _DBContext.NhanViens.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<NhanVien> NhanVienGetAll()
        {
            _lstNV = _DBContext.NhanViens.ToList();
            return _lstNV;
        }

        public bool Update(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
           var temp= _DBContext.NhanViens.FirstOrDefault(c=>c.Id==nv.Id);
            temp.GioiTinh = nv.GioiTinh;
            temp.DiaChi = nv.DiaChi;
            temp.IdCh=nv.IdCh;
            temp.IdCv=nv.IdCv;
            temp.Ho = nv.Ho;
            temp.Ma= nv.Ma;
            temp.MatKhau= nv.MatKhau;
            temp.Ten= nv.Ten;
            temp.TenDem= nv.TenDem;
            temp.TrangThai= nv.TrangThai;
            temp.NgaySinh= nv.NgaySinh;
            temp.Sdt= nv.Sdt;
            temp.IdGuiBc= nv.IdGuiBc;
            _DBContext.NhanViens.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
