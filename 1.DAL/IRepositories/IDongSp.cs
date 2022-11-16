using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public  interface IDongSp
    {
        public List<DongSp> DSPGetAll();
        public bool Add(DongSp dp);
        public bool Delete(DongSp dp);
        public bool Update(DongSp dp); 
    }
}
