using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface IGioHang
    {
        public List<GioHang> GioHangGetAll();
        public bool Add(GioHang gh);
        public bool Delete(GioHang gh);
        public bool Update(GioHang gh);
    }
}
