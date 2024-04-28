using WinFormBoilerplate.WinForm.ViewModels;

namespace Calculator.WinForm.ViewModels
{
    /// <summary>
    /// 電卓画面ViewModel
    /// </summary>
    public class DefaultCalcViewModel : ViewModelBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DefaultCalcViewModel()
        {
            //Debug.WriteLine("---- DefaultCalcViewModel Created! ----");
        }

        private string _calculateProcess = string.Empty;
        /// <summary>
        /// 計算プロセス
        /// </summary>
        public string CalculateProcess
        {
            get { return _calculateProcess; }
            set { SetProperty(ref _calculateProcess, value); }
        }

        private string _displayValue = string.Empty;
        /// <summary>
        /// 値の表示部分（計算結果、入力値を表示）
        /// </summary>
        public string DisplayValue
        {
            get { return _displayValue; }
            set { SetProperty(ref _displayValue, value); }
        }
    }
}
