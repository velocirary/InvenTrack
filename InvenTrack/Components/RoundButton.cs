using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int BorderRadius { get; set; } = 15;
    public Color BackgroundColor { get; set; } = Color.White;
    public Color HoverColor { get; set; } = Color.LightGray;
    public Color PressedColor { get; set; } = Color.Gainsboro;

    private bool isHovered = false;
    private bool isPressed = false;

    public RoundedButton()
    {
        FlatAppearance.BorderSize = 0;
        FlatStyle = FlatStyle.Flat;
        BackColor = BackgroundColor;
        ForeColor = Color.Black;        
        Size = new Size(120, 30);

        MouseEnter += (s, e) => { isHovered = true; Invalidate(); };
        MouseLeave += (s, e) => { isHovered = false; Invalidate(); };
        MouseDown += (s, e) => { isPressed = true; Invalidate(); };
        MouseUp += (s, e) => { isPressed = false; Invalidate(); };
    }

    protected override void OnPaint(PaintEventArgs evenArgs)
    {
        base.OnPaint(evenArgs);

        evenArgs.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rectangle = this.ClientRectangle;
        int radius = BorderRadius;

        using (GraphicsPath path = GetRoundedPath(rectangle, radius))
        using (SolidBrush brush = new SolidBrush(GetCurrentBackColor()))
        {
            Region = new Region(path);
            evenArgs.Graphics.FillPath(brush, path);
        }

        TextRenderer.DrawText(evenArgs.Graphics, Text, Font, rectangle, ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private Color GetCurrentBackColor()
    {
        if (isPressed) return PressedColor;
        if (isHovered) return HoverColor;
        return BackgroundColor;
    }

    private GraphicsPath GetRoundedPath(Rectangle rectangle, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float r = radius;
        path.StartFigure();
        path.AddArc(rectangle.X, rectangle.Y, r, r, 180, 90);
        path.AddArc(rectangle.Right - r, rectangle.Y, r, r, 270, 90);
        path.AddArc(rectangle.Right - r, rectangle.Bottom - r, r, r, 0, 90);
        path.AddArc(rectangle.X, rectangle.Bottom - r, r, r, 90, 90);
        path.CloseFigure();
        return path;
    }
}