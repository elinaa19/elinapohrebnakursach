using RealtAgency.Models;
using RealtAgency.RealAgencyLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtAgency.UserApp
{
    public partial class YourOptions : Form
    {
        private Contora contora;
        private List<Flat> presentFlat;
        private Buyer presentByer;
        private List <Criteria> presentCriteria;
		

        public YourOptions(ref Contora contora, Buyer buyer)
        {
          InitializeComponent();
          this.contora = contora;
           this.presentByer = buyer;
           presentFlat = new List<Flat>();
			presentFlat.AddRange(contora.Flats.Where(o => Convert.ToInt32(o.Price) == 5000));
            flatBindingSource.DataSource = presentFlat;
        }
        
        
        // Кнопка Close
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.White;

        }

        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.Red;
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

        
    }
}
