﻿using DB_MAPR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class frm_checklist : Form
    {

        public frm_checklist()
        {
            InitializeComponent();
        }
        private void frm_checklist_Load(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.abrir();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Regresar2_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgv_cam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
