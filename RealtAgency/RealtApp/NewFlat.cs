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

        // To update an existing product.
        public NewFlat(Flat Flat) : this()
        {
            flat = Flat;
            //  nameBox.Text = product.Name;
            // unitBox.Text = product.Unit;
            // priceBox.Value = product.Price;
            //  pictureBox.Image = product.Image;
            nameField.Text = Flat.Name;
            adressField.Text = Flat.Adress;
            neighField.Text = Flat.Neighbourhood;
            roomsField.Text = Flat.Rooms;
            conditionField.Text = Flat.Condition;
            priceField.Text = Flat.Price;
            coordsField.Text = Flat.Coords;
            Flat.Image = null;
        }


            private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.Red;
        }

        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.White;
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

        private void ManePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
        private void RequiredValidate(Control c, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.Pink;
                e.Cancel = true;
            }
        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
} 
