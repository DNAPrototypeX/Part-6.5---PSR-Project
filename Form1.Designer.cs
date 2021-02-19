namespace Part_6._5___PSR_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblCpuWins = new System.Windows.Forms.Label();
            this.nudBetting = new System.Windows.Forms.NumericUpDown();
            this.lblBallance = new System.Windows.Forms.Label();
            this.btnSubmitBet = new System.Windows.Forms.Button();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.imgScissors = new System.Windows.Forms.PictureBox();
            this.imgPaper = new System.Windows.Forms.PictureBox();
            this.imgRock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 36);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(776, 58);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblResult.Visible = false;
            // 
            // btnNextRound
            // 
            this.btnNextRound.BackColor = System.Drawing.Color.Green;
            this.btnNextRound.Font = new System.Drawing.Font("Showcard Gothic", 36F);
            this.btnNextRound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNextRound.Location = new System.Drawing.Point(208, 326);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(372, 112);
            this.btnNextRound.TabIndex = 6;
            this.btnNextRound.Text = "Next Round";
            this.btnNextRound.UseVisualStyleBackColor = false;
            this.btnNextRound.Visible = false;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Green;
            this.btnPlayAgain.Font = new System.Drawing.Font("Showcard Gothic", 36F);
            this.btnPlayAgain.Location = new System.Drawing.Point(208, 97);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(442, 186);
            this.btnPlayAgain.TabIndex = 7;
            this.btnPlayAgain.Text = "Play Again?";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 112);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(12, 9);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(77, 27);
            this.lblPlayerWins.TabIndex = 9;
            this.lblPlayerWins.Text = "Wins: ";
            // 
            // lblCpuWins
            // 
            this.lblCpuWins.AutoSize = true;
            this.lblCpuWins.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuWins.Location = new System.Drawing.Point(694, 9);
            this.lblCpuWins.Name = "lblCpuWins";
            this.lblCpuWins.Size = new System.Drawing.Size(77, 27);
            this.lblCpuWins.TabIndex = 10;
            this.lblCpuWins.Text = "Wins: ";
            // 
            // nudBetting
            // 
            this.nudBetting.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.nudBetting.Location = new System.Drawing.Point(634, 391);
            this.nudBetting.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBetting.Name = "nudBetting";
            this.nudBetting.Size = new System.Drawing.Size(59, 33);
            this.nudBetting.TabIndex = 11;
            this.nudBetting.ValueChanged += new System.EventHandler(this.nudBetting_ValueChanged);
            // 
            // lblBallance
            // 
            this.lblBallance.AutoSize = true;
            this.lblBallance.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.lblBallance.Location = new System.Drawing.Point(337, 9);
            this.lblBallance.Name = "lblBallance";
            this.lblBallance.Size = new System.Drawing.Size(140, 27);
            this.lblBallance.TabIndex = 12;
            this.lblBallance.Text = "Money: 100$";
            // 
            // btnSubmitBet
            // 
            this.btnSubmitBet.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitBet.Location = new System.Drawing.Point(699, 381);
            this.btnSubmitBet.Name = "btnSubmitBet";
            this.btnSubmitBet.Size = new System.Drawing.Size(94, 57);
            this.btnSubmitBet.TabIndex = 13;
            this.btnSubmitBet.Text = "Submit Bet";
            this.btnSubmitBet.UseVisualStyleBackColor = true;
            this.btnSubmitBet.Click += new System.EventHandler(this.btnSubmitBet_Click);
            // 
            // imgOpponent
            // 
            this.imgOpponent.BackColor = System.Drawing.Color.White;
            this.imgOpponent.Location = new System.Drawing.Point(591, 135);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Padding = new System.Windows.Forms.Padding(5);
            this.imgOpponent.Size = new System.Drawing.Size(112, 175);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 3;
            this.imgOpponent.TabStop = false;
            // 
            // imgScissors
            // 
            this.imgScissors.BackColor = System.Drawing.Color.White;
            this.imgScissors.Image = global::Part_6._5___PSR_Project.Properties.Resources.scissors;
            this.imgScissors.Location = new System.Drawing.Point(342, 135);
            this.imgScissors.Name = "imgScissors";
            this.imgScissors.Padding = new System.Windows.Forms.Padding(5);
            this.imgScissors.Size = new System.Drawing.Size(112, 175);
            this.imgScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissors.TabIndex = 2;
            this.imgScissors.TabStop = false;
            this.imgScissors.Click += new System.EventHandler(this.imgScissors_Click);
            // 
            // imgPaper
            // 
            this.imgPaper.BackColor = System.Drawing.Color.White;
            this.imgPaper.Image = global::Part_6._5___PSR_Project.Properties.Resources.paper;
            this.imgPaper.Location = new System.Drawing.Point(194, 135);
            this.imgPaper.Name = "imgPaper";
            this.imgPaper.Padding = new System.Windows.Forms.Padding(5);
            this.imgPaper.Size = new System.Drawing.Size(112, 175);
            this.imgPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaper.TabIndex = 1;
            this.imgPaper.TabStop = false;
            this.imgPaper.Click += new System.EventHandler(this.imgPaper_Click);
            // 
            // imgRock
            // 
            this.imgRock.BackColor = System.Drawing.Color.White;
            this.imgRock.Image = global::Part_6._5___PSR_Project.Properties.Resources.rock;
            this.imgRock.Location = new System.Drawing.Point(52, 135);
            this.imgRock.Name = "imgRock";
            this.imgRock.Padding = new System.Windows.Forms.Padding(5);
            this.imgRock.Size = new System.Drawing.Size(112, 175);
            this.imgRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock.TabIndex = 0;
            this.imgRock.TabStop = false;
            this.imgRock.Click += new System.EventHandler(this.imgRock_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmitBet);
            this.Controls.Add(this.lblBallance);
            this.Controls.Add(this.nudBetting);
            this.Controls.Add(this.lblCpuWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.imgScissors);
            this.Controls.Add(this.imgPaper);
            this.Controls.Add(this.imgRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.nudBetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgRock;
        private System.Windows.Forms.PictureBox imgPaper;
        private System.Windows.Forms.PictureBox imgScissors;
        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblCpuWins;
        private System.Windows.Forms.NumericUpDown nudBetting;
        private System.Windows.Forms.Label lblBallance;
        private System.Windows.Forms.Button btnSubmitBet;
    }
}

