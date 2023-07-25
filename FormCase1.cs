using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using Forms1;


namespace Forms1
{
    public partial class FormCase1 : Form
    {

        public FormCase1()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BoxRasa_TextChanged(object sender, EventArgs e)
        {
            string type = Console.ReadLine();
        }

        private void BoxNrIdent_TextChanged(object sender, EventArgs e)
        {
            var number = Console.ReadLine();
        }

        private void BoxNazwa_TextChanged(object sender, EventArgs e)
        {
            var name = Console.ReadLine();
        }

        private void BoxDataUr_TextChanged(object sender, EventArgs e)
        {

            var dateOfBirth = Console.ReadLine();
        }

        private void BoxTypUzytkowy_TextChanged(object sender, EventArgs e)
        {
            var Bydlaq = new BydlaqClass();
            var utilityType = Console.ReadLine();

            if (BoxTypUzytkowy.Text == "krowa")
            {
                BoxCielnosc.Enabled = true;
                BoxDataKrycia.Enabled = true;
                BoxDataWycielenia.Enabled = true;
                BoxPlanowaneWycielenie.Enabled = true;
            }
            else
            {
                BoxCielnosc.Enabled = false;
                BoxCielnosc.Text = "Informacja dotyczy tylko krów";
                BoxDataKrycia.Enabled = false;
                BoxDataKrycia.Text = "Informacja dotyczy tylko krów";
                BoxDataWycielenia.Enabled = false;
                BoxDataWycielenia.Text = "Informacja dotyczy tylko krów";
                BoxPlanowaneWycielenie.Enabled = false;
                BoxPlanowaneWycielenie.Text = "Informacja dotyczy tylko krów";

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BoxDataKrycia_TextChanged(object sender, EventArgs e)
        {
            var dateOfFertilization = Console.ReadLine();
        }
        private void BoxDataWycielenia_TextChanged(object sender, EventArgs e)
        {
            var dateOfCalving = Console.ReadLine();
        }

        private void BoxCielnosc_TextChanged(object sender, EventArgs e)
        {
            var pregnant= Console.ReadLine();   
        }

        private void BoxPlanowaneWycielenie_TextChanged(object sender, EventArgs e)
        {
            var Bydlaq = new BydlaqClass();
            var dateOfFutureCalving= Console.ReadLine();
        }

        private void btnDodajZwierze_Click(object sender, EventArgs e)// string type,string number, string name, string dateOfBirth, string utilityType, string dateOfFertilization, string dateOfCalving, string pregnant, string dateOfFutureCalving )
        {
            var Bydlaq = new BydlaqClass();
          
            
            Bydlaq.DeserializeJsonDatabase();
            switch (BoxTypUzytkowy.Text)//?????????????
            {
                case "jałówka":

                    var newAnimalJalowka = new Animal(BoxRasa.Text, BoxNrIdent.Text, BoxNazwa.Text, BoxDataUr.Text, BoxTypUzytkowy.Text);
                    Bydlaq.AddAnimal(newAnimalJalowka);
                    break;

                case "byk":

                    var newAnimalByk = new Animal(BoxRasa.Text, BoxNrIdent.Text, BoxNazwa.Text, BoxDataUr.Text, BoxTypUzytkowy.Text);
                    Bydlaq.AddAnimal(newAnimalByk);
                    break;

                case "krowa":

                    var newAnimalKrowa = new Animal(BoxRasa.Text, BoxNrIdent.Text, BoxNazwa.Text, BoxDataUr.Text, BoxTypUzytkowy.Text, BoxDataKrycia.Text, BoxDataWycielenia.Text, BoxCielnosc.Text, BoxPlanowaneWycielenie.Text);

                    Bydlaq.AddAnimal(newAnimalKrowa);
                    break;


            }
            Bydlaq.JsonAnimalsSaveToDatabase();
            MessageBox.Show("Dodano zwięrzę", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wyczyscFormularz();

        }

        private void wyczyscFormularz()
        {
            BoxRasa.Text = "";
            BoxNrIdent.Text = "";
            BoxNazwa.Text = "";
            BoxDataUr.Text = "";
            BoxTypUzytkowy.Text = "";
            BoxDataKrycia.Text = "";
            BoxDataWycielenia.Text = "";
            BoxCielnosc.Text = "";
            BoxPlanowaneWycielenie.Text = "";
        }

        private void labelWprowadznazwe_Click(object sender, EventArgs e)
        {

        }

        private void labelWprowadzDateUr_Click(object sender, EventArgs e)
        {

        }
    }
}
