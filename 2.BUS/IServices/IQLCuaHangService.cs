using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLCuaHangService
    {
       
        public string Add(CuaHang obj);
        public string Update(CuaHang obj);
        public string Delete(CuaHang obj);
        List<CuaHang> CHGetAll();
    }
}
