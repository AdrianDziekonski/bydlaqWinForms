using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class FormCase6 : Form
    {
        public FormCase6()
        {
            InitializeComponent();
        }

        private void BoxUsunZwierzePoNazwie_TextChanged(object sender, EventArgs e)
        {
            var deleteAnimal=Console.ReadLine();
        }
        private void BtnUsunZwierze_Click(object sender, EventArgs e)
        {
            var Bydlaq=new BydlaqClass();
            var Animal = new Animal();
            Bydlaq.DeleteAnimalByName(BoxUsunZwierzePoNazwie.Text); 
        }

        
    }
}
