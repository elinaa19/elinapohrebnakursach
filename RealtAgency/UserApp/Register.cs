using RealtAgency.Models;
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
        public Register(ref Contora store)
        {
            this.store = store;
           
            InitializeComponent();
        }

       
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Берем введенные данные с полей
            string name = RegName.Text;
            string password = RegPassword.Text;
            string cost = RegCost.Text;
            string rooms = RegRooms.Text;
            string neighb = RegNeighb.Text;
            // Проверяем, есть ли в считанном ранее списке пользователь с таким ником и паролем
            // Это LINQ выражение, которое сверяет данные каждого из элементов списка (u) с введенными данными
            if (store.Buyers.FirstOrDefault(u => u.Name == name || u.Password == password) == null)
            {
                Buyer user = new Buyer(name, password);
                store.Buyers.Add(user);
                MessageBox.Show("We are glad to hear you joined us!");
                store.Save();
                Form Options = new YourOptions();
                Options.Left = this.Left;
                Options.Top = this.Top;
                Options.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry, such buyer already exists in our app(");
                RegName.Text = string.Empty;
                RegPassword.Text = string.Empty;
            }
        }

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form Autorization1 = Application.OpenForms[0];
            Autorization1.Left = this.Left;
            Autorization1.Top = this.Top;
            Autorization1.Show();
            this.Hide();
        }



        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
