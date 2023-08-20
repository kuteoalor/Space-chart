using ScottPlot;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace SpaceChart
{
    public partial class Form1 : Form
    {
        private string[] lines;
        private List<Star> StarList;
        public Form1()
        {
            InitializeComponent();

        }

        private void diagram_Load(object sender, EventArgs e)
        {
            diagram.Plot.XAxis.TickLabelNotation(invertSign: true);
            diagram.Plot.YAxis.TickLabelNotation(invertSign: true);
            diagram.Plot.Style(ScottPlot.Style.Blue2);
            diagram.Refresh();
            //var cmap = ScottPlot.Drawing.Colormap.Turbo;
            //diagram.Plot.AddColorbar(cmap);

            //Random rand = new(0);

            //for (int i = 0; i < 1000; i++)
            //{
            //    double x = ScottPlot.DataGen.RandomNormalValue(rand, mean: 0.1, stdDev: .7);
            //    double y = ScottPlot.DataGen.RandomNormalValue(rand, mean: 0.1, stdDev: .7);
            //    double colorFranction = Math.Sqrt(x * x + y * y);
            //    System.Drawing.Color c = ScottPlot.Drawing.Colormap.Turbo.GetColor(colorFranction);
            //    diagram.Plot.AddPoint(x, y, c);
            //}

            //diagram.Plot.AddPoint(3, 3, ScottPlot.Drawing.Colormap.Turbo.GetColor(Math.Sqrt(3 * 3 + 3 * 3)));
            //diagram.Refresh();
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            var path = Path.Combine(Environment.CurrentDirectory, filename);
            lines = File.ReadAllLines(path);
            diagram.Plot.Clear();
            //diagram.Plot.XAxis.TickLabelNotation(invertSign: true);
            //diagram.Plot.YAxis.TickLabelNotation(invertSign: true);
            //foreach ( var line in lines )
            for (int i = 0; i < 200000; i++)
            {
                var star = new Star(lines[i]);
                diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
            }
            diagram.Refresh();
        }
    }
}