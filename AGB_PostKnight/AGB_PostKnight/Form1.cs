using AGB_Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGB_PostKnight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbMissionNumber.SelectedIndex = 0; //Sets default selection

            Logger.UpdateConsole += Log_UpdateConsole;
        }

        private void Log_UpdateConsole(string message)
        {
            console.Invoke((MethodInvoker)delegate
            {   //Required for threading
                console.AppendText(message);
            });

            if (console.TextLength > 100000)
            {   //Removes half of old text - keeps length managable
                console.Text = console.Text.Remove(0, console.TextLength / 2);
                Logger.Debug("Removed old log data");
            }

            console.ScrollToCaret();
        }

        private void runMode(string mode)
        {
            //Settings
            if (cbRunMission.Checked)
            {
                Config.RunMissions = true;
                Config.MissionNumber = cbMissionNumber.SelectedIndex + 1;
            }
            else
            {
                Config.RunMissions = false;
            }

            if (rbDiffEasy.Checked)
            {
                Config.Difficulty = 1;
            }
            else
            {
                Config.Difficulty = 2;
            }

            if (cbGiftNPC.Checked)
            {
                Config.GiftNPC = true;
                Config.GiftNPCTimeout = numGiftRunDelay.Value;
            }

            Logger.Info("Running " + mode);
            Logger.Info("Starting background worker...");
            backgroundWorker.RunWorkerAsync(mode);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            runMode("Run");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            Logger.Info("Backgroundworker canceled");
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            Worker.Start(e.Argument);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void btnFindSign_Click(object sender, EventArgs e)
        {
            runMode("FindMissionSign");
        }

        private void btnSelectMission_Click(object sender, EventArgs e)
        {
            runMode("SelectMission");
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            runMode("Fight");
        }

        private void btnDetectState_Click(object sender, EventArgs e)
        {
            runMode("DetectState");
        }
    }
}
