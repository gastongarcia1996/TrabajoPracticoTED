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
    public partial class RegistroUsuarioForm : Form
    {
        InicioSesion form = null;

        public RegistroUsuarioForm(InicioSesion f)
        {
            this.form = f;
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.Text.CompareTo(txt_repetirContraseña.Text) == 0 && txt_nombreDeUsuario.Text != "")
            {
                MessageBox.Show(this, "Registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else if (txt_nombreDeUsuario.Text == "" || txt_repetirContraseña.Text == "" || txt_contraseña.Text == "")
            {
                MessageBox.Show(this, "Hay campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Text == "")
                {
                    c.BackColor = Color.Red;
                }
            }
        }
    }
}
