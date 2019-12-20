using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class NationalityRepository : Repository<Nationality>, INationalityRepository
    {
        public NationalityRepository(DataContext context)
            : base(context)
        {
        }
    }
}