using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class ChestRepository : IChestOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public ChestRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }

        public bool DeleteTreasure(int id)
        {
            throw new NotImplementedException();
        }

        public string GetAllTreasures()
        {
            throw new NotImplementedException();
        }

        public string GetTreasure(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateTreasure(int id, string flag)
        {
            throw new NotImplementedException();
        }
    }
}
