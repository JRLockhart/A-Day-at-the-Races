namespace A_Day_at_the_Races
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
            this.components = new System.ComponentModel.Container();
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.race = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bets = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dogNumberToBet = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberToBet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = global::A_Day_at_the_Races.Properties.Resources.racetrack;
            this.raceTrack.Location = new System.Drawing.Point(12, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(600, 200);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = global::A_Day_at_the_Races.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(12, 25);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::A_Day_at_the_Races.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(12, 73);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::A_Day_at_the_Races.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(12, 123);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::A_Day_at_the_Races.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(12, 179);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // race
            // 
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(389, 35);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(223, 106);
            this.race.TabIndex = 5;
            this.race.Text = "Race!";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Betting Parlor";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(13, 24);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 7;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(16, 49);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 8;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(16, 72);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 9;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(16, 95);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 17);
            this.alRadioButton.TabIndex = 10;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bets";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(227, 51);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(63, 13);
            this.joeBetLabel.TabIndex = 12;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(227, 74);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(67, 13);
            this.bobBetLabel.TabIndex = 13;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(227, 97);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(57, 13);
            this.alBetLabel.TabIndex = 14;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name";
            // 
            // bets
            // 
            this.bets.Location = new System.Drawing.Point(48, 124);
            this.bets.Name = "bets";
            this.bets.Size = new System.Drawing.Size(60, 20);
            this.bets.TabIndex = 16;
            this.bets.Text = "Bets";
            this.bets.UseVisualStyleBackColor = true;
            this.bets.Click += new System.EventHandler(this.bets_Click);
            // 
            // betAmount
            // 
            this.betAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Location = new System.Drawing.Point(114, 124);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(55, 20);
            this.betAmount.TabIndex = 17;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "bucks on dog number";
            // 
            // dogNumberToBet
            // 
            this.dogNumberToBet.Location = new System.Drawing.Point(296, 124);
            this.dogNumberToBet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumberToBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumberToBet.Name = "dogNumberToBet";
            this.dogNumberToBet.Size = new System.Drawing.Size(59, 20);
            this.dogNumberToBet.TabIndex = 19;
            this.dogNumberToBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dogNumberToBet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.betAmount);
            this.groupBox1.Controls.Add(this.bets);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Location = new System.Drawing.Point(4, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 166);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.raceTrack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberToBet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bets;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown dogNumberToBet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

