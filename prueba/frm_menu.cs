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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        //private DataGridView dgv1 = new DataGridView();
        //private BindingSource bs1 = new BindingSource();
        //private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        //private Button reloadButton = new Button();
        //private Button submitButton = new Button();

        private void AddFormulario(Form f)
        {

            if (this.panel_contenedor1.Controls.Count>0)
            {
                this.panel_contenedor1.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            this.panel_contenedor1.Controls.Add(f);
            f.Dock= DockStyle.Fill;
            f.Show();
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
            frm_usuarios f = new frm_usuarios();
            AddFormulario(f);

            //this.img_menu.Hide();
            //this.img_menu.Visible= false;

            //this.dgv_usuarios.Visible= true;
        }

        private void img_menu_Click(object sender, EventArgs e)
        {

        }

        //private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    this.dgv_usuarios.Visible= false;
        //}

        private void panel_opciones_Paint(object sender, PaintEventArgs e)
        {

            this.img_menu.Hide();
            this.img_menu.Visible= true;
            //this.dgv_usuarios.Visible= false;
            //this.dgv_usuarios.Hide();
            //dgv_usuarios.Show();
        }

        private void btn_Checklist_Click(object sender, EventArgs e)
        {
            this.img_menu.Hide();
            this.img_menu.Visible= false;
            frm_checklist f = new frm_checklist();
            AddFormulario(f);

            //this.Hide();
            //frm_checklist frm_checklist = new frm_checklist();
            //frm_checklist.Show();
        }

        private void panel_contenedor1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
