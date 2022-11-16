using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface INhanVien
    {
        public List<NhanVien> NhanVienGetAll();
        public bool Add(NhanVien nv);
        public bool Delete(NhanVien nv);
        public bool Update(NhanVien nv);
    }
}
