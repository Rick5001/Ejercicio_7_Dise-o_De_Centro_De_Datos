using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            DateTime fechainicio = DateTime.Parse(dtpFecha_Inicial.Value.ToString());
            DateTime fechafin = DateTime.Parse(dtpFecha_Final.Value.Date.ToString());

            Reportes_Ventas_Fechas reporte = new Reportes_Ventas_Fechas();
            reporte.fechainicial = fechainicio;
            reporte.fechafinal = fechafin;

            reporte.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
