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

namespace VotingSystem
{
    public partial class FormMNA : Form
    {
        public FormMNA()
        {
            InitializeComponent();
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            if (TextBoxNic.Text.Length != 13)
            {
                MessageBox.Show("Please Enter NIC number in valid format \n without dash (-)", "Invalid NIC Format given");
                TextBoxNic.Focus();
                return;
            }
            try
            {
                Double nic = Convert.ToDouble(TextBoxNic.Text);
            }


            catch (Exception ee)
            {
                MessageBox.Show("Please Enter NIC number in valid format", "Error");
                return;
            }

            try
            {
                if (DB_Connection.connection.State == ConnectionState.Open)
                {

                    DB_Connection.connection.Close();
                }


                DB_Connection.connection.Open();

                String query = "insert into MNA_Table values('" + TextBoxNic.Text + "')";
                SqlCommand cmd = new SqlCommand(query, DB_Connection.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                TextBoxNic.Clear();
                 //MessageBox.Show("SuccessFul");

                DB_Connection.connection.Close();
                FormMNA_Icons obj = new FormMNA_Icons();
                obj.ShowDialog();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Sorry this person has casted vote","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                TextBoxNic.Focus();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
        }
    }
    }

