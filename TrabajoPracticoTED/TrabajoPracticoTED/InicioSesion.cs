﻿using System;
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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(this);
            this.Hide();
            menu.Show();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            RegistroUsuarioForm rg = new RegistroUsuarioForm(this);
            this.Hide();
            rg.Show();
        }

        private void Form_closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "¿Seguro desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha_hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss ");
        }
    }
}
