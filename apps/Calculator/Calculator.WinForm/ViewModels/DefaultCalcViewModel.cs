using Calculator.Domain.Entities;
using System.Diagnostics;
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
            _currentResultEntity = new CalculationResultEntity("0");
            CalculateProcess = _currentResultEntity.Process;
            DisplayValue = _currentResultEntity.DisplayValue;
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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

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
            if (!_currentResultEntity.CanAddNumber())
            {
                Debug.WriteLine("小数点桁数上限を超過しました。");
                return;
            }

            ButtonExecute(resultEntity =>
            {
                resultEntity.SetNumber(9);
            });
        }

        /// <summary>
        /// +/-ボタンを押した時の処理
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void ReverseNumberSign()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.ReverseNumberSign();
            });
        }

        /// <summary>
        /// .ボタンを押した時の処理
        /// </summary>
        public void PointButtonExecute()
        {
            if (!_currentResultEntity.CanAddPoint())
            {
                Debug.WriteLine("既に小数点を追加済みのため、小数点は追加しません。");
                return;
            }

            ButtonExecute(resultEntity =>
            {
                resultEntity.SetPoint();
            });
        }

        /// <summary>
        /// +ボタンを押した時の処理
        /// </summary>
        public void AddButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetAdd();
            });
        }

        /// <summary>
        /// -ボタンを押した時の処理
        /// </summary>
        public void SubtractButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetSubtract();
            });
        }

        /// <summary>
        /// ×ボタンを押した時の処理
        /// </summary>
        public void MultiplyExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetMultiply();
            });
        }

        /// <summary>
        /// ÷ボタンを押した時の処理
        /// </summary>
        public void DivideExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetDivide();
            });
        }

        /// <summary>
        /// =ボタンを押した時の処理
        /// </summary>
        public void EqualButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.SetEqual();
            });
        }

        /// <summary>
        /// Cボタンを押した時の処理
        /// </summary>
        public void ClearButtonExecute()
        {
            ButtonExecute(resultEntity =>
            {
                resultEntity.Clear();
            });
        }

        /// <summary>
        /// 戻るボタンを押した時の処理
        /// </summary>
        public void BackButtonExecute()
        {
            if (_currentResultEntity.PrevEntity is null)
            {
                Debug.WriteLine("前回の操作がありません！");
                return;
            }
            _currentResultEntity = _currentResultEntity.PrevEntity;
            CalculateProcess = _currentResultEntity.Process;
            DisplayValue = _currentResultEntity.DisplayValue;
        }

        /// <summary>
        /// 進むボタンを押した時の処理
        /// </summary>
        public void NextButtonExecute()
        {
            if (_currentResultEntity.NextEntity is null)
            {
                Debug.WriteLine("次の操作がありません！");
                return;
            }
            _currentResultEntity = _currentResultEntity.NextEntity;
            CalculateProcess = _currentResultEntity.Process;
            DisplayValue = _currentResultEntity.DisplayValue;
        }

        /// <summary>
        /// ボタン押下時の汎用処理
        /// </summary>
        /// <param name="resultEntity">最新の計算結果エンティティ。呼び出し元で処理を実装すること。</param>
        private void ButtonExecute(Action<CalculationResultEntity> resultEntity)
        {
            // TODO: 無限にリストを繋いでいく処理になっているため、処理を記録する上限機能を設ける。

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
