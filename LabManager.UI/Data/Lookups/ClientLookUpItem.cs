using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.Data.Lookups
{
    public class ClientLookUpItem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string Person { get; set; }
        public string JobTitle { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
