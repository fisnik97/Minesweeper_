using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Minesweeper
{

    public class Box : Button
    {
        public bool IsClicked { get; set; }
        public bool HasBomb { get; set; }
        public int MinesAround  => CountMinesAround(this);
        public bool HasDetonated { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private Random rand;

        public Box(bool isClicked, short minesAround, bool hasDetonated)
        {
            rand = new Random();
            IsClicked = isClicked;
            HasDetonated = hasDetonated;
        }

        public Box()
        { rand = new Random(); }

        public Box(string text)
        {
            rand = new Random();
            this.Text = text;
        }


        protected override void OnClick(EventArgs e)
        {
            BoxClicked();
        }

        private void BoxClicked()
        {
            if (this.IsClicked) return;
            this.IsClicked = true;
            var box = GameWeb.Box[this.X, this.Y];
            if (box.HasBomb)
            {
                GameWeb.GameOver();
                return;
            }
            else
            {
                OpenBox();
                this.Text = CountMinesAround(box).ToString();
                this.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
                RevealNeighbors(box, rand.Next(5, 20));
                GameWeb.IsGameWon();
            }

        }

        private void OpenBox()
        {
            this.IsClicked = true;
            this.BackColor = System.Drawing.Color.White;
        }

        private void RevealNeighbors(Box box, int level)
        {
            if (level == 0)
                return;

            int xPeek = GameWeb.Box.GetLength(0) - 1;
            int yPeek = GameWeb.Box.GetLength(1) - 1;
            if (X == 0 || X == xPeek) return;//In corners dont reveal around boxes
            if (Y == 0 || Y == yPeek) return;//In corners dont reveal around boxes
            var boxes = new List<Box>();
            for (int i = (X <= 0 ? X : X - 1); i <= (box.X >= xPeek ? X : X + 1); i++)
            {
                for (int j = (Y <= 0 ? Y : Y - 1); j <= (box.Y >= yPeek ? box.Y : box.Y + 1); j++)
                {
                    boxes.Add(GameWeb.Box[i, j]);
                }
            }
            foreach (var item in boxes.Where(x => !x.IsClicked && !x.HasBomb))
            {
                item.OpenBox();
                item.Text = item.MinesAround == 0 ? string.Empty : item.MinesAround.ToString();
                if (level == 0)
                    break;
                RevealNeighbors(item, --level); //Rekurzion, i kufizuar nga vlera random level
            }
        }


        private int CountMinesAround(Box box)
        {
            int xZero = 0, xPeek = GameWeb.Box.GetLength(0) - 1;
            int yZero = 0, yPeek = GameWeb.Box.GetLength(1) - 1;
            var boxes = new List<Box>();
            for (int i = (X <= xZero ? X : X - 1); i <= (box.X >= xPeek ? X : X + 1); i++)
            {
                for (int j = (Y <= yZero ? Y : Y - 1); j <= (box.Y >= yPeek ? box.Y : box.Y + 1); j++)
                {
                    boxes.Add(GameWeb.Box[i, j]);
                }
            }
            return boxes.Count(x => x.HasBomb == true);
        }




    }
}
