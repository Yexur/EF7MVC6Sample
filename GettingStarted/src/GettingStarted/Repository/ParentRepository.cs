using GettingStarted.Core;
using GettingStarted.IRepository;
using GettingStarted.Models;

namespace GettingStarted.Repository
{
    public class ParentRepository : Repository<Parent>, IParentRepository
    {
        public ParentRepository(DemoContext context) : base(context)
        {
        }
    }
}
