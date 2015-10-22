using Common.Data;
using Common.Data.Contracts;
using SecurityApi.Data.Contracts;
using SecurityApi.Models;

namespace SecurityApi.Data
{
    public class SecurityUow : Common.Data.BaseUow, ISecurityUow
    {
        public SecurityUow(SecurityContext securityContext)
            : base(securityContext)
        {
            
        }

        public IRepository<User> Users { get { return GetStandardRepo<User>(); } }

        public IRepository<Account> Account { get { return GetStandardRepo<Account>(); } }

        public IRepository<Role> Roles { get { return GetStandardRepo<Role>(); } }

        public IRepository<Group> Groups { get { return GetStandardRepo<Group>(); } }

        public IRepository<Session> Sessions { get { return GetStandardRepo<Session>(); } }

        public void SaveChanges()
        {
            
        }

    }
}
