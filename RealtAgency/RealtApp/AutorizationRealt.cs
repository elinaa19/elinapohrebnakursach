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
        internal Contora store;
        const string RealtPassword = "1904";
        const string RealtName = "Elina";
        public event Action<object, EventArgs> UserChanged;
		public AutorizationRealt()
        {
            store = new Contora();
            InitializeComponent();
        }

        
        // Кнопка переходу до клієнтської авторизації
        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Form CustomerAutor = new Autorization ();
            CustomerAutor.Left = this.Left;
            CustomerAutor.Top = this.Top;
            CustomerAutor.Show();
            this.Hide();
        }
        // Енопка Close
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


        // Кнопка Enter, перевірка внесених даних
        private void buttonEnter_Click(object sender, EventArgs e)
        {
          
            string nickname = RealName.Text;
            string password = RealPassword.Text;
           
                if ( password == RealtPassword || nickname == RealtName)
                {
					this.Close();
                    Realtor user = new Realtor(nickname, password);
					UserChanged.Invoke(this, EventArgs.Empty);
			       
				}
                else
                {
                    MessageBox.Show(" Please, check your name and  pass");
                RealName.Clear();
                RealPassword.Clear();

                }
            }

        // Валідація вводу користувача

        //RealName textbox
        private void RealName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 64) && (e.KeyChar != 45) &&
                (e.KeyChar != 46) && (e.KeyChar != 95))
            {
                e.Handled = true;
            }

            RealName.MaxLength = 30;
        }

        private void RealName_TextChanged(object sender, EventArgs e)
        {
            RealName.Text = RealName.Text.Replace(" ", "");
        }
        //RealPassword TextBox

        private void RealPassword_TextChanged(object sender, EventArgs e)
        {
            RealPassword.Text = RealPassword.Text.Replace(" ", "");
        }

        private void RealPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

            RealPassword.MaxLength = 30;
        }

        private void RealPassword_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

      // Поівідомлення користувачу
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, fill all the fields to get rieltor's rights");
        }
    }
}




