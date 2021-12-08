using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.Model
{
    public class ContactPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string JobTitle { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public Email Email { get; set; }
        public int EmailId { get; set; }
        public ICollection<ContactNumber> PhoneNumbers { get; set; }
    }
}
