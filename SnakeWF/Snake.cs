using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace SnakeWF
{
    class Snake
    {
        private PictureBox[,] board = new PictureBox[25,25];
        private Control parent;

        private int[] snakeX = new int[50];
        private int[] snakeY = new int[50];
        private int snakeParts = 1;
        private int foodX;
        private int foodY;
        private string direction;

        private Timer timer = new Timer();

        private Random random = new Random();

        //Constructor
        public Snake(Control parent, int snakeX, int snakeY)
        {
            this.parent = parent;
            this.snakeX[0] = snakeX;
            this.snakeY[0] = snakeY;
            foodX = random.Next(0, 25);
            foodY = random.Next(0, 25);
            timer.Interval = 500;
            timer.Enabled = true;
            timer.Tick += MyTick;
            direction = "right";
        }
        //Game loop
        public void MyTick(object sender, EventArgs e)
        {
            if (foodX == snakeY[0] && foodY == snakeX[0])
            {
                snakeParts++;
                foodX = random.Next(0, 25);
                foodY = random.Next(0, 25);
                DrawFood();
            }
            switch (direction)
            {
                case "right":
                    ReDrawSnake();
                    snakeX[0] += 1;
                    board[snakeY[0], snakeX[0]].BackColor = Color.Green;
                    break;
                case "down":
                    ReDrawSnake();
                    snakeY[0] += 1;
                    board[snakeY[0], snakeX[0]].BackColor = Color.Green;
                    break;
                case "up":
                    ReDrawSnake();
                    snakeY[0] -= 1;
                    board[snakeY[0], snakeX[0]].BackColor = Color.Green;
                    break;
                case "left":
                    ReDrawSnake();
                    snakeX[0] -= 1;
                    board[snakeY[0], snakeX[0]].BackColor = Color.Green;
                    break;
            }
            
        }
        //Замальовка останього елемента
        public void ReDrawSnake()
        {
            board[snakeY[snakeParts - 1], snakeX[snakeParts - 1]].BackColor = Color.White;
            for (int i = 1; i < snakeParts; i++)
            {
                snakeX[snakeParts - i] = snakeX[snakeParts - 1 - i];
                snakeY[snakeParts - i] = snakeY[snakeParts - 1 - i];
            }
        }
        //Вивисти поле на форму
        public void CreateBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = new PictureBox();
                    board[i, j].Top = 25 * i;
                    board[i, j].Left = 25 * j;
                    board[i, j].Width = 25;
                    board[i, j].Height = 25;
                    board[i, j].Image = DrawImage();
                    parent.Controls.Add(board[i, j]);
                }
            }
        }
        //Створення обєкта для малювання
        public Bitmap DrawImage()
        {
            Bitmap bitmap = new Bitmap(25, 25);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(0, 0, 24, 24));
            }
            return bitmap;
        }
        //Намалювати змейку
        public void DrawSnake(int y, int x)
        {
            board[x, y].BackColor = Color.Green;
        }
        //Намалювати яблуко
        public void DrawFood()
        {
            board[foodX, foodY].BackColor = Color.Red;
        }
        //поміняти напрям
        public void ChangeDirection(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    direction = "right";
                    break;
                case Keys.S:
                    direction = "down";
                    break;
                case Keys.A:
                    direction = "left";
                    break;
                case Keys.W:
                    direction = "up";
                    break;
            }
        }
    }
}
