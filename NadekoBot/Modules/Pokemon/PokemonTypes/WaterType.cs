﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NadekoBot.Modules.Pokemon;
using NadekoBot.Classes;
using NadekoBot.Classes._DataModels; using NadekoBot.Modules.Pokemon.PokeTypes; using NadekoBot.Modules.Pokemon.PokeTypes;

namespace NadekoBot.Modules.Pokemon.PokemonTypes
{
    class WaterType : IPokeType
    {
        static readonly string name = "WATER";
        public static int numType = 2;

        public double GetMagnifier(IPokeType target)
        {
            switch (target.GetName())
            {

                case "FIRE": return 2;
                case "WATER": return 0.5;
                case "GRASS": return 0.5;
                case "GROUND": return 2;
                case "ROCK": return 2;
                case "DRAGON": return 0.5;
                default: return 1;
            }
        }
        List<string> moves = new List<string>();

        


        public string GetName()
        {
            return name;
        }

        
        public string GetImage()
        {
            return "💦";
        }

        public int GetNum()
        {
            return numType;
        }
    }
}
