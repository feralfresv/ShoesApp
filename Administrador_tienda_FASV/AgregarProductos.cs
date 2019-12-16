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
using CDatos;

namespace Administrador_tienda_FASV
{
    public partial class AgregarProductos : Form
    {
        Business bb = new Business();



        public AgregarProductos()
        {
            InitializeComponent();
        }

        //METODOS-------------------------------------------------
        public void AgregarInsert()
        {
            bb.InsertarPro(TextBox_addNombre.Text, TextBox_AddDescProduc.Text, Convert.ToInt32(TextBox_AddPrecio.Text), Convert.ToInt32(comboBox1.SelectedValue));
            MessageBox.Show("Listo Agregado");
            
        }
        public void Limpiar()
        {
            TextBox_addNombre.Text = "";
            TextBox_AddDescProduc.Text = "";
            TextBox_AddPrecio.Text = "";
        }

        //TextBox Solo Númerico 
        private void TextBox_AddPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 2)
            {
                e.Handled = true;
            }
        }


        //Button Agregar Zapato
        private void Button_Agregar_Click(object sender, EventArgs e)
        {
            AgregarInsert();
            Limpiar();
            bb.ObtenerProductos();
        }


        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            LlamarColores();
        }

        public void LlamarColores()
        {
            comboBox1.DataSource = bb.Allcolor();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "IdColor";
            comboBox1.SelectedIndex = -1;
        }
    }
}
