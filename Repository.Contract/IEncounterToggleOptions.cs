using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IEncounterToggleOptions
    {
        string GetEncounter(int id);
        string CreateEncounter();
        string UpdateEncounter();
        bool DeleteEncounter(int id);
    }
}
