using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLChucVuService
    {
        public string Add(ChucVu obj);
        public string Update(ChucVu obj);
        public string Delete(ChucVu obj);
        List<ChucVu> CVGetAll();
    }
}
