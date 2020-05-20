using RealtAgency.Models;
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
    public partial class AutorizationRealt : Form
    {
       
        const string RealtPassword = "1904";
        const string RealtName = "Elina";
        public AutorizationRealt()
        {
           
            InitializeComponent();
        }

        

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Form CustomerAutor = Application.OpenForms[0];
            CustomerAutor.Left = this.Left;
            CustomerAutor.Top = this.Top;
            CustomerAutor.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
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

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // Берем введенные данные с полей
            string nickname = RealName.Text;
            string password = RealPassword.Text;
           
                if ( password == RealtPassword || nickname == RealtName)
                {
                    Realtor user = new Realtor(nickname, password);
                    
                Form Menu = new Menu();
                Menu.Left = this.Left;
                Menu.Top = this.Top;
                Menu.Show();
                this.Hide();

            }
                else
                {
                    MessageBox.Show(" Please, check your name and  pass");
                }
            }
            
                
    }
}




