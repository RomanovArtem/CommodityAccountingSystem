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
        /// Переход ко Второй вьюшке
        /// </summary>
        private RelayCommand _LoadSecondUCCommand;

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
        public IMainWindows CodeBehind { get; set; }
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

        public RelayCommand LoadSecondUCCommand
        {
            get
            {
                return _LoadSecondUCCommand = _LoadSecondUCCommand ??
                  new RelayCommand(OnLoadSecondUC, CanLoadSecondUC);
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
            CodeBehind.LoadView(ViewType.First);
        }

        private bool CanLoadSecondUC()
        {
            return true;
        }
        private void OnLoadSecondUC()
        {
            CodeBehind.LoadView(ViewType.Second);
        }

        private bool CanLoadMainUC()
        {
            return true;
        }
        private void OnLoadMainUC()
        {
            CodeBehind.LoadView(ViewType.Main);
        }
        #endregion
    }
}
