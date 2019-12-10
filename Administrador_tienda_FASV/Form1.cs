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
using Entity;

namespace Administrador_tienda_FASV
{
    public partial class Form1 : Form
    {

        Business BsSQL = new Business();


        public Form1()
        {
            InitializeComponent();
        }

        public void MostrasDataGrid()
        {
            dataGridView1.DataSource = BsSQL.ListarProductos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrasDataGrid();
        }
    }
}
