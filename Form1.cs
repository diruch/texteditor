using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.Activate();
            
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Новая вкладка";
        }

        public void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            TabPage t = new TabPage("Новая вкладка");
            RichTextBox r = new RichTextBox();
            r.Dock = DockStyle.Fill;
            r.BackColor = Color.Bisque;
            tabControl1.TabPages.Add(t);
            t.Controls.Add(r);
           
            tabControl1.SelectedTab = t;
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                t.Text = ofd.FileName;
            }
            string str = System.IO.File.ReadAllText(@filePath, Encoding.Default);
            r.Text = str;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            var a=tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName + ".txt", a.Text, Encoding.Default);

        }
      
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                exiting a = new exiting();
                a.Show();
            
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            exiting a = new exiting();
            a.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search f = new Search();
            f.Owner = this;
            f.Show();
            
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
      

        private void создатьВкладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage t = new TabPage("Новая вкладка");
            
            RichTextBox r = new RichTextBox();
            r.BackColor = Color.Bisque;
            r.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(t);
            t.Controls.Add(r);
            tabControl1.SelectedTab = t;
            
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tabControl1.SelectedTab.Dispose();
                
            }
            
        } 

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }

      
        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            var a = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            System.Drawing.Font currentFont = a.SelectionFont;
            System.Drawing.FontStyle newFontStyle;
            newFontStyle = FontStyle.Regular;
            a.SelectionFont = new Font(currentFont.FontFamily, 4, newFontStyle);

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            FontDialog fo = new FontDialog();
            fo.ShowColor = true;
            if (fo.ShowDialog()==DialogResult.OK &!string.IsNullOrEmpty(a.ToString()))
            {
                a.SelectionFont = fo.Font;
                a.SelectionColor = fo.Color;
            }
        }

        private void левоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            a.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void центрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            a.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void правоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            a.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            a.Undo();
        }

        private void найтиИЗаменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replace f1 = new replace();
            f1.Owner = this;
            f1.Show();
        }

        private void выравниваниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            a.Paste();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().FirstOrDefault();
            a.Copy();
        }
    }
}
