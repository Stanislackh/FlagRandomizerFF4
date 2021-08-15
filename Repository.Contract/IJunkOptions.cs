using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IJunkOptions
    {
        string CreateJunk(int id);
        string UpdateJunk(int id);
        bool DeleteJunk(int id);
        string GetJunk(int id);

    }
}
