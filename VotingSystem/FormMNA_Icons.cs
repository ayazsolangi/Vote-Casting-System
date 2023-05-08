﻿using System;
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
    public partial class FormMNA_Icons : Form
    {
        public FormMNA_Icons()
        {
            InitializeComponent();
        }

        private void pictureBoxApple_Click(object sender, EventArgs e)
        {
            Vote("Apple");
        }
        private void Vote(String Vote)
        {
            if (DB_Connection.connection.State == ConnectionState.Open)
            {

                DB_Connection.connection.Close();
            }


            DB_Connection.connection.Open();
            String query = "insert into Votes_MNA(Vote_MNA) values('" + Vote + "')";
            SqlCommand cmd = new SqlCommand(query,DB_Connection.connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            da.Fill(DS);
            DB_Connection.connection.Close();
            MessageBox.Show("Vote Casted Successful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();




        }

        private void pictureBoxOrange_Click(object sender, EventArgs e)
        {
            Vote("Orange");
        }

        private void pictureBoxRose_Click(object sender, EventArgs e)
        {
            Vote("Rose");
        }

        private void pictureBoxCheery_Click(object sender, EventArgs e)
        {
            Vote("Cherry");
        }

        private void pictureBoxButterFly_Click(object sender, EventArgs e)
        {
            Vote("Butterfly");
        }

        private void pictureBoxGoat_Click(object sender, EventArgs e)
        {
            Vote("Goat");
        }
    }
}
