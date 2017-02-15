using System.Collections.Generic;

namespace MvcDataGrid.Models
{
    public interface IDataProvider<T> 
    {
        IEnumerable<T> GetAllUsers();
        T GetById(int id);
    }
}