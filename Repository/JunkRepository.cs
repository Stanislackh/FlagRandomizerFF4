using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class JunkRepository : IJunkOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public JunkRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
        public string CreateJunk(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJunk(int id)
        {
            throw new NotImplementedException();
        }

        public string GetJunk(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateJunk(int id)
        {
            throw new NotImplementedException();
        }
    }
}
