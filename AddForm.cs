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
        private List<Auto> autos;

        public Auto Auto { get => auto; set => auto = value; }

        public AddForm(List <Auto> a)
        {
            InitializeComponent();
            autos = a;

            for (int i = 2025; i >= 1950; i--)
            {
                cmbBaujahr.Items.Add(i);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ma = cmbMarke.Text;
            double p;
            string mo = txtModell.Text;
            int baujahr; string autoart = ""; string extras = ""; 
            if(Double.TryParse(txtPreis.Text, out p))
            {
            }
            else
            {
                p = 1000.00;
            }

            if(Int32.TryParse(cmbBaujahr.Text, out baujahr))
            {
            }
            else
            {
                baujahr = 2025;
            }


            if(rdoBenzin.Checked)
            {
                autoart = "Benzin";
            }
            else if(rdoDiesel.Checked)
            {
                autoart = "Diesel";
            }

            if(chkKlima.Checked)
            {
                extras += "Klimaanlage ";
            }
            if (chkSitzheizung.Checked)
            {
                extras += "Sitzheizung ";
            }

            auto = new Auto(ma,p,mo, baujahr,autoart,extras);

            autos.Add(auto);
         
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
