namespace MonUniverse
{
    public partial class DataForm : Form
    {
        DataGridView dgv = new DataGridView()
        {
            Dock = DockStyle.Fill
        };
        public DataForm(BindingSource src)
        {
            InitializeComponent();
            this.Controls.Add(dgv);
            dgv.DataSource = src;
            DataGridViewViewer.ConfigureAsReadOnlyViewer(this.dgv, src);
        }
    }
}