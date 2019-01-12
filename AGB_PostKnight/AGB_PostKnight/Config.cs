using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGB_PostKnight
{
    public static class Config
    {
        private static bool runMissions = true;
        public static int MissionNumber = 1;
        public static int Difficulty = 1; //1=Easy, 2=Hard
        public static bool GiftNPC = true;
        public static decimal GiftNPCTimeout = 50;

        public static bool RunMissions { get => runMissions; set => runMissions = value; }
    }
}
