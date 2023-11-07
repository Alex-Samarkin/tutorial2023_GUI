using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tut3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if( textBox1.SelectionLength > 0 )
            {
                textBox1.Copy();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Cut();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString();
            var index = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert( index,date);
            // textBox1.SelectionStart = index;
            textBox1.SelectionStart = index+date.Length;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var txt = this.toolStripTextBox1.Text;
            var index = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(index, txt);
            // textBox1.SelectionStart = index;
            // textBox1.SelectionStart = index + txt.Length;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var txt = this.toolStripTextBox2.Text;
            var index = textBox1.SelectionStart;

            index = textBox1.Text.IndexOf(txt);
            if (index != -1)
            {
                textBox1.SelectionStart = index;
                textBox1.SelectionLength = txt.Length;
            }
        }
    }
}
