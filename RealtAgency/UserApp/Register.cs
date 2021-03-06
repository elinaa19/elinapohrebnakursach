﻿using RealtAgency.Models;
using RealtAgency.RealAgencyLibrary.Models;
using RealtAgency.UserApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtAgency
{
    public partial class Register : Form
    {
        internal Contora store;
        public string cost;

        public Register()
        {

        }
        public Register(ref Contora store)
        {
            this.store = store;
            InitializeComponent();
        }

        // Додавання покупця
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegName.Text) || string.IsNullOrWhiteSpace(RegPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(RegName.Text))
                {
                    RegName.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(RegPassword.Text))
                {

                    RegPassword.BackColor = Color.MediumSeaGreen;
                }
                MessageBox.Show("Fill in the blank space, please");
                RegName.BackColor = Color.White;
                RegPassword.BackColor = Color.White;
            }
            else if (RegName.Text.Length < 2 || RegName.Text.Length >= 10)
            {
                RegName.BackColor = Color.Red;
                MessageBox.Show("Name has inappropriate length, try again");
                RegName.BackColor = Color.White;
                RegName.Text = string.Empty;
            }
            else if (RegPassword.Text.Length < 2 || RegPassword.Text.Length >= 10)
            {
                RegPassword.BackColor = Color.Red;
                MessageBox.Show("Password has inappropriate length, try again");
                RegPassword.BackColor = Color.White;
                RegPassword.Text = string.Empty;
            }
            else
            {
                    string name = RegName.Text;
                    string pass = RegPassword.Text;
                    cost = comboBoxRegCost.Text;
                    string rooms = RegRooms.Text;
                    string neighb = RegNeighb.Text;
                string condition = RegCondition.Text;

                    if (store.Buyers.FirstOrDefault(u => u.Name == name || u.Password == pass) == null)
                    {
                        Buyer user = new Buyer(name, pass);
                    Criteria criteria = new Criteria(cost, rooms, neighb, condition);
                    store.Criterias.Add(criteria);
                    
                        store.Buyers.Add(user);
                        MessageBox.Show("We are glad to hear you joined us!");
                        store.Save();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, such buyer already exists in our app(");
                        RegName.Text = string.Empty;
                        RegPassword.Text = string.Empty;
                    }
                }
        }
            
        // Кнопка Close
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        //Події та їх Функції для переміщення форми по екрану 
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

        // Кнопка Back
        private void BackButton_Click(object sender, EventArgs e)
        {
            Form Autorization1 = Application.OpenForms[0];
            Autorization1.Left = this.Left;
            Autorization1.Top = this.Top;
            Autorization1.Show();
            this.Hide();
        }

   
        // Валідація вводу користувача
        private void RegName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        //Name
        private void RegName_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();

        }

        private void RegName_TextChanged(object sender, EventArgs e)
        {
            RegName.Text = RegName.Text.Replace(" ", " ");
        }
        //Password
        private void RegPassword_TextChanged(object sender, EventArgs e)
        {
            RegPassword.Text = RegPassword.Text.Replace(" ", " ");
        }

        private void RegPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RegPassword_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }
        //Condition
        private void RegCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Rooms
        private void RegRooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       //Neghbourhood
        private void RegNeighb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Price
		private void comboBoxRegCost_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

        // Повідомлення  користувачу
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, fill all the fields to register in our app. Your password should be from 3 to 10 characters, using only numbers.");
        }
    }
}
