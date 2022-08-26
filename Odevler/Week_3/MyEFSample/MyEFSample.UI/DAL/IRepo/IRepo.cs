using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSample.UI.DAL.IRepo
{
    public interface IRepo<T> where T : class
    {
        List<T> Select();
        T Insert(T eklenecekVeri);
        int Delete(object ID);
        int Update(T guncellenecekVeri);
        //List<T> SelectByFilter(Expression<Func<T, bool>> filter);
        //T SelectByID(object ID);

        //int SoftDelete(object ID);

    }
}
