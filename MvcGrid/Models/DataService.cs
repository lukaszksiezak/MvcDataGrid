using MvcDatagridSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CrmDataService : IDataProvider<Users>
    {
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