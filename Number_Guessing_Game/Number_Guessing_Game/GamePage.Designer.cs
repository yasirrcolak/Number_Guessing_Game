
namespace Number_Guessing_Game
{
    partial class GamePage
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
            this.components = new System.ComponentModel.Container();
            this.backButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.writeGameInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.livesLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gameZoneGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.enterGameInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.repeatingNumberNoRadioButton = new System.Windows.Forms.RadioButton();
            this.repeatingNumberYesRadioButton = new System.Windows.Forms.RadioButton();
            this.numberOfDigitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfLivesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.writeGameInformationGroupBox.SuspendLayout();
            this.gameZoneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guessNumericUpDown)).BeginInit();
            this.enterGameInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDigitsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLivesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.backButton.Location = new System.Drawing.Point(175, 429);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(254, 82);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label9.Location = new System.Drawing.Point(18, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "İsim:";
            // 
            // writeGameInformationGroupBox
            // 
            this.writeGameInformationGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.writeGameInformationGroupBox.Controls.Add(this.livesLabel);
            this.writeGameInformationGroupBox.Controls.Add(this.timeLabel);
            this.writeGameInformationGroupBox.Controls.Add(this.scoreLabel);
            this.writeGameInformationGroupBox.Controls.Add(this.playerNameLabel);
            this.writeGameInformationGroupBox.Controls.Add(this.label5);
            this.writeGameInformationGroupBox.Controls.Add(this.label3);
            this.writeGameInformationGroupBox.Controls.Add(this.label9);
            this.writeGameInformationGroupBox.Controls.Add(this.label4);
            this.writeGameInformationGroupBox.Location = new System.Drawing.Point(671, 35);
            this.writeGameInformationGroupBox.Name = "writeGameInformationGroupBox";
            this.writeGameInformationGroupBox.Size = new System.Drawing.Size(597, 147);
            this.writeGameInformationGroupBox.TabIndex = 19;
            this.writeGameInformationGroupBox.TabStop = false;
            this.writeGameInformationGroupBox.Text = "Oyun bilgileri";
            // 
            // livesLabel
            // 
            this.livesLabel.BackColor = System.Drawing.SystemColors.Window;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.livesLabel.Location = new System.Drawing.Point(527, 74);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(62, 38);
            this.livesLabel.TabIndex = 33;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.Location = new System.Drawing.Point(296, 74);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(62, 38);
            this.timeLabel.TabIndex = 32;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.SystemColors.Window;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLabel.Location = new System.Drawing.Point(93, 74);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(107, 38);
            this.scoreLabel.TabIndex = 31;
            this.scoreLabel.Text = "0";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerNameLabel.Location = new System.Drawing.Point(92, 26);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(498, 38);
            this.playerNameLabel.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(5, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Puan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(206, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Süre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(364, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kalan Hak:";
            // 
            // gameZoneGroupBox
            // 
            this.gameZoneGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.gameZoneGroupBox.Controls.Add(this.flowLayoutPanel);
            this.gameZoneGroupBox.Controls.Add(this.guessNumericUpDown);
            this.gameZoneGroupBox.Controls.Add(this.label2);
            this.gameZoneGroupBox.Controls.Add(this.guessButton);
            this.gameZoneGroupBox.Location = new System.Drawing.Point(671, 202);
            this.gameZoneGroupBox.Name = "gameZoneGroupBox";
            this.gameZoneGroupBox.Size = new System.Drawing.Size(597, 315);
            this.gameZoneGroupBox.TabIndex = 20;
            this.gameZoneGroupBox.TabStop = false;
            this.gameZoneGroupBox.Text = "Oyun Sahası";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(79, 105);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(460, 45);
            this.flowLayoutPanel.TabIndex = 24;
            // 
            // guessNumericUpDown
            // 
            this.guessNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guessNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.guessNumericUpDown.Location = new System.Drawing.Point(159, 184);
            this.guessNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.guessNumericUpDown.Name = "guessNumericUpDown";
            this.guessNumericUpDown.Size = new System.Drawing.Size(309, 38);
            this.guessNumericUpDown.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(73, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sayı:";
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.guessButton.Enabled = false;
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guessButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.guessButton.Location = new System.Drawing.Point(163, 227);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(254, 82);
            this.guessButton.TabIndex = 21;
            this.guessButton.Text = "Tahmin Et";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // enterGameInformationGroupBox
            // 
            this.enterGameInformationGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.enterGameInformationGroupBox.Controls.Add(this.repeatingNumberNoRadioButton);
            this.enterGameInformationGroupBox.Controls.Add(this.repeatingNumberYesRadioButton);
            this.enterGameInformationGroupBox.Controls.Add(this.numberOfDigitsNumericUpDown);
            this.enterGameInformationGroupBox.Controls.Add(this.numberOfLivesNumericUpDown);
            this.enterGameInformationGroupBox.Controls.Add(this.playerNameTextBox);
            this.enterGameInformationGroupBox.Controls.Add(this.label6);
            this.enterGameInformationGroupBox.Controls.Add(this.label7);
            this.enterGameInformationGroupBox.Controls.Add(this.label8);
            this.enterGameInformationGroupBox.Controls.Add(this.label10);
            this.enterGameInformationGroupBox.Location = new System.Drawing.Point(18, 92);
            this.enterGameInformationGroupBox.Name = "enterGameInformationGroupBox";
            this.enterGameInformationGroupBox.Size = new System.Drawing.Size(597, 230);
            this.enterGameInformationGroupBox.TabIndex = 23;
            this.enterGameInformationGroupBox.TabStop = false;
            // 
            // repeatingNumberNoRadioButton
            // 
            this.repeatingNumberNoRadioButton.AutoSize = true;
            this.repeatingNumberNoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.repeatingNumberNoRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.repeatingNumberNoRadioButton.Location = new System.Drawing.Point(434, 180);
            this.repeatingNumberNoRadioButton.Name = "repeatingNumberNoRadioButton";
            this.repeatingNumberNoRadioButton.Size = new System.Drawing.Size(138, 35);
            this.repeatingNumberNoRadioButton.TabIndex = 22;
            this.repeatingNumberNoRadioButton.TabStop = true;
            this.repeatingNumberNoRadioButton.Text = "Olmasın";
            this.repeatingNumberNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // repeatingNumberYesRadioButton
            // 
            this.repeatingNumberYesRadioButton.AutoSize = true;
            this.repeatingNumberYesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.repeatingNumberYesRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.repeatingNumberYesRadioButton.Location = new System.Drawing.Point(303, 180);
            this.repeatingNumberYesRadioButton.Name = "repeatingNumberYesRadioButton";
            this.repeatingNumberYesRadioButton.Size = new System.Drawing.Size(108, 35);
            this.repeatingNumberYesRadioButton.TabIndex = 21;
            this.repeatingNumberYesRadioButton.TabStop = true;
            this.repeatingNumberYesRadioButton.Text = "Olsun";
            this.repeatingNumberYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberOfDigitsNumericUpDown
            // 
            this.numberOfDigitsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberOfDigitsNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.numberOfDigitsNumericUpDown.Location = new System.Drawing.Point(282, 134);
            this.numberOfDigitsNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numberOfDigitsNumericUpDown.Name = "numberOfDigitsNumericUpDown";
            this.numberOfDigitsNumericUpDown.Size = new System.Drawing.Size(309, 38);
            this.numberOfDigitsNumericUpDown.TabIndex = 20;
            // 
            // numberOfLivesNumericUpDown
            // 
            this.numberOfLivesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberOfLivesNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.numberOfLivesNumericUpDown.Location = new System.Drawing.Point(282, 90);
            this.numberOfLivesNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberOfLivesNumericUpDown.Name = "numberOfLivesNumericUpDown";
            this.numberOfLivesNumericUpDown.Size = new System.Drawing.Size(309, 38);
            this.numberOfLivesNumericUpDown.TabIndex = 19;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.playerNameTextBox.Location = new System.Drawing.Point(282, 41);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(309, 38);
            this.playerNameTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label6.Location = new System.Drawing.Point(199, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "İsim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label7.Location = new System.Drawing.Point(8, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tekrar eden rakam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label8.Location = new System.Drawing.Point(118, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hak sayısı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label10.Location = new System.Drawing.Point(50, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 31);
            this.label10.TabIndex = 16;
            this.label10.Text = "Basamak sayısı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(128, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(375, 39);
            this.label11.TabIndex = 22;
            this.label11.Text = "Oyun bilgilerini giriniz.";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.startButton.Location = new System.Drawing.Point(175, 337);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(254, 82);
            this.startButton.TabIndex = 21;
            this.startButton.Text = "Başla";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(635, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 551);
            this.label13.TabIndex = 35;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1291, 547);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.enterGameInformationGroupBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameZoneGroupBox);
            this.Controls.Add(this.writeGameInformationGroupBox);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.writeGameInformationGroupBox.ResumeLayout(false);
            this.writeGameInformationGroupBox.PerformLayout();
            this.gameZoneGroupBox.ResumeLayout(false);
            this.gameZoneGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guessNumericUpDown)).EndInit();
            this.enterGameInformationGroupBox.ResumeLayout(false);
            this.enterGameInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDigitsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLivesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox writeGameInformationGroupBox;
        private System.Windows.Forms.GroupBox gameZoneGroupBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.GroupBox enterGameInformationGroupBox;
        private System.Windows.Forms.RadioButton repeatingNumberNoRadioButton;
        private System.Windows.Forms.RadioButton repeatingNumberYesRadioButton;
        private System.Windows.Forms.NumericUpDown numberOfDigitsNumericUpDown;
        private System.Windows.Forms.NumericUpDown numberOfLivesNumericUpDown;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown guessNumericUpDown;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}