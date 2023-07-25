using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Forms1
{
    public partial class FormCase2 : Form
    {
        public FormCase2()
        {
            InitializeComponent();
        }

        private void BoxWyszukajPoNr_TextChanged(object sender, EventArgs e)
        {
            var searchedNumber=Console.ReadLine();
        }

        private void BtnSzukajPoNr_Click(object sender, EventArgs e)
        {
            //var Bydlaq = new BydlaqClass();
            //Bydlaq.DisplayAnimalByNumber(BoxWyszukajPoNr.Text);
            BoxWyswietlPoNr_TextChanged(sender,e);

        }


        private void BoxWyswietlPoNr_TextChanged(object sender, EventArgs e)
        {
            string tester = "Coś się napisało";
            BoxWyswietlPoNr.Text = tester;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
