using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class PassRepository : IPassOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public PassRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }

        public bool DeletePass(int id)
        {
            throw new NotImplementedException();
        }

        public string GetPass(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdatePass(int id, string flag)
        {
            throw new NotImplementedException();
        }
    }
}
