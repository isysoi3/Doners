using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Example
{
    public partial class QueueForm : Form
    {
        Queue<GroupBox> groubBoxes = new Queue<GroupBox>();
        int counter = 0;

        public QueueForm()
        {
            InitializeComponent();
        }

        private void changeRTBColor(Label rtb)
        {
            Color red = Color.FromArgb(255, 128, 128);
            Color yellow = Color.FromArgb(255, 255, 128);
            Color green = Color.FromArgb(128, 255, 128);
            if (rtb.BackColor == Color.White)
                rtb.BackColor = red;
            else if (rtb.BackColor == red)
                rtb.BackColor = yellow;
            else if (rtb.BackColor == yellow)
                rtb.BackColor = green;
            else
                rtb.BackColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupBox lastGroupBox = groubBoxes.Last();
            GroupBox groupBox = new GroupBox();
            groupBox.Top = lastGroupBox.Bottom;
            groupBox.Left = lastGroupBox.Left;
            groupBox.Width = lastGroupBox.Width;
            groupBox.Height = lastGroupBox.Height;
            groupBox.Text = "Заказ №" + counter;
            groubBoxes.Enqueue(groupBox);
            counter++;
            Controls.Add(groupBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupBox firstGroupBox = groubBoxes.Dequeue();
            int deltaY = firstGroupBox.Height;
            Controls.Remove(firstGroupBox);
            foreach (GroupBox gb in groubBoxes)
                gb.Top = gb.Top - deltaY;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox6_Click(object sender, EventArgs e)
        {
            changeRTBColor(sender as Label);
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
