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
    public partial class Form1 : Form
    {
        Business tt = new Business();

        public Form1()
        {
            InitializeComponent();
        }

        //---------------Metodos
        public void MostrasDataGrid()
        {
            dataGridView1.DataSource = tt.ObtenerProductos();
        }
        public void FiltrarById()
        {
            dataGridView1.DataSource = tt.FiltroId(Convert.ToInt32(TextBox_BscID.Text));
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrasDataGrid();
        }


        //TextBox Solo Númerico 
        private void TextBox_BscID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 2)
            {
                e.Handled = true;
            }
        }
        //Ir al FORM de Agregar
        private void Button_Agregar_Click(object sender, EventArgs e)
        {
            AgregarProductos FormAddPro = new AgregarProductos();
            FormAddPro.ShowDialog();
        }


        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tt.FiltroTitle(TextBox_BscNombre.Text);
        }



        private void Button_BsrID_Click(object sender, EventArgs e)
        {
            FiltrarById();
        }

        private void Button_Actualizar_Click(object sender, EventArgs e)
        {
            MostrasDataGrid();
            TextBox_BscID.Text = "";
            TextBox_BscNombre.Text = "";
        }
    }   
}
