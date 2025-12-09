using Tyuiu.GroshevID.Sprint6.Task0.V7.Lib;

namespace Tyuiu.GroshevID.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA.Text), Convert.ToInt32()))
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
