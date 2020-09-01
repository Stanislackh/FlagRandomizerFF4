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
            {1," Kmain" },
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
            {49, "quest_mistcave" },
            {50, "quest_waterfall" },
            {51, "quest_antlionnest" },
            {52, "quest_hobs" },
            {53, "quest_fabul" },
            {54, "quest_ordeals" },
            {55, "quest_baroninn" },
            {56, "quest_baroncastle" },
            {57, "quest_lowerbabil" },
            {58, "quest_falcon" },
            {59, "quest_sealedcave" },
            {60, "quest_monsterqueen" },
            {61, "quest_monsterking" },
            {62, "quest_baronbasement" },
            {63, "quest_giant" },
            {64, "quest_cavebahamut" },
            {65, "quest_murasamealtar" },
            {66, "quest_crystalaltar" },
            {67, "quest_whitealtar" },
            {68, "quest_ribbonaltar" },
            {69, "quest_masamunealtar" },
            {70, "quest_burnmist" },
            {71, "quest_curefever" },
            {72, "quest_unlocksewer" },
            {73, "quest_music" },
            {74, "quest_toroiatreasury" },
            {75, "quest_magma" },
            {76, "quest_supercanon" },
            {77, "quest_unlocksealedcave" },
            {78, "quest_bigwhale" },
            {79, "quest_traderat" },
            {80, "quest_forge" },
            {81, "quest_wakeyang" },
            {82, "quest_tradepan" },
            {83, "quest_tradepink" },
            {84, "quest_pass" }
        };

        //Les objets clés
        public static Dictionary<int, string> DicoKeyItem { get; } = new Dictionary<int, string>()
        {
            { 1,"summon"},
            { 2,"key"},
            { 3,"chest"}
        };

        //Options Pass 
        public static Dictionary<int, string> DicoPass { get; } = new Dictionary<int, string>()
        {
            {1, "shop" },
            {2, "key" },
            {3, "chest" }
        };

        //Randomisation des personnages
        public static Dictionary<int, string> DicoCharacterRand { get; } = new Dictionary<int, string>()
        {
            {1, "standard" },
            {2, "relaxed" },
            {3, "vanilla" }
        };

        //Personnage du début
        public static Dictionary<int, string> DicoCharacterStart { get; } = new Dictionary<int, string>()
        {
            {1, "start:cecil"},
            {2, "start:kain"},
            {3, "start:rydia"},
            {4, "start:tellah"},
            {5, "start:edward"},
            {6, "start:rosa"},
            {7, "start:yang"},
            {8, "start:palom"},
            {9, "start:porom"},
            {10, "start:cid"},
            {11, "start:edge"},
            {12, "start:fusoya"}
        };

        //Sorts des personnages
        public static Dictionary<int, string> DicoCharacterSpell { get; } = new Dictionary<int, string>()
        {
            {1,"j:spells" },
            {2,"j:abilities" },
            {3,"nodupes" },
            {4,"bye" },
            {5,"permajoin" }
        };

        //Les trésors
        public static Dictionary<int, string> DicoTreasure { get; } = new Dictionary<int, string>()
        {
            {1, "shuffle" },
            {2, "standard" },
            {3, "pro" },
            {4, "wild" },
            {5, "wildish" }
        };

        //Garder les objets pourris
        public static Dictionary<int, string> DicoTreasureOption { get; } = new Dictionary<int, string>()
        {
            {1,"no:j" },
            {2,"junk" }
        };

        //Les magasins
        public static Dictionary<int, string> DicoShop { get; } = new Dictionary<int, string>()
        {
            {1,"shuffle" },
            {2,"standard" },
            {3,"pro" },
            {4,"wild" },
            {5,"cabins" },
        };

        //Options des magasins
        public static Dictionary<int, string> DicoShopOptions { get; } = new Dictionary<int, string>()
        {
            {1,"free" },
            {2,"quarter" },
            {3,"no:j" },
            {4,"no:apples" },
            {5,"no:sirens" }
        };

        //Les boss
        public static Dictionary<int, string> DicoBossWyvern { get; } = new Dictionary<int, string>()
        {
            {1,"whyburn" },
            {2,"whichburn" }

        };

        //Les challenges
        public static Dictionary<int, string> DicoChallenge { get; } = new Dictionary<int, string>()
        {
            {1,"chars" },
            {2,"key" },
            {3,"bosses" }
        };

        //Les combats
        public static Dictionary<int, string> DicoEncounterToggle { get; } = new Dictionary<int, string>()
        {
            {1,"kep:doors" },
            {2,"kep:behemoths" },
            {3,"danger" }
        };

        //Les drops des combats
        public static Dictionary<int, string> DicoEncounterDrop { get; } = new Dictionary<int, string>()
        {
            {1,"no:sirens" },
            {2,"no:jdrops" }
        };

        //Les glitchs
        public static Dictionary<int, string> DicoGlitch { get; } = new Dictionary<int, string>()
        {
            {1,"dupe" },
            {2,"mp" },
            {3,"warp" },
            {4,"life" },
            {5,"64" }
        };

        //Autres
        public static Dictionary<int, string> DicoOtherStarter { get; } = new Dictionary<int, string>()
        {
            {1,"basic" },
            {2,"better" },
            {3,"loaded" },
            {4,"spitball" }
        };

        public static Dictionary<int, string> DicoOther { get; } = new Dictionary<int, string>()
        {
            {1,"-noadamants" },
            {2,"-spoon" }
        };
    }
}
