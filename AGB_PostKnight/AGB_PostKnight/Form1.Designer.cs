namespace AGB_PostKnight
{
    partial class Form1
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
            this.console = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnSelectMission = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            this.btnFindSign = new System.Windows.Forms.Button();
            this.btnDetectState = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numGiftRunDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbGiftNPC = new System.Windows.Forms.CheckBox();
            this.rbDiffHard = new System.Windows.Forms.RadioButton();
            this.rbDiffEasy = new System.Windows.Forms.RadioButton();
            this.cbRunMission = new System.Windows.Forms.CheckBox();
            this.cbMissionNumber = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiftRunDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.MenuText;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.SystemColors.Window;
            this.console.Location = new System.Drawing.Point(116, 111);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(336, 357);
            this.console.TabIndex = 0;
            this.console.Text = "";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(89, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 156);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // btnSelectMission
            // 
            this.btnSelectMission.Location = new System.Drawing.Point(12, 70);
            this.btnSelectMission.Name = "btnSelectMission";
            this.btnSelectMission.Size = new System.Drawing.Size(89, 23);
            this.btnSelectMission.TabIndex = 3;
            this.btnSelectMission.Text = "Select Mission";
            this.btnSelectMission.UseVisualStyleBackColor = true;
            this.btnSelectMission.Click += new System.EventHandler(this.btnSelectMission_Click);
            // 
            // btnFight
            // 
            this.btnFight.Location = new System.Drawing.Point(12, 99);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(89, 23);
            this.btnFight.TabIndex = 4;
            this.btnFight.Text = "Fight";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // btnFindSign
            // 
            this.btnFindSign.Location = new System.Drawing.Point(12, 41);
            this.btnFindSign.Name = "btnFindSign";
            this.btnFindSign.Size = new System.Drawing.Size(89, 23);
            this.btnFindSign.TabIndex = 5;
            this.btnFindSign.Text = "Find Sign";
            this.btnFindSign.UseVisualStyleBackColor = true;
            this.btnFindSign.Click += new System.EventHandler(this.btnFindSign_Click);
            // 
            // btnDetectState
            // 
            this.btnDetectState.Location = new System.Drawing.Point(12, 128);
            this.btnDetectState.Name = "btnDetectState";
            this.btnDetectState.Size = new System.Drawing.Size(89, 23);
            this.btnDetectState.TabIndex = 6;
            this.btnDetectState.Text = "Detect State";
            this.btnDetectState.UseVisualStyleBackColor = true;
            this.btnDetectState.Click += new System.EventHandler(this.btnDetectState_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numGiftRunDelay);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.cbGiftNPC);
            this.groupBox1.Controls.Add(this.rbDiffHard);
            this.groupBox1.Controls.Add(this.rbDiffEasy);
            this.groupBox1.Controls.Add(this.cbRunMission);
            this.groupBox1.Controls.Add(this.cbMissionNumber);
            this.groupBox1.Location = new System.Drawing.Point(116, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 93);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Settings ";
            // 
            // numGiftRunDelay
            // 
            this.numGiftRunDelay.Location = new System.Drawing.Point(106, 66);
            this.numGiftRunDelay.Name = "numGiftRunDelay";
            this.numGiftRunDelay.Size = new System.Drawing.Size(39, 20);
            this.numGiftRunDelay.TabIndex = 21;
            this.numGiftRunDelay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(150, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 44);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(218, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Watch ad to heal if below                % hp";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbGiftNPC
            // 
            this.cbGiftNPC.AutoSize = true;
            this.cbGiftNPC.Location = new System.Drawing.Point(6, 67);
            this.cbGiftNPC.Name = "cbGiftNPC";
            this.cbGiftNPC.Size = new System.Drawing.Size(178, 17);
            this.cbGiftNPC.TabIndex = 18;
            this.cbGiftNPC.Text = "Gift NPCs every                 run(s)";
            this.cbGiftNPC.UseVisualStyleBackColor = true;
            // 
            // rbDiffHard
            // 
            this.rbDiffHard.AutoSize = true;
            this.rbDiffHard.Location = new System.Drawing.Point(273, 20);
            this.rbDiffHard.Name = "rbDiffHard";
            this.rbDiffHard.Size = new System.Drawing.Size(48, 17);
            this.rbDiffHard.TabIndex = 17;
            this.rbDiffHard.Text = "Hard";
            this.rbDiffHard.UseVisualStyleBackColor = true;
            // 
            // rbDiffEasy
            // 
            this.rbDiffEasy.AutoSize = true;
            this.rbDiffEasy.Checked = true;
            this.rbDiffEasy.Location = new System.Drawing.Point(219, 20);
            this.rbDiffEasy.Name = "rbDiffEasy";
            this.rbDiffEasy.Size = new System.Drawing.Size(48, 17);
            this.rbDiffEasy.TabIndex = 16;
            this.rbDiffEasy.TabStop = true;
            this.rbDiffEasy.Text = "Easy";
            this.rbDiffEasy.UseVisualStyleBackColor = true;
            // 
            // cbRunMission
            // 
            this.cbRunMission.AutoSize = true;
            this.cbRunMission.Location = new System.Drawing.Point(6, 19);
            this.cbRunMission.Name = "cbRunMission";
            this.cbRunMission.Size = new System.Drawing.Size(84, 17);
            this.cbRunMission.TabIndex = 15;
            this.cbRunMission.Text = "Run Mission";
            this.cbRunMission.UseVisualStyleBackColor = true;
            // 
            // cbMissionNumber
            // 
            this.cbMissionNumber.Items.AddRange(new object[] {
            "Mission 1",
            "Mission 2",
            "Mission 3",
            "Mission 4",
            "Mission 5"});
            this.cbMissionNumber.Location = new System.Drawing.Point(92, 17);
            this.cbMissionNumber.Name = "cbMissionNumber";
            this.cbMissionNumber.Size = new System.Drawing.Size(121, 21);
            this.cbMissionNumber.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDetectState);
            this.Controls.Add(this.btnFindSign);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.btnSelectMission);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.console);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiftRunDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnSelectMission;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Button btnFindSign;
        private System.Windows.Forms.Button btnDetectState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbGiftNPC;
        private System.Windows.Forms.RadioButton rbDiffHard;
        private System.Windows.Forms.RadioButton rbDiffEasy;
        private System.Windows.Forms.CheckBox cbRunMission;
        private System.Windows.Forms.ComboBox cbMissionNumber;
        private System.Windows.Forms.NumericUpDown numGiftRunDelay;
    }
}

