using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minesweeper.GameWeb;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Developed with fun: Fisnik Maloku
        /// Date: 2019.17.Feb
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            var d = new GameMenu();
            d.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGame();
        }

        private void InitGame()
        {
            AddWebToPanel(GenerateWeb());
            AdjustWindowsSize();
            GameOverEvent += OnGameLose;
            GameWonEvent += OnGameWin;
        }

        private void AddWebToPanel(Box[,] web)
        {
            for (int i = 0; i < web.GetLength(0); i++)
            {
                for (int j = 0; j < web.GetLength(1); j++)
                {
                    this.panel1.Controls.Add(web[i, j]);
                }
            }
        }

        private void AdjustWindowsSize()
        {
            this.panel1.Size = new Size
            {
                Width  = Columns * boxWidth + 23,
                Height = Rows    * boxHeight + 131
            };
            this.Size = panel1.Size;
        }

        private void OnGameWin()
        {
            pbAnimation.Image = resources.bombFail2;
            if(MessageBox.Show($"Congratulations ... You won the game!\nPlay Again ?", "Congratulations", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ResetGame();
                InitGame();
            }
            else Application.Exit();
        }

        private void OnGameLose()
        {
            pbAnimation.Image = resources.bombExplode2;
            if (MessageBox.Show($"You lost!", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
            {
                ResetGame();
                InitGame();
            }
            else Application.Exit();
        }

        private void ResetGame()
        {
            pbAnimation.Image = null;
            panel1.Controls.Clear();
            GameOverEvent -= OnGameLose;
            GameWonEvent -= OnGameWin;
            AdjustWindowsSize();
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            GameMenu gm = new GameMenu();
            gm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ResetGame();
            InitGame();
        }
    }
}
