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
    public partial class SistemaNerviosoForm : Form
    {
        public SistemaNerviosoForm()
        {
            InitializeComponent();
            this.Width = 1200;
            this.CenterToScreen();
        }

        private void Form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
