using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface IHoaDon
    {
        public List<HoaDon> HoaDonGetAll();
        public bool Add(HoaDon hd);
        public bool Delete(HoaDon hd);
        public bool Update(HoaDon hd);
    }
}
