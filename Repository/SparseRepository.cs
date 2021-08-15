using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class SparseRepository : ISparseOption
    {
        private readonly FlagContextDB _flagContextDB;

        public SparseRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
        public bool DeleteSparse()
        {
            throw new NotImplementedException();
        }

        public string GetSparse(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateSparse()
        {
            throw new NotImplementedException();
        }
    }
}
