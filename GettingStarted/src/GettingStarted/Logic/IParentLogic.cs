using GettingStarted.Models;
using System.Linq;

namespace GettingStarted.Logic
{
    public interface IParentLogic
    {
        Parent Get(int id);
        IQueryable<Parent> GetList();
        void Save(Parent parent);
        void Delete(int id);
    }
}
