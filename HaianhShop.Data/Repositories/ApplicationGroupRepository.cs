using HaianhShop.Data.Infrastructure;
using HaianhShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaianhShop.Data.Repositories
{
    public interface IApplicationGroupRepository : IRepository<ApplicationGroup>
    {
        IEnumerable<ApplicationGroup> GetListGroupByUserId(string userId);
        //IEnumerable<ApplicationUser> GetListUserByGroupId(int groupId);
    }
    public class ApplicationGroupRepository : RepositoryBase<ApplicationGroup>, IApplicationGroupRepository
    {
        public ApplicationGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<ApplicationGroup> GetListGroupByUserId(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
