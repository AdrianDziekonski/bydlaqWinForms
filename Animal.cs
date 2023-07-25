using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
//using System.Threading.Tasks;
//using System.Data;

namespace Forms1
{
    class Animal
    {

        //Json chce pusty kontruktor
        public Animal()
        {
        }

        public Animal(string type, string number, string name, string dateOfBirth, string utylityType)
        {
            this.type = type;
            this.utylityType = utylityType;
            this.number = number;
            this.name = name;
            this.dateOfBirth = dateOfBirth;

        }

        public Animal(string type, string number, string name, string dateOfBirth, string utylityType,
            string dateOfFertilization, string dateOfCalving, string pregnant, string dateOfFutureCalving)
        {
            this.type = type;
            this.utylityType = utylityType;
            this.number = number;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.dateOfFertilization = dateOfFertilization;
            this.dateOfCalving = dateOfCalving;
            this.pregnant = pregnant;
            this.dateOfFutureCalving = dateOfFutureCalving;

        }


        public string type { get; set; }
        public string utylityType { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public string dateOfFertilization { get; set; }
        public string dateOfCalving { get; set; }
        public string pregnant { get; set; }
        public string dateOfFutureCalving { get; set; }


    }
}

