using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantCheat
{
    public partial class Form1 : Form

    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            gunaElipsePanel7.Show();
            gunaElipsePanel12.Hide();
            gunaElipsePanel14.Hide();

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaElipsePanel7.Hide();
            gunaElipsePanel12.Show();
            gunaElipsePanel14.Hide();


        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            gunaElipsePanel14.Show();
            gunaElipsePanel7.Hide();
            gunaElipsePanel12.Hide();
        }

        private void gunaCheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox14.Checked)
            {
                this.Opacity = 0.5;
            }

            else
            {
                this.Opacity = 1;
            }
        }

        private void gunaCheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox15.Checked)
            {
                this.TopMost = true;
            }

            else
            {
                this.TopMost = false;
            }
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            Form2 credits = new Form2();
            credits.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
