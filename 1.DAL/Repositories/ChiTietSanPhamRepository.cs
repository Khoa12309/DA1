using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.Repositories
{
    public class ChiTietSanPhamRepository : IChiTietSP
    {
        private FpolyDBContext _DBContext;

        private List<ChiTietSp> _lstCTSP;
        public ChiTietSanPhamRepository()
        {
            _DBContext = new FpolyDBContext();  
            _lstCTSP = new List<ChiTietSp>();
            GetAllCTSP();
        }
        public bool Add(ChiTietSp CTSP)
        {
            
            if (CTSP==null)
            {
                return false;
            }
            return true;
        }

        public bool Delete(ChiTietSp CTSP)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietSp> GetAllCTSP()
        {
            throw new NotImplementedException();
        }

        public bool Update(ChiTietSp CTSP)
        {
            throw new NotImplementedException();
        }
    }
}
