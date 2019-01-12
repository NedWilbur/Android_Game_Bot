using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGB_Core;
using System.Drawing;

namespace AGB_PostKnight
{
    public static class Worker
    {
        private static void MainLoop()
        {
            int runCount = 0;
            Logger.Info($"Starting run #{runCount+1}...");

            while(true)
            { 
                if (Config.RunMissions)
                {
                    Logger.Info("Running mission...");
                    FindMissionSign();
                    SelectMission(Config.MissionNumber, Config.Difficulty);
                    Fight();
                    Logger.Info("Mission finished...");
                }

                runCount++;

                Logger.Info($"Run #{runCount} completed!");
                Actions.Sleep(10000);
            }
        }

        public static void Start(object sender)
        {
            switch (sender)
            {
                case "Run":
                    MainLoop();
                    break;
                case "FindMissionSign":
                    FindMissionSign();
                    break;
                case "Fight":
                    Fight();
                    break;
                case "SelectMission":
                    SelectMission(Config.MissionNumber, Config.Difficulty);
                    break;
                case "DetectState":
                    DetectState();
                    break;
            }
        }

        private static bool FindMissionSign()
        {
            Logger.Info("Looking for mission sign");
            Point location = Point.Empty;

            //Try to scroll 6 times to the left to find sign post
            for (int i = 0; i < 6; i++)
            {
                if (Actions.FindImage(Repository.Images.Town.MissionSignPostRight, out location) ||
                    Actions.FindImage(Repository.Images.Town.MissionSignPostLeft, out location))
                {
                    Logger.Info("Found, clicking sign");
                    Actions.LClick(location.X, location.Y);
                    Actions.Sleep(750);
                    return true;
                }
                else
                {
                    Logger.Info("Not found, swipping right...");
                    Actions.LClickDrag(25, 90, 290, 90);
                    Actions.Sleep(750);
                }
            }

            Logger.Error("Unable to find!");
            return false;
        }

        private static void DetectState()
        {

        }

        private static void SelectMission(int MissionNumber, int Difficulty)
        {

            Logger.Info($"Selecting mission# {MissionNumber} ({Difficulty})");

            //Difficulty Toggle
            if (Difficulty == 1)
            {
                //TODO Difficulty Toggle
            }
            else
            {
                
            }

            //Select Mission
            switch (MissionNumber)
            {
                case 1:
                    Actions.LClick(Repository.Locations.MissionWindow.Mission1);
                    break;
                case 2:
                    Actions.LClick(Repository.Locations.MissionWindow.Mission2);
                    break;
                case 3:
                    Actions.LClick(Repository.Locations.MissionWindow.Mission3);
                    break;
                case 4:
                    Actions.LClick(Repository.Locations.MissionWindow.Mission4);
                    break;
                case 5:
                    Actions.LClick(Repository.Locations.MissionWindow.Mission5);
                    break;

            }
            
            Actions.Sleep(10000);
        }

        private static void Fight()
        {
            Logger.Info("Starting mission...");
            Logger.Info("Waiting for mid-point...");

            int maxAttempts = 1000;
            Point GoButtonLocation = Point.Empty;
            Point CloseButtonLocation = Point.Empty;
            Point PlusButtonLocation = Point.Empty;
            Point DialogIndicator = Point.Empty;

            for (int i = 0; i < maxAttempts / 2; i++)
            {
                UseSkills();
                Actions.Sleep(250);

                //Look for out of combat indicator
                Actions.FindImage(Repository.Images.Buttons.CloseButton, out CloseButtonLocation);
                Actions.FindImage(Repository.Images.Buttons.GoButton, out GoButtonLocation);
                Actions.FindImage(Repository.Images.Buttons.PlusButton, out PlusButtonLocation);

                if (CloseButtonLocation != Point.Empty ||
                    GoButtonLocation != Point.Empty ||
                    PlusButtonLocation != Point.Empty)
                    break;
            }
            Actions.Sleep(1000);

            //Died
            if (PlusButtonLocation != Point.Empty)
            {
                Logger.Info("Hero died...");
                ExitMission(PlusButtonLocation);
                return;
            }

            //Heal Question
            if (CloseButtonLocation != Point.Empty)
            {
                Logger.Info("Clearing Heal/Watch Ad Question...");
                Actions.LClick(CloseButtonLocation);
                Actions.Sleep(3000);
            }

            //Continue Fight
            Logger.Info("Continue mission...");
            Actions.FindImage(Repository.Images.Buttons.GoButton, out GoButtonLocation);
            Actions.LClick(GoButtonLocation);
            Actions.Sleep(3000);

            Logger.Info("Waiting for end...");
            for (int i = 0; i < maxAttempts/2; i++)
            {
                UseSkills();

                Actions.Sleep(250);
                Actions.FindImage(Repository.Images.Buttons.PlusButton, out PlusButtonLocation);

                if (PlusButtonLocation != Point.Empty)
                    break;
            }
            Actions.Sleep(5000);
            Logger.Info("Mission finished");


            ExitMission(PlusButtonLocation);
        }

        private static void UseSkills()
        {
            Point SkillButton = Point.Empty;

            if (Actions.FindImage(Repository.Images.Skills.Blitz, out SkillButton))
                Actions.LClick(SkillButton);
            if (Actions.FindImage(Repository.Images.Skills.PreciseBarrier, out SkillButton))
                Actions.LClick(SkillButton);
            if (Actions.FindImage(Repository.Images.Skills.DiamondPotion, out SkillButton))
                Actions.LClick(SkillButton);

            //Clear NPC Diaglog if it exist
            if (Actions.FindImage(Repository.Images.DialogIndicator))
                Actions.LClick(Repository.Locations.Fight.Shield);
        }

        private static void ExitMission(Point PlusButtonLocation)
        {
            Logger.Info("Returning to town...");
            Actions.FindImage(Repository.Images.Buttons.PlusButton, out PlusButtonLocation); //Button moves from orig position
            Actions.LClick(PlusButtonLocation);
            Actions.Sleep(3000);

            //Detect Level Up Window
            Point CheckMarkButton = Point.Empty;
            if (Actions.FindImage(Repository.Images.Buttons.CheckmarkButton, out CheckMarkButton))
            {
                Logger.Info("Skipping skill selection window...");
                Actions.LClick(CheckMarkButton);
                Actions.Sleep(3000);
            }

            Actions.Sleep(10000);
        }
    }
}
