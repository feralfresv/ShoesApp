using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace Administrador_tienda_FASV
{
    public partial class Form2Modificar : Form
    {
        Business bb = new Business();

        public Form2Modificar()
        {
            InitializeComponent();
        }

        //METODOS-------------------------------------------------
        public void Modificar()
        {
            bb.ModifyProduct(Convert.ToInt32(Txt_ModId.Text), Txt_ModNombre.Text, Txt_ModDescr.Text, Convert.ToInt32(TxT_ModPrecio.Text), Convert.ToInt32(comboBox1.SelectedValue));
            MessageBox.Show("Cambioar realizados");
        }
        public void LlamarColores()
        {
            comboBox1.DataSource = bb.Allcolor();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "IdColor";
            comboBox1.SelectedIndex = -1;
        }

        //Load
        private void Form2Modificar_Load(object sender, EventArgs e)
        {
            LlamarColores();
        }

        //Boton Midificar
        private void Button_Editar_Click(object sender, EventArgs e)
        {
            Modificar();
        }



    }
}
