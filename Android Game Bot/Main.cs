using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AGB_Core;

namespace AGB_DevTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //Event Delegate
            Logger.UpdateConsole += Log_UpdateConsole;
            Logger.Info("AGB Launched");
        }

        private void Log_UpdateConsole(string message)
        {
            console.AppendText(message);
            console.ScrollToCaret(); //Scroll to end
        }

        //GUI Functions
        //Get a new screenshot
        string screenshotLocation = null; //Used for image search
        private void btnGetScreenshot_Click(object sender, EventArgs e)
        {
            screenshotLocation = Actions.Screenshot();

            if (!String.IsNullOrEmpty(screenshotLocation))
            {
                picBoxScreenCap.Image = Image.FromFile(screenshotLocation);
                tbScreenshotImageLocation.Text = screenshotLocation;
            }
        }

        //Tap at specified X, Y
        private void btnMouseTap_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbMouseX.Text);
                int y = int.Parse(tbMouseY.Text);
                int duration = 0;

                if (tbMouseCordsDur.Text.Length > 0)
                    duration = int.Parse(tbMouseCordsDur.Text);
                    
                PerformClick(x, y, duration);
            }
            catch (Exception ex)
            {
                Logger.Exception("Cant perform click", ex);
            }
        }

        //Get Mouse Cords
        private void btnImageTap_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbImageX.Text);
                int y = int.Parse(tbImageY.Text);
                int duration = 0;

                if (tbMouseCordsDur.Text.Length > 0)
                    duration = int.Parse(tbImageCordsDur.Text);

                PerformClick(x, y, duration);
            }
            catch (Exception ex)
            {
                Logger.Exception("Cant perform tap", ex);
            }
        }

        private void PerformClick(int x, int y, int duration = 0)
        {
            if (duration == 0)
            {
                Logger.Info($"Clicking at {x}, {y}...");
                Actions.LClick(x, y);
            }
            else
            {
                Logger.Info($"Clicking at {x}, {y} for {duration}ms...");
                Actions.LClick(x, y, duration);
            }

            btnGetScreenshot_Click(null, null); //Update SS
        }

        //Get Clicked X, Y in screencap
        private void picBoxPortrait_Click(object sender, EventArgs e)
        {
            Point mouseLoc = picBoxScreenCap.PointToClient(Cursor.Position);
            string x = Convert.ToInt32(mouseLoc.X).ToString();
            string y = Convert.ToInt32(mouseLoc.Y).ToString();

            if (ModifierKeys == Keys.Control)
            {
                tbSwipeXEnd.Text = x;
                tbSwipeYEnd.Text = y;
            } else
            {
                tbMouseX.Text = x;
                tbMouseY.Text = y;
                tbSwipeXStart.Text = x;
                tbSwipeYStart.Text = y;
            }
        }

        //Select BMP
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\Ned\Desktop\Images";
            openFileDialog.Filter = "BMP Image (*.bmp)|*.bmp";
            openFileDialog.FilterIndex = 2;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tbSearchImageLocation.Text = openFileDialog.FileName;
        }

        //Search for image, return cordinates
        private void btnSearchForImage_Click(object sender, EventArgs e)
        {
            Point location = new Point();
            Actions.FindImage(tbScreenshotImageLocation.Text, out location);

            if (location != Point.Empty)
            {
                tbImageX.Text = location.X.ToString();
                tbImageY.Text = location.Y.ToString();
            }
        }

        //Perform Swipe
        private void btnSwipe_Click(object sender, EventArgs e)
        {
            Actions.LClickDrag
                (
                    Convert.ToInt32(tbSwipeXStart.Text),
                    Convert.ToInt32(tbSwipeYStart.Text),
                    Convert.ToInt32(tbSwipeXEnd.Text),
                    Convert.ToInt32(tbSwipeYEnd.Text)
                );
        }

        //Perform type
        private void btnType_Click(object sender, EventArgs e) => Actions.Type(tbType.Text);

        //Code Assistance
        private void copyToClipboard(string code)
        {
            Logger.Debug("Code added to clipboard: " + code);
            Clipboard.SetText(code);
        }

        private void lblMouseCords_Click(object sender, EventArgs e)
        {
            if(tbMouseCordsDur.Text.Length <= 0)
                copyToClipboard($"Actions.Tap({tbMouseX.Text}, {tbMouseY.Text});");
            else
                copyToClipboard($"Actions.Tap({tbMouseX.Text}, {tbMouseY.Text}, {tbMouseCordsDur.Text});");
        }
            

        private void lblImageCords_Click(object sender, EventArgs e)
        {
            if (tbImageCordsDur.Text.Length <= 0)
                copyToClipboard($"Actions.Tap({tbImageX.Text}, {tbImageY.Text});");
            else
                copyToClipboard($"Actions.Tap({tbImageX.Text}, {tbImageY.Text}, {tbImageCordsDur.Text});");
        }

        private void lblSwipeStart_Click(object sender, EventArgs e)
        {
            if (tbMouseCordsDur.Text.Length <= 0)
                copyToClipboard($"Actions.Swipe({tbSwipeXStart.Text}, {tbSwipeYStart.Text}, {tbSwipeXEnd.Text}, {tbSwipeYEnd.Text});");

        }

        private void lblSwipeEnd_Click(object sender, EventArgs e)
        {
            lblSwipeStart_Click(null, null);
        }

        private void lblType_Click(object sender, EventArgs e)
        {
            copyToClipboard($"Actions.Type(\"{tbType.Text}\");");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Actions.resetloc();
        }

        private void btnMouseMove_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbMouseX.Text);
                int y = int.Parse(tbMouseY.Text);

                Actions.MouseMove(x, y);
            }
            catch (Exception ex)
            {
                Logger.Exception("Cant move mouse", ex);
            }
        }

        private void btnImageMove_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbImageX.Text);
                int y = int.Parse(tbImageY.Text);

                Actions.MouseMove(x, y);
            }
            catch (Exception ex)
            {
                Logger.Exception("Cant move mouse", ex);
            }
        }
    }
}
