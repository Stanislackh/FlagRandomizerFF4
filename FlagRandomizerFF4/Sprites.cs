using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagRandomizerFF4
{
    public class Sprites
    {

        // Presets Seed
        public static Dictionary<int, string> DicoSpriteSeed = new Dictionary<int, string>()
        {
           { 0, "/images/FFIVFE-Characters-5Edward-Active.png" },
           { 1, "/images/FFIVFE-Characters-1DKCecil-Active.png" },
           { 2, "/images/FFIVFE-Characters-6Rosa-Active.png" },
           { 3, "/images/FFIVFE-Characters-8Porom-Active.png" },
           { 4, "/images/FFIVFE-Characters-4Tellah-Active.png" },
           { 5, "/images/FFIVFE-Characters-3CRydia-Active.png" },
           { 6, "/images/FFIVFE-Characters-2Kain-Active.png" },
           { 7, "/images/FFIVFE-Bosses-1MistD-Color.png" },
           { 8, "/images/FFIVFE-Bosses-36Zeromus-Color.png" },
           { 9, "/images/FFIVFE-Characters-11Edge-Active.png" },
           { 10, "/images/FFIVFE-Characters-12FuSoYa-Active.png" },
           { 11, "/images/FFIVFE-Bosses-29Bahamut-Color.png" }
        };

        // Characters
        public static Dictionary<int, string> DicoSpritePersos = new Dictionary<int, string>()
        {
            // Sprites Paladin Cecil
            {1 , "images/FFIVFE-Characters-1Cecil-Inactive.png" },
            {2 , "images/FFIVFE-Characters-1Cecil-Active.png" },
            {3 , "images/FFIVFE-Characters-1Cecil-Rejected.png" },

            // Sprites Dark Knight Cecil
            {4 , "images/FFIVFE-Characters-1DKCecil-Inactive.png" },
            {5 , "images/FFIVFE-Characters-1DKCecil-Active.png" },
            {6 , "images/FFIVFE-Characters-1DKCecil-Rejected.png" },

            // Sprites Kain
            {7 , "images/FFIVFE-Characters-2Kain-Inactive.png" },
            {8 , "images/FFIVFE-Characters-2Kain-Active.png" },
            {9 , "images/FFIVFE-Characters-2Kain-Rejected.png" },

            // Sprites Rydia Adulte
            {10 , "images/FFIVFE-Characters-3CRydia-Inactive.png" },
            {11 , "images/FFIVFE-Characters-3CRydia-Active.png" },
            {12 , "images/FFIVFE-Characters-3CRydia-Rejected.png" },

            // Sprites Rydia Loli
            {13 , "images/FFIVFE-Characters-3Rydia-Inactive.png" },
            {14 , "images/FFIVFE-Characters-3Rydia-Active.png" },
            {15 , "images/FFIVFE-Characters-3Rydia-Rejected.png" },

            // Sprites Tellah
            {16 , "images/FFIVFE-Characters-4Tellah-Inactive.png" },
            {17 , "images/FFIVFE-Characters-4Tellah-Active.png" },
            {18 , "images/FFIVFE-Characters-4Tellah-Rejected.png" },

            // Sprites Edward / Gilbert
            {19 , "images/FFIVFE-Characters-5Edward-Inactive.png" },
            {20 , "images/FFIVFE-Characters-5Edward-Active.png" },
            {21 , "images/FFIVFE-Characters-5Edward-Rejected.png" },

            // Sprites Rosa
            {22 , "images/FFIVFE-Characters-6Rosa-Inactive.png" },
            {23 , "images/FFIVFE-Characters-6Rosa-Active.png" },
            {24 , "images/FFIVFE-Characters-6Rosa-Inactive.png" },

            // Sprites Yang
            {25 , "images/FFIVFE-Characters-7Yang-Inactive.png" },
            {26 , "images/FFIVFE-Characters-7Yang-Active.png" },
            {27 , "images/FFIVFE-Characters-7Yang-Rejected.png" },

            // Sprites Porom Loli
            {28 , "images/FFIVFE-Characters-8Porom-Inactive.png" },
            {29 , "images/FFIVFE-Characters-8Porom-Active.png" },
            {30 , "images/FFIVFE-Characters-8Porom-Rejected.png" },

            // Sprites Palom Shota
            {31 , "images/FFIVFE-Characters-9Palom-Inactive.png" },
            {32 , "images/FFIVFE-Characters-9Palom-Active.png" },
            {33 , "images/FFIVFE-Characters-9Palom-Rejected.png" },

            // Sprites Cid
            {34 , "images/FFIVFE-Characters-10Cid-Inactive.png" },
            {35 , "images/FFIVFE-Characters-10Cid-Active.png" },
            {36 , "images/FFIVFE-Characters-10Cid-Rejected.png" },

            // Sprites Edge
            {37 , "images/FFIVFE-Characters-11Edge-Inactive.png" },
            {38 , "images/FFIVFE-Characters-11Edge-Active.png" },
            {39 , "images/FFIVFE-Characters-11Edge-Rejected.png" },

            // Sprites Fusoya 
            {40 , "images/FFIVFE-Characters-12FuSoYa-Inactive.png" },
            {41 , "images/FFIVFE-Characters-12FuSoYa-Active.png" },
            {42 , "images/FFIVFE-Characters-12FuSoYa-Rejected.png" }
        };

        // Key items
        public static Dictionary<int, string> DicoSpriteKeyItems = new Dictionary<int, string>()
        {
            //Crystal
            {1, "images/FFIVFE-Icons-1THECrystal-Gray.png" },
            {2, "images/FFIVFE-Icons-1THECrystal-Color.png" },
            {3, "images/FFIVFE-Icons-1THECrystal-Check.png" },

            //Pass
            {4, "images/FFIVFE-Icons-2Pass-Gray.png" },
            {5, "images/FFIVFE-Icons-2Pass-Color.png" },
            {6, "images/FFIVFE-Icons-2Pass-Check.png" },

            //Hook
            {7, "images/FFIVFE-Icons-3Hook-Gray.png" },
            {8, "images/FFIVFE-Icons-3Hook-Color.png" },
            {9, "images/FFIVFE-Icons-3Hook-Check.png" },

            //Darkness
            {10, "images/FFIVFE-Icons-4DarkCrystal-Gray.png" },
            {11, "images/FFIVFE-Icons-4DarkCrystal-Color.png" },
            {12, "images/FFIVFE-Icons-4DarkCrystal-Check.png" },

            //Earth Crystal
            {13, "images/FFIVFE-Icons-5EarthCrystal-Gray.png" },
            {14, "images/FFIVFE-Icons-5EarthCrystal-Check.png" },
            {15, "images/FFIVFE-Icons-5EarthCrystal-Check.png" },

            //TwinHarp
            {16, "images/FFIVFE-Icons-6TwinHarp-Gray.png" },
            {17, "images/FFIVFE-Icons-6TwinHarp-Color.png" },
            {18, "images/FFIVFE-Icons-6TwinHarp-Check.png" },

            //Package
            {19, "images/FFIVFE-Icons-7Package-Gray.png" },
            {20, "images/FFIVFE-Icons-7Package-Color.png" },
            {21, "images/FFIVFE-Icons-7Package-Check.png" },

            //SandRuby
            {22, "images/FFIVFE-Icons-8SandRuby-Gray.png" },
            {23, "images/FFIVFE-Icons-8SandRuby-Color.png" },
            {24, "images/FFIVFE-Icons-8SandRuby-Check.png" },

            //Baron Key
            {25, "images/FFIVFE-Icons-9BaronKey-Gray.png" },
            {26, "images/FFIVFE-Icons-9BaronKey-Color.png" },
            {27, "images/FFIVFE-Icons-9BaronKey-Check.png" },

            //Magma Key
            {28, "images/FFIVFE-Icons-10MagmaKey-Gray.png" },
            {29, "images/FFIVFE-Icons-10MagmaKey-Color.png" },
            {30, "images/FFIVFE-Icons-10MagmaKey-Check.png" },

            //Tower Key
            {31, "images/FFIVFE-Icons-11TowerKey-Gray.png" },
            {32, "images/FFIVFE-Icons-11TowerKey-Color.png" },
            {33, "images/FFIVFE-Icons-11TowerKey-Check.png" },

            //Luca Key
            {34, "images/FFIVFE-Icons-12LucaKey-Gray.png" },
            {35, "images/FFIVFE-Icons-12LucaKey-Color.png" },
            {36, "images/FFIVFE-Icons-12LucaKey-Check.png" },

            //Adamant
            {37, "images/FFIVFE-Icons-13Adamant-Gray.png" },
            {38, "images/FFIVFE-Icons-13Adamant-Color.png" },
            {39, "images/FFIVFE-Icons-13Adamant-Check.png" },

            //Legend 
            {40, "images/FFIVFE-Icons-14LegendSword-Gray.png" },
            {41, "images/FFIVFE-Icons-14LegendSword-Color.png" },
            {42, "images/FFIVFE-Icons-14LegendSword-Check.png" },

            //Pan
            {43, "images/FFIVFE-Icons-15Pan-Gray.png" },
            {44, "images/FFIVFE-Icons-15Pan-Color.png" },
            {45, "images/FFIVFE-Icons-15Pan-Check.png" },

            //Spoon
            {46, "images/FFIVFE-Icons-16Spoon-Gray.png" },
            {47, "images/FFIVFE-Icons-16Spoon-Color.png" },
            {48, "images/FFIVFE-Icons-16Spoon-Check.png" },

            //Rat Tail
            {49, "images/FFIVFE-Icons-17RatTail-Gray.png" },
            {50, "images/FFIVFE-Icons-17RatTail-Color.png" },
            {51, "images/FFIVFE-Icons-17RatTail-Check.png" },

            //Pink Tail
            {52, "images/FFIVFE-Icons-18PinkTail-Gray.png" },
            {53, "images/FFIVFE-Icons-18PinkTail-Color.png" },
            {54, "images/FFIVFE-Icons-18PinkTail-Check.png" }

        };

        // Bosses
        public static Dictionary<int, string> DicoSpriteBosses = new Dictionary<int, string>()
        {
            // Mist Dragon
            {1, "images/FFIVFE-Bosses-1MistD-Gray.png" },
            {2, "images/FFIVFE-Bosses-1MistD-Color.png" },

            // Soldier
            {3, "images/FFIVFE-Bosses-2Soldier-Gray.png" },
            {4, "images/FFIVFE-Bosses-2Soldier-Color.png" },

            // Octomamm
            {5, "images/FFIVFE-Bosses-3Octo-Gray.png" },
            {6, "images/FFIVFE-Bosses-3Octo-Color.png" },

            // Antlion
            {7, "images/FFIVFE-Bosses-4Antlion-Gray.png" },
            {8, "images/FFIVFE-Bosses-4Antlion-Color.png" },

            // Waterhag
            {9, "images/FFIVFE-Bosses-5WHag-Gray.png" },
            {10, "images/FFIVFE-Bosses-5WHag-Color.png" },

            // Mom Bombo
            {11, "images/FFIVFE-Bosses-6Mombomb-Gray.png" },
            {12, "images/FFIVFE-Bosses-6Mombomb-Color.png" },

            // Fabul Gauntlet
            {13, "images/FFIVFE-Bosses-7Gauntlet-Gray.png" },
            {14, "images/FFIVFE-Bosses-7Gauntlet-Color.png" },

            // Milon
            {15, "images/FFIVFE-Bosses-8Milon-Gray.png" },
            {16, "images/FFIVFE-Bosses-8Milon-Color.png" },

            // Milon Z
            {17, "images/FFIVFE-Bosses-9MilonZ-Gray.png" },
            {18, "images/FFIVFE-Bosses-9MilonZ-Color.png" },

            // Dark Knihgt Cecil
            {19, "images/FFIVFE-Bosses-10DKCecil-Gray.png" },
            {20, "images/FFIVFE-Bosses-10DKCecil-Color.png" },

            // Baron Guards
            {21, "images/FFIVFE-Bosses-11Guards-Gray.png" },
            {22, "images/FFIVFE-Bosses-11Guards-Color.png" },

            // Karate (Yang)
            {23, "images/FFIVFE-Bosses-12Yang-Gray.png" },
            {24, "images/FFIVFE-Bosses-12Yang-Color.png" },

            // Baigan
            {25, "images/FFIVFE-Bosses-13Baigan-Gray.png" },
            {26, "images/FFIVFE-Bosses-13Baigan-Color.png" },

            // Kainazzo
            {27, "images/FFIVFE-Bosses-14Kainazzo-Gray.png" },
            {28, "images/FFIVFE-Bosses-14Kainazzo-Color.png" },

            // Dark Elf
            {29, "images/FFIVFE-Bosses-15DElf-Gray.png" },
            {30, "images/FFIVFE-Bosses-15DElf-Color.png" },

            // Magus Sisters
            {31, "images/FFIVFE-Bosses-16MagusSis-Gray.png" },
            {32, "images/FFIVFE-Bosses-16MagusSis-Color.png" },

            // Valvalis
            {33, "images/FFIVFE-Bosses-17Valvalis-Gray.png" },
            {34, "images/FFIVFE-Bosses-17Valvalis-Color.png" },

            // Calcabrina
            {35, "images/FFIVFE-Bosses-18Calcabrina-Gray.png" },
            {36, "images/FFIVFE-Bosses-18Calcabrina-Color.png" },

            // Golbez
            {37, "images/FFIVFE-Bosses-19Golbez-Gray.png" },
            {38, "images/FFIVFE-Bosses-19Golbez-Color.png" },

            // Lugae & Balnab
            {39, "images/FFIVFE-Bosses-20Lugae-Gray.png" },
            {40, "images/FFIVFE-Bosses-20Lugae-Color.png" },

            // King & Queen Eblan
            {41, "images/FFIVFE-Bosses-21Eblan-Gray.png" },
            {42, "images/FFIVFE-Bosses-21Eblan-Color.png" },

            // Rubicant
            {43, "images/FFIVFE-Bosses-22Rubicante-Gray.png" },
            {44, "images/FFIVFE-Bosses-22Rubicante-Color.png" },

            // Evil Wall
            {45, "images/FFIVFE-Bosses-23EvilWall-Gray.png" },
            {46, "images/FFIVFE-Bosses-23EvilWall-Color.png" },

            // Elements (4 Fiends)
            {47, "images/FFIVFE-Bosses-24Fiends-Gray.png" },
            {48, "images/FFIVFE-Bosses-24Fiends-Color.png" },

            // CPU 
            {49, "images/FFIVFE-Bosses-25CPU-Gray.png" },
            {50, "images/FFIVFE-Bosses-25CPU-Color.png" },

            // Odin
            {51, "images/FFIVFE-Bosses-26Odin-Gray.png" },
            {52, "images/FFIVFE-Bosses-26Odin-Color.png" },

            // Asura
            {53, "images/FFIVFE-Bosses-27Asura-Gray.png" },
            {54, "images/FFIVFE-Bosses-27Asura-Color.png" },

            // Leviathan
            {55, "images/FFIVFE-Bosses-28Leviath-Gray.png" },
            {56, "images/FFIVFE-Bosses-28Leviath-Color.png" },

            // Bahamut
            {57, "images/FFIVFE-Bosses-29Bahamut-Gray.png" },
            {58, "images/FFIVFE-Bosses-29Bahamut-Color.png" },

            // Pale Dim
            {59, "images/FFIVFE-Bosses-30PaleDim-Gray.png" },
            {60, "images/FFIVFE-Bosses-30PaleDim-Color.png" },

            // Lunar Dragons
            {61, "images/FFIVFE-Bosses-31LunarD-Gray.png" },
            {62, "images/FFIVFE-Bosses-31LunarD-Color.png" },

            // Plague
            {63, "images/FFIVFE-Bosses-32Plague-Gray.png" },
            {64, "images/FFIVFE-Bosses-32Plague-Color.png" },

            // Ogopogo
            {65, "images/FFIVFE-Bosses-33Ogopogo-Gray.png" },
            {66, "images/FFIVFE-Bosses-33Ogopogo-Color.png" },

            // Wyvern
            {67, "images/FFIVFE-Bosses-34Wyvern-Gray.png" },
            {68, "images/FFIVFE-Bosses-34Wyvern-Color.png" },

            // Dark imps
            {69, "images/FFIVFE-Bosses-35DarkImps-Gray.png" },
            {70, "images/FFIVFE-Bosses-35DarkImps-Color.png" },

            // Zeromus
            {71, "images/FFIVFE-Bosses-36Zeromus-Gray.png" },
            {72, "images/FFIVFE-Bosses-36Zeromus-Color.png" }
        };

    }
}
