using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tas_Kagit_Makas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_oyna_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
                     form1sec.Show();
                      this.Hide();
        }

        private void bt_cks_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_krll_Click(object sender, EventArgs e)
        {
            Form3 form3sec = new Form3();
            form3sec.Show();
            this.Hide();
        }
    }
}
