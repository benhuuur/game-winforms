using System.Drawing;
using System.Windows.Forms;

public class Wall : Hittable
{
    public Wall() { }

    public override void Draw(Graphics g, PictureBox pb)
    {
        NewHitbox(this.X, this.Y, this.Width + 1, this.Height + 1);

        g.DrawRectangle(Pens.White, this.Hitbox);
    }
}
