using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaianhShop.Data.Infrastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
        private HaiAnhShopDbContext dbContext;

        public HaiAnhShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HaiAnhShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
