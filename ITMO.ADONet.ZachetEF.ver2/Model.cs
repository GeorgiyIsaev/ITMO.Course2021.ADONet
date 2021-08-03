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
    }
    public class PetType
    {
        public int PetTypeId { get; set; }
        public string Type { get; set; }
        public string Bbreed { get; set; }
        public string Characteristic { get; set; }
        public string DopInfo { get; set; }
    }
    public class Pet
    {
        public int PetId { get; set; }
        public PetType PetTypeId { get; set; }
        public Owner OwnerId { get; set; }
        public string Name { get; set; }
        public string DataRegistr { get; set; } 
    }
}
