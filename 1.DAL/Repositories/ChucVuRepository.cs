using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class ChucVuRepository : IChucVu
    {
         private FpolyDBContext _DBContext;
            private List<ChucVu> _lstChucVu;
        public ChucVuRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstChucVu = new List<ChucVu>();
            ChucvuGetAll();
        }
        public bool Add(ChucVu CV)
        {
            if (CV==null)
            {
                return false;
            }
            _DBContext.Add(CV);
            _DBContext.SaveChanges();
            return true;
        }

        public List<ChucVu> ChucvuGetAll()
        {
            _lstChucVu=_DBContext.ChucVus.ToList();
            return _lstChucVu;
        }

        public bool Delete(ChucVu CV)
        {

            if (CV == null)
            {
                return false;
            }
            var temp = _DBContext.ChucVus.FirstOrDefault(c => c.Id == CV.Id);
            _DBContext.ChucVus.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Update(ChucVu CV)
        {
            if (CV == null)
            {
                return false;
            }
            var temp = _DBContext.ChucVus.FirstOrDefault(c => c.Id == CV.Id);
            temp.NhanViens = CV.NhanViens;
            temp.Ten=CV.Ten;
            temp.Ma=CV.Ma;
            _DBContext.ChucVus.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
