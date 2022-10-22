using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Effects;

namespace Turkey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele=new Random();
            LiveCharts.WinForms.GeoMap gMaps= new LiveCharts.WinForms.GeoMap();
            Dictionary<string,double> keyValues= new Dictionary<string,double>();
            keyValues["3065"] = rastgele.Next(0, 1000);
            keyValues["3064"] = rastgele.Next(0, 1000);
            keyValues["3063"] = rastgele.Next(0, 1000);
            keyValues["3062"] = rastgele.Next(0, 1000);


            gMaps.HeatMap = keyValues;
            gMaps.Source = "Turkey.xml";

            this.Controls.Add(gMaps);
            gMaps.Dock= DockStyle.Fill;
            gMaps.LandStrokeThickness = 2;
            gMaps.Hoverable = true;
            gMaps.BackColor=Color.Black;
            gMaps.BackColorTransparent = false;


        }
    }
}
