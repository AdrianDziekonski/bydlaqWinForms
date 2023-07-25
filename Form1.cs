using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCase1 oknoCase1 = new FormCase1();
            oknoCase1.ShowDialog();
        }
       

        private void button8_Click(object sender, EventArgs e)
        {

        }

       
        private void btnCase2_Click(object sender, EventArgs e)
        {
            FormCase2 oknoCase2=new FormCase2();
            oknoCase2.ShowDialog();
        }

        private void btnCase3_Click(object sender, EventArgs e)
        {
            FormCase3 oknoCase3 = new FormCase3();
            oknoCase3.ShowDialog();
        }

        private void btnCase4_Click(object sender, EventArgs e)
        {
            FormCase4 oknoCase4=new FormCase4();
            oknoCase4.ShowDialog();
            
        }

        private void btnCase5_Click(object sender, EventArgs e)
        {
            FormCase5 oknoCase5 = new FormCase5();
            oknoCase5.ShowDialog();
        }

        private void btnCase7_Click(object sender, EventArgs e)
        {
            FormCase7 oknoCase7 = new FormCase7();
            oknoCase7.ShowDialog();
        }

        private void btnCase6_Click(object sender, EventArgs e)
        {
            FormCase6 oknoCase6 = new FormCase6();
            oknoCase6.ShowDialog();
        }
    }
}
