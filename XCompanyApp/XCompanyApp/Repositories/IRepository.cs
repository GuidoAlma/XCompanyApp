using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XCompanyApp.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Remove(int id);
    }
}