using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class replace : Form
    {
        int i;
        public replace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            i = main.tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault().Find(textBox1.Text, 0, RichTextBoxFinds.None);
            try
            {
                main.tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault().SelectedText = main.tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault().SelectedText.Replace(main.tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault().SelectedText, textBox2.Text);
            }
            catch(Exception)
            {

            }
            }
    }
}
