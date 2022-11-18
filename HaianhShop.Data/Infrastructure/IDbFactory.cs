using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaianhShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HaiAnhShopDbContext Init();
    }
}
