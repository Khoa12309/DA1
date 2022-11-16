using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLKhachHangService
    {
        public string Add(KhachHang obj);
        public string Update(KhachHang obj);
        public string Delete(KhachHang obj);
        List<KhachHang> KHGetAll();
    }
}
