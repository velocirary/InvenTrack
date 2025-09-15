using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedMaskedTextBox : UserControl
{
    private MaskedTextBox maskedTextBox = new MaskedTextBox();

    public RoundedMaskedTextBox()
    {
        this.DoubleBuffered = true;
        this.BackColor = Color.White;
        this.Padding = new Padding(10);
        this.Size = new Size(200, 30);

        maskedTextBox.BorderStyle = BorderStyle.None;
        maskedTextBox.Dock = DockStyle.Fill;
        maskedTextBox.Font = this.Font;
        maskedTextBox.ForeColor = Color.Black;

        this.Controls.Add(maskedTextBox);
    }
    
    public string Mask
    {
        get => maskedTextBox.Mask;
        set => maskedTextBox.Mask = value;
    }

    public string TextValue
    {
        get => maskedTextBox.Text;
        set => maskedTextBox.Text = value;
    }

    public override Color ForeColor
    {
        get => maskedTextBox.ForeColor;
        set
        {
            maskedTextBox.ForeColor = value;
            base.ForeColor = value;
            maskedTextBox.Refresh();
        }
    }

    public override Font Font
    {
        get => maskedTextBox.Font;
        set
        {
            maskedTextBox.Font = value;
            base.Font = value;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        int radius = 15;
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}