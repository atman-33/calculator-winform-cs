using Calculator.WinForm.ViewModels;

namespace Calculator.WinForm
{
    /// <summary>
    /// 電卓画面
    /// </summary>
    public partial class DefaultCalcView : BaseForm
    {
        /// <summary>
        /// ViewModel
        /// </summary>
        private DefaultCalcViewModel _viewModel = new DefaultCalcViewModel();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DefaultCalcView()
        {
            InitializeComponent();

            CalculateProcessLabel.DataBindings.Add(
                nameof(CalculateProcessLabel.Text), _viewModel, nameof(_viewModel.CalculateProcess));
            DisplayValueTextBox.DataBindings.Add(
                nameof(DisplayValueTextBox.Text), _viewModel, nameof(_viewModel.DisplayValue));
        }

        /// <summary>
        /// 0ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.ZeroButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 1ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.OneButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 2ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.TwoButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 3ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.ThreeButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 4ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.FourButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 5ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.FiveButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 6ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.SixButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 7ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.SevenButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 8ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.EightButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// 9ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.NineButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// +/-ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.ReverseNumberSign();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// .ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PointButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.PointButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// +ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.AddButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// -ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.SubtractButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// ×ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.MultiplyExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// ÷ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.DivideExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// =ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.EqualButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }

        /// <summary>
        /// Cボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.ClearButtonExecute();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod()
            );
        }
    }
}
