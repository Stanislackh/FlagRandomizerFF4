using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface ISparseOption
    {
        string GetSparse(int id);
        string UpdateSparse();

        bool DeleteSparse();
    }
}
