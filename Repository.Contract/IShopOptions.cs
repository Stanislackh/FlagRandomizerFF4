using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IShopOptions

    {
        List<string> GetAllShop();
        string GetShop(int id);
        string UpdateShop(int id, string flag);
        bool DeleteShop(int id);
    }
}
