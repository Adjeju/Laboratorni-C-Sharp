using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWF
{
    public partial class Form1 : Form
    {
        Snake snake;
        public Form1()
        {
            InitializeComponent();
            this.Width = 645;
            this.Height = 666;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            snake = new Snake(this, 0,0);
            snake.CreateBoard();
            snake.DrawFood();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            snake.ChangeDirection(sender,e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.MyTick(sender, e);
        }
    }
}
