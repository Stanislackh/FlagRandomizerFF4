using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IOtherOptions
    {
        string GetOther(int id);
        string UpdateOther(int id, string flag);
        bool DeleteOther(int id);
    }
}
