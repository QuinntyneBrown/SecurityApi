using Common.Data.Contracts;
using SecurityApi.Models;

namespace SecurityApi.Data.Contracts
{
    public interface ISecurityUow
    {
        IRepository<User> Users { get; }

        IRepository<Role> Roles { get;}
        
        IRepository<Group> Groups { get; }

        IRepository<Session> Sessions { get; }

        void SaveChanges();
    }
}
