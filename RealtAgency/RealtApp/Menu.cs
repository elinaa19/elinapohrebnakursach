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
       
        public Menu(ref Contora store)
        {
            this.store = store;
            InitializeComponent();
            store.FillTestData(10);
            flatBindingSource.DataSource = store.Flats;
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

        private void AddNewFlatButton_Click(object sender, EventArgs e)
        {
            var pf = new AddFlat();
            if (pf.ShowDialog() == DialogResult.OK)
            {
           //     store.AddFlat(pf.flat);
              //  flatBindingSource.ResetBindings(false);
               // store.IsDirty = true;

                // select and scroll to the last row
                var lastIdx = flatGridView.Rows.Count - 1;
                flatGridView.Rows[lastIdx].Selected = true;
                flatGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }



        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ShowCustomersButton_Click(object sender, EventArgs e)
        {

        }

        private void ManePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deliteFlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // var toDel = FlatList.SelectedItem as Flat;
            //  MessageBox.Show($"Delete {toDel.Name} ?");
            //store.Flats.Remove(toDel);
            var toDel = flatGridView.SelectedRows[0 ].DataBoundItem as Flat;
            var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                store.Flats.Remove(toDel);
                flatBindingSource.ResetBindings(false);
               // store.IsDirty = true;
            }

            flatBindingSource.ResetBindings(false);
          
        }

        private void editFlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toEdit = flatGridView.SelectedRows[0].DataBoundItem as Flat;
            var pf = new AddFlat(toEdit);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                flatBindingSource.ResetBindings(false);
               // store.IsDirty = true;
            }
        }
    }
}
