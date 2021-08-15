using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IChestOptions
    {
        string GetAllTreasures();
        string GetTreasure(int id);
        string UpdateTreasure(int id, string flag);
        bool DeleteTreasure(int id);
    }
}
