using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AGB_Core
{
    public static class Actions
    {
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string strClassName, string strWindowName);
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsIconic(IntPtr hWnd);

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int SW_SHOWMAXIMIZED = 3;

        private static IntPtr BluestacksHandle { get; set; }
        private static Rect BluestacksWindow { get; set; }
        private static int BlueStacksWidth = 312;
        private static int BlueStacksHeight = 625;
        private static int RetryCount = 0;

        private static bool GetBlueStacksProcess()
        {
            Process[] processList = Process.GetProcessesByName("bluestacks");
            if (processList.Length == 0)
            {
                Logger.Warn("Bluestacks not running!");
                return false;
            }

            foreach (Process process in processList)
            {
                if (process.MainWindowHandle != IntPtr.Zero)
                {
                    BluestacksHandle = process.MainWindowHandle;
                    Logger.Info("Updated Bluestacks Process Handle: " + BluestacksHandle);
                    return true;
                }
            }

            if (BluestacksHandle == IntPtr.Zero)
            {
                Logger.Warn("Unable to find correct Bluestacks window!");
                return false;
            }

            return false;
        }

        private static bool UpdateBluestacksWindow()
        {
            //Get BluestacksHandle
            if (BluestacksHandle == IntPtr.Zero)
                if (!GetBlueStacksProcess())
                    return false;

            if (IsIconic(BluestacksHandle)) //If minimized
            { //TODO: Auto maximize
                Logger.Warn("Bluestacks minimized!");
                return false;
            }

            //Focus Window
            SetForegroundWindow(BluestacksHandle);

            //Get Window Loc
            Rect _BlueStacksWindow = new Rect();
            GetWindowRect(BluestacksHandle, ref _BlueStacksWindow);
            BluestacksWindow = _BlueStacksWindow;

            int currentWidth = BluestacksWindow.Right - BluestacksWindow.Left;
            int currentHeight = BluestacksWindow.Bottom - BluestacksWindow.Top;

            if (currentWidth != BlueStacksWidth || currentHeight != BlueStacksHeight)
            {
                
                RetryCount++;
                if (RetryCount <= 3)
                {
                    Logger.Info("Resizing Bluestacks...");
                    MoveWindow(BluestacksHandle, BluestacksWindow.Left, BluestacksWindow.Top, BlueStacksWidth, BlueStacksHeight, true);
                    UpdateBluestacksWindow();
                }
                else
                {
                    Logger.Warn("Failed to resize Bluestacks");
                    Logger.Debug($"Current (WxH): {currentWidth}x{currentHeight}");
                    Logger.Debug($"Expected (WxH): {BlueStacksWidth}x{BlueStacksHeight}");
                    return false;
                }

            }

            RetryCount = 0;
            return true;
        }

        public static void resetloc() //FOR DEBUGGING ONLY
        {
            MoveWindow(BluestacksHandle, 0, 0, 313, 625, true);
        }

        public static void LClick(int downX, int downY, int duration = 0)
        {
            if (duration == 0)
            {
                Logger.Info($"Performing left click at {downX}, {downY}");
                Click(MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP, downX, downY, -1, -1);
            }
            else
            {
                Logger.Info($"Performing left click at {downX}, {downY} for {duration}ms");
                Click(MOUSEEVENTF_LEFTDOWN, downX, downY, -1, -1);
                Sleep(duration);
                Click(MOUSEEVENTF_LEFTUP, downX, downY, -1, -1);
            }
        }

        public static void LClick(System.Drawing.Point location)
        {
            LClick(location.X, location.Y);
        }

        public static void RClick(int downX, int downY, int duration = 0)
        {
            if (duration == 0)
            {
                Logger.Info($"Performing right click at {downX}, {downY}");
                Click(MOUSEEVENTF_RIGHTDOWN, MOUSEEVENTF_RIGHTUP, downX, downY, -1, -1);
            }
            else
            {
                Logger.Info($"Performing right click at {downX}, {downY} for {duration}ms");
                Click(MOUSEEVENTF_RIGHTDOWN, downX, downY, -1, -1);
                Sleep(duration);
                Click(MOUSEEVENTF_RIGHTUP, downX, downY, -1, -1);
            }
        }

        public static void RClick(System.Drawing.Point location)
        {
            RClick(location.X, location.Y);
        }

        public static void LClickDrag(int downX, int downY, int upX, int upY)
        {
            Logger.Info($"Performing left click drag at {downX}, {downY} to {upX}, {upY}");
            Click(MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP, downX, downY, upX, upY);
        }

        private static void Click(int clickTypeDown, int clickTypeUp, int downX, int downY, int upX = -1, int upY = -1)
        {
            //Update Window
            if (!UpdateBluestacksWindow()) return;

            //Makes it relative to window location
            downX += BluestacksWindow.Left;
            downY += BluestacksWindow.Top;

            //Perform Click
            if (upX > -1 || upY > -1)
            {   //Mouse drag
                SetCursorPos(downX, downY);
                mouse_event(clickTypeDown, downX, downY, 0, 0);

                //Simulate Movement
                //TODO: Move on Y axis
                int step = 5;
                int sleep = 5;
                if (downX > upX)
                {   //Right to Left
                    while (downX > upX)
                    {
                        SetCursorPos(downX, downY);
                        downX -= step;
                        Sleep(sleep, false);
                    }
                }
                else
                {   //Left to Right
                    upX += BluestacksWindow.Left;
                    upY += BluestacksWindow.Top;

                    while (downX < upX)
                    {
                        SetCursorPos(downX, downY);
                        downX += step;
                        Sleep(sleep, false);
                    }
                }

                mouse_event(clickTypeUp, upX, upY, 0, 0);
            }
            else
            {   //Normal Click
                SetCursorPos(downX, downY);
                mouse_event(clickTypeDown, downX, downY, 0, 0);
                mouse_event(clickTypeUp, upX, upY, 0, 0);
            }
        }

        public static void LClickDrag(System.Drawing.Point downLocation, System.Drawing.Point upLocation)
        {
            LClickDrag(downLocation.X, downLocation.Y, upLocation.X, upLocation.Y);
        }

        public static void MouseMove(int x, int y)
        {
            //Makes it relative to window location
            x += BluestacksWindow.Left;
            y += BluestacksWindow.Top;

            SetCursorPos(x, y);
        }

        public static void Type(string keySequence)
        {
            //Not implemented
        }

        public static string Screenshot()
        {
            if (!UpdateBluestacksWindow()) return string.Empty; //Something wrong with window

            string timeStamp = DateTime.Now.ToString("yyMMddHHmmssfff");
            //string saveLocation = Path.GetTempPath() + "AGB-" + timeStamp;
            string saveLocation = Path.GetTempPath() + "AGB";

            int width = BluestacksWindow.Right - BluestacksWindow.Left;
            int height = BluestacksWindow.Bottom - BluestacksWindow.Top;

            Bitmap bmp = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(BluestacksWindow.Left, BluestacksWindow.Top, 0, 0, new System.Drawing.Size(width, height), CopyPixelOperation.SourceCopy);

            bmp.Save(saveLocation + ".bmp", ImageFormat.Bmp);
            //TODO: Downgrade image

            return saveLocation + ".bmp";
        }

        public static void Sleep(int ms, bool report = true)
        {
            //TODO: FILTHY
            if (report)
                Logger.Info($"Sleeping for {ms}ms...");

            Thread.Sleep(ms);
        }

        /// <summary>
        /// Find template image in current screen
        /// </summary>
        /// <param name="templateLocation"></param>
        /// <param name="location"></param>
        /// <param name="similarity"></param>
        /// <returns>T|F if found; out Point location of template image</returns>
        public static bool FindImage(string templateLocation, out System.Drawing.Point location, double similarity = 0.98)
        {
            Logger.Info("Searching for template image within screen...");

            //Set Source & Template image
            Mat src = new Mat(Screenshot());
            Mat template = new Mat(templateLocation);
            Mat result = src.MatchTemplate(template, TemplateMatchModes.CCoeffNormed);

            double minVal, maxVal;
            OpenCvSharp.Point minLoc, maxLoc;
            result.MinMaxLoc(out minVal, out maxVal, out minLoc, out maxLoc);
            //Logger.Debug($"maxLoc: {maxLoc}, maxVal: {maxLoc}, minVal: {minVal}, maxVal: {maxVal}");


            if (maxVal >= similarity)
            {
                location = new System.Drawing.Point(maxLoc.X, maxLoc.Y);
                Logger.Info($"Image found at {location.X}, {location.Y} (Similarity: {Math.Round(maxVal,2)})");
                return true;
            }
            else
            {
                Logger.Warn($"Image not found (Similarity: {Math.Round(maxVal, 2)})");
                location = System.Drawing.Point.Empty;
                return false;
            }
        }

        /// <summary>
        /// Find template image in current screen (does not return location of image)
        /// </summary>
        /// <param name="templateLocation"></param>
        /// <param name="similarity"></param>
        /// <returns>T|F if found</returns>
        public static bool FindImage(string templateLocation, double similarity = 0.98)
        {
            System.Drawing.Point location = System.Drawing.Point.Empty;
            return FindImage(templateLocation, out location, similarity);
        }
    }
}
