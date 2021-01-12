using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillSplitter
{
    public partial class BillSplitter : Form
    {
        public int Quantity = 2;
        private int resizeSpace = 30;

        public BillSplitter()
        {
            InitializeComponent();
        }


        private void BillSplitter_Load(object sender, EventArgs e)
        {
            lblQuantity.Text = Quantity.ToString();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Splitter splitter = new Splitter();
            splitter.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Quantity < 6)
            {
                Quantity++;
                lblQuantity.Text = Quantity.ToString();

                this.Size = new Size(Width, Height + resizeSpace);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Quantity > 2)
            {
                Quantity--;
                lblQuantity.Text = Quantity.ToString();
                this.Size = new Size(Width, Height - resizeSpace);
            }
        }
    }
}
