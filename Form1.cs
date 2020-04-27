using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiemensProgram.Conveyor;

namespace SiemensProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor2 conveyor2 = new Conveyor2();
            conveyor2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 181, 182, 182);
            System.Drawing.Drawing2D.GraphicsPath myPath =
    new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, alBut.Width, alBut.Height);
            Region myRegion = new Region(myPath);
            alBut.Region = myRegion;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            pictureBox11.Visible = false;
            panel1.BackColor = Color.FromArgb(255, 181, 182, 182);
            panel1.BackColor = Color.FromArgb(255, 181, 182, 182);
            panel3.BackColor = Color.FromArgb(255, 181, 182, 182);
        }

        private void conv1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor1 conveyor1 = new Conveyor1();
            conveyor1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            pictureBox11.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            pictureBox11.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            pictureBox11.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Visible = !true;
            Conveyor14 conveyor14 = new Conveyor14();
            conveyor14.ShowDialog();
        }


        private void conv1Info_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor1 conveyor1 = new Conveyor1();
            conveyor1.Show();
            
        }

        private void conv2Info_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor2 conveyor2 = new Conveyor2();
            conveyor2.Show();

        }

        private void conv3Info_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor3 conveyor3 = new Conveyor3();
            conveyor3.Show();
        }

        private void conv4Info_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor4 conveyor4 = new Conveyor4();
            conveyor4.Show();
        }

        private void conv5Info_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor5 conveyor5 =  new Conveyor5();
            conveyor5.Show();
        }

        private void conv6Info_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor6 conveyor6 = new Conveyor6();
            conveyor6.ShowDialog();
        }

        private void conv7Info_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conveyor7 conveyor7 = new Conveyor7();
            conveyor7.ShowDialog();
        }

        private void conv8Info_Click(object sender, EventArgs e)
        {
            this.Visible = !true;
            Conveyor8 conveyor8= new Conveyor8();
            conveyor8.ShowDialog();
        }

        private void conv9Info_Click(object sender, EventArgs e)
        {
            this.Visible = !true;
            Conveyor9 conveyor9 = new Conveyor9();
            conveyor9.ShowDialog();
        }

        private void conv10Info_Click(object sender, EventArgs e)
        {
            this.Visible = !true;
            Conveyor10 conveyor10 = new Conveyor10();
            conveyor10.ShowDialog();
        }

        private void conv11Info_Click(object sender, EventArgs e)
        {
            this.Visible = !true;
            Conveyor11 conveyor11 = new Conveyor11();
            conveyor11.ShowDialog();
        }

        private void conv12Info_Click(object sender, EventArgs e)
        {
            this.Visible = !true;
            Conveyor12 conveyor12 = new Conveyor12();
            conveyor12.ShowDialog();
        }

        private void conv13Info_Click(object sender, EventArgs e)
        {
            this.Visible = !true;
            Conveyor13 conveyor13 = new Conveyor13();
            conveyor13.ShowDialog();
        }

        private void conv15Info_Click(object sender, EventArgs e)
        {
            this.Visible = !true;
            Conveyor15 conveyor15 = new Conveyor15();
            conveyor15.ShowDialog();
        }
    }
}
