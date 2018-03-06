using System;

namespace CourseScheduler.EF
{
    public class Disposable
        : IDisposable
    {
        private bool _isDisposed;

        ~Disposable()
        {
            Dispose(true);
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

        /// <summary>
        /// Override this to dispose custom objects
        /// </summary>
        protected virtual void DisposeCore()
        {

        }
    }
}