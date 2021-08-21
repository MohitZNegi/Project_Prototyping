using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Prototyping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            int color = colorDialog1.Color.ToArgb();
            richTextBox1.BackColor = Color.FromArgb(color);
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            int color = colorDialog1.Color.ToArgb();
            richTextBox1.ForeColor = Color.FromArgb(color);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            // to set font color.
            colorDialog1.ShowDialog();
            int color = colorDialog1.Color.ToArgb();
            richTextBox1.ForeColor = Color.FromArgb(color);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            richTextBox1.Cut();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

           if (toolStripComboBox1.SelectedIndex == -1)
            {
                toolStripComboBox1.SelectedItem = "Arial";
            }
            if (toolStripComboBox2.SelectedIndex == -1) 
            {
                toolStripComboBox2.SelectedItem = "8";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(font.Name.ToString());
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
           // to set font style as bold.
           richTextBox1.Font = new Font(toolStripComboBox1.SelectedItem.ToString(), Convert.ToInt32(toolStripComboBox2.SelectedItem.ToString()), FontStyle.Bold);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            // to set font style as regular.
            richTextBox1.Font = new Font(toolStripComboBox1.SelectedItem.ToString(), Convert.ToInt32(toolStripComboBox2.SelectedItem.ToString()), FontStyle.Regular);
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            // to set font style as italic.
            richTextBox1.Font = new Font(toolStripComboBox1.SelectedItem.ToString(), Convert.ToInt32(toolStripComboBox2.SelectedItem.ToString()), FontStyle.Italic);
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            // to set font style as underline.
            richTextBox1.Font = new Font(toolStripComboBox1.SelectedItem.ToString(), Convert.ToInt32(toolStripComboBox2.SelectedItem.ToString()), FontStyle.Underline);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // to set font size.
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(toolStripComboBox2.SelectedItem.ToString()));
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // to set font Type.
            richTextBox1.Font = new Font(toolStripComboBox1.Text, richTextBox1.Font.Size);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // to set text alignment as left.
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            // to set text alignment as Center.
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            // to set text alignment as right.
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
