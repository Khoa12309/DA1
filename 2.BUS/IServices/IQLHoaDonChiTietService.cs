using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
   public interface IQLHoaDonChiTiet
    {
        public string Add(HoaDonChiTiet obj);
        public string Update(HoaDonChiTiet obj);
        public string Delete(HoaDonChiTiet obj);
        List<HoaDonChiTiet> HDCTGetAll();
    }
}
