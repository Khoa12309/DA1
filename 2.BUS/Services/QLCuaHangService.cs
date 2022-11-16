using _1.DAL.DomainClass;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BUS.Services
{
    public class QLCuaHangService : IQLCuaHangService
    {
        private CuaHangRepository _ICHRep;
        public QLCuaHangService()
        {
            _ICHRep = new CuaHangRepository();

        }
        public string Add(CuaHang obj)
        {
            if (_ICHRep.Add(obj))

            {                
                return "thêm thành công";
            }
            return " thêm không Thành công";
        }

        public List<CuaHang> CHGetAll()
        {
            return _ICHRep.CuaHangGetAll().ToList();
        }

        public string Delete(CuaHang obj)
        {
            throw new NotImplementedException();
        }

        public string Update(CuaHang obj)
        {
            throw new NotImplementedException();
        }
    }
}
