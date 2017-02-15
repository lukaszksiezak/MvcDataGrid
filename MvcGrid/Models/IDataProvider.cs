using System.Collections.Generic;

namespace WebApplication1.Models
{
    public interface IDataProvider<T>
    {
        IEnumerable<T> GetAllUsers();
        T GetById(int id);
    }
}