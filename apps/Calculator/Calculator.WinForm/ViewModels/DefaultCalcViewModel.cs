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
        /// 2ボタンを押した時の処理
        /// </summary>
        public void TwoButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(2);
            });
        }

        /// <summary>
        /// 3ボタンを押した時の処理
        /// </summary>
        public void ThreeButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(3);
            });
        }

        /// <summary>
        /// 4ボタンを押した時の処理
        /// </summary>
        public void FourButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(4);
            });
        }

        /// <summary>
        /// 5ボタンを押した時の処理
        /// </summary>
        public void FiveButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(5);
            });
        }

        /// <summary>
        /// 6ボタンを押した時の処理
        /// </summary>
        public void SixButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(6);
            });
        }

        /// <summary>
        /// 7ボタンを押した時の処理
        /// </summary>
        public void SevenButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(7);
            });
        }

        /// <summary>
        /// 8ボタンを押した時の処理
        /// </summary>
        public void EightButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(8);
            });
        }

        /// <summary>
        /// 9ボタンを押した時の処理
        /// </summary>
        public void NineButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(9);
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
