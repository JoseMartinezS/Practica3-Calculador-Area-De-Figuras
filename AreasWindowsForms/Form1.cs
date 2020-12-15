using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasWindowsForms
{
    public partial class lblArea : Form
    {
        public lblArea()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Cuadrado(numAreaCuadrado.Value);
            lblAreaCuadrado.Text = resultado + "";
        }

        private void btnAreaTriangulo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Triangulo(numAreaTriangulo1.Value, numAreaTriangulo2.Value);
            lblAreaTriangulo.Text = resultado + "";
        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Rectangulo(numAreaRectangulo1.Value, numAreaRectangulo2.Value);
            lblAreaRectangulo.Text = resultado + "";
        }

        private void btnAreaParalelogramo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Paralelogramo(numAreaParalelogramo1.Value, numAreaParalelogramo2.Value);
            lblAreaParalelogramo.Text = resultado + "";
        }

        private void btnAreaRombo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Rombo(numAreaRombo1.Value, numAreaRombo2.Value);
            lblAreaRombo.Text = resultado + "";
        }

        private void btnAreaCiruclo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Circulo(numRadioCirculo.Value);
            lblAreaCirculo.Text = resultado + "";
        }
    }
}
