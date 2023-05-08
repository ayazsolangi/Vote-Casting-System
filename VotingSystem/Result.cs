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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }


        public Result(String sql)
        {
            InitializeComponent();

            if (sql == "MNA")
            {

                this.Text = "Result of MNA Election";
                LabelApple.Text = countvote("Apple");
                LabelButterFly.Text = countvote("Butterfly");
                LabelCherry.Text = countvote("Orange");
                LabelRose.Text = countvote("Rose");
                LabelCherry.Text = countvote("Cherry");

                LabelGoat.Text = countvote("Goat");
            }



            else
            {
                this.Text = "Results of MPA Election";
                LabelApple.Text = countvote("Apple");
                LabelButterFly.Text = countvote("Butterfly");
                LabelCherry.Text = countvote("Orange");
                LabelRose.Text = countvote("Rose");
                LabelCherry.Text = countvote("Cherry");

                LabelGoat.Text = countvote("Goat");
            }


        }


        private String countvote(String sql)
        {

            if (DB_Connection.connection.State == ConnectionState.Open)
            {
                DB_Connection.connection.Close();
            }

            DB_Connection.connection.Open();
            String query = "select count(Vote_MNA)  from Votes_MNA where Vote_MNA = '" + sql + "'";
            SqlCommand cmd = new SqlCommand(query, DB_Connection.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0].Rows[0][0] + "";
            DB_Connection.connection.Close();
        }


        private String countvoteMPA(String sql)
        {

            if (DB_Connection.connection.State == ConnectionState.Open)
            {
                DB_Connection.connection.Close();
            }

            DB_Connection.connection.Open();
            String query = "select count(Vote_MNA)  from Votes_MNA where Vote_MNA = '" + sql + "'";
            SqlCommand cmd = new SqlCommand(query, DB_Connection.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0].Rows[0][0] + "";
            DB_Connection.connection.Close();
        }







        private void Result_Load(object sender, EventArgs e)
        {

        }
    }

}
