using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppleOs.Resources
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Commands
        public ICommand MinimizeCommand { get; set; }

        public ICommand MaximizeCommand { get; set; }

        public ICommand CloseCommand { get; set; }


        #endregion Commands
    }
}
