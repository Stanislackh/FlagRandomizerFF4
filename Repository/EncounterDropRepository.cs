using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class EncounterDropRepository : IEncounterDropOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public EncounterDropRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
    }
}
