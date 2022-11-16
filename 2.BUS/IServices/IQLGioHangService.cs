using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLGioHangService
    {
        public string Add(GioHang obj);
        public string Update(GioHang obj);
        public string Delete(GioHang obj);
        List<GioHang> GHGetAll();
    }
}
