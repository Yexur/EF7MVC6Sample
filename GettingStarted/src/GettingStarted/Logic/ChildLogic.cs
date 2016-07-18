using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GettingStarted.Models;
using GettingStarted.IRepository;

namespace GettingStarted.Logic
{
    public class ChildLogic : IChildLogic
    {
        private readonly IChildRepository _childRepository;

        public ChildLogic(IChildRepository childRepository)
        {
            _childRepository = childRepository;
        }

        public void Delete(int id)
        {
            _childRepository.Delete(id);
        }

        public Child Get(int id)
        {
            return _childRepository.FindById(id);
        }

        public IQueryable<Child> GetList()
        {
            return _childRepository.All();
        }

        public void Save(Child child)
        {
            _childRepository.Insert(child);
        }
    }
}
