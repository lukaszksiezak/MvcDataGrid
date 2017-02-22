using System.Collections.Generic;

namespace MvcDataGrid.Models
{
    public interface IDataProvider<T> 
    {
        void Edit(T item);
        IEnumerable<T> GetAllUsers();
        T GetById(int id);
    }
}