using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAcces
{
    public class ClientData : BaseDataAccess<Client>
    {
        public Client GetClientById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Clients.FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
