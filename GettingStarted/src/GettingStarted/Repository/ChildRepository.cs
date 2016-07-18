using GettingStarted.Core;
using GettingStarted.IRepository;
using GettingStarted.Models;

namespace GettingStarted.Repository
{
    public class ChildRepository : Repository<Child>, IChildRepository
    {
        public ChildRepository(DemoContext context) : base(context)
        {
        }
    }
}
