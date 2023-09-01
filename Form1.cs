using ScottPlot;
using ScottPlot.Plottable;
using System.IO;
using System.Linq.Expressions;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace SpaceChart
{
    public partial class Form1 : Form
    {
        private string[] lines;
        uint AmountOfStars = 1000;
        DraggableMarkerPlot myDraggableMarker = new ScottPlot.Plottable.DraggableMarkerPlot();
        //private List<Star> StarList;
        public Form1()
        {
            InitializeComponent();
        }

        private void diagram_Load(object sender, EventArgs e)
        {
            diagram.Plot.XAxis.TickLabelNotation(invertSign: true);
            diagram.Plot.YAxis.TickLabelNotation(invertSign: true);
            diagram.Plot.Style(ScottPlot.Style.Blue2);
            diagram.Plot.YLabel("Абсолютная звездная величина");
            diagram.Plot.XLabel("Температура, К");
            diagram.Plot.Title("Диаграмма Герцшпрунга-Рассела", size: 25);
            diagram.Plot.Render(lowQuality: true);
            diagram.Refresh();
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            var path = Path.Combine(Environment.CurrentDirectory, filename);
            lines = File.ReadAllLines(path);
            for (int i = 0; i < AmountOfStars; i++)
            {
                var star = new Star(lines[i]);
                diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
            }
            diagram.Plot.Legend();
            diagram.Refresh();
            SunCheckBox.Visible = true;
            MainSequenceBox.Visible = true;
            clearButton.Visible = true;
            BrightGiantsBox.Visible = true;
            redGiantsBox.Visible = true;
            SuperGiantsBox.Visible = true;
            WhiteDwarfsBox.Visible = true;
        }



        private void starScroll_Scroll(object sender, EventArgs e)
        {
            starBox.Text = starScroll.Value.ToString();
            //AmountOfStars = (uint)starScroll.Value;
        }

        private void starBox_TextChanged(object sender, EventArgs e)
        {
            if (!uint.TryParse(starBox.Text, out AmountOfStars) && !string.IsNullOrEmpty(starBox.Text))
            {
                MessageBox.Show("Введите число в диапазоне от 1000 до 200000!");
            }
            else
            {
                if (AmountOfStars > 200000)
                {
                    MessageBox.Show("Введите число в диапазоне от 1000 до 200000!");
                    AmountOfStars = 200000;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            diagram.Plot.Clear();
            diagram.Refresh();
            SunCheckBox.Visible = false;
            SunCheckBox.Checked = false;
            MainSequenceBox.Visible = false;
            MainSequenceBox.Checked = false;
            clearButton.Visible = false;
            WhiteDwarfsBox.Visible = false;
            redGiantsBox.Visible = false;
            SuperGiantsBox.Visible = false;
            BrightGiantsBox.Visible = false;
        }

        private void SunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SunCheckBox.Checked)
            {
                diagram.Plot.AddPoint(-5778, -4.83, Color.Red, 7, label: "Солнце");
                diagram.Refresh();
            }
            else
            {
                diagram.Plot.Clear();
                for (int i = 0; i < AmountOfStars; i++)
                {
                    var star = new Star(lines[i]);
                    diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
                }
                diagram.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDraggableMarker.X = -3800;
            myDraggableMarker.Y = -9;
            myDraggableMarker.Color = Color.Magenta;
            myDraggableMarker.MarkerShape = MarkerShape.filledCircle;
            myDraggableMarker.MarkerSize = 5;
            diagram.Plot.Add(myDraggableMarker);
            diagram.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = myDraggableMarker.X.ToString();
            label3.Text = myDraggableMarker.Y.ToString();
        }

        private void MainSequenceBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MainSequenceBox.Checked)
            {
                double[] xs = {-3857, -3930, -4056, -4197, -4358, -4598, -4798, -5020, -5318, -5620,
                    -5788, -6018, -6227, -6453, -6776, -7153, -7562, -8159, -8615, -9453, -10510};
                double[] ys = {-9, -8.5, -8, -7.6, -7.375, -6.937, -6.518, -6.118, -5.654, -5.176, -4.929,
                -4.5, -4.122, -3.483, -2.976, -2.437, -1.904, -1.464, -0.974, -0.533, -0.215};
                diagram.Plot.AddScatter(xs, ys, Color.Yellow, 3, 1, label: "Главная последовательность");
                diagram.Refresh();
            }
            else
            {
                diagram.Plot.Clear();
                for (int i = 0; i < AmountOfStars; i++)
                {
                    var star = new Star(lines[i]);
                    diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
                }
                diagram.Refresh();
            }
        }

        private void WhiteDwarfsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WhiteDwarfsBox.Checked)
            {
                double[] xs = { -4576, -6084, -7434, -9363, -11485 };
                double[] ys = { -15.645, -14.378, -13.563, -11.889, -10.938 };
                diagram.Plot.AddScatter(xs, ys, Color.White, 3, 1, label: "Белые Карлики");
                diagram.Refresh();
            }
            else
            {
                diagram.Plot.Clear();
                for (int i = 0; i < AmountOfStars; i++)
                {
                    var star = new Star(lines[i]);
                    diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
                }
                diagram.Refresh();
            }

        }

        private void redGiantsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (redGiantsBox.Checked)
            {
                double[] xs = { -5043, -4623, -4288, -4105, -3755, -3633 };
                double[] ys = { -2.942, -1.989, -0.918, 0.321, 1.391, 2.602 };
                diagram.Plot.AddScatter(xs, ys, Color.Red, 3, 1, label: "Красные Гиганты");
                diagram.Refresh();
            }
            else
            {
                diagram.Plot.Clear();
                for (int i = 0; i < AmountOfStars; i++)
                {
                    var star = new Star(lines[i]);
                    diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
                }
                diagram.Refresh();
            }
        }

        private void BrightGiants_CheckedChanged(object sender, EventArgs e)
        {
            if (BrightGiantsBox.Checked)
            {
                double[] ys = { 6.755, 6.336, 6.4566, 6.336, 6.277, 6.576, 7.174 };
                double[] xs = { -3603, -4536, -5632, -6939, -8362, -11022, -12048 };
                diagram.Plot.AddScatter(xs, ys, Color.DeepSkyBlue, 3, 1, label: "Яркие Гиганты");
                diagram.Refresh();
            }
            else
            {
                diagram.Plot.Clear();
                for (int i = 0; i < AmountOfStars; i++)
                {
                    var star = new Star(lines[i]);
                    diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
                }
                diagram.Refresh();
            }
        }

        private void SuperGiantsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SuperGiantsBox.Checked)
            {
                double[] xs = { -3556, -4449, -5302, -6209, -7276, -8410, -9451, -10878 };
                double[] ys = { 11.843, 10.918, 10.610, 10.507, 10.37, 10.644, 10.884, 11.157 };
                diagram.Plot.AddScatter(xs, ys, Color.Purple, 3, 1, label: "Сверхгиганты");
                diagram.Refresh();
            }
            else
            {
                diagram.Plot.Clear();
                for (int i = 0; i < AmountOfStars; i++)
                {
                    var star = new Star(lines[i]);
                    diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
                }
                diagram.Refresh();
            }
        }
    }
}