using Microsoft.ReportingServices.Diagnostics.Internal;
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

        private string  = "Data Source=srv-data2;Initial Catalog=DB_MAPR;Integrated Security=True";

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frm_checklist_Load(object sender, EventArgs e, object dt)
        {
            conexionbd conecct = 
            //string consulta = "select * from CAM";
            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, connectionString);
            //DataTable dataTable = new DataTable();
            //DataTable datatable = dataTable;
            //adaptador.Fill(datatable);

            //dgv_cam.DataSource= dt;

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
