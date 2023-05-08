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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonMNA_Click(object sender, EventArgs e)
        {
            FormMNA obj = new FormMNA();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result obj = new Result("MNA");
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_MPA obj = new Form_MPA();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result obj = new Result("MPA");
            obj.ShowDialog();
        }
    }
}
