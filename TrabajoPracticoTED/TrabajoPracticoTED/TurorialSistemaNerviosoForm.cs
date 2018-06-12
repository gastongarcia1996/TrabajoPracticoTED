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
    public partial class TurorialSistemaNerviosoForm : Form
    {
        public TurorialSistemaNerviosoForm()
        {
            InitializeComponent();
            EditarTexto();
            this.btn_continuar.Left = (this.Width - btn_continuar.Width) / 2;
        }

        private void EditarTexto()
        {
            Font font1 = new Font("Verdana", 14, FontStyle.Bold);
            Font font2 = new Font("Verdana", 11, FontStyle.Underline);
            Font font3 = new Font("Verdana", 9, FontStyle.Regular);

            richTextBox.SelectionStart = richTextBox.Find("Bienvenido al tutorial");
            richTextBox.SelectionFont = font1;
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;

            richTextBox.SelectionStart = richTextBox.Find("En este tutorial explicaremos el juego de la ruleta");
            richTextBox.SelectionFont = font2;

            richTextBox.SelectionStart = richTextBox.Find("1) Presionar el botón \"girar\" para rotar la ruleta");
            richTextBox.SelectionFont = font3;

            richTextBox.SelectionStart = richTextBox.Find("2) Luego cuando la ruleta pare le tocará un ítem");
            richTextBox.SelectionFont = font3;

            richTextBox.SelectionStart = richTextBox.Find("3) A partir de ese momento se le abrirá una actividad para realizar");
            richTextBox.SelectionFont = font3;

            richTextBox.SelectionStart = richTextBox.Find("4) Seleccione una respuesta y presione aceptar");
            richTextBox.SelectionFont = font3;
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            SistemaNerviosoForm snf = new SistemaNerviosoForm();
            this.Hide();
            snf.Show();
        }
    }
}
