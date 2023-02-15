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
    public partial class frm_prueba : Form
    {
        public frm_prueba()
        {
            InitializeComponent();
        }

        

        private void Open_form_panel(object form_panel)
        {
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        
    }
}
