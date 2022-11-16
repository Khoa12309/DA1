using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories

{
   public interface ICuaHang
    {
        List<CuaHang> CuaHangGetAll();
        bool Add(CuaHang cuaHang);
        bool Delete(CuaHang cuaHang);
        bool Update(CuaHang cuaHang);
    }
}
