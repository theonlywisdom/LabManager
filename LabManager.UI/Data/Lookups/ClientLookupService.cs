using LabManager.DataAccess;
using LabManager.UI.Data.Lookups;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LabManager.UI.Data.Lookups
{
    public class ClientLookupService : IClientLookupService
    {
        private Func<DbSeedContext> _contextCreator;

        public ClientLookupService(Func<DbSeedContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<ClientLookUpItem>> GetAllAsync()
        {
            using (var ctx = _contextCreator())
            {
                var query = from c in ctx.Clients
                            join a in ctx.Addresses on c.Id equals a.ClientId into AddressClient
                            from a in AddressClient
                            join cp in ctx.ContactPeople on a.Id equals cp.AddressId into ContactAddress
                            from cp in ContactAddress
                            join e in ctx.Emails on cp.EmailId equals e.Id into EmailContact
                            from e in EmailContact
                            join ph in ctx.ContactNumbers on cp.Id equals ph.ContactPersonId into ContactNumber
                            from ph in ContactNumber.Where(phone => phone.ContactTypeId == 2)
                            select new ClientLookUpItem
                            {
                                Id = c.Id,
                                Code = c.Code,
                                Name = c.Name,
                                Address = a.Line_1 + " " + a.Line_2 + " " + a.Line_3,
                                Postcode = a.PostCode,
                                Person = cp.FirstName + " " + cp.LastName,
                                JobTitle = cp.JobTitle,
                                Email = e.ContactEmail,
                                Phone = ph.PhoneNumber
                            };

                return await query.AsNoTracking().ToListAsync();
            }
        }
    }
}
