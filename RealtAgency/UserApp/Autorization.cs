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
    public partial class Autorization : Form
    {
        internal Contora store;
        public Autorization()
        {
            InitializeComponent();
            this.AutPassword.AutoSize = false;
            this.AutPassword.Size = new Size(this.AutPassword.Size.Width, 23) ;
            store = new Contora();
           store.Load();


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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Form Register = new Register(ref store);

            Register.Left = this.Left;
            Register.Top = this.Top;
            Register.Show();
            this.Hide();
        }

        private void RealtorButton_Click(object sender, EventArgs e)
        {
            Form Realt = new AutorizationRealt();
            Realt.Left = this.Left;
            Realt.Top = this.Top;
            Realt.Show();
            this.Hide();

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string name = AutName.Text;
            string password = AutPassword.Text;
            if (string.IsNullOrWhiteSpace(AutName.Text) || string.IsNullOrWhiteSpace(AutPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(AutName.Text))
                {
                    AutName.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(AutPassword.Text))
                {

                    AutPassword.BackColor = Color.MediumSeaGreen;
                }
                MessageBox.Show("Fill in the blank space, please");
                AutName.BackColor = Color.White;
                AutPassword.BackColor = Color.White;
            }
            else if (AutName.Text.Length <=3 || AutName.Text.Length >= 10)
            {
                AutName.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Name has inappropriate length, try again");
                AutName.BackColor = Color.White;
                AutName.Text = string.Empty;
            }
            else if (AutPassword.Text.Length < 2 || AutPassword.Text.Length >= 10)
           
            {
                AutPassword.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Password has inappropriate length, try again");
                AutPassword.BackColor = Color.White;
                AutPassword.Text = string.Empty;
            }
            else
            {

                string nickname;
                int number;
                int pass;
               
                    nickname = AutName.Text;
                    if (store.Buyers.FirstOrDefault(u => u.Name == name && u.Password == password) != null)
                    {
                        MessageBox.Show($"Hello, Dear {name}! It's a pleasure to see you in our agency today!");
                        Form Options = new YourOptions(ref store, store.Buyers.FirstOrDefault(u => u.Name == name));
                    Options.Left = this.Left;
                        Options.Top = this.Top;
                        Options.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, such Customer doesn`t exist...Try again or sign up !");
                    }

                }
            }
        

       

        private void Autorization_Load(object sender, EventArgs e)
        {

        }
        //Name
        private void AutName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AutName_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

        private void AutName_TextChanged(object sender, EventArgs e)
        {
            AutName.Text = AutName.Text.Replace(" ", " ");
        }

        //Password Box
        private void AutPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AutPassword_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

        private void AutPassword_TextChanged(object sender, EventArgs e)
        {
            AutPassword.Text = AutPassword.Text.Replace(" ", " ");
        }
    }
}
