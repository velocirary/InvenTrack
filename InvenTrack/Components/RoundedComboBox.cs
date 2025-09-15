using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedComboBox : UserControl
{
    private ComboBox comboBox = new ComboBox();

    public RoundedComboBox()
    {
        this.DoubleBuffered = true;
        this.BackColor = Color.White;
        this.Padding = new Padding(5);
        this.Size = new Size(200, 30);

        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox.FlatStyle = FlatStyle.Flat;
        comboBox.Dock = DockStyle.Fill;
        comboBox.Font = this.Font;
        comboBox.BackColor = Color.White;
        comboBox.ForeColor = Color.Black;

        this.Controls.Add(comboBox);
    }

    public ComboBox.ObjectCollection Items => comboBox.Items;

    public override Color ForeColor
    {
        get => comboBox.ForeColor;
        set
        {
            comboBox.ForeColor = value;
            base.ForeColor = value;
            comboBox.Refresh();
        }
    }

    public object SelectedItem
    {
        get => comboBox.SelectedItem;
        set => comboBox.SelectedItem = value;
    }

    public int SelectedIndex
    {
        get => comboBox.SelectedIndex;
        set => comboBox.SelectedIndex = value;
    }

    public string DisplayMember
    {
        get => comboBox.DisplayMember;
        set => comboBox.DisplayMember = value;
    }

    public string ValueMember
    {
        get => comboBox.ValueMember;
        set => comboBox.ValueMember = value;
    }

    public object DataSource
    {
        get => comboBox.DataSource;
        set => comboBox.DataSource = value;
    }

    public string SelectedText => comboBox.Text;

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