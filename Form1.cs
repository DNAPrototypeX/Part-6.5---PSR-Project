using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6._5___PSR_Project
{
    public partial class frmMain : Form
    {
        int computerChoice;
        int wins = 0;
        int cpuWins = 0;
        int money = 100;
        int betValue = 0;
        bool betSubmited = false;
        Random rng = new Random();
        void playAgain()
        {
            if (wins >= 3 || cpuWins >= 3)
            {
                if (betSubmited == true)
                {
                    if (wins == 3)
                    {
                        money += betValue * 2;
                    }
                    else
                    {
                        money -= betValue * 4;
                    }
                    lblBallance.Text = $"Money: {money}";
                }
                imgOpponent.Visible = false;
                imgRock.Visible = false;
                imgPaper.Visible = false;
                imgScissors.Visible = false;
                lblResult.Visible = false;
                btnNextRound.Visible = false;
                btnPlayAgain.Visible = true;
                nudBetting.Visible = false;
                btnSubmitBet.Visible = false;
                btnExit.Text = "Exit";
                imgRock.BackColor = Color.White;
                imgPaper.BackColor = Color.White;
                imgScissors.BackColor = Color.White;
                imgOpponent.BackColor = Color.White;
            }
            return;
        }

        public frmMain()
        {
            InitializeComponent();            
        }

        private void imgRock_Click(object sender, EventArgs e)
        {
            computerChoice = rng.Next(0, 3);
            imgPaper.Visible = false;
            imgScissors.Visible = false;
            imgRock.Enabled = false;            
            lblResult.Visible = true;
            btnNextRound.Visible = true;
            btnSubmitBet.Enabled = false;
            nudBetting.Enabled = false;
            if (computerChoice == 1)
            {
                imgRock.BackColor = Color.Red;
                imgOpponent.BackColor = Color.Lime;
                imgOpponent.Image = Properties.Resources.paper;
                lblResult.Text = "You lost!";
                cpuWins += 1;
                lblCpuWins.Text = $"Wins: {cpuWins}";
            }
            else if (computerChoice == 2)
            {
                imgRock.BackColor = Color.Lime;
                imgOpponent.BackColor = Color.Red;
                imgOpponent.Image = Properties.Resources.scissors;
                lblResult.Text = "Victory!";
                wins += 1;
                lblPlayerWins.Text = $"Wins: {wins}";
            }
            else if (computerChoice == 0)
            {
                imgRock.BackColor = Color.SkyBlue;
                imgOpponent.BackColor = Color.SkyBlue;
                imgOpponent.Image = Properties.Resources.rock;
                lblResult.Text = "It's a tie!";
            }
            playAgain();
        }

        private void imgPaper_Click(object sender, EventArgs e)
        {
            computerChoice = rng.Next(0, 3);
            imgRock.Visible = false;
            imgScissors.Visible = false;
            imgPaper.Enabled = false;
            lblResult.Visible = true;
            btnNextRound.Visible = true;
            btnSubmitBet.Enabled = false;
            nudBetting.Enabled = false;
            if (computerChoice == 1)
            {
                imgPaper.BackColor = Color.SkyBlue;
                imgOpponent.BackColor = Color.SkyBlue;
                imgOpponent.Image = Properties.Resources.paper;
                lblResult.Text = "It's a tie!";                
            }
            else if (computerChoice == 2)
            {
                imgPaper.BackColor = Color.Red;
                imgOpponent.BackColor = Color.Lime;
                imgOpponent.Image = Properties.Resources.scissors;
                lblResult.Text = "You lost!";
                cpuWins += 1;
                lblCpuWins.Text = $"Wins: {cpuWins}";
            }
            else if (computerChoice == 0)
            {
                imgPaper.BackColor = Color.Lime;
                imgOpponent.BackColor = Color.Red;
                imgOpponent.Image = Properties.Resources.rock;
                lblResult.Text = "Victory!";
                wins += 1;
                lblPlayerWins.Text = $"Wins: {wins}";
            }
            playAgain();
        }

        private void imgScissors_Click(object sender, EventArgs e)
        {             
            computerChoice = rng.Next(0, 3);
            imgRock.Visible = false;
            imgPaper.Visible = false;
            imgScissors.Enabled = false;
            lblResult.Visible = true;
            btnNextRound.Visible = true;
            btnSubmitBet.Enabled = false;
            nudBetting.Enabled = false;
            if (computerChoice == 1)
            {
                imgOpponent.Image = Properties.Resources.paper;
                imgScissors.BackColor = Color.Lime;
                imgOpponent.BackColor = Color.Red;
                lblResult.Text = "Victory!";
                wins += 1;
                lblPlayerWins.Text = $"Wins: {wins}";
            }
            else if (computerChoice == 2)
            {
                imgScissors.BackColor = Color.SkyBlue;
                imgOpponent.BackColor = Color.SkyBlue;
                imgOpponent.Image = Properties.Resources.scissors;
                lblResult.Text = "It's a tie!";                
            }
            else if (computerChoice == 0)
            {
                imgScissors.BackColor = Color.Red;
                imgOpponent.BackColor = Color.Lime;
                imgOpponent.Image = Properties.Resources.rock;
                lblResult.Text = "You lost!";
                cpuWins += 1;
                lblCpuWins.Text = $"Wins: {cpuWins}";
            }
            playAgain();
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            imgRock.Visible = true;
            imgPaper.Visible = true;
            imgScissors.Visible = true;
            imgRock.Enabled = true;
            imgPaper.Enabled = true;
            imgScissors.Enabled = true;
            imgOpponent.Image = null;
            lblResult.Visible = false;
            btnNextRound.Visible = false;
            nudBetting.Visible = true;
            btnSubmitBet.Visible = true;
            nudBetting.Value = 0;
            imgRock.BackColor = Color.White;
            imgPaper.BackColor = Color.White;
            imgScissors.BackColor = Color.White;
            imgOpponent.BackColor = Color.White;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            wins = 0;
            cpuWins = 0;
            imgOpponent.Visible = true;
            imgRock.Visible = true;
            imgPaper.Visible = true;
            imgScissors.Visible = true;
            lblResult.Visible = false;
            imgRock.Enabled = true;
            imgPaper.Enabled = true;
            imgScissors.Enabled = true;
            btnNextRound.Visible = false;
            btnPlayAgain.Visible = false;
            nudBetting.Visible = true;
            btnSubmitBet.Visible = true;
            btnSubmitBet.Enabled = true; ;
            nudBetting.Enabled = true; ;
            lblCpuWins.Text = "Wins: ";
            lblPlayerWins.Text = "Wins: ";
            btnExit.Text = "Exit";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (money < 0)
            {
                btnExit.Text = "You must pay off your debts before you exit the program >:)";
            }
            else
            {
                Close();  
            }
                      
        }

        private void btnSubmitBet_Click(object sender, EventArgs e)
        {
            betSubmited = true;
            betValue = Convert.ToInt32(nudBetting.Value);
            btnSubmitBet.Enabled = false;
            nudBetting.Enabled = false;
        }
    }
}
