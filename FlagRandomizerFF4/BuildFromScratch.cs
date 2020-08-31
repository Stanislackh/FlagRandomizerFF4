using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagRandomizerFF4
{
    //Liste de toutes les options possible
    public class BuildFromScratch
    {
        //Prefixes
        public static Dictionary<int, string> DicoPrefixes { get; } = new Dictionary<int, string>()
        {
            {1," K" },
            {2," P" },
            {3," C" },
            {4," T" },
            {5," S" },
            {6," B" },
            {7," N" },
            {8," Etoggle" },
            {9," G" }
        };

        //Les objectifs principaux
        public static Dictionary<int, string> DicoObjectiveMode { get; } = new Dictionary<int, string>()
        {
            {1, "classicforge" },
            {2, "classicgiant" },
            {3, "fiends" },
            {4, "dkmatter" }
        };

        //Les objectifs personnalisés
        public static Dictionary<int, string> DicoObjectiveCustom { get; } = new Dictionary<int, string>()
        {
            {1, "none" },
            {2, "char_cecil" },
            {3, "char_kain" },
            {4, "char_porom" },
            {5, "char_palom" },
            {6, "char_rosa" },
            {7, "char_cid" },
            {8, "char_edward" },
            {9, "char_rydia" },
            {10, "char_fusoya" },
            {11, "char_edge" },
            {12, "char_tellah" },
            {13, "char_yang" },
            {14, "boss_dmist" },
            {15, "boss_officer" },
            {16, "boss_octomamm" },
            {17, "boss_antlion" },
            {18, "boss_waterhag" },
            {19, "boss_mombomb" },
            {20, "boss_fabulgauntlet" },
            {21, "boss_milon" },
            {22, "boss_milonz" },
            {23, "boss_mirrorcecil" },
            {24, "boss_guard" },
            {25, "boss_karate" },
            {26, "boss_baigan" },
            {27, "boss_kainazzo" },
            {28, "boss_darkelf" },
            {29, "boss_magus" },
            {30, "boss_valvalis" },
            {31, "boss_calbrena" },
            {32, "boss_golbez" },
            {33, "boss_lugae" },
            {34, "boss_darkimp" },
            {35, "boss_kingqueen" },
            {36, "boss_rubicant" },
            {37, "boss_evilwall" },
            {38, "boss_asura" },
            {39, "boss_leviathan" },
            {40, "boss_odin" },
            {41, "boss_bahamut" },
            {42, "boss_elements" },
            {43, "boss_cpu" },
            {44, "boss_paledim" },
            {45, "boss_wyvern" },
            {46, "boss_plague" },
            {47, "boss_dlunar" },
            {48, "boss_ogopogo" },
            {49, "" },
            {50, "" },
            {51, "" },
            {52, "" },
            {53, "" },
            {54, "" },
            {55, "" },
            {56, "" },
            {57, "" },
            {58, "" },
            {59, "" },
            {60, "" },
            {61, "" },
            {62, "" },
            {63, "" },
            {64, "" },
            {65, "" },
            {66, "" },
            {67, "" },
            {68, "" },
            {69, "" },
            {70, "" },
            {71, "" },
            {72, "" },
            {73, "" },
            {74, "" },
            {75, "" },
            {76, "" },
            {77, "" },
            {78, "" },
            {79, "" },
            {80, "" },
            {81, "" },
            {82, "" },
            {83, "" },
            {84, "" },

            {20, "" },
            {10, "" },
        };
    }
}
