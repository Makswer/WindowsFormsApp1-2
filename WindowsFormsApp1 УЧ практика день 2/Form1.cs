using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_УЧ_практика_день_2
{
    public partial class Form1 : Form
    {
        private double a, b, h;
        private double x, y;

        public Form1()
        {

            InitializeComponent();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            x = a;
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            while (x<=b)
            {
                y = Math.Pow(x, 3) + 4 * Math.Pow(x, 2) * Math.Sqrt(Math.Abs(x));
                this.chart1.Series[0].Points.AddXY(x,y);
                x += h;


                y = Math.Pow(x-1,3)+Math.Pow(Math.Cos(x),3);
                this.chart1.Series[1].Points.AddXY(x, y);
                x += h;


                y = Math.Sqrt(Math.Pow(Math.Abs(x), 2)) * Math.Pow(Math.Sin(x), 3);
                this.chart1.Series[2].Points.AddXY(x, y);
                x += h;
            }
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля!");
            }
        }

        private void цветГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.chart1.Series[0].Color = colorDialog1.Color;
            }
        }

        private void цветГрафикаF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.chart1.Series[1].Color = colorDialog1.Color;
            }
        }

        private void цветГрафикаF3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.chart1.Series[2].Color = colorDialog1.Color;
            }
        }

        private void цветФонаГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                this.chart1.ChartAreas[0].BackColor  =  colorDialog1.Color;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Сохранить изображение как ...";
                sfd.Filter = "*.bmp|*.bmp;|*.png|*.png;|*.jpg|*.jpg";
                sfd.AddExtension = true;
                sfd.FileName = "graphicImage";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                 chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); 
                }
            }
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
