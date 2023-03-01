using DB_MAPR;
using prueba.Sql;
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
            string consulta = "select * from CHK_LIST";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Properties.Settings.Default.connection);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_checklist.DataSource = dt;
        }
    }
}
