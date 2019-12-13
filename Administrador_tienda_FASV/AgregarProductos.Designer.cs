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
            this.TextBox_BscNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_DeleteId = new System.Windows.Forms.TextBox();
            this.TextBox_DescProduc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox_BscNombre
            // 
            this.TextBox_BscNombre.Location = new System.Drawing.Point(538, 32);
            this.TextBox_BscNombre.Name = "TextBox_BscNombre";
            this.TextBox_BscNombre.Size = new System.Drawing.Size(239, 26);
            this.TextBox_BscNombre.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Colores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tallas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción del Producto:";
            // 
            // TextBox_DeleteId
            // 
            this.TextBox_DeleteId.Location = new System.Drawing.Point(477, 79);
            this.TextBox_DeleteId.Name = "TextBox_DeleteId";
            this.TextBox_DeleteId.Size = new System.Drawing.Size(125, 26);
            this.TextBox_DeleteId.TabIndex = 12;
            this.TextBox_DeleteId.TextChanged += new System.EventHandler(this.TextBox_DeleteId_TextChanged);
            this.TextBox_DeleteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_DeleteId_KeyPress);
            // 
            // TextBox_DescProduc
            // 
            this.TextBox_DescProduc.Location = new System.Drawing.Point(431, 249);
            this.TextBox_DescProduc.Name = "TextBox_DescProduc";
            this.TextBox_DescProduc.Size = new System.Drawing.Size(239, 26);
            this.TextBox_DescProduc.TabIndex = 13;
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_DescProduc);
            this.Controls.Add(this.TextBox_DeleteId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_BscNombre);
            this.Controls.Add(this.label2);
            this.Name = "AgregarProductos";
            this.Text = "AgregarProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_BscNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_DeleteId;
        private System.Windows.Forms.TextBox TextBox_DescProduc;
    }
}