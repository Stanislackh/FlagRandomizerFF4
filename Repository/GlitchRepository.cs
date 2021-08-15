using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class GlitchRepository : IGlitchOptions
    {

        private readonly FlagContextDB _flagContextDB;

        public GlitchRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }

        public string CreateGlitch(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGlitch()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllGlitches()
        {
            throw new NotImplementedException();
        }

        public string UpdateGlitch()
        {
            throw new NotImplementedException();
        }
    }
}
