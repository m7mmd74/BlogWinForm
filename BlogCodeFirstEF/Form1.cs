using BlogCodeFirstEF.Models;

namespace BlogCodeFirstEF
{
    public partial class Form1 : Form
    {
        ITIDbcontext db;
        public Form1()
        {
            InitializeComponent();
            db = new ITIDbcontext();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}