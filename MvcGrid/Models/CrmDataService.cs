using MvcDatagridSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDataGrid.Models
{
    public class CrmDataService : IDataProvider<Users>
    {
        public void Edit(Users item)
        {
            using (var context = new SampleCRMEntities())
            {
                context.Users.Attach(item);
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<Users> GetAllUsers()
        {
            using (var context = new SampleCRMEntities())
            {
                return context.Users.ToList();
            }
        }

        public Users GetById(int id)
        {
            using (var context = new SampleCRMEntities())
            {                
                return context.Users.Where(u => u.UsersID.Equals(id)).Single();
            }
        }
    }
}