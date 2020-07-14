using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brayan_Hernandez__Figuras_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcularcubo_Click(object sender, EventArgs e)
        {
            int lado;
            double area, volumen;


            lado = int.Parse(txtcubo.Text);
            area = 6 * (lado * lado);
            volumen = lado * lado * lado;

            lblresultareacubo.Text = area.ToString("N2");
            lblresultvolcubo.Text = volumen.ToString("N2");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresultvolcubo.Text = " ";
            lblresultareacubo.Text = " ";
            lblresultareacilindro.Text = " ";
            lblresultvolumencilindro.Text = " ";
            lblresultareaesfera.Text = " ";
            lblresultvolumenesfera.Text = " "; 
        }

        private void btnlimpiarcubo_Click(object sender, EventArgs e)
        {
            txtcubo.Text = " ";
            lblresultareacubo.Text = " ";
            lblresultvolcubo.Text = " ";


        }

        private void btncalcularcilindro_Click(object sender, EventArgs e)
        {
            double radio, altura, area, volumen;

            radio = Convert.ToDouble(txtcilindroradio.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            area = 2 * 3.1416 * radio * (radio + altura);
            volumen = 3.1416 * (radio * radio) * altura;
            lblresultareacilindro.Text = area.ToString("N2");
            lblresultvolumencilindro.Text = volumen.ToString("N2");


        }

        private void btnlimpiarcilindro_Click(object sender, EventArgs e)
        {
            txtaltura.Text = " ";
            txtcilindroradio.Text = " ";
            lblresultvolumencilindro.Text = " ";
            lblresultareacilindro.Text = " ";
        }

        private void btncalcularesfera_Click(object sender, EventArgs e)
        {
            double radio, area, volumen;

            radio = Convert.ToDouble(txtesferaradio.Text);
            area = 4 * 3.1416 * (radio * radio);
            volumen = (1.3333) * (3.1416) * (radio * radio * radio);

            lblresultareaesfera.Text = area.ToString("N2");
            lblresultvolumenesfera.Text = volumen.ToString("N2");

        }

        private void btnlimpiaresfera_Click(object sender, EventArgs e)
        {
            txtesferaradio.Text = " ";
            lblresultvolumenesfera.Text = " ";
            lblresultareaesfera.Text = " "; 

        }
    }
    }
