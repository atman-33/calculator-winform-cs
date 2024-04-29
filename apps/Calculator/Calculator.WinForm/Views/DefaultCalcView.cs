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
    }
}
