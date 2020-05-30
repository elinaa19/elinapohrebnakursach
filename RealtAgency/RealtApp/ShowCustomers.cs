using RealtAgency.Models;
using RealtAgency.RealAgencyLibrary.Models;
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
    public partial class ShowCustomers : Form
    {
        internal Contora store;
        public ShowCustomers()
        {
            store = new Contora();
            InitializeComponent();
           // store.FillTestData(20);
            store.Load();
           // store.Save();
            buyerBindingSource.DataSource = store.Buyers;
            buyerBindingSource.ResetBindings(false);
           

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

        private void CancelButton_Click(object sender, EventArgs e)
        {
          
            
            this.Hide();

        }

        private void ShowCustomers_Load(object sender, EventArgs e)
        {
            customersGridView.Rows[0].Selected = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var toDel = customersGridView.SelectedRows[0].DataBoundItem as Buyer;
            var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                store.Buyers.Remove(toDel);
                buyerBindingSource.ResetBindings(false);
                store.IsDirty = true;
            }

            buyerBindingSource.ResetBindings(false);

        }

        private void ShowCustomers_FormClosing(object sender, FormClosingEventArgs e)
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
    }
    }


