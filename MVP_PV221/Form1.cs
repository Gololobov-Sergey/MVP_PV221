using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_PV221.View;
using MVP_PV221.Presenter;

namespace MVP_PV221
{
    public partial class Form1 : Form, IProduct
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal Count { get => numCount.Value; set => numCount.Value = value; }
        public string PriceText { get => txtPrice.Text; set => txtPrice.Text = value; }
        public string CoastText { get => labCoast.Text; set => labCoast.Text = value; }

        private void btnCoast_Click(object sender, EventArgs e)
        {
            ProductPresenter pp = new ProductPresenter(this);
            pp.Coast();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            btnCoast_Click(sender, e);
        }

        private void numCount_ValueChanged(object sender, EventArgs e)
        {
            btnCoast_Click(sender, e);
        }
    }
}
