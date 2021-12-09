using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._3_lmv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && (e.Control))
            {
                button3_Click(button3, null);
            }
            if (e.KeyCode == Keys.A && (e.Control))
            {
                button4_Click(button4, null);
            }

            if (e.KeyCode == Keys.C && (e.Control))
            {
                button2_Click(button2, null);
            }
            if (e.KeyCode == Keys.M && (e.Control))
            {
                button1_Click(button1, null);
            }
            if (e.KeyCode == Keys.A)
            {
                newToolStripMenuItem.Visible = true;
                openToolStripMenuItem.Visible = true;
                closeToolStripMenuItem.Visible = true;
            }
            if (e.KeyCode == Keys.D)
            {
                newToolStripMenuItem.Visible = false;
                openToolStripMenuItem.Visible = false;
                closeToolStripMenuItem.Visible = false;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Krysevych Maksym");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(button4, null);
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(button1, null);
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(button2, null);
        }

        private void exitCtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(button3, null);
        }
    }
}
