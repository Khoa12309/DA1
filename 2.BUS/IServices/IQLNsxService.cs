using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLNsxService
    {
        public string Add(Nsx obj);
        public string Update(Nsx obj);
        public string Delete(Nsx obj);
        List<Nsx> NsxGetAll();
    }
}
