using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
        }
        void check() {


            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {

                MessageBox.Show("Please Fill All the Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (textBoxUserName.Text == "Admin" && textBoxPassword.Text == "Password")
            {
                Dashboard DA = new Dashboard();
                this.Hide();
                DA.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid Login Details", "Errpor", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }









        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                check();

            }
        }
    }
}
