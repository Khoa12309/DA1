using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
   public class NsxRepository : INsx
    {
        private FpolyDBContext _DBContext;
        private List<Nsx> _lstNsx;
        public NsxRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstNsx = new List<Nsx>();
            NsxGetAll();

        }

        public bool Add(Nsx obj)
        {
            if (obj==null)
            {
                return false;
            }
            _DBContext.Nsxes.Add(obj);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp=_DBContext.Nsxes.FirstOrDefault(c=>c.Id==obj.Id);
            _DBContext.Nsxes.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<Nsx> NsxGetAll()
        {
           _lstNsx=_DBContext.Nsxes.ToList();
            return _lstNsx;
        }

        public bool Update(Nsx obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _DBContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            temp.Ten=obj.Ten;
            temp.Ma=obj.Ma;
            _DBContext.Nsxes.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
