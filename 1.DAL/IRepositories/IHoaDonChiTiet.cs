using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChiTiet
    {
        public List<HoaDonChiTiet> HDCTGetAll();
        public bool Add(HoaDonChiTiet hdct);
        public bool Delete(HoaDonChiTiet hdct);
        public bool Update(HoaDonChiTiet hdct);
    }
}
