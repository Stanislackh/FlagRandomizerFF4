using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class EncounterToggleRepository : IEncounterToggleOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public EncounterToggleRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }

        public string CreateEncounter()
        {
            throw new NotImplementedException();
        }

        public bool DeleteEncounter(int id)
        {
            throw new NotImplementedException();
        }

        public string GetEncounter(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateEncounter()
        {
            throw new NotImplementedException();
        }
    }
}
