using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLMauSacService
    {
        public string Add(MauSac obj);
        public string Update(MauSac obj);
        public string Delete(MauSac obj);
        List<MauSac> MSGetAll();
    }
}
