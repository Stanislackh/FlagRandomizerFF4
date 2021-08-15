using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlagRandomizerFF4
{
    //Pour la version 4.1.0
    public class RandomizerMethods
    {
        public string SuperFlag { get; set; }
        public bool SiteOpen { get; set; }

        //Initialise les nombres aléatoire
        private Random Rnd = new Random();

        //Méthode pour copier dans le presse papier
        public void CopierFlag(string FlagFinal)
        {
            Clipboard.Clear();
            Clipboard.SetText(FlagFinal);

            //Ouvre la page pour entrer le flag
            if (!SiteOpen)
            {
                Process.Start("http://ff4fe.com/make");
                SiteOpen = true;
            }
        }

        //Méthode pour choisir le flag
        public void ChoixFlag(int numeroFlag)
        {
            CopierFlag(FlagsPreset.DicoFlag[FlagsPreset.DicoNomFlag[numeroFlag]]);
        }

        //Choix seed prédéfinie
        public int PresetFlag()
        {
            int Chiffre = Rnd.Next(0, 10);

            if (Chiffre == 0) //Echec
            {
                Chiffre = Rnd.Next(0, 6);
                if (Chiffre == 0) //Echec critique pire preset
                {
                    ChoixFlag(Chiffre);
                }
                else //On limite la casse
                {
                    ChoixFlag(10);
                }
            }

            if (Chiffre == 5) //Réussite
            {
                Chiffre = Rnd.Next(0, 7);
                if (Chiffre == 5) //Réussite critique meilleur preset
                {
                    ChoixFlag(Chiffre);
                }
                else //Bien aussi
                {
                    ChoixFlag(9);
                }
            }

            //Sinon
            ChoixFlag(Chiffre);

            return Chiffre;
        }

        //Objectifs 
        public void RandObjective()
        {
            //Objective mode
            int alea = Rnd.Next(0, 5);
            if (alea == 0)
            {
                SuperFlag += "Onone";
            }
            else if (alea == 4)
            {
                int alea2 = Rnd.Next(1, 21);
                if (alea2 != 4)
                {
                    alea = Rnd.Next(1, 4);
                    AleaObjectiveMode(alea);
                }
                else
                {
                    AleaObjectiveMode(alea2);
                }
            }
            else
            {
                AleaObjectiveMode(alea);
            }

            //Custom Objective
            int custom = Rnd.Next(0, 9);

            if (custom != 0)
            {
                CustomObjective(custom);
            }

            //Random objective
            int random = Rnd.Next(0, 6);

            if (random != 0)
            {
                RandomObjective(random);
            }

            //Reward
            if (random != 0 || custom != 0)
            {
                if (alea == 1)
                {
                    RewardObjective(alea);
                }
                else
                {
                    RewardObjective(2);
                }
            }
        }

        //Règle finale de complétion
        private void RewardObjective(int alea)
        {
            if (alea == 1)
            {
                SuperFlag += "/win:crystal";
            }
            else
            {
                SuperFlag += "/win:game";
            }
        }

        //Les objectifs aléatoire
        private void RandomObjective(int random)
        {
            if (SuperFlag == "Onone")
            {
                SuperFlag = "O";
            }
            else
            {
                SuperFlag += "/";
            }

            SuperFlag += "random" + Convert.ToString(random);
        }

        //Les objectifs customs choisis aléatoirement
        private void CustomObjective(int custom)
        {
            int taille = BuildFromScratch.DicoObjectiveCustom.Count();
            List<string> ListeCustom = new List<string>();

            if (SuperFlag == "Onone")
            {
                SuperFlag = "O";
            }
            else
            {
                SuperFlag += "/";
            }

            //Construction de la liste d'objectifs
            while (ListeCustom.Count != custom)
            {
                int rand2 = Rnd.Next(2, taille + 1);
                bool dansListe = false;

                //Regarde si l'élément est dans la liste
                foreach (var item in ListeCustom)
                {
                    if (BuildFromScratch.DicoObjectiveCustom[rand2] == item)
                    {
                        dansListe = true;
                    }
                }

                //Ajoute à la liste si non présent
                if (dansListe != true)
                {
                    ListeCustom.Add(BuildFromScratch.DicoObjectiveCustom[rand2]);
                }
            }

            //Si un seul objectif
            if (custom == 1)
            {
                SuperFlag += Convert.ToString(1) + ":" + ListeCustom[custom - 1];
            }
            else //Si plusieurs objectifs
            {
                for (int i = 0; i < ListeCustom.Count(); i++)
                {
                    SuperFlag += Convert.ToString(i + 1) + ":";
                    SuperFlag += ListeCustom[i];

                    if (i + 1 != ListeCustom.Count())
                    {
                        SuperFlag += "/";
                    }
                }
            }
        }

        //Les modes de jeu choisis aléatoirement
        private void AleaObjectiveMode(int alea)
        {
            if (alea == 4)
            {
                int alea2 = Rnd.Next(1, 21);
                if (alea2 != 4)
                {
                    alea = Rnd.Next(1, 4);
                }
            }

            SuperFlag = "Omode:";
            int maxObjectiveMode = BuildFromScratch.DicoObjectiveMode.Count();
            List<string> listeObjectif = new List<string>();

            if (alea == maxObjectiveMode)
            {
                foreach (var item in BuildFromScratch.DicoObjectiveMode)
                {
                    listeObjectif.Add(item.Value);
                }
            }
            else
            {
                while (listeObjectif.Count() != alea)
                {
                    int rand2 = Rnd.Next(2, maxObjectiveMode + 1);
                    if (rand2 == 4)
                    {
                        rand2 = Rnd.Next(1, 31);
                        if (rand2 != 8)
                        {
                            rand2 = Rnd.Next(1, 4);
                        }
                    }

                    bool dansListe = false; //Réinitialise avant de reparcourir la liste
                    foreach (var item in listeObjectif)
                    {
                        if (BuildFromScratch.DicoObjectiveMode[rand2] == item)
                        {
                            dansListe = true;
                            break;
                        }
                    }

                    //Ajoute si pas dans la liste
                    if (dansListe == false)
                    {
                        listeObjectif.Add(BuildFromScratch.DicoObjectiveMode[rand2]);
                    }
                }

                //Ajoute la liste des objectifs au SuperFlag
                for (int i = 0; i < listeObjectif.Count(); i++)
                {
                    SuperFlag += listeObjectif[i];
                    if (i != listeObjectif.Count() - 1)
                    {
                        SuperFlag += ",";
                    }
                }
            }
        }

        //Les objets clés
        private void KeyItem()
        {
            SuperFlag += BuildFromScratch.DicoPrefixes[1];
            List<string> ListeKey = new List<string>();

            int cleAlea = Rnd.Next(0, 4);
            if (cleAlea != 0)
            {
                while (ListeKey.Count() != cleAlea)
                {
                    int rand2 = Rnd.Next(1, 4);
                    if (rand2 == 3)
                    {
                        rand2 = Rnd.Next(1, 31);
                        if (rand2 != 3)
                        {
                            rand2 = Rnd.Next(1, 3);
                        }
                    }

                    //Vérifie si présente dans la liste
                    bool dansListe = false;
                    foreach (var item in ListeKey)
                    {
                        if (BuildFromScratch.DicoKeyItem[rand2] == item)
                        {
                            dansListe = true;
                            break;
                        }
                    }

                    //Rajoute à la liste si pas présent
                    if (dansListe == false)
                    {
                        ListeKey.Add(BuildFromScratch.DicoKeyItem[rand2]);
                    }
                }

                foreach (var item in ListeKey)
                {
                    SuperFlag += "/" + item;
                }
            }
        }


        //Le pass de Toroia
        private void Pass()
        {
            int alea = Rnd.Next(0, 4);
            List<string> ListePass = new List<string>();

            SuperFlag += BuildFromScratch.DicoPrefixes[2];

            if (alea == 0)
            {
                SuperFlag += "none";
            }
            else if (alea == 3)
            {
                foreach (var item in BuildFromScratch.DicoPass)
                {
                    ListePass.Add(item.Value);
                }
            }
            else
            {
                while (ListePass.Count() != alea)
                {
                    int rand2 = Rnd.Next(1, 4);
                    if (rand2 == 3)
                    {
                        int rand3 = Rnd.Next(1, 11);
                        if (rand3 == 9)
                        {
                            ListePass.Add(BuildFromScratch.DicoPass[rand2]);
                        }
                    }
                    else
                    {
                        //Regarde si présent dans la liste
                        bool dansListe = false;
                        foreach (var item in ListePass)
                        {
                            if (BuildFromScratch.DicoPass[rand2] == item)
                            {
                                dansListe = true;
                                break;
                            }
                        }

                        //Si pas dans la liste le rajoute
                        if (dansListe == false)
                        {
                            ListePass.Add(BuildFromScratch.DicoPass[rand2]);
                        }
                    }
                }
            }

            //Ajout au SuperFlag
            for (int i = 0; i < ListePass.Count(); i++)
            {
                if (i != ListePass.Count() - 1)
                {
                    SuperFlag += ListePass[i] + "/";
                }
                else
                {
                    SuperFlag += ListePass[i];
                }
            }
        }

        //Options personnages
        private void Character()
        {
            List<string> ListeSpell = new List<string>();

            int charRand = Rnd.Next(1, 4);
            SuperFlag += BuildFromScratch.DicoPrefixes[3] + BuildFromScratch.DicoCharacterRand[charRand];

            if (charRand != 3)
            {
                charRand = Rnd.Next(1, 3);
                if (charRand == 2)
                {
                    SuperFlag += "/maybe";
                }
            }

            //Personnage du début
            charRand = Rnd.Next(0, 13);
            if (charRand != 0)
            {
                SuperFlag += "/" + BuildFromScratch.DicoCharacterStart[charRand];
            }

            //Liste des sorts
            charRand = Rnd.Next(0, 5);
            if (charRand != 0)
            {
                while (ListeSpell.Count() != charRand)
                {
                    int rand2 = Rnd.Next(1, 6);

                    bool dansListe = false;
                    foreach (var item in ListeSpell)
                    {
                        if (BuildFromScratch.DicoCharacterSpell[rand2] == item)
                        {
                            dansListe = true;
                            break;
                        }
                    }

                    if (dansListe == false)
                    {
                        ListeSpell.Add(BuildFromScratch.DicoCharacterSpell[rand2]);
                    }
                }

                foreach (var item in ListeSpell)
                {
                    SuperFlag += "/" + item;
                }
            }

            //Mort permanante
            charRand = Rnd.Next(1, 11);
            if (charRand == 4)
            {
                SuperFlag += "/permadeath";
            }

        }

        //Options Trésors
        private void Treasure()
        {
            SuperFlag += BuildFromScratch.DicoPrefixes[4];

            int alea = Rnd.Next(1, 6);
            SuperFlag += BuildFromScratch.DicoTreasure[alea];

            alea = Rnd.Next(0, 2);
            if (alea == 3)
            {
                foreach (var item in BuildFromScratch.DicoTreasureOption)
                {
                    SuperFlag += "/" + item.Value;
                }
            }
            else if (alea != 0)
            {
                SuperFlag += "/" + BuildFromScratch.DicoTreasureOption[alea];
            }
        }

        //Options magasins
        private void Shop()
        {
            List<string> ListShop = new List<string>();
            SuperFlag += BuildFromScratch.DicoPrefixes[5];

            int alea = Rnd.Next(1, 6);
            SuperFlag += BuildFromScratch.DicoShop[alea];

            alea = Rnd.Next(0, 6);
            if (alea != 0)
            {
                while (ListShop.Count() != alea)
                {
                    int rand2 = Rnd.Next(1, 6);

                    bool dansListe = false;
                    foreach (var item in ListShop)
                    {
                        if (BuildFromScratch.DicoShopOptions[rand2] == item)
                        {
                            dansListe = true;
                            break;
                        }
                    }

                    if (dansListe == false)
                    {
                        ListShop.Add(BuildFromScratch.DicoShopOptions[rand2]);
                    }
                }

                foreach (var item in ListShop)
                {
                    SuperFlag += "/" + item;
                }
            }
        }

        //Options Boss
        private void Boss()
        {
            SuperFlag += BuildFromScratch.DicoPrefixes[6];

            //Force le placement aléatoire des boss
            SuperFlag += "standard";

            int alea = Rnd.Next(0, 2);
            if (alea == 1)
            {
                SuperFlag += "/alt:gauntlet";
            }

            alea = Rnd.Next(0, 2);
            if (alea != 0)
            {
                SuperFlag += BuildFromScratch.DicoBossWyvern[alea];
            }
        }

        //Options Challenges
        private void Challenge()
        {
            List<string> ListChallenge = new List<string>();
            SuperFlag += BuildFromScratch.DicoPrefixes[7];

            int alea = Rnd.Next(0, 4);
            if (alea == 3)
            {
                int alea2 = Rnd.Next(0, 51);
                if (alea2 != 42)
                {
                    alea = Rnd.Next(1, 3);
                }
            }

            if (alea == 0)
            {
                SuperFlag += "none";
            }
            else
            {
                while (ListChallenge.Count() != alea)
                {
                    int rand2 = Rnd.Next(1, 4);
                    if (rand2 == 3)
                    {
                        int rand3 = Rnd.Next(0, 51);
                        if (rand3 == 17)
                        {
                            ListChallenge.Add(BuildFromScratch.DicoChallenge[3]);
                        }
                    }
                    else
                    {
                        bool dansListe = false;
                        foreach (var item in ListChallenge)
                        {
                            if (BuildFromScratch.DicoChallenge[rand2] == item)
                            {
                                dansListe = true;
                                break;
                            }
                        }
                        if (dansListe == false)
                        {
                            ListChallenge.Add(BuildFromScratch.DicoChallenge[rand2]);
                        }
                    }
                }
            }

            for (int i = 0; i < ListChallenge.Count(); i++)
            {
                if (i != ListChallenge.Count() - 1)
                {
                    SuperFlag += ListChallenge[i] + "/";
                }
                else
                {
                    SuperFlag += ListChallenge[i];
                }
            }
        }

        //Options Combat 
        private void Encounter()
        {
            SuperFlag += BuildFromScratch.DicoPrefixes[8];

            int alea = Rnd.Next(0, 61);
            if (alea == 15)
            {
                SuperFlag += "/" + BuildFromScratch.DicoEncounterToggle[1];
            }
            else if (alea == 30)
            {
                SuperFlag += "/" + BuildFromScratch.DicoEncounterToggle[2];
            }
            else if (alea == 45)
            {
                SuperFlag += "/" + BuildFromScratch.DicoEncounterToggle[3];
            }

            alea = Rnd.Next(0, 31);
            if (alea == 1)
            {
                SuperFlag += BuildFromScratch.DicoEncounterDrop[1];
            }
            else if (alea == 2)
            {
                SuperFlag += BuildFromScratch.DicoEncounterDrop[2];
            }
        }
        //Options Glitchs
        private void Glitch()
        {
            List<string> ListGlitch = new List<string>();
            SuperFlag += BuildFromScratch.DicoPrefixes[9];

            int alea = Rnd.Next(0, 6);
            if (alea == 0)
            {
                SuperFlag += "none";
            }
            else
            {
                while (ListGlitch.Count() != alea)
                {
                    int rand2 = Rnd.Next(1, 6);

                    bool dansListe = false;
                    foreach (var item in ListGlitch)
                    {
                        if (BuildFromScratch.DicoGlitch[rand2] == item)
                        {
                            dansListe = true;
                            break;
                        }
                    }
                    if (dansListe == false)
                    {
                        ListGlitch.Add(BuildFromScratch.DicoGlitch[rand2]);
                    }
                }

                for (int i = 0; i < ListGlitch.Count(); i++)
                {
                    if (i != ListGlitch.Count() - 1)
                    {
                        SuperFlag += ListGlitch[i] + "/";
                    }
                    else
                    {
                        SuperFlag += ListGlitch[i];
                    }
                }
            }
        }

        //Options Autres
        private void Other()
        {
            int alea = Rnd.Next(1, 5);
            SuperFlag += "-kit:" + BuildFromScratch.DicoOtherStarter[alea];

            alea = Rnd.Next(0, 11);
            if (alea == 4)
            {
                SuperFlag += " " + BuildFromScratch.DicoOther[1];
            }

            alea = Rnd.Next(0, 11);
            if (alea == 8)
            {
                SuperFlag += " " + BuildFromScratch.DicoOther[2];
            }

        }
        //Seed from scratch
        public void ScratchFlag()
        {
            //Initialisation de la chaine
            SuperFlag = "";

            //Suite de méthodes pour construire la chaine
            RandObjective();
            KeyItem();
            Pass();
            Character();
            Treasure();
            Shop();
            Boss();
            Challenge();
            Encounter();
            Glitch();
            Other();

            CopierFlag(SuperFlag);
        }
    }
}
