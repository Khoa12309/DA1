using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
   public interface IMauSac
    {
        public List<MauSac> MSGetAll();
        public bool Add(MauSac ms);
        public bool Delete(MauSac ms);
        public bool Update(MauSac ms);
    }
}
