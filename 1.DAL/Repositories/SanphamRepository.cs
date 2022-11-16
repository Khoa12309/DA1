using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class SanphamRepository : ISanPham
    {
        private FpolyDBContext _DBContext;
        private List<SanPham> _lstSP;
        public SanphamRepository()
        {
            _DBContext = new FpolyDBContext();
            _lstSP = new List<SanPham>();
            SanPhamGetAll();
        }
        public bool Add(SanPham sp)
        {
            if (sp == null)
            {
                return false;
            }
            _DBContext.SanPhams.Add(sp);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham sp)
        {
            if (sp == null) return false;
            var temp = _DBContext.SanPhams.FirstOrDefault(c => c.Id == sp.Id);
            _DBContext.SanPhams.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<SanPham> SanPhamGetAll()
        {
            _lstSP = _DBContext.SanPhams.ToList();
            return _lstSP;
        }

        public bool Update(SanPham sp)
        {
            if (sp == null) return false;
            var temp = _DBContext.SanPhams.FirstOrDefault(c => c.Id == sp.Id);
            temp.Ten = sp.Ten;        
            temp.Ma = sp.Ma;         
            
            _DBContext.SanPhams.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
