using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Snake.Model
{
    public class Fruit
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Segment { get; set; }

        public Fruit(int segment)
        {
            Segment = segment;
            this.NewFruit();
        }

        public void NewFruit()
        {
            Random r = new Random();
            X = r.Next(0, 20) * Segment;
            Y = r.Next(0, 20) * Segment;
        }

        public bool RandomNewFruit(int glowa, int ogon)
        {
            if(X == glowa && Y == ogon)
            {
                this.NewFruit();
                return true;
            }
            return false;
        }

    }
}
