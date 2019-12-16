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
        Form2Modificar MD = new Form2Modificar();

        public Form1()
        {
            InitializeComponent();
        }

        //----------------------------------Metodos
        public void MostrasDataGrid()
        {
            dataGridView1.DataSource = tt.ObtenerProductos();
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

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrasDataGrid();
        }//Mostrar Datagrid al correr el programa

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

        //Ejeccucion
        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            FiltrarByTitle();
        } //Filtrar por Title
         
        private void Button_BsrID_Click(object sender, EventArgs e)
        {
            if (TextBox_BscID.Text == "")
            {
                MessageBox.Show("Inserta un número");
            }
            else
            {
                FiltrarById();
            }
         
        } //Filtrar por ID

        private void Button_Actualizar_Click(object sender, EventArgs e)
        {
            Business t2 = new Business();
            dataGridView1.DataSource = t2.ObtenerProductos2();
            TextBox_BscID.Text = "";
            TextBox_BscNombre.Text = "";
            TextBox_DeleteId.Text = "";

        } //Actualziar Tabla

        private void Button_Eliminar_Click(object sender, EventArgs e)//Eliminar por ID
        {
            DeleteById();
        }

        private void DataGridView1_Click(object sender, EventArgs e)//Mostrar Datos para editar
        {        
            MD.Txt_ModId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MD.Txt_ModNombre.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            MD.Txt_ModDescr.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            MD.TxT_ModPrecio.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void Button_Editar_Click(object sender, EventArgs e)
        {
            MD.ShowDialog();
        }//Ejecutar cambios del zapato

    }   
}
