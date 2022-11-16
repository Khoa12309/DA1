using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLHoaDonService
    {
        public string Add(HoaDon obj);
        public string Update(HoaDon obj);
        public string Delete(HoaDon obj);
        List<HoaDon> HDGetAll();
    }
}
