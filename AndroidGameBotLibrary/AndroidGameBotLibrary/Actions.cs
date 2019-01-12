using SharpAdbClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;

namespace AndroidGameBotLibrary
{
    public static class Actions
    {
        //Convert x,y to Point object? https://msdn.microsoft.com/en-us/library/system.drawing.point(v=vs.110).aspx
        public static void Tap(Point point) => ADB.SendCommand($"input tap {point.X.ToString()} {point.Y.ToString()}");
        public static void Tap(string xy) => ADB.SendCommand($"input tap {xy}");
        public static void Tap(int x, int y) => ADB.SendCommand($"input tap {x} {y}");
        public static void Tap(int x, int y, int duration) => ADB.SendCommand($"input swipe {x} {y} {x} {y} {duration}");
        public static void Swipe(int XStart, int YStart, int XEnd, int YEnd) => ADB.SendCommand($"input swipe {XStart} {YStart} {XEnd} {YEnd}");
        public static void Swipe(int XStart, int YStart, int XEnd, int YEnd, int duration) => ADB.SendCommand($"input swipe {XStart} {YStart} {XEnd} {YEnd} {duration}");
        public static void Type(string keySequence) => ADB.SendCommand($"input text '{keySequence}'");

        //Android Buttons/Events (https://stackoverflow.com/questions/7789826/adb-shell-input-events)
        public static void Menu() =>ADB.SendCommand($"input keyevent 1");
        public static void Home() =>ADB.SendCommand($"input keyevent 3");
        public static void Back() =>ADB.SendCommand($"input keyevent 4");
        public static void VolumeUp() =>ADB.SendCommand($"input keyevent 24");
        public static void VolumeDown() =>ADB.SendCommand($"input keyevent 25");
        public static void Power() =>ADB.SendCommand($"input keyevent 26");
        public static void Clear() =>ADB.SendCommand($"input keyevent 28");
        public static void Enter() =>ADB.SendCommand($"input keyevent 66");
        public static void Menu2() =>ADB.SendCommand($"input keyevent 82");
        public static void Search() =>ADB.SendCommand($"input keyevent 84");

        //Misc
        public static void Sleep(int ms)
        {
            //TODO: FILTHY
            Logger.Info($"Sleeping for {ms}ms...");
            Thread.Sleep(ms);
        }

        //TODO: Use memory stream
        public static string Screenshot(bool portraitMode = true)
        {
            string timeStamp = DateTime.Now.ToString("yyMMddHHmmssfff");
            string saveLocation = Path.GetTempPath() + "AGBSS_ADBScreencap_" + timeStamp;
            string outputLocation = saveLocation += "Processed";

            //Take SS
           ADB.SendCommand("screencap /sdcard/screenshot.png");

            //Pull SS
            try
            {
                using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)),ADB.device))
                using (Stream stream = File.OpenWrite(saveLocation + ".png"))
                    service.Pull("/sdcard/screenshot.png", stream, null, CancellationToken.None);
            }
            catch (Exception ex)
            {
                Logger.Exception("Unable to pull screenshot", ex);
                return null;
            }
            
            //Delete SS
           ADB.SendCommand("rm /sdcard/screenshot.png");

            //Downgrade Image
            saveLocation += ".png";
            outputLocation += ".bmp";
            ImageProcessor.DowngradeImage(saveLocation, outputLocation, portraitMode);

            Logger.Info("Screenshot saved to: " + outputLocation);
            return outputLocation;
        }

        /// <summary>
        /// Finds bmp in current screenshot
        /// </summary>
        /// <param name="searchImageFilePath"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        public static bool FindImage(Bitmap searchImage, out Point location)
        {
            Bitmap screenshot = (Bitmap)Image.FromFile(Screenshot());

            List<Point> FoundLocations = ImageReader.GetSubPositions(searchImage, screenshot);
            if (FoundLocations.Count <= 0)
            {
                location = Point.Empty;
                return false;
            }
            else
            {
                location = FoundLocations[0];
                return true;
            }

            //ADD ERROR HANDLER 
            //ADD CORDS TO IMAGE CORDS TB
            //if (allLocations.Count <= 0)
            //    Logger.Warn("Image NOT found");
            //if (allLocations.Count >= 2)
            //    Logger.Warn("More than one location found!");

            //foreach (Point location in allLocations)
            //{
            //    Logger.Info($"Image Found @ {location.X}, {location.Y}");
            //    tbImageX.Text = Convert.ToInt32(location.X * 4).ToString();
            //    tbImageY.Text = Convert.ToInt32(location.Y * 4).ToString();
            //}
        }

        public static bool LaunchGame(string app_icon_url, string app_name, string app_url, string app_pkg, string BlueStacksLocation = "default")
        {
            //Verify is not running
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (process.ProcessName.Contains("Bluestacks"))
                {
                    Logger.Warn("Bluestacks already running! Ensure the game is open");
                }
            }

            //Build Launch Path & Arguments
            if (BlueStacksLocation == "default")
                BlueStacksLocation = String.Format("\"{0}\" -json \"{\"\"app_icon_url\"\": \"\"{1}\"\", \"\"app_name\"\": \"\"{2}\"\", \"\"app_url\"\": \"\"{3}\"\", \"\"app_pkg\"\": \"\"{4}\"\"}\"",
                    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\BlueStacks\\HD - RunApp.exe",
                    app_icon_url, app_name, app_url, app_pkg);
            else
                BlueStacksLocation = String.Format("\"{0}\" -json \"{\"\"app_icon_url\"\": \"\"{1}\"\", \"\"app_name\"\": \"\"{2}\"\", \"\"app_url\"\": \"\"{3}\"\", \"\"app_pkg\"\": \"\"{4}\"\"}\"",
                    BlueStacksLocation, app_icon_url, app_name, app_url, app_pkg);

            //Launch Bluestacks
            Logger.Info($"Launching {app_name}...");
            Process.Start(BlueStacksLocation);
            return true;
        }
    }
}
