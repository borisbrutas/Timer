using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form1_Resize);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }                               

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(sender,e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Start Timer (ctrl + s)
            if (e.KeyCode == Keys.ControlKey && e.KeyCode == Keys.S)
            {
                MessageBox.Show("s");
            }
            
            //Set Time (ctrl + n)
            if (e.KeyCode == Keys.ControlKey && e.KeyCode == Keys.N)
            {
                MessageBox.Show("s");
            }

            //Stop Timer  (ctrl + t)
            if (e.KeyCode == Keys.ControlKey && e.KeyCode == Keys.T)
            {
                MessageBox.Show("s");
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label1.Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            label1.Font = new Font("Arial", this.ClientSize.Height / 10);
            label1.Text = "Test";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {   
                case Keys.F1:
                    ShowHelp();
                    break;
                case Keys.F2:
                    MaximizeWindow();
                    break;
                case Keys.F3:
                    MinimizeWindow();
                    break;
                case Keys.F12:
                    ShowTimeInput();
                    break;
                default:
                    break;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ShowTimeInput()
        {
            throw new NotImplementedException();
        }

        private void MinimizeWindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.TopMost = true;
        }

        private void MaximizeWindow()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
        }

        protected void ShowHelp()
        {
            MessageBox.Show("F1 = Help. \nF2 = Maximize. \nF3 = Minimize. \nF12 = Close.");
        }
    }
}
