using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppleOs.Resources
{
    /// <summary>
    /// A base view model fires Proeprty Changed events as needed
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// A global lock for property checks so prevent locking on different instances of expressions.
        /// Considering how fast this check will always be it isn't an issue to globally lock all callers.
        /// </summary>
        protected object mPropertyValueCheckLock = new object();

        /// <summary>
        /// This event is fired when any child property changes its value
        /// Parameterize the event a default lambda expression to make sure this will never be null
        /// My comprehension ( flawed ): This event will be auto set by the wpf framework, which means will be parameterized on build.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #region Command Helpers

        /// <summary>
        /// This function is for those properties, in .net, properties can't be transfered by reference, use lambda as a container to pass it as reference.
        /// What a smart way.
        /// </summary>
        /// <param name="updatingFlag"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        protected async Task RunCommandAsync(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            //Lock to ensure single access to check
            lock (mPropertyValueCheckLock)
            {
                //Check if the flag property is true ( meaning the function is already running)
                if (updatingFlag.GetPropertyValue())
                    return;

                // Set the property flag to true to indicate we are running
                updatingFlag.SetPropertyValue(true);
            }

            try
            {
                // Run the passed in action
                await action();
            }
            finally
            {
                // Set the property flag back to false, and now it's finished
                updatingFlag.SetPropertyValue(false);
            }
        }

        protected async Task<T> RunCommandAsync<T>(Expression<Func<bool>> updatingFlag, Func<Task<T>> action, T defaultValue = default)
        {
            lock (mPropertyValueCheckLock)
            {
                if (updatingFlag.GetPropertyValue())
                    return defaultValue;

                updatingFlag.SetPropertyValue(true);
            }

            try
            {
                return await action();
            }
            finally
            {
                updatingFlag.SetPropertyValue(false);
            }
        }

        #endregion Command Helpers

    }
}
