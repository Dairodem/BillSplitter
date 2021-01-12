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
        public List<string> NameList = new List<string>();

        public Splitter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToParent();

            lbxNames.DataSource = NameList;
        }

    }
}
