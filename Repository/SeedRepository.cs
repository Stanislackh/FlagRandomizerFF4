using Entities;
using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class SeedRepository : ISeedOption
    {
        private FlagContextDB _flagContextDB;

        public SeedRepository(FlagContextDB flagContextDB)
        {
            _flagContextDB = flagContextDB;
        }
        private Dictionary<string, string> listePreset { get; set; } = new Dictionary<string, string>();
        public void AddDicoInDB()
        {
            //Bosses
            foreach (var item in ScriptSql.DicoBossWyvern)
            {
                Boss boss = new Boss();
                boss.Flag = item.Value;

                _flagContextDB.Bosses.Add(boss);
                _flagContextDB.SaveChanges();
            }

            //Character
            foreach (var item in ScriptSql.DicoCharacterRand)
            {
                CharacterRandom character = new CharacterRandom();
                //remplir
            }

            foreach (var item in ScriptSql.DicoCharacterStart)
            {
                CharacterStart character = new CharacterStart();
                //remplir
            }

            foreach (var item in ScriptSql.DicoCharacterSpell)
            {
                CharacterRandom character = new CharacterRandom();
                //remplir
            }

            //Chest
            foreach (var item in ScriptSql.DicoTreasure)
            {
                Chest chest = new Chest();
                //Remplir
            }

            //Junk
            foreach (var item in ScriptSql.DicoTreasureOption)
            {
                Junk junk = new Junk();
                //Remplir
            }

            //Encounter
            foreach (var item in ScriptSql.DicoEncounterToggle)
            {
                EncounterToggle encounter = new EncounterToggle();
                //remplir

            }

            foreach (var item in ScriptSql.DicoEncounterDrop)
            {
                EncounterDrop encounter = new EncounterDrop();
                //Remplir
            }

            //Glitch
            foreach (var item in ScriptSql.DicoGlitch)
            {
                Glitch glitch = new Glitch();
                //Remplir
            }

            //ItemKey
            ItemKey itemKey = new ItemKey();
            itemKey.Flag = "Kmain";

            _flagContextDB.ItemKeys.Add(itemKey);
            _flagContextDB.SaveChanges();

            //Objective
            foreach (var item in ScriptSql.DicoObjectiveMode)
            {
                ObjectiveMode objectiveMode = new ObjectiveMode();
                //remplir
            }

            foreach (var item in ScriptSql.DicoObjectiveCustom)
            {
                ObjectiveCustom objectivevCustom = new ObjectiveCustom();
            }

            //Other
            foreach (var item in ScriptSql.DicoOther)
            {
                Other other = new Other();
                //Remplir
            }

            foreach (var item in ScriptSql.DicoOtherStarter)
            {
                OtherStarter otherStarter = new OtherStarter();
                //Remplir
            }

            //Permadeath
            foreach (var item in ScriptSql.DicoPermadeath)
            {
                Permadeath permadeath = new Permadeath();
                //Remplir
            }
            
            //PresetFlag
            foreach (var item in ScriptSql.DicoNomFlag)
            {
                PresetFlag presetFlag = new PresetFlag();
                //presetFlag.Id = item.Key;
                presetFlag.Libelle = item.Value;

                foreach (var elem in ScriptSql.DicoFlag)
                {
                    if (presetFlag.Libelle == elem.Key)
                    {
                        presetFlag.Flag = elem.Value;
                    }
                }

                _flagContextDB.Add(presetFlag);
                _flagContextDB.SaveChanges();
            }

            //Shop
            foreach (var item in ScriptSql.DicoShop)
            {
                Shop shop = new Shop();
                //Remplir
            }

            //Sparse
            foreach (var item in ScriptSql.DicoShopOptions)
            {
                Sparse sparse = new Sparse();
                //remplir
            }

            //Prefixes
            foreach (var item in ScriptSql.DicoPrefixes)
            {
                Prefixe prefixe = new Prefixe();
                //remplir
            }
        }
    }
    //Liste de toutes les options possible
    public class ScriptSql
    {

        //Permadeath option
        public static Dictionary<int, string> DicoPermadeath = new Dictionary<int, string>()
        {
            {1,"permadeath" },
            {2, "permadeader" }
        };

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
        //Dictionnaire des Presets
        public static Dictionary<int, string> DicoNomFlag { get; } = new Dictionary<int, string>()
        {
            { 0 , "DARK SIZE MATTER" },
            { 1 , "BLACK OR WHITE" },
            { 2 , "LUCKY OR NOT" },
            { 3 , "SLACKH'S DREAM" },
            { 4 , "TATE NO YUUSHA" },
            { 5 , "RUN FOR THE LALAS" },
            { 6 , "DRAGON HUNTER" },
            { 7 , "KILL THE RELATIVES" },
            { 8 , "BOSS RUSH" },
            { 9 , "FAZE EZ AS FUCK" },
            { 10, "RUN FOR YOUR BOOTY" },
        };

        //Dictionnaire du contenu des Presets
        public static Dictionary<string, string> DicoFlag { get; } = new Dictionary<string, string>()
        {
            {"DARK SIZE MATTER", "Omode:dkmatter/win:game Kmain/summon/moon Pkey Cstandard/maybe/start:edward/only:tellah,edward,yang,palom,porom,cid/j:spells,abilities Tstandard/sparse:50 Sstandard Bstandard/alt:gauntlet/whichburn Nchars/key Etoggle/danger Gdupe/life -kit:better" },
            {"BLACK OR WHITE", "Omode:classicgiant/win:game Kmain Pshop Crelaxed/maybe/only:cecil/j:spells,abilities/permajoin Tstandard Sstandard Bstandard/alt:gauntlet/whichburn Nchars/key Etoggle Gdupe/warp/life -kit:better"},
            {"LUCKY OR NOT", "Orandom:5/win:crystal Kmain/summon/moon Pkey Cstandard/maybe/start:rydia/only:cecil,kain,rydia,rosa,edge,fusoya/j:spells,abilities/permajoin Tstandard/sparse:90 Sstandard Bstandard/alt:gauntlet Nchars/key Etoggle/keep:behemoths Gdupe/warp/life -kit:better"},
            {"SLACKH'S DREAM", "Omode:classicgiant/win:crystal Kmain/moon Pkey Crelaxed/maybe/only:porom/j:spells,abilities/permajoin Tstandard Sstandard/free Bstandard/alt:gauntlet/whichburn Nchars/key Etoggle Gdupe/warp/life -kit:better" },
            {"TATE NO YUUSHA", "Omode:classicforge/win:crystal Kmain/moon Pkey Cstandard/maybe/start:tellah/only:rydia,palom,porom/j:spells,abilities/permajoin Tstandard/sparse:70 Sstandard Bstandard/alt:gauntlet/whichburn Nchars/key Etoggle Gdupe/warp/life -kit:better"},
            {"RUN FOR THE LALAS", "O1:quest_dwarfcastle/win:game Kmain Pshop Crelaxed/maybe/start:rosa/only:edge/j:spells,abilitiesTstandard Sstandard/freeBstandard/whyburn Nnone Etoggle Gdupe/warp/life -kit:better" },
            {"DRAGON HUNTER", "O1:boss_dmist/2:boss_darkelf/3:boss_bahamut/4:boss_paledim/5:boss_wyvern/6:boss_dlunar/win:game Kmain Pnone Crelaxed/maybe/start:kain/j:spells,abilities Twild Swild Bstandard/alt:gauntlet/whichburn Nchars/key Etoggle Gdupe/warp/life -kit:better -spoon" },
            {"KILL THE RELATIVES", "O1:boss_dmist/2:boss_mirrorcecil/3:boss_golbez/4:boss_kingqueen/win:crystal Kmain/summon/moon Pkey Cstandard/start:rydia/only:cecil,kain,rydia,rosa,edge/ j:spells,abilities/nodupes Twild Swild Bstandard/unsafe/alt:gauntlet/whichburn Nnone Etoggle Gwarp/life -kit:better" },
            {"BOSS RUSH", "Omode:fiends/1:boss_calbrena/2:boss_golbez/3:boss_wyvern/4:boss_plague/5:boss_dlunar/6:boss_odin/7:boss_evilwall/8:boss_mirrorcecil/win:crystal Kmain/summon/moon Pkey Cstandard/maybe/j:spells,abilities/nodupes Twildish Swild/quarter Bstandard/alt:gauntlet/whichburn Nkey Etoggle Gdupe/mp/warp/life -kit:spitball -spoon"},
            {"FAZE EZ AS FUCK","Omode:classicgiant/win:game Kmain Pshop Crelaxed/maybe/start:fusoya/only:cecil,kain,rydia,rosa,porom,edge,fusoya/j:spells,abilities Tstandard Sstandard/free Bstandard/alt:gauntlet/whichburn Nnone Etoggle Gdupe/warp/life -kit:better"},
            {"RUN FOR YOUR BOOTY", "Omode:classicforge/win:crystal Kmain/trap Pshop Crelaxed/maybe/start:edge/only:cecil,kain,rydia,rosa,edge,fusoya/ j:spells,abilities/permadeath Tstandard/sparse:90 Sstandard Bstandard/alt:gauntlet/whichburn Nchars/key Etoggle/keep:doors,behemoths/danger Gdupe/life -kit:better"},
        };
    }
}
