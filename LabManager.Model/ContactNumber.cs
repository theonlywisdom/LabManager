using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.Model
{
    public class ContactNumber
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public ContactPerson ContactPerson { get; set; }
        public int ContactPersonId { get; set; }
        public ContactType ContactType { get; set; }
        public int ContactTypeId { get; set; }
    }
}
