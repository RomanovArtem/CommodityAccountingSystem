using CommodityAccountingSystem.View;

namespace CommodityAccountingSystem.ViewModel
{
    public class MenuViewModel
    {
        #region Fields
        /// <summary>
        /// Переход к первой вьюшке
        /// </summary>
        private RelayCommand _LoadFirstUCCommand;

        /// <summary>
        /// Переход ко вью данных
        /// </summary>
        private RelayCommand _LoadDataViewCommand;

        /// <summary>
        /// Возвращение к главной вьюшке
        /// </summary>
        private RelayCommand _LoadMainUCCommand;
        #endregion

        #region Constructors
        public MenuViewModel()
        {

        }
        #endregion

        #region Properties
        public IMainWindows MainWindows { get; set; }
        #endregion

        #region Command
        public RelayCommand LoadFirstUCCommand
        {
            get
            {
                return _LoadFirstUCCommand = _LoadFirstUCCommand ??
                  new RelayCommand(OnLoadFirstUC, CanLoadFirstUC);
            }
        }

        public RelayCommand LoadDataViewCommand
        {
            get
            {
                return _LoadDataViewCommand = _LoadDataViewCommand ??
                  new RelayCommand(OnLoadDataView, CanLoadDataView);
            }
        }

        public RelayCommand LoadMainUCCommand
        {
            get
            {
                return _LoadMainUCCommand = _LoadMainUCCommand ??
                  new RelayCommand(OnLoadMainUC, CanLoadMainUC);
            }
        }
        #endregion

        #region Methods
        private bool CanLoadFirstUC()
        {
            return true;
        }
        private void OnLoadFirstUC()
        {
            MainWindows.LoadView(ViewType.First);
        }

        private bool CanLoadDataView()
        {
            return true;
        }
        private void OnLoadDataView()
        {
            MainWindows.LoadView(ViewType.DataView);
        }

        private bool CanLoadMainUC()
        {
            return true;
        }
        private void OnLoadMainUC()
        {
            MainWindows.LoadView(ViewType.Main);
        }
        #endregion
    }
}
