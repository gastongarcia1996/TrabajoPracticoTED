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
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_sistMateriales_Click(object sender, EventArgs e)
        {
            SistemaMaterialesForm smf = new SistemaMaterialesForm();
            this.Hide();          
            smf.Show();
        }
    }
}
