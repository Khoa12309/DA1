using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface IKhachHang
    {
      
        public List<KhachHang> KhachHangGetAll();
        public bool Add(KhachHang kh);
        public bool Delete(KhachHang kh);
        public bool Update(KhachHang kh);
    }
}
