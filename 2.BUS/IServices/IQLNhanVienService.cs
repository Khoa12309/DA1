using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLNhanVienService
    {
        public string Add (NhanVien obj);
        public string Update(NhanVien obj);
        public string Delete(NhanVien obj);
        List<NhanVien> NVGetAll();
    }
}
