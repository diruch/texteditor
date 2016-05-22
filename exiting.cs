using System;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class exiting : Form
    {
        public exiting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
