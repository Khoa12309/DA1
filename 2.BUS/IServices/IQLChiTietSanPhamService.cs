using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLChiTietSanPhamService
    {
        public string Add(ChiTietSp obj);
        public string Update(ChiTietSp obj);
        public string Delete(ChiTietSp obj);
        List<ChiTietSp> CTSPGetAll();
    }
}
