using System;
using RealtAgency.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RealtAgency.RealAgencyLibrary.Models;
using RealtAgency.Models;

namespace RealtAgency
{
    public partial class Menu : Form
    {
        internal Contora store;
        private AutorizationRealt ar;
        private bool isAdmin;
        public Menu()
        {
            store = new Contora();
            InitializeComponent();
            flatBindingSource.DataSource = store.Flats;
            store.Load();
            flatBindingSource.ResetBindings(false);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        
        // Видалення елементу зі списку
        private void deliteFlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toDel = flatGridView.SelectedRows[0 ].DataBoundItem as Flat;
            var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                store.Flats.Remove(toDel);
                flatBindingSource.ResetBindings(false);
               store.IsDirty = true;
            }

            flatBindingSource.ResetBindings(false);
          
        }


        //Редагування елементу у списку
        private void editFlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toEdit = flatGridView.SelectedRows[0].DataBoundItem as Flat;
            var pf = new NewFlat(toEdit);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                flatBindingSource.ResetBindings(false);
               store.IsDirty = true;
            }
        }

       
        // Кнопка Load
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Load();
            flatBindingSource.ResetBindings(false);
        }

        // Закриття форми, збереження даних
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!store.IsDirty)
                return;
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    store.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        // Додавання квартири у список
        private void AddNewFlatButton_Click_1(object sender, EventArgs e)
        {
            var pf = new NewFlat();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                store.AddFlat(pf.flat);
                flatBindingSource.ResetBindings(false);
                store.IsDirty = true;
                var lastIdx = flatGridView.Rows.Count - 1;
                flatGridView.Rows[lastIdx].Selected = true;
                flatGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }

        }

        //Відкриття кнопки для авторизованого ріелтора
        private void autirizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ar = new AutorizationRealt();
            ar.UserChanged += UserAuthorisation;
			ar.Top = this.Top;
            ar.Left = this.Left;
            ar.ShowDialog();

        }
        //event handler
        private void UserAuthorisation(object sender, EventArgs e)
        {
	        isAdmin = !isAdmin;
	        ShowCustomersButton.Visible = true;
        }

		private void ShowCustomersButton_Click(object sender, EventArgs e)
        {
            Form Customers = new ShowCustomers();
            Customers.Top = this.Top;
            Customers.Left = this.Left;
            Customers.ShowDialog();
        }

       //Кнопка Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Save();
        }

        // Пошук
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
		
			Flat fl = new Flat();
			List<Flat> flats = new List<Flat>();
            try
            {
                fl.Name = toolStripTextBox1.Text;
                flats.AddRange(store.Flats.Where(o => o.Name == fl.Name));
                flatBindingSource.DataSource = flats;
            }
            
            catch
            {
                flats = store.Flats;
            }
			flatBindingSource.ResetBindings(false);
			store.IsDirty = true;
			store.Load();
		}

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Flat fl = new Flat();
            List<Flat> flats = new List<Flat>();
            try
            {
                fl.Adress = toolStripTextBox1.Text;
                flats.AddRange(store.Flats.Where(o => o.Adress == fl.Adress));
                flatBindingSource.DataSource = flats;
            }

            catch
            {
                flats = store.Flats;
            }
            flatBindingSource.ResetBindings(false);
            store.IsDirty = true;
            store.Load();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Flat fl = new Flat();
            List<Flat> flats = new List<Flat>();
            try
            {
                fl.Neighbourhood = toolStripTextBox1.Text;
                flats.AddRange(store.Flats.Where(o => o.Neighbourhood == fl.Neighbourhood));
                flatBindingSource.DataSource = flats;
            }

            catch
            {
                flats = store.Flats;
            }
            flatBindingSource.ResetBindings(false);
            store.IsDirty = true;
            store.Load();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Flat fl = new Flat();
            List<Flat> flats = new List<Flat>();
            try
            {
                fl.Rooms = toolStripTextBox1.Text;
                flats.AddRange(store.Flats.Where(o => Convert.ToInt32(o.Rooms) == Convert.ToInt32(fl.Rooms)));
                flatBindingSource.DataSource = flats;
            }

            catch
            {
                flats = store.Flats;
            }
            flatBindingSource.ResetBindings(false);
            store.IsDirty = true;
            store.Load();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Flat fl = new Flat();
            List<Flat> flats = new List<Flat>();
            try
            {
                fl.Price = toolStripTextBox1.Text;
                flats.AddRange(store.Flats.Where(o => Convert.ToInt32(o.Price) == Convert.ToInt32(fl.Price)));
                flatBindingSource.DataSource = flats;
            }

            catch
            {
                flats = store.Flats;
            }
            flatBindingSource.ResetBindings(false);
            store.IsDirty = true;
            store.Load();
        }
        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flatBindingSource.DataSource = store.Flats;
            store.Load();
            flatBindingSource.ResetBindings(false);
        }

        // Повідомлення користувачу
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are on the main form now, click help if you have any problems");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "To get access to the instriction click Cправка",
            "Cправка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1,
            0,
            "https://github.com/elinaa19/elinapohrebnakursach/tree/master/Docs",
            "keyword");
        }
       
    }
}
