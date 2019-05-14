using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Snake.Model
{
    public class Snake
    {
        public int Segemnt { get; set; }
        public int Segmenty { get; set; }
        public int[] X { get; set; }
        public int[] Y { get; set; }
        public Move? Move { get; set; } = null;

        public Snake(int szer, int wys)
        {
            this.X = new int[900];
            this.Y = new int[900];
            DefaultSettings(szer);
        }

        private void DefaultSettings(int szer)
        {
            Segemnt = szer / 20;
            Segmenty = 3;
            Move = Model.Move.PRAWO;
            int xg = 9 * Segemnt;
            int yg = 9 * Segemnt;
            for (int i = 0; i < Segmenty; i++)
            {
                X[i] = xg - (i * Segemnt);
                Y[i] = yg;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region move snake
        public void MoveSnake()
        {
            //for (int i = Segmenty; i > 0; i--)
            //{
            //    X[i] = X[i - 1];
            //    Y[i] = Y[i - 1];
            //}
            //switch (Move)
            //{
            //    case Model.Move.PRAWO:
            //        X[0] = X[0] + Segemnt;
            //        break;
            //    case Model.Move.LEWO:
            //        X[0] = X[0] - Segemnt;
            //        break;
            //    case Model.Move.GORA:
            //        Y[0] = Y[0] - Segemnt;
            //        break;
            //    case Model.Move.DOL:
            //        Y[0] = Y[0] + Segemnt;
            //        break;
            //}
            //if (X[0] < 0) { X[0] = Segemnt * 19; }
            //if (X[0] > Segemnt * 20) { X[0] = 0; }
            //if (Y[0] < 0) { Y[0] = Segemnt * 19; }
            //if (Y[0] > Segemnt * 20) { Y[0] = 0; }
        }
        #endregion
    }
}
