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
        ConexionDB cc = new ConexionDB();
        Business tt = new Business();

        public Form1()
        {
            InitializeComponent();
        }

        //---------------Metodos
        public void MostrasDataGrid()
        {
            dataGridView1.DataSource = tt.ObtenerProductos();
            TextBox_BscID.Text = "";
            TextBox_BscNombre.Text = "";
            TextBox_DeleteId.Text = "";

        }
        public void FiltrarById()
        {
            dataGridView1.DataSource = tt.FiltroId(Convert.ToInt32(TextBox_BscID.Text));
        }
        public void FiltrarByTitle()
        {
            dataGridView1.DataSource = tt.FiltroTitle(TextBox_BscNombre.Text);
        }
        public void DeleteById()
        {
            tt.EliminarId(Convert.ToInt32(TextBox_DeleteId.Text));
            dataGridView1.DataSource = tt.FiltroId(Convert.ToInt32(TextBox_DeleteId.Text));
        }

        //---------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrasDataGrid();
        }
        //Ir al FORM de Agregar
        private void Button_Agregar_Click(object sender, EventArgs e)
        {
            AgregarProductos FormAddPro = new AgregarProductos();
            FormAddPro.ShowDialog();
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
        private void TextBox_DeleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 2)
            {
                e.Handled = true;
            }
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            FiltrarByTitle();
        } //Filtrar por Title
         
        private void Button_BsrID_Click(object sender, EventArgs e)
        {
            FiltrarById();
        } //Filtrar por ID

        private void Button_Actualizar_Click(object sender, EventArgs e)
        {
            MostrasDataGrid();

        } //Actualziar Tabla

        private void Button_Eliminar_Click(object sender, EventArgs e)//Eliminar por ID
        {
            DeleteById();
        }
    }   
}
