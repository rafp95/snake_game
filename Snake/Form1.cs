using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private bool _isStarted;
        private Model.Snake _snake;
        public Form1()
        {
            InitializeComponent();
            this._isStarted = false;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isStarted)
            {
                pole_gry.CreateGraphics().Clear(Color.Black);
                _snake.MoveSnake();
                DrawSnake(pole_gry.CreateGraphics(), new SolidBrush(Color.Aqua));
            }
            else
            {
                FontFamily fontFamily = new FontFamily("Arial");
                Font font = new Font(fontFamily, 15);
                Brush b = new SolidBrush(Color.Aqua);
                this.pole_gry.CreateGraphics().DrawString("Start ", font, b, 90, 100);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._isStarted = true;
            _snake = new Model.Snake(pole_gry.Width, pole_gry.Height);
        }

        public void DrawSnake(Graphics g, Brush b)
        {
            for (int i = 0; i < _snake.Segmenty; i++)
            {
                g.FillRectangle(b, _snake.X[i], _snake.Y[i], _snake.Segemnt, _snake.Segemnt);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) _snake.Move = Model.Move.GORA;
            if (e.KeyCode == Keys.Down) _snake.Move = Model.Move.DOL;
            if (e.KeyCode == Keys.Right) _snake.Move = Model.Move.PRAWO;
            if (e.KeyCode == Keys.Left) _snake.Move = Model.Move.LEWO;
        }
    }
}
