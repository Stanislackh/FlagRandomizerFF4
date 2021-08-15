using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IItemKeyOptions
    {
        List<string> GetAllListKey();
        string CreateItemKey(int id, string flag);

        string UpdateItemKey(int id, string flag);

        bool DeleteItemKey();
    }
}
