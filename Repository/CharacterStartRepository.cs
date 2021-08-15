using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CharacterStartRepository : ICharacterStartOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public CharacterStartRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
    }
}
