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

        private TextBox[] textBoxNames;
        private int resizeSpace = 40;
        

        public BillSplitter()
        {
            InitializeComponent();

            textBoxNames = new TextBox[] { txtName1, txtName2, txtName3, txtName4, txtName5, txtName6 };
            txtName1.Text = "Dairo";
            txtName2.Text = "Joren";
        }


        private void BillSplitter_Load(object sender, EventArgs e)
        {
            lblQuantity.Text = Quantity.ToString();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Splitter splitter = new Splitter();
            splitter.PersonList = GetNames();
            splitter.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Quantity < 6)
            {
                Quantity++;
                lblQuantity.Text = Quantity.ToString();

                Size = new Size(Width, Height + resizeSpace);
                gbxNames.Size = new Size(gbxNames.Width, gbxNames.Height + resizeSpace);

                textBoxNames[Quantity-1].Visible = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Quantity > 2)
            {
                Quantity--;
                lblQuantity.Text = Quantity.ToString();

                Size = new Size(Width, Height - resizeSpace);
                gbxNames.Size = new Size(gbxNames.Width, gbxNames.Height - resizeSpace);

                textBoxNames[Quantity].Visible = false;
            }
        }

        private List<Person> GetNames()
        {
            List<Person> temp = new List<Person>();

            for (int i = 0; i < Quantity; i++)
            {
                temp.Add(new Person { Name = textBoxNames[i].Text, Bills = new List<double> { 12.10, 25.00 } });

            }

            return temp;
        }
    }
}
