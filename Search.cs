using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Search : Form
    {
        
        int i = 0;
        public Search()
        {
            InitializeComponent();
        }

        
        public void Search_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            i= main.tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault().Find(textBox1.Text, 0, RichTextBoxFinds.None);

            main.tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault().Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                i = main.tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault().Find(textBox1.Text, i + textBox1.Text.Length, RichTextBoxFinds.None);
                main.tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault().Focus();
            }
            catch (Exception)
            {

            }
            }
    }
}
