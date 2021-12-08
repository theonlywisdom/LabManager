using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.Model
{
    public class Email
    {
        public int Id { get; set; }
        public string ContactEmail { get; set; }
        public ICollection<ContactPerson> ContactPeople { get; set; }
    }
}
