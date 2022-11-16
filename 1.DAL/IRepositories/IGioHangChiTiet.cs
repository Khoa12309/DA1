using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface IGioHangChiTiet
    {
        public List<GioHangChiTiet> GHCTGetAll();
        public bool Add(GioHangChiTiet ghct);
        public bool Delete(GioHangChiTiet ghct);
        public bool Update(GioHangChiTiet ghct);
    }
}
