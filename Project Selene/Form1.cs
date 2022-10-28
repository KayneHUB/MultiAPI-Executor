using Project_Selene.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Windows.Forms;
using EasyExploits;
using WeAreDevs_API;
using KrnlAPI;

namespace Project_Selene
{
    public partial class Form1 : Form
    {

        EasyExploits.Module EasyExploitApi = new EasyExploits.Module();
        WeAreDevs_API.ExploitAPI api = new WeAreDevs_API.ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.EXECUTE;
            pictureBox2.Image = Properties.Resources.HOME;
            pictureBox3.Image = Properties.Resources.INJECT;
            CLOSE.Image = Properties.Resources.EXIT;
            MINIMIZE.Image = Properties.Resources.MINIMIZE;
            ScriptTab.Image = Properties.Resources.ScriptTab;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.onmouse;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.EXECUTE;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.INJECT2;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.INJECT;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm too lazy to make HOME Page");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.HOME2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.HOME;
        }

        private void CLOSE_MouseEnter(object sender, EventArgs e)
        {
            CLOSE.Image = Properties.Resources.EXIT2;
        }

        private void CLOSE_MouseLeave(object sender, EventArgs e)
        {
            CLOSE.Image = Properties.Resources.EXIT;
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MINIMIZE_MouseEnter(object sender, EventArgs e)
        {
            MINIMIZE.Image = Properties.Resources.MINIMIZE2;
        }

        private void MINIMIZE_MouseLeave(object sender, EventArgs e)
        {
            MINIMIZE.Image = Properties.Resources.MINIMIZE;
        }

        private void MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This executor is fully skidded by me");
        }

        private void ScriptTab_MouseEnter(object sender, EventArgs e)
        {
            ScriptTab.Image = Properties.Resources.ScriptTab2;
        }

        private void ScriptTab_MouseLeave(object sender, EventArgs e)
        {
            ScriptTab.Image = Properties.Resources.ScriptTab;
        }

        private void ScriptTab_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm too lazy to make Script Tab");
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (EasyExploitButton.Checked == true)
            {
                EasyExploitApi.ExecuteScript(ScriptBox.Text);
            }
            else if(WeAreDevsButton.Checked == true)
            {
                string script = ScriptBox.Text;
                api.SendLuaScript(script);
            }
            else if (KrnlButton.Checked == true)
            {
                MainAPI.Execute(ScriptBox.Text);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (EasyExploitButton.Checked == true)
            {
                EasyExploitApi.LaunchExploit();
            }
            else if (WeAreDevsButton.Checked == true) {
                api.LaunchExploit();
            }
            else if (KrnlButton.Checked == true)
            {
                MainAPI.Inject();
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (topmost.Checked == true) {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
    }
}
