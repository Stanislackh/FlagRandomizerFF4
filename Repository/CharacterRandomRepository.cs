using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class CharacterRandomRepository : ICharacterRandomOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public CharacterRandomRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }

        public List<string> GetAllSpell()
        {
            throw new NotImplementedException();
        }

        public string GetFirstCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public string GetRandomModeCharacter()
        {
            throw new NotImplementedException();
        }

        public string SpellList(List<string> spellList)
        {
            throw new NotImplementedException();
        }

        public string UpdateCharacterOption(int id, string flag)
        {
            throw new NotImplementedException();
        }
    }
}
