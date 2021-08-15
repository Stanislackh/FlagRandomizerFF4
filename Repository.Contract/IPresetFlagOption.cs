using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IPresetFlagOption
    {
        string GetPreset(int id);
        string CreatePreset(int id, string flag);

        string UpdatePreset(int id, string flag);

        bool DeletePreset(int id);

    }
}
