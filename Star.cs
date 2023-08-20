using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceChart
{
    internal class Star
    {
        public double Luminosity { get; set; }
        public double AbsoluteMagnitude { get; set; }
        public double Temperature { get; set; }
        public double ColorIndex { get; set; }
        public Color color { get; set; }
        public Star(string row)
        {
            string[] columns = row.Split(' ');
            ColorIndex = double.Parse(columns[0]);
            AbsoluteMagnitude = double.Parse(columns[1]);
            Temperature = 4600 * (1 / (0.92 * ColorIndex + 1.7) + 1 / (0.92 * ColorIndex + 0.62));
            Luminosity = Math.Pow(10, -AbsoluteMagnitude / 2.512);
                double Kel = Temperature / 100;
                double r, g, b;

                //red
                if (Kel <= 66)
                {
                    r = 255;
                }
                else
                {
                    r = Kel - 60;
                    r = 329.698727446 * Math.Pow(r, -0.1332047592);
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                }

                //green
                if (Kel <= 66)
                {
                    g = Kel;
                    g = 99.4708025861 * Math.Log(g) - 161.1195681661;
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                }
                else
                {
                    g = Kel - 60;
                    g = 288.1221695283 * Math.Pow(g, -0.0755148492);
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                }

                //blue 
                if (Kel >= 66)
                {
                    b = 255;
                }
                else
                {
                    if (Kel <= 19) b = 0;
                    else
                    {
                        b = Kel - 10;
                        b = 138.5177312231 * Math.Log(b) - 305.0447927307;
                        if (b < 0) b = 0;
                        if (b > 255) b = 255;
                    }
                }

                color = Color.FromArgb((int)r, (int)g, (int)b);
        }
    }
}
