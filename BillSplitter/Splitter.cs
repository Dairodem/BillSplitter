using System;
using System.Collections.Generic;
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

        private void ResetBillsList()
        {
            lbxBills.DataSource = null;
            lbxBills.DataSource = currPerson.Bills;
        }// resets the billsList
        private double GetTotalfromBills()
        {
            double total = 0;

            foreach (double bill in currPerson.Bills)
            {
                total += bill;
            }
            currPerson.Total = total;

            return total;
        } // adds all the bills to total
        private void btnCalc_Click(object sender, EventArgs e)
        {

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
            txtTotal.Text = GetTotalfromBills().ToString();

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                double entry = Convert.ToDouble(txtEntry.Text);

                currPerson.Bills.Add(entry);
                ResetBillsList();
                txtTotal.Text = GetTotalfromBills().ToString();

            }
            catch 
            {
                MessageBox.Show("Not a valid entry!");
            }
        }
    }
}
