namespace AutoverwaltungForms
{
    public partial class Form1 : Form
    {

        private List<Auto> autos = new List<Auto>();
        Auto a;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(autos);
            af.ShowDialog();
            updateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Auto temp;
            if (lst.SelectedIndex == -1)
                return;

            temp = autos[lst.SelectedIndex];
            DialogResult res = MessageBox.Show("Moechten sie wirklich loeschen?", "Loeschen", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {
                autos.RemoveAt(lst.SelectedIndex);
            }

            updateList();
        }

        private void updateList()
        {
            lst.Items.Clear();
            foreach (Auto a in autos)
            {
                lst.Items.Add(a.autoInfo());
            }
            lblGesamtwert.Text = getGesamtwert().ToString();
        }

        private double getGesamtwert()
        {
            double g = autos.Sum(x => x.Preis);

            return g;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
