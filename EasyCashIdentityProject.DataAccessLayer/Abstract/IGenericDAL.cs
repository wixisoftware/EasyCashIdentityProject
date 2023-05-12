using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {

        // Temelde 5 adet metot var

        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        T GetByID(int id);

        List<T> GetAll();

    }
}
