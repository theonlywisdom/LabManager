using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabManager.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<ClientCategory> ClientCategories { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
