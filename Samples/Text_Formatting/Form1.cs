using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;

namespace Text_Formatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radialSlider1.DrawText += RadialSlider1_DrawText;
            radialSlider1.MinimumValue = 0;
            radialSlider1.MaximumValue = 100;
            radialSlider1.BackgroundColor = System.Drawing.Color.White;
        }

        private void RadialSlider1_DrawText(object sender, RadialSlider.DrawTextEventArgs e)
        {
            int Value = int.Parse(e.Text);
            e.Text += "°C";
            if (e.TextType == TextType.Interval)
            {
                if (Value <= 33)
                {
                    e.Font = new Font("Arial", 8);
                    e.ForeColor = Brushes.Green;
                }
                else if (Value > 33 && Value <= 66)
                {
                    e.Font = new Font("Courier", 10);
                    e.ForeColor = Brushes.Gold;
                }
                else
                {
                    e.Font = new Font("Georgia", 10);
                    e.ForeColor = Brushes.Red;
                }
            }
            else if (e.TextType == TextType.Pointer)
            {
                e.Font = new Font("Segoe UI Black", 8);
                e.ForeColor = Brushes.Blue;
            }
            else if (e.TextType == TextType.Value)
            {
                e.Font = new Font("MoolBoran", 12);
                e.ForeColor = Brushes.DeepPink;
            }
        }
    }
}
