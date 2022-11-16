using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
   public interface INsx
    {
        public List<Nsx> NsxGetAll();
        public bool Add(Nsx obj);
        public bool Delete(Nsx obj);
        public bool Update(Nsx obj);
    }
}
