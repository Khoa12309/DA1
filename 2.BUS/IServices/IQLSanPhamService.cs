using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLSanPhamService
    {
        public string Add(SanPham obj);
        public string Update(SanPham obj);
        public string Delete(SanPham obj);
        List<SanPham> NsxGetAll();
    }
}
