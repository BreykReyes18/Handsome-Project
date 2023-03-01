using prueba.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class frm_login : Form
    {
        private Builder builder;
        private Connection connection;
        private frm_menu fm;
        public object DATETIME { get; private set; }

        public frm_login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            builder = new Builder();
            connection = new Connection();
            builder.Build(TxtUser.Text, TxtPassword.Text);
            if (connection.Connect())
            {                
                Clear();
                MessageBox.Show("Conexión exitosa.");
                connection.Disconnect();
                fm = new frm_menu();
                fm.ShowDialog();
            }
            else
            {
                Clear();
                MessageBox.Show("Conexión no exitosa.");
            }
        }

        private void Clear()
        {
            TxtUser.Clear();
            TxtPassword.Clear();
        }

        private void btn_apagar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
