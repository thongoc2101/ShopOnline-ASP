using System;

namespace Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        // kế thừa interface này sẽ tự động huỷ cài đặt các phương thức
        private bool _isDisposed;

        ~Disposable()
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
            if (!_isDisposed && disposing)
            {
                DisposeCore();
            }

            _isDisposed = true;
        }

        // Ovveride this dispose custom object
        protected virtual void DisposeCore()
        {

        }
    }
}
