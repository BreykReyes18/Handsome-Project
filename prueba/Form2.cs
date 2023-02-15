using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_prueba frm = new frm_prueba();
            frm.Show();
            

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            this.img_menu.Hide();
            this.img_menu.Visible= false;
            this.dgv_usuarios.Visible= true;
        }

        private void img_menu_Click(object sender, EventArgs e)
        {

        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv_usuarios.Visible= false;
        }

        private void panel_opciones_Paint(object sender, PaintEventArgs e)
        {
            this.img_menu.Visible= true;
            this.dgv_usuarios.Visible= false;
            this.dgv_usuarios.Hide();
            dgv_usuarios.Show();
        }
    }
}
