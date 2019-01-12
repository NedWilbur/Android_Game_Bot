using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGB_PostKnight
{
    public static class Repository
    {
        public static class Images
        {
            public static class Town
            {
                public static string MissionSignPostRight = @"./Images/MissionSignPostRight.bmp";
                public static string MissionSignPostLeft = @"./Images/MissionSignPostLeft.bmp";
            }
            public static class Buttons
            {
                public static string GoButton = @"./Images/GoSign.bmp";
                public static string CloseButton = @"./Images/CloseButton.bmp";
                public static string PlusButton = @"./Images/PlusButton.bmp";
                public static string CheckmarkButton = @"./Images/CheckmarkButton.bmp";
                public static string RetryButton = @"./Images/RetryButton.bmp";
            }
            public static class Skills
            {
                //Charge
                public static string Blitz = @"./Images/Blitz.bmp";

                //Shield
                public static string PreciseBarrier = @"./Images/PreciseBarrier.bmp";

                //Potions
                public static string DiamondPotion = @"./Images/DiamondPotion.bmp";
            }

            public static string DialogIndicator = @"./Images/DialogIndicator.bmp";
        }

        public static class Locations
        {
            public static class MissionWindow
            {
                public static Point Difficulty = new Point(240, 125);

                public static Point Mission1 = new Point(160, 165);
                public static Point Mission2 = new Point(160, 220);
                public static Point Mission3 = new Point(160, 275);
                public static Point Mission4 = new Point(160, 328);
                public static Point Mission5 = new Point(160, 384);

                public static Point Routes = new Point(90, 460);
                public static Point Areas = new Point(210, 460);

                public static Point Close = new Point(185, 515);
            }
            public static class Fight
            {
                public static Point Charge = new Point(80, 500);
                public static Point Shield = new Point(155, 500);
                public static Point Potion = new Point(235, 500);

                public static Point ResetSkills = new Point(125, 430);
                public static Point ClearLevelUp = new Point(125, 430);
            }
        }
    }
}
