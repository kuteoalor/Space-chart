namespace SpaceChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void diagram_Load(object sender, EventArgs e)
        {
            var cmap = ScottPlot.Drawing.Colormap.Turbo;
            diagram.Plot.AddColorbar(cmap);

            Random rand = new(0);

            for (int i = 0; i < 1000; i++)
            {
                double x = ScottPlot.DataGen.RandomNormalValue(rand, mean: 0.1, stdDev: .7);
                double y = ScottPlot.DataGen.RandomNormalValue(rand, mean: 0.1, stdDev: .7);
                double colorFranction = Math.Sqrt(x * x + y * y);
                System.Drawing.Color c = ScottPlot.Drawing.Colormap.Turbo.GetColor(colorFranction);
                diagram.Plot.AddPoint(x, y, c);
            }

            diagram.Plot.AddPoint(3, 3, ScottPlot.Drawing.Colormap.Turbo.GetColor(Math.Sqrt(3 * 3 + 3 * 3)));
            diagram.Refresh();
        }
    }
}