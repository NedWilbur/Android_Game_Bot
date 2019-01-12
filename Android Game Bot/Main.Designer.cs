namespace AGB_DevTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMouseTap = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.btnGetScreenshot = new System.Windows.Forms.Button();
            this.picBoxScreenCap = new System.Windows.Forms.PictureBox();
            this.tbMouseX = new System.Windows.Forms.TextBox();
            this.tbMouseY = new System.Windows.Forms.TextBox();
            this.lblMouseCords = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.tbScreenshotImageLocation = new System.Windows.Forms.TextBox();
            this.tbSearchImageLocation = new System.Windows.Forms.TextBox();
            this.btnSearchForImage = new System.Windows.Forms.Button();
            this.lblImageCords = new System.Windows.Forms.Label();
            this.tbImageY = new System.Windows.Forms.TextBox();
            this.tbImageX = new System.Windows.Forms.TextBox();
            this.btnImageTap = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lblSwipeStart = new System.Windows.Forms.Label();
            this.btnSwipe = new System.Windows.Forms.Button();
            this.tbSwipeYStart = new System.Windows.Forms.TextBox();
            this.tbSwipeXStart = new System.Windows.Forms.TextBox();
            this.tbSwipeYEnd = new System.Windows.Forms.TextBox();
            this.tbSwipeXEnd = new System.Windows.Forms.TextBox();
            this.lblSwipeEnd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbImageCordsDur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMouseCordsDur = new System.Windows.Forms.TextBox();
            this.btnMouseMove = new System.Windows.Forms.Button();
            this.btnImageMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScreenCap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMouseTap
            // 
            this.btnMouseTap.Location = new System.Drawing.Point(217, 30);
            this.btnMouseTap.Name = "btnMouseTap";
            this.btnMouseTap.Size = new System.Drawing.Size(73, 23);
            this.btnMouseTap.TabIndex = 18;
            this.btnMouseTap.Text = "Click";
            this.btnMouseTap.UseVisualStyleBackColor = true;
            this.btnMouseTap.Click += new System.EventHandler(this.btnMouseTap_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.MenuText;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.console.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.SystemColors.Window;
            this.console.Location = new System.Drawing.Point(11, 426);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(527, 215);
            this.console.TabIndex = 27;
            this.console.Text = "";
            // 
            // btnGetScreenshot
            // 
            this.btnGetScreenshot.Location = new System.Drawing.Point(6, 19);
            this.btnGetScreenshot.Name = "btnGetScreenshot";
            this.btnGetScreenshot.Size = new System.Drawing.Size(95, 23);
            this.btnGetScreenshot.TabIndex = 6;
            this.btnGetScreenshot.Text = "Get Screencap";
            this.btnGetScreenshot.UseVisualStyleBackColor = true;
            this.btnGetScreenshot.Click += new System.EventHandler(this.btnGetScreenshot_Click);
            // 
            // picBoxScreenCap
            // 
            this.picBoxScreenCap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBoxScreenCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxScreenCap.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.picBoxScreenCap.Location = new System.Drawing.Point(544, 16);
            this.picBoxScreenCap.Name = "picBoxScreenCap";
            this.picBoxScreenCap.Size = new System.Drawing.Size(625, 625);
            this.picBoxScreenCap.TabIndex = 13;
            this.picBoxScreenCap.TabStop = false;
            this.picBoxScreenCap.Click += new System.EventHandler(this.picBoxPortrait_Click);
            // 
            // tbMouseX
            // 
            this.tbMouseX.Location = new System.Drawing.Point(109, 31);
            this.tbMouseX.Name = "tbMouseX";
            this.tbMouseX.Size = new System.Drawing.Size(30, 20);
            this.tbMouseX.TabIndex = 15;
            // 
            // tbMouseY
            // 
            this.tbMouseY.Location = new System.Drawing.Point(145, 32);
            this.tbMouseY.Name = "tbMouseY";
            this.tbMouseY.Size = new System.Drawing.Size(30, 20);
            this.tbMouseY.TabIndex = 16;
            // 
            // lblMouseCords
            // 
            this.lblMouseCords.AutoSize = true;
            this.lblMouseCords.Location = new System.Drawing.Point(32, 34);
            this.lblMouseCords.Name = "lblMouseCords";
            this.lblMouseCords.Size = new System.Drawing.Size(69, 13);
            this.lblMouseCords.TabIndex = 18;
            this.lblMouseCords.Text = "Mouse Cords";
            this.lblMouseCords.Click += new System.EventHandler(this.lblMouseCords_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(6, 43);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(95, 23);
            this.btnSelectImage.TabIndex = 8;
            this.btnSelectImage.Text = "Load *.bmp";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // tbScreenshotImageLocation
            // 
            this.tbScreenshotImageLocation.Location = new System.Drawing.Point(107, 19);
            this.tbScreenshotImageLocation.Name = "tbScreenshotImageLocation";
            this.tbScreenshotImageLocation.Size = new System.Drawing.Size(232, 20);
            this.tbScreenshotImageLocation.TabIndex = 7;
            // 
            // tbSearchImageLocation
            // 
            this.tbSearchImageLocation.Location = new System.Drawing.Point(107, 44);
            this.tbSearchImageLocation.Name = "tbSearchImageLocation";
            this.tbSearchImageLocation.Size = new System.Drawing.Size(232, 20);
            this.tbSearchImageLocation.TabIndex = 9;
            // 
            // btnSearchForImage
            // 
            this.btnSearchForImage.Location = new System.Drawing.Point(345, 19);
            this.btnSearchForImage.Name = "btnSearchForImage";
            this.btnSearchForImage.Size = new System.Drawing.Size(61, 45);
            this.btnSearchForImage.TabIndex = 10;
            this.btnSearchForImage.Text = "Search";
            this.btnSearchForImage.UseVisualStyleBackColor = true;
            this.btnSearchForImage.Click += new System.EventHandler(this.btnSearchForImage_Click);
            // 
            // lblImageCords
            // 
            this.lblImageCords.AutoSize = true;
            this.lblImageCords.Location = new System.Drawing.Point(35, 60);
            this.lblImageCords.Name = "lblImageCords";
            this.lblImageCords.Size = new System.Drawing.Size(66, 13);
            this.lblImageCords.TabIndex = 26;
            this.lblImageCords.Text = "Image Cords";
            this.lblImageCords.Click += new System.EventHandler(this.lblImageCords_Click);
            // 
            // tbImageY
            // 
            this.tbImageY.Location = new System.Drawing.Point(145, 58);
            this.tbImageY.Name = "tbImageY";
            this.tbImageY.Size = new System.Drawing.Size(30, 20);
            this.tbImageY.TabIndex = 12;
            // 
            // tbImageX
            // 
            this.tbImageX.Location = new System.Drawing.Point(109, 57);
            this.tbImageX.Name = "tbImageX";
            this.tbImageX.Size = new System.Drawing.Size(30, 20);
            this.tbImageX.TabIndex = 11;
            // 
            // btnImageTap
            // 
            this.btnImageTap.Location = new System.Drawing.Point(217, 55);
            this.btnImageTap.Name = "btnImageTap";
            this.btnImageTap.Size = new System.Drawing.Size(73, 24);
            this.btnImageTap.TabIndex = 14;
            this.btnImageTap.Text = "Click";
            this.btnImageTap.UseVisualStyleBackColor = true;
            this.btnImageTap.Click += new System.EventHandler(this.btnImageTap_Click);
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(217, 134);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(73, 22);
            this.btnType.TabIndex = 25;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(109, 136);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(102, 20);
            this.tbType.TabIndex = 24;
            // 
            // lblSwipeStart
            // 
            this.lblSwipeStart.AutoSize = true;
            this.lblSwipeStart.Location = new System.Drawing.Point(75, 86);
            this.lblSwipeStart.Name = "lblSwipeStart";
            this.lblSwipeStart.Size = new System.Drawing.Size(29, 13);
            this.lblSwipeStart.TabIndex = 39;
            this.lblSwipeStart.Text = "Start";
            this.lblSwipeStart.Click += new System.EventHandler(this.lblSwipeStart_Click);
            // 
            // btnSwipe
            // 
            this.btnSwipe.Location = new System.Drawing.Point(217, 84);
            this.btnSwipe.Name = "btnSwipe";
            this.btnSwipe.Size = new System.Drawing.Size(73, 46);
            this.btnSwipe.TabIndex = 23;
            this.btnSwipe.Text = "Swipe";
            this.btnSwipe.UseVisualStyleBackColor = true;
            this.btnSwipe.Click += new System.EventHandler(this.btnSwipe_Click);
            // 
            // tbSwipeYStart
            // 
            this.tbSwipeYStart.Location = new System.Drawing.Point(145, 84);
            this.tbSwipeYStart.Name = "tbSwipeYStart";
            this.tbSwipeYStart.Size = new System.Drawing.Size(30, 20);
            this.tbSwipeYStart.TabIndex = 20;
            // 
            // tbSwipeXStart
            // 
            this.tbSwipeXStart.Location = new System.Drawing.Point(109, 83);
            this.tbSwipeXStart.Name = "tbSwipeXStart";
            this.tbSwipeXStart.Size = new System.Drawing.Size(30, 20);
            this.tbSwipeXStart.TabIndex = 19;
            // 
            // tbSwipeYEnd
            // 
            this.tbSwipeYEnd.Location = new System.Drawing.Point(145, 110);
            this.tbSwipeYEnd.Name = "tbSwipeYEnd";
            this.tbSwipeYEnd.Size = new System.Drawing.Size(30, 20);
            this.tbSwipeYEnd.TabIndex = 22;
            // 
            // tbSwipeXEnd
            // 
            this.tbSwipeXEnd.Location = new System.Drawing.Point(109, 109);
            this.tbSwipeXEnd.Name = "tbSwipeXEnd";
            this.tbSwipeXEnd.Size = new System.Drawing.Size(30, 20);
            this.tbSwipeXEnd.TabIndex = 21;
            // 
            // lblSwipeEnd
            // 
            this.lblSwipeEnd.AutoSize = true;
            this.lblSwipeEnd.Location = new System.Drawing.Point(75, 112);
            this.lblSwipeEnd.Name = "lblSwipeEnd";
            this.lblSwipeEnd.Size = new System.Drawing.Size(26, 13);
            this.lblSwipeEnd.TabIndex = 45;
            this.lblSwipeEnd.Text = "End";
            this.lblSwipeEnd.Click += new System.EventHandler(this.lblSwipeEnd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetScreenshot);
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.tbScreenshotImageLocation);
            this.groupBox1.Controls.Add(this.tbSearchImageLocation);
            this.groupBox1.Controls.Add(this.btnSearchForImage);
            this.groupBox1.Location = new System.Drawing.Point(5, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 77);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Image Based ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImageMove);
            this.groupBox2.Controls.Add(this.btnMouseMove);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.lblImageCords);
            this.groupBox2.Controls.Add(this.btnMouseTap);
            this.groupBox2.Controls.Add(this.tbMouseX);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblSwipeEnd);
            this.groupBox2.Controls.Add(this.tbMouseY);
            this.groupBox2.Controls.Add(this.tbType);
            this.groupBox2.Controls.Add(this.tbMouseCordsDur);
            this.groupBox2.Controls.Add(this.btnType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblMouseCords);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnImageTap);
            this.groupBox2.Controls.Add(this.tbImageCordsDur);
            this.groupBox2.Controls.Add(this.tbImageX);
            this.groupBox2.Controls.Add(this.tbImageY);
            this.groupBox2.Controls.Add(this.lblSwipeStart);
            this.groupBox2.Controls.Add(this.btnSwipe);
            this.groupBox2.Controls.Add(this.tbSwipeXEnd);
            this.groupBox2.Controls.Add(this.tbSwipeYStart);
            this.groupBox2.Controls.Add(this.tbSwipeYEnd);
            this.groupBox2.Controls.Add(this.tbSwipeXStart);
            this.groupBox2.Location = new System.Drawing.Point(5, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 196);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Input Actions ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(70, 139);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 53;
            this.lblType.Text = "Type";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Click image to get cordinates. Ctrl+Click to get Swipe End cordinates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Click action labels to copy code to clipboard";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(5, 297);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 26);
            this.btnStart.TabIndex = 59;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbImageCordsDur
            // 
            this.tbImageCordsDur.Location = new System.Drawing.Point(181, 58);
            this.tbImageCordsDur.Name = "tbImageCordsDur";
            this.tbImageCordsDur.Size = new System.Drawing.Size(30, 20);
            this.tbImageCordsDur.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Dur.";
            // 
            // tbMouseCordsDur
            // 
            this.tbMouseCordsDur.Location = new System.Drawing.Point(181, 32);
            this.tbMouseCordsDur.Name = "tbMouseCordsDur";
            this.tbMouseCordsDur.Size = new System.Drawing.Size(30, 20);
            this.tbMouseCordsDur.TabIndex = 17;
            // 
            // btnMouseMove
            // 
            this.btnMouseMove.Location = new System.Drawing.Point(296, 31);
            this.btnMouseMove.Name = "btnMouseMove";
            this.btnMouseMove.Size = new System.Drawing.Size(73, 23);
            this.btnMouseMove.TabIndex = 55;
            this.btnMouseMove.Text = "Move";
            this.btnMouseMove.UseVisualStyleBackColor = true;
            this.btnMouseMove.Click += new System.EventHandler(this.btnMouseMove_Click);
            // 
            // btnImageMove
            // 
            this.btnImageMove.Location = new System.Drawing.Point(296, 55);
            this.btnImageMove.Name = "btnImageMove";
            this.btnImageMove.Size = new System.Drawing.Size(73, 23);
            this.btnImageMove.TabIndex = 56;
            this.btnImageMove.Text = "Move";
            this.btnImageMove.UseVisualStyleBackColor = true;
            this.btnImageMove.Click += new System.EventHandler(this.btnImageMove_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 653);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBoxScreenCap);
            this.Controls.Add(this.console);
            this.Name = "Main";
            this.Text = "Android Game Bot | Developer Tool";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScreenCap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMouseTap;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button btnGetScreenshot;
        private System.Windows.Forms.PictureBox picBoxScreenCap;
        private System.Windows.Forms.TextBox tbMouseX;
        private System.Windows.Forms.TextBox tbMouseY;
        private System.Windows.Forms.Label lblMouseCords;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.TextBox tbScreenshotImageLocation;
        private System.Windows.Forms.TextBox tbSearchImageLocation;
        private System.Windows.Forms.Button btnSearchForImage;
        private System.Windows.Forms.Label lblImageCords;
        private System.Windows.Forms.TextBox tbImageY;
        private System.Windows.Forms.TextBox tbImageX;
        private System.Windows.Forms.Button btnImageTap;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lblSwipeStart;
        private System.Windows.Forms.Button btnSwipe;
        private System.Windows.Forms.TextBox tbSwipeYStart;
        private System.Windows.Forms.TextBox tbSwipeXStart;
        private System.Windows.Forms.TextBox tbSwipeYEnd;
        private System.Windows.Forms.TextBox tbSwipeXEnd;
        private System.Windows.Forms.Label lblSwipeEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMouseCordsDur;
        private System.Windows.Forms.TextBox tbImageCordsDur;
        private System.Windows.Forms.Button btnMouseMove;
        private System.Windows.Forms.Button btnImageMove;
    }
}

