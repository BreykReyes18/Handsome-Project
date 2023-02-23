namespace prueba
{
    partial class frm_prueba
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "salir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Abrir Menu";
            // 
            // btn_menu
            // 
            this.btn_menu.Image = global::prueba.Properties.Resources.menu;
            this.btn_menu.Location = new System.Drawing.Point(42, 83);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(86, 63);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu.TabIndex = 5;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::prueba.Properties.Resources.pngwing_com;
            this.btn_salir.Location = new System.Drawing.Point(175, 83);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(69, 63);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 2;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prueba.Properties.Resources.handsoll_BLOQ_IT;
            this.pictureBox1.Location = new System.Drawing.Point(3, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 382);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_prueba";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_menu;
    }
}

