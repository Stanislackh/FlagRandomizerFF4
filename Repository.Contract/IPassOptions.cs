using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IPassOptions
    {
        string GetPass(int id);
        bool DeletePass(int id);
        string UpdatePass(int id, string flag);
    }
}
