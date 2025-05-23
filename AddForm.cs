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
        int index;
        bool edit;

        public Auto Auto { get => auto; set => auto = value; }

        public AddForm(List <Auto> a)
        {
            InitializeComponent();
            autos = a;
            edit = false;

            for (int i = 2025; i >= 1950; i--)
            {
                cmbBaujahr.Items.Add(i);
            }
        }

        public AddForm(List <Auto> a, bool e, int ind)
        {
            InitializeComponent();
            autos = a;
            edit = e;
            index = ind;

            if (edit)
            {
                btnCreate.Text = "Aendern";
                fill();
            }

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

            if (edit)
                autos[index] = auto;
            else
                autos.Add(auto);
         
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void fill()
        {
            auto = autos[index];
            txtModell.Text = autos[index].Modellname;
            cmbMarke.Text = autos[index].Marke;
            txtPreis.Text = autos[index].Preis.ToString();
            cmbBaujahr.Text = autos[index].Marke.ToString();
            if (auto.Antrieb.Equals("Benzin"))
            {
                rdoBenzin.Checked = true;
                //rdoDiesel.Checked = false;
            }
            else
            {
                //rdoBenzin.Checked = false;
                rdoDiesel.Checked = true;
            }
            if (auto.Extras.Contains("Klimaanlage"))
            {
                chkKlima.Checked = true;
            }
            if (auto.Extras.Contains("Sitzheizung"))
            {
                chkSitzheizung.Checked = true;
            }
        }


    }
}
