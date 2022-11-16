using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class MauSacRepository :IMauSac
    {
        private FpolyDBContext _DBContext;
        private List<MauSac> _lstMS;

        public MauSacRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstMS=new List<MauSac>();
            MSGetAll();
        }
        public bool Add(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            _DBContext.MauSacs.Add(ms);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            var temp = _DBContext.MauSacs.FirstOrDefault(c => c.Id == ms.Id);
            _DBContext.MauSacs.Remove(ms);
            _DBContext.SaveChanges();
            return true;
        }

        public List<MauSac> MSGetAll()
        {
            _lstMS = _DBContext.MauSacs.ToList();
            return _lstMS;
        }

        public bool Update(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            var temp = _DBContext.MauSacs.FirstOrDefault(c => c.Id == ms.Id);
            temp.Ten=ms.Ten;
            temp.Ma=ms.Ma;
            _DBContext.MauSacs.Update(temp);
            _DBContext.SaveChanges();
            return true;

        }
    }
}
