using ScottPlot;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace SpaceChart
{
    public partial class Form1 : Form
    {
        private string[] lines;
        uint AmountOfStars = 1000;
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
            diagram.Plot.Render(lowQuality:true);
            diagram.Refresh();
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            var path = Path.Combine(Environment.CurrentDirectory, filename);
            lines = File.ReadAllLines(path);
            diagram.Plot.Clear();
            for (int i = 0; i < AmountOfStars; i++)
            {
                var star = new Star(lines[i]);
                diagram.Plot.AddPoint(-star.Temperature, -star.AbsoluteMagnitude, star.color, 2);
            }
            diagram.Refresh();
            SunButton.Enabled = true;
            SunButton.Visible = true;
        }

        private void SunButton_Click(object sender, EventArgs e)
        {
            //diagram.Plot.AddMarker(-5778, -4.83, MarkerShape.filledDiamond, 10, Color.Yellow);
            diagram.Plot.AddPoint(-5778, -4.83, Color.Red, 7);
            diagram.Refresh();
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
        }
    }
}