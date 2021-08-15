using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class PresetFlagRepository : IPresetFlagOption
    {
        private readonly FlagContextDB _flagContextDB;

        public PresetFlagRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
        public string CreatePreset(int id, string flag)
        {
            throw new NotImplementedException();
        }

        public bool DeletePreset(int id)
        {
            throw new NotImplementedException();
        }

        public string GetPreset(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdatePreset(int id, string flag)
        {
            throw new NotImplementedException();
        }
    }
}
