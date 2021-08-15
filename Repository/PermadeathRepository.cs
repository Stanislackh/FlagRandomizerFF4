using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class PermadeathRepository : IPermadethOption
    {
        private readonly FlagContextDB _flagContextDB;

        public PermadeathRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
        public string GetPermadeth(int id)
        {
            throw new NotImplementedException();
        }
    }
}
