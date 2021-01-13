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
    public partial class Splitter : Form
    {
        public List<Person> PersonList = new List<Person>();
        Person currPerson = new Person ();

        public Splitter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToParent();

            lbxNames.DataSource = PersonList;
            lbxNames.SelectedIndex = 0;
            currPerson = (Person)lbxNames.SelectedItem;

        }

        private void lbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            currPerson = (Person)lbxNames.SelectedItem;
            ResetBillsList();


        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                double entry = Convert.ToDouble(txtEntry.Text);
                currPerson.Bills.Add(entry);
                ResetBillsList();

            }
            catch 
            {
                MessageBox.Show("Not a valid entry!");
            }
        }
        private void ResetBillsList()
        {
            lbxBills.DataSource = null;
            lbxBills.DataSource = currPerson.Bills;
        }
    }
}
