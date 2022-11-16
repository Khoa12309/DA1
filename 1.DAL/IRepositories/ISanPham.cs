using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface ISanPham
    {
        public List<SanPham> SanPhamGetAll();
        public bool Add(SanPham sp);
        public bool Delete(SanPham sp);
        public bool Update(SanPham sp);
    }
}
