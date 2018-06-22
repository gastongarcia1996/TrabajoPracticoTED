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
    public partial class ActividadCerebroForm : Form
    {
        private string[] datos = { "Médula espinal", "Cerebelo", "Glándula pineal", "Plexo coroides", "Cerebro", "Ventrículos", "Hipotálamo", "Nervio óptico",
            "Hipófisis", "Protuberancia", "Bulbo raquídeo"};
        private int correctas = 0;


        public ActividadCerebroForm()
        {
            InitializeComponent();
            CargarCombos(this.datos);
        }
        private void CargarCombos(string[] datos)
        {
            ComboBox combo = null;

            foreach (Object c in this.Controls)
            {
                if (c is ComboBox)
                {
                    combo = (ComboBox)c;
                    combo.Items.AddRange(datos);
                    combo.DropDownStyle = ComboBoxStyle.DropDown;
                    combo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            VerificarCombo1();
            VerificarCombo2();
            VerificarCombo3();
            VerificarCombo4();
            VerificarCombo5();
            VerificarCombo6();
            VerificarCombo7();
            VerificarCombo8();
            VerificarCombo9();
            VerificarCombo10();
            VerificarCombo11();

            MessageBox.Show(correctas + " / 11 correctas", "Puntuación", MessageBoxButtons.OK);
            correctas = 0;
        }

        private void VerificarCombo1()
        {
            if (this.comboBox1.SelectedItem != null && this.comboBox1.SelectedItem.ToString().CompareTo("Médula espinal") == 0)
            {
                this.comboBox1.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox1.BackColor = Color.Red;
            }
        }

        private void VerificarCombo2()
        {
            if (this.comboBox2.SelectedItem != null && this.comboBox2.SelectedItem.ToString().CompareTo("Cerebelo") == 0)
            {
                this.comboBox2.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox2.BackColor = Color.Red;
            }
        }

        private void VerificarCombo3()
        {
            if (this.comboBox3.SelectedItem != null && this.comboBox3.SelectedItem.ToString().CompareTo("Glándula pineal") == 0)
            {
                this.comboBox3.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox3.BackColor = Color.Red;
            }
        }

        private void VerificarCombo4()
        {
            if (this.comboBox4.SelectedItem != null && this.comboBox4.SelectedItem.ToString().CompareTo("Plexo coroides") == 0)
            {
                this.comboBox4.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox4.BackColor = Color.Red;
            }
        }

        private void VerificarCombo5()
        {
            if (this.comboBox5.SelectedItem != null && this.comboBox5.SelectedItem.ToString().CompareTo("Cerebro") == 0)
            {
                this.comboBox5.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox5.BackColor = Color.Red;
            }
        }

        private void VerificarCombo6()
        {
            if (this.comboBox6.SelectedItem != null && this.comboBox6.SelectedItem.ToString().CompareTo("Ventrículos") == 0)
            {
                this.comboBox6.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox6.BackColor = Color.Red;
            }
        }
        private void VerificarCombo7()
        {
            if (this.comboBox7.SelectedItem != null && this.comboBox7.SelectedItem.ToString().CompareTo("Hipotálamo") == 0)
            {
                this.comboBox7.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox7.BackColor = Color.Red;
            }
        }

        private void VerificarCombo8()
        {
            if (this.comboBox8.SelectedItem != null && this.comboBox8.SelectedItem.ToString().CompareTo("Nervio óptico") == 0)
            {
                this.comboBox8.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox8.BackColor = Color.Red;
            }
        }
        private void VerificarCombo9()
        {
            if (this.comboBox9.SelectedItem != null && this.comboBox9.SelectedItem.ToString().CompareTo("Hipófisis") == 0)
            {
                this.comboBox9.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox9.BackColor = Color.Red;
            }
        }
        private void VerificarCombo10()
        {
            if (this.comboBox10.SelectedItem != null && this.comboBox10.SelectedItem.ToString().CompareTo("Protuberancia") == 0)
            {
                this.comboBox10.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox10.BackColor = Color.Red;
            }
        }
        private void VerificarCombo11()
        {
            if (this.comboBox11.SelectedItem != null && this.comboBox11.SelectedItem.ToString().CompareTo("Bulbo raquídeo") == 0)
            {
                this.comboBox11.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                this.comboBox11.BackColor = Color.Red;
            }
        }
    }
}
