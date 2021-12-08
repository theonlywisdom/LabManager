using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Line_1 { get; set; }
        public string Line_2 { get; set; }
        public string Line_3 { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public string PostCode { get; set; }
        public string AddressType { get; set; }
        public ICollection<ContactPerson> ContactPeople { get; set; }
    }
}
