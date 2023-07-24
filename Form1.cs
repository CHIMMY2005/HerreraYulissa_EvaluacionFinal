using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace examen_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int b;
            int c;
            
            string[] categorias = { "categoria 1", "categoria 2", "categoria 3", "categoria 4", "categoria 5" };
            int[] valores = { 20, 35, 12, 45, 28 };
            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("Valores ");
            for(int i = 0; i < categorias.Length; i++)
            {
                Series a = chart1.Series.Add(categorias[i]);
                a.Label = valores[i].ToString();
                a.Points.Add(valores[i]);
            }
        }
    }
}
