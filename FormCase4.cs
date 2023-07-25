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
    public partial class FormCase4 : Form
    {
        public FormCase4()
        {
            InitializeComponent();

        }
        private void BtnWywietlWszytskie_Click(object sender, EventArgs e)
        {
            BoxWyswietlWszytskieZwierzeta_TextChanged(sender,e);
        }
        private void BoxWyswietlWszytskieZwierzeta_TextChanged(object sender, EventArgs e)
        {
            var Bydlaq=new BydlaqClass();
            string path = @"BydlaqBazaDanychForm.json";
            string text=File.ReadAllText(path);

            BoxWyswietlWszytskieZwierzeta.Text = text;
        }
        //private void wyswietlListe(Animal animal)
        //{
        //    var Bydlaq = new BydlaqClass();
        //    var Animal = new Animal();

        //    string text = ($"Rasa: {Animal.type}, Numer: {Animal.number}, Nazwa: {Animal.name}, Data urodzenia: {Animal.dateOfBirth}, Typ użytkowy: {Animal.utylityType}, Data krycia: {Animal.dateOfFertilization}, Data wycielenia: {Animal.dateOfCalving}, Czy krowa jest cielna: {Animal.pregnant}, Data planowanego wycielenia: {Animal.dateOfFutureCalving})");

        //}

    }
}
