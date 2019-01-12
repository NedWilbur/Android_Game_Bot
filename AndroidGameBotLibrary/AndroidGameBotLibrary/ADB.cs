using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using SharpAdbClient;
using System.Net;
using System.Threading;

namespace AndroidGameBotLibrary
{
    //TODO: Error handling
    public static class ADB
    {
        //Object Init
        private static AdbServer server = new AdbServer();
        private static ConsoleOutputReceiver receiver = new ConsoleOutputReceiver();
        public static DeviceData device;

        //Methods
        public static void Start(bool restartServerIfNewer = true)
        {
            Logger.Info(server.StartServer(@"./Tools/adb.exe", restartServerIfNewer).ToString());
        }

        public static void Kill()
        {
            Logger.Info("Killing all instances of ADB");
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (process.ProcessName.Contains("ADB"))
                {
                    process.Kill();
                    Logger.Info("Killed " + process.ProcessName);
                }
            }
        }

        public static bool ConnectToBlueStacks()
        {
            Logger.Info("Connecting to BlueStacks...");
            List<DeviceData> AvailableDevices = AdbClient.Instance.GetDevices();

            if (AvailableDevices.Count <= 0)
            {
                Logger.Error("No devices available");
                return false;
            }
            if (AvailableDevices.Count >= 1)
            {
                Logger.Warn("More than one device discovered");
            }

            foreach (DeviceData AvailableDevice in AvailableDevices)
            {
                if (AvailableDevice.Serial.StartsWith("emulator-"))
                {
                    device = AvailableDevice;
                    Logger.Info("Connected to: " + device.Serial);
                    return true;
                }
            }

            Logger.Error("Unable to connect to device");
            return false;
        }

        public static string SendCommand(string command)
        {
            Logger.Debug("ADB >> " + command);
            try
            {
                AdbClient.Instance.ExecuteRemoteCommand(command, device, receiver);
                if (receiver.ToString().Length > 0)
                    Logger.Info("ADB << " + receiver.ToString());
            }
            catch (Exception ex)
            {
                Logger.Exception("Failed to send command", ex);
            }

            return receiver.ToString();
        }
    }
}
