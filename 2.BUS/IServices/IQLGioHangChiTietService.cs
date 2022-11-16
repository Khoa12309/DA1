using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLGioHangChiTietService
    {
        public string Add(GioHangChiTiet obj);
        public string Update(GioHangChiTiet obj);
        public string Delete(GioHangChiTiet obj);
        List<GioHangChiTiet> GHCTGetAll();
    }
}
