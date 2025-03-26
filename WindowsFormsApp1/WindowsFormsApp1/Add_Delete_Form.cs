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
    public partial class Add_Delete_Form : Form
    {
        public Add_Delete_Form()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm MainForm = new mainForm();
            MainForm.Show();
        }

        private void Add_prod_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Form add_form = new Add_Form();
            add_form.Show();
        }

        private void Del_prod_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Form delete_form = new Delete_Form();
            delete_form.Show();
        }
    }
}
