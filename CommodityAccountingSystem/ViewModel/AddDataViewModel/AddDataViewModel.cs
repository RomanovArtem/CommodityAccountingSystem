using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.AddDataView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityAccountingSystem.ViewModel.AddDataViewModel
{
    public class AddDataViewModel
    {
        private IAddDataView _addDataView;
        private IMainWindows _mainWindow;


        #region Properties
        public IAddDataView AddDataView { get; set; }
        #endregion

        public AddDataViewModel(IAddDataView addDataView)
        {
            _addDataView = addDataView;
        }

        public AddDataViewModel(IMainWindows mainWindows)
        {
            _mainWindow = mainWindows;
        }
    }
}
