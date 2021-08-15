using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contract
{
    public interface IGlitchOptions
    {
        List<string> GetAllGlitches();
        string UpdateGlitch();
        bool DeleteGlitch();
        string CreateGlitch(int id);
    }
}
