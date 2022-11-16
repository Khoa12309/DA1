using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
   public interface IChiTietSP
    {
       public List<ChiTietSp> GetAllCTSP();
        public bool Add(ChiTietSp CTSP);
        public bool Delete(ChiTietSp CTSP);
        public bool Update(ChiTietSp CTSP);

    }
}
