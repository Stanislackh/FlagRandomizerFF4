using Entities;
using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BossesRepository : IBossesOptions
    {

        private readonly FlagContextDB flagContextDB;

        public BossesRepository(FlagContextDB _flagContextDB)
        {
            flagContextDB = _flagContextDB;
        }

        public bool DeleteBoss(int id)
        {
            throw new NotImplementedException();
        }

        public string GetBoss(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBoss(IBossesOptions bosses)
        {
            throw new NotImplementedException();
        }
    }
}
