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
        public ActividadCerebroForm()
        {
            InitializeComponent();
            CargarCombos();
        }
        private void CargarCombos()
        {
            String[] datos = { "Glándula pineal", "Cerebelo" , "Plexo coroides", "Ventrículos", "Nervio Óptico"}; 
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
            
        }
    }
}
