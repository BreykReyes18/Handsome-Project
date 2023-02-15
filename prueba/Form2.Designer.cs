namespace prueba
{
    partial class frm_menu
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
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.btn_apagar = new System.Windows.Forms.PictureBox();
            this.panel_contenedor1 = new System.Windows.Forms.Panel();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.img_menu = new System.Windows.Forms.PictureBox();
            this.panel_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_apagar)).BeginInit();
            this.panel_contenedor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_opciones
            // 
            this.panel_opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_opciones.BackColor = System.Drawing.Color.White;
            this.panel_opciones.Controls.Add(this.btn_mostrar);
            this.panel_opciones.Controls.Add(this.btn_regresar);
            this.panel_opciones.Controls.Add(this.btn_apagar);
            this.panel_opciones.Location = new System.Drawing.Point(0, 0);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(184, 391);
            this.panel_opciones.TabIndex = 0;
            this.panel_opciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_opciones_Paint);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.White;
            this.btn_mostrar.FlatAppearance.BorderSize = 0;
            this.btn_mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar.Location = new System.Drawing.Point(0, 0);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(184, 31);
            this.btn_mostrar.TabIndex = 2;
            this.btn_mostrar.Text = "Mostrar Usuarios";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_regresar.Image = global::prueba.Properties.Resources.regresar;
            this.btn_regresar.Location = new System.Drawing.Point(12, 312);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(66, 67);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 1;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_apagar.Image = global::prueba.Properties.Resources.apagar;
            this.btn_apagar.Location = new System.Drawing.Point(108, 312);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(70, 67);
            this.btn_apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_apagar.TabIndex = 0;
            this.btn_apagar.TabStop = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // panel_contenedor1
            // 
            this.panel_contenedor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_contenedor1.BackColor = System.Drawing.Color.White;
            this.panel_contenedor1.Controls.Add(this.img_menu);
            this.panel_contenedor1.Controls.Add(this.dgv_usuarios);
            this.panel_contenedor1.Location = new System.Drawing.Point(184, 0);
            this.panel_contenedor1.Name = "panel_contenedor1";
            this.panel_contenedor1.Size = new System.Drawing.Size(545, 391);
            this.panel_contenedor1.TabIndex = 1;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(0, 39);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.Size = new System.Drawing.Size(545, 312);
            this.dgv_usuarios.TabIndex = 1;
            this.dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellContentClick);
            // 
            // img_menu
            // 
            this.img_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_menu.Image = global::prueba.Properties.Resources.handsoll_BLOQ_IT;
            this.img_menu.Location = new System.Drawing.Point(-2, 39);
            this.img_menu.Name = "img_menu";
            this.img_menu.Size = new System.Drawing.Size(545, 312);
            this.img_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_menu.TabIndex = 0;
            this.img_menu.TabStop = false;
            this.img_menu.Click += new System.EventHandler(this.img_menu_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 391);
            this.Controls.Add(this.panel_contenedor1);
            this.Controls.Add(this.panel_opciones);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_apagar)).EndInit();
            this.panel_contenedor1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_opciones;
        private System.Windows.Forms.Panel panel_contenedor1;
        private System.Windows.Forms.PictureBox img_menu;
        private System.Windows.Forms.PictureBox btn_apagar;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.DataGridView dgv_usuarios;
    }
}