using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAcces
{
    public class ClientData
    {
        public List<Client> GetFakeData()
        {
            return new List<Client>
            {
                new Client { ID=1, Name="Juan", LastName="Perez" },
                new Client { ID=2, Name="Raul", LastName="Cuidiaz" }
            };
        }

        public List<Client> GetList()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Clients.ToList();
            }
        }

    }
}
