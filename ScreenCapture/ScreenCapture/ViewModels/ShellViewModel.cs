using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Windows.Input;

namespace ScreenCapture
{
    class ShellViewModel : ViewModelBase
    {
        public ICommand OpenDialogCommand => new RelayCommand(
            (i) =>
            {
                Console.Write(i);
            });
    }
}
