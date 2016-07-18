using System.Linq;
using GettingStarted.Models;
using GettingStarted.IRepository;

namespace GettingStarted.Logic
{
    public class ParentLogic : IParentLogic
    {
        private readonly IParentRepository _parentRepository;

        public ParentLogic(IParentRepository parentRepository)
        {
            _parentRepository = parentRepository;
        }

        public void Delete(int id)
        {
            _parentRepository.Delete(id);
        }

        public Parent Get(int id)
        {
            return _parentRepository.FindById(id);
        }

        public IQueryable<Parent> GetList()
        {
            return _parentRepository.All();
        }

        public void Save(Parent parent)
        {
            _parentRepository.Insert(parent);
        }
    }
}
