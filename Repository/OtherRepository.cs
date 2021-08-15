using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class OtherRepository : IOtherOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public OtherRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
        public bool DeleteOther(int id)
        {
            throw new NotImplementedException();
        }

        public string GetOther(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateOther(int id, string flag)
        {
            throw new NotImplementedException();
        }
    }
}
