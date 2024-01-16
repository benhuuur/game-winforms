using System.Drawing;
using System.Windows.Forms;

public class Background : Drawable
{
    public Background(string path)
    {
        this.Image = Bitmap.FromFile(path);
    }

    public override void Draw(Graphics g, PictureBox pb)
    {
        var centerX = (pb.Width / 2) - Image.Width / 2;
        var centerY = (pb.Height / 2) - Image.Height / 2;

        g.DrawImage(Image, centerX, centerY);
    }
}
