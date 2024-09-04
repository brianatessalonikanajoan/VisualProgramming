using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                TXT_PASS.UseSystemPasswordChar = false;
            }
            else
            {
                TXT_PASS.UseSystemPasswordChar=true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "OnlyPray";
            string password = "Prayshe04";

            if(TXT_USER.Text == username && TXT_PASS.Text == password)
            {
                this.Hide();
                MessageBox.Show("Login Success");
                Form3 Form = new Form3();
                Form.ShowDialog();
            }
        }
    }
}
