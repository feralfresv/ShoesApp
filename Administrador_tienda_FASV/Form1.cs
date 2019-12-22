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
using System.IO;
using System.Xml;
//frds

namespace Administrador_tienda_FASV
{
    public partial class Form1 : Form
    {
        ConexionDB test = new ConexionDB();
        Business tt = new Business();
        Form2Modificar MD = new Form2Modificar();
        string PathCarpeta = @"C:\Users\Curso\source\repos\Academia_Softtek\ShoesApp\XML";
        string listItem = string.Empty;
        private delegate void myDelegate();
        DataSet ds = new DataSet();


        public Form1()// InitializeComponent
        {
            InitializeComponent();
        }

        //--METODOS--
        #region Metodos 
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
        private void ExportarXML()
        {
            #region XML Extracción
            var ds = new DataSet();
            var dt = new DataTable();



            foreach (var column in dataGridView1.Columns.Cast<DataGridViewColumn>())
            {
                dt.Columns.Add();
            }

            var cellValues = new object[dataGridView1.Columns.Count];

            foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;

                }
                dt.Rows.Add(cellValues);

            }

            ds.Tables.Add(dt);

            string FileName = @"C:/Users/Curso/source/repos/Academia_Softtek/ShoesApp/XML/Zapatos_xml.xml";
            FileStream Stream = new FileStream(FileName, FileMode.Create);
            XmlTextWriter xmlWriter = new XmlTextWriter(Stream, System.Text.Encoding.Unicode);
            ds.WriteXml(xmlWriter);
            xmlWriter.Close();
            #endregion
        }
        private void GetFiles()
        {
            string[] lst = Directory.GetFiles(PathCarpeta);

            TextBox_File.Text = "";
            foreach (var item in lst)
            {
                TextBox_File.Text += item + Environment.NewLine;
            }
        }
        private void GetCambios()
        {
            dataGridView2.DataSource = test.GetCambiosPro();
        }
        #region FileSystemWatcher
        private void Changed(object source, FileSystemEventArgs e)
        {
            DateTime dt = new DateTime();
            dt = System.DateTime.UtcNow;
            listItem = "Carpeta " + e.FullPath + " " + e.ChangeType.ToString() + " a la hora: " + dt.ToLocalTime().ToString();
            AddFileEvents();
        }
        private void FCreated(object source, FileSystemEventArgs e)
        {
            DateTime dt = new DateTime();
            dt = System.DateTime.UtcNow;
            listItem = "Carpeta " + e.FullPath + " " + e.ChangeType.ToString() + " a la hora: " + dt.ToLocalTime().ToString();
            AddFileEvents();
        }
        private void Deleted(object source, FileSystemEventArgs e)
        {
            DateTime dt = new DateTime();
            dt = System.DateTime.UtcNow;
            listItem = "Carpeta " + e.FullPath + " " + e.ChangeType.ToString() + " a la hora: " + dt.ToLocalTime().ToString();
            AddFileEvents();
        }
        private void Renombrar(object source, FileSystemEventArgs e)
        {
            DateTime dt = new DateTime();
            dt = System.DateTime.UtcNow;
            listItem = "Carpeta " + e.FullPath + " " + e.ChangeType.ToString() + " a la hora: " + dt.ToLocalTime().ToString();
            AddFileEvents();
        }
        #endregion
        #region Private Methods
        private void SetFileWatcher()
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Changed += new FileSystemEventHandler(Changed);
            fsw.Created += new FileSystemEventHandler(FCreated);
            fsw.Deleted += new FileSystemEventHandler(Deleted);
            //fsw.Renamed += new RenamedEventHandler(Renombrar);
            fsw.Path = @"C:\Users\Curso\source\repos\Academia_Softtek\ShoesApp/XML";
            fsw.NotifyFilter = NotifyFilters.FileName |
                                   NotifyFilters.Attributes |
                                   NotifyFilters.LastAccess |
                                   NotifyFilters.LastWrite |
                                   NotifyFilters.Security |
                                   NotifyFilters.Size |
                                   NotifyFilters.CreationTime |
                                   NotifyFilters.DirectoryName;
            fsw.EnableRaisingEvents = true;
        }
        private void AddFileEvents()
        {
            if (listBox1.InvokeRequired)
            {
                myDelegate md = new myDelegate(AddFileEvents);
                this.Invoke(md, null);
            }
            else
            {
                listBox1.Items.Add(listItem);
            }
        }
        #endregion

        #endregion


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)//Mostrar Datagrid al correr el programa
        {
            FileSystemWatcher1.Path = PathCarpeta;
            MostrasDataGrid();
            ExportarXML();
            GetFiles();
            SetFileWatcher();
            GetCambios();

            WindowState = FormWindowState.Maximized;


            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "XML|*.xml";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        ds.Tables[0].WriteXml(sfd.FileName);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex);
            //    }
            //}
        }



        private void Button_Agregar_Click(object sender, EventArgs e)//Ir al FORM de Agregar
        {
            AgregarProductos FormAddPro = new AgregarProductos();
            FormAddPro.ShowDialog();
        }
        private void TextBox_BscID_KeyPress(object sender, KeyPressEventArgs e)//TextBox Solo Númerico 

        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 2)
            {
                e.Handled = true;
            }
        }
        private void TextBox_DeleteId_KeyPress(object sender, KeyPressEventArgs e)//TextBoxEliminar SOlo Números
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 2)
            {
                e.Handled = true;
            }
        }

        //Ejeccucion de Metodos
        private void Button_Buscar_Click(object sender, EventArgs e)//Filtrar por Title
        {
            FiltrarByTitle();
        }
         
        private void Button_BsrID_Click(object sender, EventArgs e)//Filtrar por ID
        {
            if (TextBox_BscID.Text == "")
            {
                MessageBox.Show("Inserta un número");
            }
            else
            {
                FiltrarById();
            }
         
        }

        private void Button_Actualizar_Click(object sender, EventArgs e)//Actualziar Tabla
        {
            Business t2 = new Business();
            dataGridView1.DataSource = t2.ObtenerProductos2();
            TextBox_BscID.Text = "";
            TextBox_BscNombre.Text = "";
            TextBox_DeleteId.Text = "";
            ExportarXML();

        } 

        private void Button_Eliminar_Click(object sender, EventArgs e)//Eliminar por ID
        {
            DeleteById();
            ExportarXML();
        }

        private void DataGridView1_Click(object sender, EventArgs e)//Mostrar Datos para editar
        {        
            MD.Txt_ModId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MD.Txt_ModNombre.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            MD.Txt_ModDescr.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            MD.TxT_ModPrecio.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();


            /*---------->FIX*/
            MD.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].ToString();//BUSCAR SOLUCION <-----------FIX
        }

        private void Button_Editar_Click(object sender, EventArgs e)//Ejecutar cambios del zapato
        {
            MD.ShowDialog();
        }

        private void FileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)//Obtener Carpetas
        {           
            GetFiles();
        }   


    }
}
