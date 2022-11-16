using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLDongSpService
    {
        public string Add(DongSp obj);
        public string Update(DongSp obj);
        public string Delete(DongSp obj);
        List<DongSp> DspGetAll();
    }
}
