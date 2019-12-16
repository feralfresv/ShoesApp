namespace Administrador_tienda_FASV
{
    partial class Form2Modificar
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
            this.TxT_ModPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_ModDescr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_ModNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ModId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxT_ModPrecio
            // 
            this.TxT_ModPrecio.Location = new System.Drawing.Point(414, 286);
            this.TxT_ModPrecio.Name = "TxT_ModPrecio";
            this.TxT_ModPrecio.Size = new System.Drawing.Size(125, 26);
            this.TxT_ModPrecio.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio:";
            // 
            // Txt_ModDescr
            // 
            this.Txt_ModDescr.Location = new System.Drawing.Point(414, 208);
            this.Txt_ModDescr.Name = "Txt_ModDescr";
            this.Txt_ModDescr.Size = new System.Drawing.Size(239, 26);
            this.Txt_ModDescr.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Descripción del Producto:";
            // 
            // Txt_ModNombre
            // 
            this.Txt_ModNombre.Location = new System.Drawing.Point(521, 97);
            this.Txt_ModNombre.Name = "Txt_ModNombre";
            this.Txt_ModNombre.Size = new System.Drawing.Size(239, 26);
            this.Txt_ModNombre.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre: ";
            // 
            // Txt_ModId
            // 
            this.Txt_ModId.Location = new System.Drawing.Point(414, 41);
            this.Txt_ModId.Name = "Txt_ModId";
            this.Txt_ModId.ReadOnly = true;
            this.Txt_ModId.Size = new System.Drawing.Size(125, 26);
            this.Txt_ModId.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // Button_Editar
            // 
            this.Button_Editar.Location = new System.Drawing.Point(319, 378);
            this.Button_Editar.Name = "Button_Editar";
            this.Button_Editar.Size = new System.Drawing.Size(121, 45);
            this.Button_Editar.TabIndex = 24;
            this.Button_Editar.Text = "Editar";
            this.Button_Editar.UseVisualStyleBackColor = true;
            this.Button_Editar.Click += new System.EventHandler(this.Button_Editar_Click);
            // 
            // Form2Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Editar);
            this.Controls.Add(this.Txt_ModId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxT_ModPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_ModDescr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_ModNombre);
            this.Controls.Add(this.label2);
            this.Name = "Form2Modificar";
            this.Text = "Form2Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxT_ModPrecio;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox Txt_ModDescr;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox Txt_ModNombre;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox Txt_ModId;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Editar;
    }
}