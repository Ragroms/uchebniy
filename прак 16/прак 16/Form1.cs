using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace прак_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mdiChild = new Form2();
            mdiChild.MdiParent = this;
            mdiChild.Show();
            int n = this.MdiChildren.Count();
            mdiChild.Text = "Форма" + Convert.ToString(n);
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form2 mdiChild = new Form2();
                mdiChild.richTextBox1.LoadFile(openFileDialog1.FileName);
                mdiChild.Text = openFileDialog1.FileName;
                mdiChild.MdiParent = this;
                mdiChild.Show();
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Form2 mdiChild = (Form2)this.ActiveMdiChild;
                saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    mdiChild.richTextBox1.SaveFile(saveFileDialog1.FileName);
                    mdiChild.Text = saveFileDialog1.FileName;
                }
            }
        }
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ActiveMdiChild.Font = fontDialog1.Font;
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mdiChild = (Form2)this.ActiveMdiChild;
            if (ActiveMdiChild.richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }
    }
}
