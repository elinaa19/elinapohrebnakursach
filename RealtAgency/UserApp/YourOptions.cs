﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtAgency.UserApp
{
    public partial class YourOptions : Form
    {
        public YourOptions()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.White;

        }

        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.Red;
        }

        Point LastPount;
        private void ManePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPount.X;
                this.Top += e.Y - LastPount.Y;

            }
        }

        private void ManePanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPount = new Point(e.X, e.Y);
        }

        private void ShowLikedOnesButton_Click(object sender, EventArgs e)
        {
            Form Liked = new YourLiked();
            Liked.Top = this.Top;
            Liked.Left = this.Left;
            Liked.Show();
            this.Hide();
        }
    }
}