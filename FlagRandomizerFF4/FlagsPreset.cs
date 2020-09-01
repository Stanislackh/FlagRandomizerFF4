using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagRandomizerFF4
{
    public class FlagsPreset
    {
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
