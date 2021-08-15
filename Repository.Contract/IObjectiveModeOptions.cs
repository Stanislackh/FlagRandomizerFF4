using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IObjectiveModeOptions
    {
        //Alea Objective Mode
        string GetAleaObjectiveMode(int id);
        string CreateObjectiveMode(int id, string flag);
        string UpdateObjectiveMode(int id, string flag);
        bool DeleteObjectiveMode();

        //Custom Objective
        string GetCustomObjective(int id);
        string CreateObjective(int id, string flag);
        string UpdateObjective(int id, string flag);
        bool DeleteObjective(int id);

        //Random Objective
        string GetRandomObjective(int id);

        //Reward
        string GetRewardObjective(int id);
    }
}
