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
            this.CenterToScreen();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {          
            if (txt_contraseña.Text.CompareTo(txt_repetirContraseña.Text) == 0 && txt_nombreDeUsuario.Text != "")
            {
                if (Conexion.consultar_usuario(this.txt_nombreDeUsuario.Text, this.txt_contraseña.Text).HasRows)
                {
                    Conexion.CerrarConexion();
                    MessageBox.Show(this, "El usuario ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    form.Show();
                    this.Close();
                    return;
                }
                Conexion.insertar_usuario(this.txt_nombreDeUsuario.Text, this.txt_contraseña.Text);
                MessageBox.Show(this, "Registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else if (txt_nombreDeUsuario.Text == "" || txt_repetirContraseña.Text == "" || txt_contraseña.Text == "")
            {
                MessageBox.Show(this, "Hay campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_contraseña.Text.CompareTo(txt_repetirContraseña.Text) != 0)
            {
                MessageBox.Show(this, "Coloque la misma contraseña en ambos campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
