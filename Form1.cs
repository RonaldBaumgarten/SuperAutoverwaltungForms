namespace AutoverwaltungForms
{
    public partial class Form1 : Form
    {

        private List<Auto> autos = new List<Auto>();

        public List<Auto> Autos { get => autos }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.ShowDialog();
        }
    }
}
