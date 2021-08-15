using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IBossesOptions
    {
        string GetBoss(int id);
        bool DeleteBoss(int id);
        bool UpdateBoss(IBossesOptions bosses);
    }
}
