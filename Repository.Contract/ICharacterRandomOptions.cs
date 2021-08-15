using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface ICharacterRandomOptions
    {
        // Mode for the first character
        string GetRandomModeCharacter();
        string GetFirstCharacter(int id);
        List<string> GetAllSpell();
        string SpellList(List<string> spellList);
        string UpdateCharacterOption(int id, string flag);

    }
}
