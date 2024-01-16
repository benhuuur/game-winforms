using System;
using System.Drawing;
using System.Windows.Forms;



public class Player : Hittable, IMoveable
{
    public Player(int width, int height)
        : base(width, height) { }
    public int Hp { get; set; }
    public float Base_Speed { get; set; } = 5;
    public float Vx { get; set; }
    public float Vy { get; set; }

    public override void Draw(Graphics g, PictureBox pb)
    {
        g.FillRectangle(
            Brushes.Red,
            new RectangleF
            {
                X = this.X - this.Width / 2,
                Y = this.Y - this.Height / 2,
                Width = this.Width,
                Height = this.Height
            }
        );
        NewHitbox(this.X, this.Y, this.Width + 1, this.Height + 1);

        g.DrawRectangle(Pens.White, this.Hitbox);
    }


    public void Move()
    {
        Old_X = X;
        Old_Y = Y;

        double magnitude = Math.Sqrt(Vx * Vx + Vy * Vy);

        if (magnitude == 0)
            return;

        X += (float)(Vx / magnitude) * Base_Speed;
        Y += (float)(Vy / magnitude) * Base_Speed;
    }
    public void MoveUp() => this.Vy = -1;

    public void MoveDown() => this.Vy = 1;

    public void MoveRight() => this.Vx = 1;

    public void MoveLeft() => this.Vx = -1;

    public void StopY_axis() => this.Vy = 0;

    public void StopX_axis() => this.Vx = 0;
}
