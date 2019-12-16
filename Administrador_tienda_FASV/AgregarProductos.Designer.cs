namespace Administrador_tienda_FASV
{
    partial class AgregarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_addNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_AddDescProduc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_AddPrecio = new System.Windows.Forms.TextBox();
            this.Button_Agregar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_addNombre
            // 
            this.TextBox_addNombre.Location = new System.Drawing.Point(538, 32);
            this.TextBox_addNombre.Name = "TextBox_addNombre";
            this.TextBox_addNombre.Size = new System.Drawing.Size(239, 26);
            this.TextBox_addNombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción del Producto:";
            // 
            // TextBox_AddDescProduc
            // 
            this.TextBox_AddDescProduc.Location = new System.Drawing.Point(431, 143);
            this.TextBox_AddDescProduc.Name = "TextBox_AddDescProduc";
            this.TextBox_AddDescProduc.Size = new System.Drawing.Size(239, 26);
            this.TextBox_AddDescProduc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio:";
            // 
            // TextBox_AddPrecio
            // 
            this.TextBox_AddPrecio.Location = new System.Drawing.Point(431, 221);
            this.TextBox_AddPrecio.Name = "TextBox_AddPrecio";
            this.TextBox_AddPrecio.Size = new System.Drawing.Size(125, 26);
            this.TextBox_AddPrecio.TabIndex = 15;
            this.TextBox_AddPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_AddPrecio_KeyPress);
            // 
            // Button_Agregar
            // 
            this.Button_Agregar.Location = new System.Drawing.Point(273, 393);
            this.Button_Agregar.Name = "Button_Agregar";
            this.Button_Agregar.Size = new System.Drawing.Size(121, 45);
            this.Button_Agregar.TabIndex = 16;
            this.Button_Agregar.Text = "Agregar";
            this.Button_Agregar.UseVisualStyleBackColor = true;
            this.Button_Agregar.Click += new System.EventHandler(this.Button_Agregar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Color:";
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Button_Agregar);
            this.Controls.Add(this.TextBox_AddPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_AddDescProduc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_addNombre);
            this.Controls.Add(this.label2);
            this.Name = "AgregarProductos";
            this.Text = "AgregarProductos";
            this.Load += new System.EventHandler(this.AgregarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_addNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_AddDescProduc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_AddPrecio;
        private System.Windows.Forms.Button Button_Agregar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}