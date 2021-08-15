
using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ObjectiveCustomRepository : IObjectiveCustomOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public ObjectiveCustomRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
    }
}
