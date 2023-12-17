using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_Interest_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         
        

        private void button1_Click(object sender, EventArgs e)
        {
            string initialAmound = initial.Text;
            string monthlyAmount = monthly.Text;
            string timeYear = time.Text;   
            string  interestRate = rate.Text;
            string interestType = type.Text;


        }
    }
}
