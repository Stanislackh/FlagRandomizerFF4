using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contract;

namespace Repository
{
    public class ObjectiveModeRepository : IObjectiveModeOptions
    {
        private readonly FlagContextDB _flagContextDB;

        public ObjectiveModeRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }

        public string CreateObjective(int id, string flag)
        {
            throw new NotImplementedException();
        }

        public string CreateObjectiveMode(int id, string flag)
        {
            throw new NotImplementedException();
        }

        public bool DeleteObjective(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteObjectiveMode()
        {
            throw new NotImplementedException();
        }

        public string GetAleaObjectiveMode(int id)
        {
            throw new NotImplementedException();
        }

        public string GetCustomObjective(int id)
        {
            throw new NotImplementedException();
        }

        public string GetRandomObjective(int id)
        {
            throw new NotImplementedException();
        }

        public string GetRewardObjective(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateObjective(int id, string flag)
        {
            throw new NotImplementedException();
        }

        public string UpdateObjectiveMode(int id, string flag)
        {
            throw new NotImplementedException();
        }
    }
}
