using System.CodeDom;
using System.Drawing;
using System.Windows.Forms;

ApplicationConfiguration.Initialize();

var pb = new PictureBox { Dock = DockStyle.Fill, };
Bitmap bmp = null;
Graphics g = null;
Player player = new(15, 15);
player.X = 100;
player.Y = 100;

var timer = new Timer { Interval = 20, };

var form = new Form
{
    WindowState = FormWindowState.Maximized,
    FormBorderStyle = FormBorderStyle.None,
    Controls = { pb }
};

form.Load += (o, e) =>
{
    bmp = new Bitmap(pb.Width, pb.Height);
    g = Graphics.FromImage(bmp);
    g.Clear(Color.Black);
    pb.Image = bmp;

    timer.Start();
};

timer.Tick += (o, e) =>
{
    g.Clear(Color.Black);

    player.Move();
    player.Draw(g, pb);
    pb.Refresh();
};

form.KeyDown += (o, e) =>
{
    switch (e.KeyCode)
    {
        case Keys.Escape:
            Application.Exit();
            break;

        case Keys.W:
            player.MoveUp();
            break;

        case Keys.A:
            player.MoveLeft();
            break;

        case Keys.S:
            player.MoveDown();
            break;

        case Keys.D:
            player.MoveRight();
            break;
    }
};

form.KeyUp += (o, e) =>
{
    switch (e.KeyCode)
    {
        case Keys.W:
            player.StopY_axis();
            break;

        case Keys.A:
            player.StopX_axis();
            break;

        case Keys.S:
            player.StopY_axis();
            break;

        case Keys.D:
            player.StopX_axis();
            break;
    }
};

Application.Run(form);
