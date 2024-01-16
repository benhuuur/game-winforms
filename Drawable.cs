using System.Drawing;
using System.Windows.Forms;
public abstract class Drawable : IDrawable
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public Image Image { get; set; } = null;

    public Drawable(string path, int width, int height) { 
        setImage(path);
        this.Width = width;
        this.Height = height; 
    }
    public Drawable(int width, int height) { 
        this.Width = width;
        this.Height = height; 
    }

    public Drawable() { }

    public void setImage(string image)
    {
        this.Image = Bitmap.FromFile(image);
    }

    public abstract void Draw(Graphics g, PictureBox pb);
}
