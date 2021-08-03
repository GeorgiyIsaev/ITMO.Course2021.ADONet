using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADONet.Zachet
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DocumentNumber { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
    public class PetType
    {
        public int PetTypeId { get; set; }
        public string TypeAnimal { get; set; }
        public string Breed { get; set; }
        public string Characteristic { get; set; }
        public string DopInfo { get; set; }

        public override string ToString()
        {
            return TypeAnimal + " Порода: " + Breed;
        }
    }
    public class Pet
    {
        public int PetId { get; set; }
        public int PetTypeId { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string DataRegistr { get; set; } 
    }
}
