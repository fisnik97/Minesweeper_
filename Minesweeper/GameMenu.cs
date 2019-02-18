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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void btnSaveOptions_Click(object sender, EventArgs e)
        {
            if (rdEasy.Checked) Level = DifficultyLevel.Easy;
            else if (rdMedium.Checked) Level = DifficultyLevel.Medium;
            else Level = Level = DifficultyLevel.Hard;

            if((txtCols.Value <= 10 || txtCols.Value > 30) || (txtRows.Value <= 10 || txtRows.Value > 20))
            {
                MessageBox.Show("Please write the size of the game web!\nMax columns : 30\nMaxRows : 20");
                return;
            }

            Rows = (int)txtRows.Value;
            Columns =  (int)txtCols.Value;
            this.Close();
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            if (Level == DifficultyLevel.Easy) rdEasy.Checked = true;
            else if (Level == DifficultyLevel.Medium) rdMedium.Checked = true;
            else rdHard.Checked = true;

            this.txtCols.Value = Columns;
            this.txtRows.Value = Rows;
        }
    }
}
