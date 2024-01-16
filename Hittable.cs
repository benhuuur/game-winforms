using System.Drawing;
public abstract class Hittable : Drawable
{
    public Hittable(string path, int width, int height)
        : base(path, width, height) { }

    public Hittable(int width, int height)
        : base(width, height) { }

    public Hittable() { }

    public RectangleF Hitbox { get; set; }
    public float Old_X { get; set; }
    public float Old_Y { get; set; }
    public bool isColided { get; set; }

    public virtual void NewHitbox(float x, float y, float width, float height)
    {
        this.Hitbox = new RectangleF(x - (width / 2), y - (height / 2), width, height);
    }

    public virtual void Colision() { }
}
