using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaianhShop.Data.Infrastructure
{
    public class Disposeable : IDisposable
    {
        private bool isDisposed;
        ~Disposeable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        //Ovveride this to dispose custom objects
        protected virtual void DisposeCore() { }
    }
}
