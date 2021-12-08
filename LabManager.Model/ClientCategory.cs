using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.Model
{
    public class ClientCategory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}