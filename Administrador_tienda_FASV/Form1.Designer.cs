namespace Administrador_tienda_FASV
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_BscNombre = new System.Windows.Forms.TextBox();
            this.Button_Agregar = new System.Windows.Forms.Button();
            this.Button_Editar = new System.Windows.Forms.Button();
            this.Button_Eliminar = new System.Windows.Forms.Button();
            this.TextBox_BscID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_BsrID = new System.Windows.Forms.Button();
            this.Button_Actualizar = new System.Windows.Forms.Button();
            this.TextBox_DeleteId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1326, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // TextBox_BscNombre
            // 
            this.TextBox_BscNombre.Location = new System.Drawing.Point(124, 124);
            this.TextBox_BscNombre.Name = "TextBox_BscNombre";
            this.TextBox_BscNombre.Size = new System.Drawing.Size(239, 26);
            this.TextBox_BscNombre.TabIndex = 3;
            // 
            // Button_Agregar
            // 
            this.Button_Agregar.Location = new System.Drawing.Point(660, 25);
            this.Button_Agregar.Name = "Button_Agregar";
            this.Button_Agregar.Size = new System.Drawing.Size(121, 45);
            this.Button_Agregar.TabIndex = 4;
            this.Button_Agregar.Text = "Agregar";
            this.Button_Agregar.UseVisualStyleBackColor = true;
            this.Button_Agregar.Click += new System.EventHandler(this.Button_Agregar_Click);
            // 
            // Button_Editar
            // 
            this.Button_Editar.Location = new System.Drawing.Point(660, 104);
            this.Button_Editar.Name = "Button_Editar";
            this.Button_Editar.Size = new System.Drawing.Size(121, 45);
            this.Button_Editar.TabIndex = 5;
            this.Button_Editar.Text = "Editar";
            this.Button_Editar.UseVisualStyleBackColor = true;
            // 
            // Button_Eliminar
            // 
            this.Button_Eliminar.Location = new System.Drawing.Point(831, 104);
            this.Button_Eliminar.Name = "Button_Eliminar";
            this.Button_Eliminar.Size = new System.Drawing.Size(121, 59);
            this.Button_Eliminar.TabIndex = 6;
            this.Button_Eliminar.Text = "Eliminar por ID:";
            this.Button_Eliminar.UseVisualStyleBackColor = true;
            this.Button_Eliminar.Click += new System.EventHandler(this.Button_Eliminar_Click);
            // 
            // TextBox_BscID
            // 
            this.TextBox_BscID.Location = new System.Drawing.Point(124, 77);
            this.TextBox_BscID.Name = "TextBox_BscID";
            this.TextBox_BscID.Size = new System.Drawing.Size(125, 26);
            this.TextBox_BscID.TabIndex = 7;
            this.TextBox_BscID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_BscID_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Buscar_Click);
            // 
            // Button_BsrID
            // 
            this.Button_BsrID.Location = new System.Drawing.Point(369, 58);
            this.Button_BsrID.Name = "Button_BsrID";
            this.Button_BsrID.Size = new System.Drawing.Size(121, 45);
            this.Button_BsrID.TabIndex = 9;
            this.Button_BsrID.Text = "Buscar";
            this.Button_BsrID.UseVisualStyleBackColor = true;
            this.Button_BsrID.Click += new System.EventHandler(this.Button_BsrID_Click);
            // 
            // Button_Actualizar
            // 
            this.Button_Actualizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Button_Actualizar.Location = new System.Drawing.Point(645, 429);
            this.Button_Actualizar.Name = "Button_Actualizar";
            this.Button_Actualizar.Size = new System.Drawing.Size(116, 62);
            this.Button_Actualizar.TabIndex = 10;
            this.Button_Actualizar.Text = "Actualizar";
            this.Button_Actualizar.UseVisualStyleBackColor = false;
            this.Button_Actualizar.Click += new System.EventHandler(this.Button_Actualizar_Click);
            // 
            // TextBox_DeleteId
            // 
            this.TextBox_DeleteId.Location = new System.Drawing.Point(958, 124);
            this.TextBox_DeleteId.Name = "TextBox_DeleteId";
            this.TextBox_DeleteId.Size = new System.Drawing.Size(125, 26);
            this.TextBox_DeleteId.TabIndex = 11;
            this.TextBox_DeleteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_DeleteId_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 494);
            this.Controls.Add(this.TextBox_DeleteId);
            this.Controls.Add(this.Button_Actualizar);
            this.Controls.Add(this.Button_BsrID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox_BscID);
            this.Controls.Add(this.Button_Eliminar);
            this.Controls.Add(this.Button_Editar);
            this.Controls.Add(this.Button_Agregar);
            this.Controls.Add(this.TextBox_BscNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_BscNombre;
        private System.Windows.Forms.Button Button_Agregar;
        private System.Windows.Forms.Button Button_Editar;
        private System.Windows.Forms.Button Button_Eliminar;
        private System.Windows.Forms.TextBox TextBox_BscID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_BsrID;
        private System.Windows.Forms.Button Button_Actualizar;
        private System.Windows.Forms.TextBox TextBox_DeleteId;
    }
}

