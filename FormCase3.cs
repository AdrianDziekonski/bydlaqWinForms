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
using Newtonsoft.Json;


namespace Forms1
{
    public partial class FormCase3 : Form
    {
        


        public FormCase3()
        {
            InitializeComponent();
        }

        private void BoxWyszukajPoNazwie_TextChanged(object sender, EventArgs e)
        {
            var searchedName = Console.ReadLine();
        }

        private void BtnSzukajPoNazwie_Click(object sender, EventArgs e)
        {
            var Bydlaq = new BydlaqClass();
            BoxWyswietlPoNazwie_TextChanged(sender, e);
           
        }
       

        private void BoxWyswietlPoNazwie_TextChanged(object sender, EventArgs e)
        {
            //WyswietlWBoxiePoNazwie(BoxWyswietlPoNazwie,BoxWyszukajPoNazwie.Text);
            WyswietlAnimal(BoxWyswietlPoNazwie);

        }

        private void WyswietlWBoxiePoNazwie (TextBox textBox, string searchedName)
        {
            var Bydlaq = new BydlaqClass();
            var Animal = new Animal();
            Bydlaq.DeserializeJsonDatabase();

            //for (int i = 0; i < Animals.Count; i++)
            //{

            //}
            
            if (Animal.name==searchedName)
            {
                textBox.Text = $"Rasa: {Animal.type}, Numer: {Animal.number}, Nazwa: {Animal.name}, Data urodzenia: {Animal.dateOfBirth}, Typ użytkowy: {Animal.utylityType}, Data krycia: {Animal.dateOfFertilization}, Data wycielenia: {Animal.dateOfCalving}, Czy krowa jest cielna: {Animal.pregnant}, Data planowanego wycielenia: {Animal.dateOfFutureCalving} ";
            }
            else
            {
                MessageBox.Show("Nie ma zwierzęcia o podanej nazwie","Ostrzeżenie",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void WyswietlAnimal(TextBox text)
         {
            var Bydlaq = new BydlaqClass();
            var Animal = new Animal();

            Bydlaq.DisplayAnimalByName(BoxWyszukajPoNazwie.Text);
            Bydlaq.JsonAnimalsSaveToSearchByName();

            string path = @"BydlaqBazaDanychFormSearchedByName.json";
            string badumc = JsonConvert.SerializeObject(File.ReadAllText(path));

            text.Text = badumc;



            

        }

        //private string WyswietlForeachAnimal(List<Animal> animals)
        //{
        //    foreach (var animal in animals)
            
        //    {
        //        WyswietlAnimal(animal);
        //    }
        //}


        private void FormCase3_Load(object sender, EventArgs e)
        {

        }
    }

}
