using System.Threading.Tasks;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Core
{
    public interface IAuthRepository
    {
        int GetCurrentUserId();
    }
}