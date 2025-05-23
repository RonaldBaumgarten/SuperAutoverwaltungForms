using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoverwaltungForms
{
    public partial class AddForm : Form
    {
        private Auto auto;

        public AddForm()
        {
            InitializeComponent();
            for (int i = 2025; i >= 1950; i++)
            {
                cmbBaujahr.Items.Add(i);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form.Show(AddForm);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
