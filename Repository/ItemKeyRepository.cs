using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class ItemKeyRepository : IItemKeyOptions
    {

        private readonly FlagContextDB _flagContextDB;

        public ItemKeyRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
        public string CreateItemKey(int id, string flag)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItemKey()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllListKey()
        {
            throw new NotImplementedException();
        }

        public string UpdateItemKey(int id, string flag)
        {
            throw new NotImplementedException();
        }
    }
}
