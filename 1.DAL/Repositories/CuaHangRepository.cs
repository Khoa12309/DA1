using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class CuaHangRepository : ICuaHang

    {
        private FpolyDBContext _DBContext;
        private List<CuaHang> _CuaHangList;
        public CuaHangRepository()
        {
                _DBContext = new FpolyDBContext();
            _CuaHangList = new List<CuaHang>();
            CuaHangGetAll();
        }
        public bool Add(CuaHang cuaHang)
        {
            if (cuaHang== null)
            {
                return false;
            }
            _DBContext.CuaHangs.Add(cuaHang);
            _DBContext.SaveChanges();
            return true;
        }

        public List<CuaHang> CuaHangGetAll()
        {
            _CuaHangList= _DBContext.CuaHangs.ToList();
            return _CuaHangList;
        }

        public bool Delete(CuaHang cuaHang)
        {
           if (cuaHang == null) return false;   
           var temp = _DBContext.CuaHangs.FirstOrDefault(c=>c.Id==cuaHang.Id);
            _DBContext.CuaHangs.Remove(temp);
            _DBContext.SaveChanges();
            return true;

        }

        public bool Update(CuaHang cuaHang)
        {
            if (cuaHang == null) return false;
            var temp = _DBContext.CuaHangs.FirstOrDefault(c => c.Id == cuaHang.Id);
            temp.Ten=cuaHang.Ten;
            temp.DiaChi=cuaHang.DiaChi;
            temp.QuocGia = cuaHang.QuocGia;
            temp.ThanhPho=cuaHang.ThanhPho;
            temp.Ma=cuaHang.Ma;
            temp.NhanViens=cuaHang.NhanViens;
            _DBContext.CuaHangs.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
