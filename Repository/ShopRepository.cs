using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class ShopRepository : IShopOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public ShopRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
        public bool DeleteShop(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllShop()
        {
            throw new NotImplementedException();
        }

        public string GetShop(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateShop(int id, string flag)
        {
            throw new NotImplementedException();
        }
    }
}
