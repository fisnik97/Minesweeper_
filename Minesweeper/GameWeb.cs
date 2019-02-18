using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public delegate void GameOverDel();
    public delegate void GameWonDel();

    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard
    }

    public class GameWeb
    {
        public static Box[,] Box { get; set; }
        private static Random rand;
        public static int boxWidth = 30;
        public static int boxHeight = 30;
        public static event GameOverDel GameOverEvent;
        public static event GameOverDel GameWonEvent;
        public static DifficultyLevel Level { get; set; }
        public static int Rows { get; set; } = 15;
        public static int Columns { get; set; } = 20;
        public static bool InGame { get; set; }

        public GameWeb() { }

        public static Box[,] GenerateWeb()
        {
            BuildBoxMatrix();
            MineArea();
            return Box;
        }

        private static void RevealAllMines(bool hasWon)
        {
            var sadBomb = resources.bmbSad;
            var happyBomb = resources.bmbHappy1;
            for (int i = 0; i < Box.GetLength(0); i++)
            {
                for (int k = 0; k < Box.GetLength(1); k++)
                {
                    if (Box[i, k].HasBomb)
                    {
                        Box[i, k].Image = hasWon ? sadBomb : happyBomb;
                        Box[i, k].ImageAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
        }

        public static void GameOver()
        {
            RevealAllMines(false);
            GameOverEvent.Invoke();
        }

        public static void IsGameWon()
        {
            int clicked = 0, bombs = 0;
            for (int i = 0; i < Box.GetLength(0); i++)
            {
                for (int j = 0; j < Box.GetLength(1); j++)
                {
                    if (Box[i, j].IsClicked) clicked++;
                    if (Box[i, j].HasBomb) bombs++;
                }
            }
            if (clicked == (Box.Length - bombs))
            {
                RevealAllMines(true);
                GameWonEvent.Invoke();
            }
        }

        private static void MineArea()
        {
            rand = new Random();
            for (int i = 0; i < Box.GetLength(0); i++)
            {
                for (int j = 0; j < Box.GetLength(1); j++)
                {
                    var b = Box[i, j];
                    if (rand.Next(1, (Level == DifficultyLevel.Easy ? 15 : (Level == DifficultyLevel.Medium ? 10 : 6))) == 2)
                    {
                        b.HasBomb = true;
                    }
                }
            }
        }

        private static void BuildBoxMatrix()
        {
            Box = new Box[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    var b = new Box()
                    {
                        X = i,
                        Y = j,
                        Width = boxWidth,
                        Height = boxHeight,
                        Location = new Point()
                        {
                            X = boxWidth * j,
                            Y = boxHeight * i
                        },
                    };
                    Box[i, j] = b;
                }
            }
        }

    }
}
