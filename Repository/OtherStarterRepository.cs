using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class OtherStarterRepository : IOtherStarterOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public OtherStarterRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
    }
}
