using GettingStarted.Models;
using System.Linq;

namespace GettingStarted.Logic
{
    public interface IChildLogic
    {
        Child Get(int id);
        IQueryable<Child> GetList();
        void Save(Child child);
        void Delete(int id);
    }
}
