using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface IChucVu
    {
        public List<ChucVu> ChucvuGetAll();
        public bool Add(ChucVu CV);
        public bool Delete(ChucVu CV);

        public bool Update(ChucVu CV);
    }
}
