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
       
        public Menu()
        {
            store = new Contora();
            InitializeComponent();
            //store.FillTestData(10);
            flatBindingSource.DataSource = store.Flats;
            store.Load();
            flatBindingSource.ResetBindings(false);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void flatGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Load();
            flatBindingSource.ResetBindings(false);
        }

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

        private void AddNewFlatButton_Click_1(object sender, EventArgs e)
        {
            var pf = new NewFlat();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                store.AddFlat(pf.flat);
                flatBindingSource.ResetBindings(false);
                store.IsDirty = true;

                // select and scroll to the last row
                var lastIdx = flatGridView.Rows.Count - 1;
                flatGridView.Rows[lastIdx].Selected = true;
                flatGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }



        }

        private void autirizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Autorization = new AutorizationRealt();
            Autorization.Top = this.Top;
            Autorization.Left = this.Left;
            Autorization.ShowDialog();
            this.Hide();

        }

        private void ShowCustomersButton_Click(object sender, EventArgs e)
        {
            Form Customers = new ShowCustomers();
            Customers.Top = this.Top;
            Customers.Left = this.Left;
            Customers.ShowDialog();
        }

        
    }
}
