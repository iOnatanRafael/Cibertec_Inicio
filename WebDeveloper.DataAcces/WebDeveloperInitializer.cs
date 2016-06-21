using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAcces
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client { Name="José", LastName="Perez", DateCreation=DateTime.Now },
                new Client { Name="Juan", LastName="Perez", DateCreation=DateTime.Now },
                new Client { Name="Juanelo", LastName="Perez", DateCreation=DateTime.Now },
                new Client { Name="Alan", LastName="Perez", DateCreation=DateTime.Now },
                new Client { Name="Pedro", LastName="Perez" },
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
        }

    }
}
