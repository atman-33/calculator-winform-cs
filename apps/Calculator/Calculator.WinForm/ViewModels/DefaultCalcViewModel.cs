using Calculator.Domain.Entities;
using WinFormBoilerplate.WinForm.ViewModels;

namespace Calculator.WinForm.ViewModels
{
    /// <summary>
    /// 電卓画面ViewModel
    /// </summary>
    public class DefaultCalcViewModel : ViewModelBase
    {
        /// <summary>
        /// 現在の計算結果エンティティ（表示中の計算結果）
        /// </summary>
        private CalculationResultEntity _currentResultEntity;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DefaultCalcViewModel()
        {
            //Debug.WriteLine("---- DefaultCalcViewModel Created! ----");
            _currentResultEntity = new CalculationResultEntity();
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

        /// <summary>
        /// 0ボタンを押した時の処理
        /// </summary>
        public void ZeroButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(0);
            });
        }

        /// <summary>
        /// 1ボタンを押した時の処理
        /// </summary>
        public void OneButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(1);
            });
        }

        /// <summary>
        /// ボタン押下時の汎用処理
        /// </summary>
        /// <param name="resultEntity">最新の計算結果エンティティ。呼び出し元で処理を実装すること。</param>
        private void ButtonExecute(Action<CalculationResultEntity> resultEntity)
        {
            var newEntity = new CalculationResultEntity(_currentResultEntity);
            newEntity.PrevEntity = _currentResultEntity;
            _currentResultEntity.NextEntity = newEntity;

            _currentResultEntity = newEntity;
            resultEntity(newEntity);

            CalculateProcess = _currentResultEntity.Process;
            DisplayValue = _currentResultEntity.DisplayValue;
        }
    }
}
