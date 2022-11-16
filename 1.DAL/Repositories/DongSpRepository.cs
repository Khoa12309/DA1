using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class DongSpRepository : IDongSp
    {
        private FpolyDBContext _DBContext;
        private List<DongSp> _lstDSP;
        public DongSpRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstDSP = new List<DongSp>();   
            DSPGetAll();
        }
        public bool Add(DongSp dp)
        {
            if (dp == null)
            {
                return false;
            }
          _DBContext.Add(dp);
          _DBContext.SaveChanges();
            return true;
        }

        public bool Delete(DongSp dp)
        {
            if (dp == null)
            {
                return false;
            }
            var temp = _DBContext.DongSps.FirstOrDefault(c => c.Id == dp.Id);
            _DBContext.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<DongSp> DSPGetAll()
        {
            _lstDSP = _DBContext.DongSps.ToList();
            return _lstDSP;
        }

        public bool Update(DongSp dp)
        {
            if (dp == null)
            {
                return false;
            }
            var temp = _DBContext.DongSps.FirstOrDefault(c => c.Id == dp.Id);
            temp.Ten=dp.Ten;
            temp.Ma=dp.Ma;
            _DBContext.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
