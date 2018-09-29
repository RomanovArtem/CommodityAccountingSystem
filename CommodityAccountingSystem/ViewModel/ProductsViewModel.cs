using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityAccountingSystem.ViewModel
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        public ProductsViewModel(IMainWindows mainWindows)
        {
            _mainWindow = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
