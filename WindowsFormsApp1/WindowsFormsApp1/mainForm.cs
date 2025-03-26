using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Add_Delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Delete_Form add_delete_form = new Add_Delete_Form();
            add_delete_form.Show();
        }

        private void Catalog_Prod_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_Form add_form = new List_Form();
            add_form.Show();
        }
    }
}
