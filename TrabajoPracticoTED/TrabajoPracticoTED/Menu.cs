using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoTED
{
    public partial class Menu : Form
    {
        InicioSesion inicioSesion = null;

        public Menu(InicioSesion inicioSesion)
        {
            InitializeComponent();
            this.inicioSesion = inicioSesion;
            this.CenterToScreen();
        }

        private void btn_sistMateriales_Click(object sender, EventArgs e)
        {
            SistemaMaterialesForm smf = new SistemaMaterialesForm();
            this.Hide();          
            smf.Show();
        }

        private void btn_sistNervioso_Click(object sender, EventArgs e)
        {
            SistemaNerviosoForm snf = new SistemaNerviosoForm();
            this.Hide();
            snf.Show();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
            inicioSesion.Show();
        }
    }
}
