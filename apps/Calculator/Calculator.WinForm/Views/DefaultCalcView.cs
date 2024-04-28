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
    }
}
