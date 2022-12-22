using HaianhShop.Data.Infrastructure;
using HaianhShop.Model.Models;

namespace HaianhShop.Data.Repositories
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {

    }
    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
