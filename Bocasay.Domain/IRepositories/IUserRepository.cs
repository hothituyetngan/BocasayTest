using Bocasay.Domain.Models;

namespace Bocasay.Domain.IRepositories
{
    public interface IUserRepository
    {
        void Create(User user);
    }
}
