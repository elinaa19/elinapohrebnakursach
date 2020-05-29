using RealtAgency.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtAgency
{
    public partial class NewFlat : Form
    {
        public Flat flat{ set; get; }


        Contora store;
        public NewFlat()
        {
            store = new Contora();
            InitializeComponent();
        }

        // Редагування квартири
        public NewFlat(Flat Flat) : this()
        {
            flat = Flat;
            nameField.Text = Flat.Name;
            adressField.Text = Flat.Adress;
            neighField.Text = Flat.Neighbourhood;
            roomsField.Text = Flat.Rooms;
            conditionField.Text = Flat.Condition;
            priceField.Text = Flat.Price;
            coordsField.Text = Flat.Coords;
            Flat.Image = null;
        }

        // Кнопка Close
            private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка Back
        private void BackButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        // Кнопка Close
        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.Red;
        }

        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.White;
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

        //Закриття форми, збереження даних
        private void AddFlat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
            RequiredValidate(nameField, e);
            RequiredValidate(adressField, e);
            RequiredValidate(neighField, e);
            RequiredValidate(roomsField, e);
            RequiredValidate(conditionField, e);
            RequiredValidate(priceField, e);
            RequiredValidate(coordsField, e);
        }

        // Валідація вводу користувача
        private void RequiredValidate(Control c, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.Pink;
                e.Cancel = true;
            }
        }

        //Додавання квартири
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (flat == null)
            {
                flat = new Flat();
            }
            flat.Name = nameField.Text;
            flat.Adress = adressField.Text;
            flat.Neighbourhood = neighField.Text;
            flat.Rooms = roomsField.Text;
            flat.Condition = conditionField.Text;
            flat.Price = priceField.Text;
            flat.Coords = coordsField.Text;
            flat.Image = pictureBox1.Image;
        }
        
        //Зображення
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

       
        //Валідація вводу користувача
        private void priceField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void roomsField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void conditionField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void neighField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void coordsField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
} 
