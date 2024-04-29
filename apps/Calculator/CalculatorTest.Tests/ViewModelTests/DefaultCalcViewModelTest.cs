using Calculator.WinForm.ViewModels;

namespace CalculatorTest.Tests.ViewModelTests
{
    [TestClass]
    public class DefaultCalcViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var vm = new DefaultCalcViewModel();

            Assert.AreEqual("", vm.CalculateProcess);
            Assert.AreEqual("", vm.DisplayValue);

            // 0
            vm.ZeroButtonExecute();
            Assert.AreEqual("0", vm.CalculateProcess);
            Assert.AreEqual("0", vm.DisplayValue);

            // 1
            vm.OneButtonExecute();
            Assert.AreEqual("1", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // 2
            vm.TwoButtonExecute();
            Assert.AreEqual("12", vm.CalculateProcess);
            Assert.AreEqual("12", vm.DisplayValue);

            // .
            vm.PointButtonExecute();
            Assert.AreEqual("12", vm.CalculateProcess);
            Assert.AreEqual("12.", vm.DisplayValue);

            // . (2回目の小数点追加は、何もしない)
            vm.PointButtonExecute();
            Assert.AreEqual("12", vm.CalculateProcess);
            Assert.AreEqual("12.", vm.DisplayValue);

            // +
            vm.AddButtonExecute();
            Assert.AreEqual("12 +", vm.CalculateProcess);
            Assert.AreEqual("12", vm.DisplayValue);

            // -
            vm.SubtractButtonExecute();
            Assert.AreEqual("12 -", vm.CalculateProcess);
            Assert.AreEqual("12", vm.DisplayValue);

            // 2
            vm.TwoButtonExecute();
            Assert.AreEqual("12 -", vm.CalculateProcess);
            Assert.AreEqual("2", vm.DisplayValue);

            // =
            vm.EqualButtonExecute();
            Assert.AreEqual("12 - 2 =", vm.CalculateProcess);
            Assert.AreEqual("10", vm.DisplayValue);

            // 1 (=後の数値入力は、リセットされる)
            vm.OneButtonExecute();
            Assert.AreEqual("1", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);
        }

        [TestMethod]
        public void 小数点処理()
        {
            var vm = new DefaultCalcViewModel();

            Assert.AreEqual("", vm.CalculateProcess);
            Assert.AreEqual("", vm.DisplayValue);

            // 1
            vm.OneButtonExecute();
            Assert.AreEqual("1", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // +
            vm.AddButtonExecute();
            Assert.AreEqual("1 +", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // 2
            vm.TwoButtonExecute();
            Assert.AreEqual("1 +", vm.CalculateProcess);
            Assert.AreEqual("2", vm.DisplayValue);

            // =
            vm.EqualButtonExecute();
            Assert.AreEqual("1 + 2 =", vm.CalculateProcess);
            Assert.AreEqual("3", vm.DisplayValue);

            // .
            vm.PointButtonExecute();
            Assert.AreEqual("0", vm.CalculateProcess);
            Assert.AreEqual("0.", vm.DisplayValue);

            // 0
            vm.ZeroButtonExecute();
            Assert.AreEqual("0", vm.CalculateProcess);
            Assert.AreEqual("0.0", vm.DisplayValue);

            // 1
            vm.OneButtonExecute();
            Assert.AreEqual("0.01", vm.CalculateProcess);
            Assert.AreEqual("0.01", vm.DisplayValue);

            // +
            vm.AddButtonExecute();
            Assert.AreEqual("0.01 +", vm.CalculateProcess);
            Assert.AreEqual("0.01", vm.DisplayValue);

            // 0
            vm.ZeroButtonExecute();
            Assert.AreEqual("0.01 +", vm.CalculateProcess);
            Assert.AreEqual("0", vm.DisplayValue);

            // .
            vm.PointButtonExecute();
            Assert.AreEqual("0.01 +", vm.CalculateProcess);
            Assert.AreEqual("0.", vm.DisplayValue);

            // 2
            vm.TwoButtonExecute();
            Assert.AreEqual("0.01 +", vm.CalculateProcess);
            Assert.AreEqual("0.2", vm.DisplayValue);

            // =
            vm.EqualButtonExecute();
            Assert.AreEqual("0.01 + 0.2 =", vm.CalculateProcess);
            Assert.AreEqual("0.21", vm.DisplayValue);
        }

        [TestMethod]
        public void 連続計算()
        {
            var vm = new DefaultCalcViewModel();

            Assert.AreEqual("", vm.CalculateProcess);
            Assert.AreEqual("", vm.DisplayValue);

            // 1
            vm.OneButtonExecute();
            Assert.AreEqual("1", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // +
            vm.AddButtonExecute();
            Assert.AreEqual("1 +", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // 2
            vm.TwoButtonExecute();
            Assert.AreEqual("1 +", vm.CalculateProcess);
            Assert.AreEqual("2", vm.DisplayValue);

            // +
            vm.AddButtonExecute();
            Assert.AreEqual("3 +", vm.CalculateProcess);
            Assert.AreEqual("3", vm.DisplayValue);

        }

        [TestMethod]
        public void 掛け算()
        {
            var vm = new DefaultCalcViewModel();

            Assert.AreEqual("", vm.CalculateProcess);
            Assert.AreEqual("", vm.DisplayValue);

            // 1
            vm.OneButtonExecute();
            Assert.AreEqual("1", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // ×
            vm.MultiplyExecute();
            Assert.AreEqual("1 ×", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // 2
            vm.TwoButtonExecute();
            Assert.AreEqual("1 ×", vm.CalculateProcess);
            Assert.AreEqual("2", vm.DisplayValue);

            // =
            vm.EqualButtonExecute();
            Assert.AreEqual("1 × 2 =", vm.CalculateProcess);
            Assert.AreEqual("2", vm.DisplayValue);
        }

        [TestMethod]
        public void 割り算()
        {
            var vm = new DefaultCalcViewModel();

            Assert.AreEqual("", vm.CalculateProcess);
            Assert.AreEqual("", vm.DisplayValue);

            // 1
            vm.OneButtonExecute();
            Assert.AreEqual("1", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // ÷
            vm.DivideExecute();
            Assert.AreEqual("1 ÷", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // 2
            vm.TwoButtonExecute();
            Assert.AreEqual("1 ÷", vm.CalculateProcess);
            Assert.AreEqual("2", vm.DisplayValue);

            // =
            vm.EqualButtonExecute();
            Assert.AreEqual("1 ÷ 2 =", vm.CalculateProcess);
            Assert.AreEqual("0.5", vm.DisplayValue);
        }

        [TestMethod]
        public void 符号を変更()
        {
            var vm = new DefaultCalcViewModel();

            Assert.AreEqual("", vm.CalculateProcess);
            Assert.AreEqual("", vm.DisplayValue);

            // 1
            vm.OneButtonExecute();
            Assert.AreEqual("1", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            // +/-
            vm.ReverseNumberSign();
            Assert.AreEqual("-1", vm.CalculateProcess);
            Assert.AreEqual("-1", vm.DisplayValue);

            // +
            vm.AddButtonExecute();
            Assert.AreEqual("-1 +", vm.CalculateProcess);
            Assert.AreEqual("-1", vm.DisplayValue);

            // 2
            vm.TwoButtonExecute();
            Assert.AreEqual("-1 +", vm.CalculateProcess);
            Assert.AreEqual("2", vm.DisplayValue);

            // +/-
            vm.ReverseNumberSign();
            Assert.AreEqual("-1 +", vm.CalculateProcess);
            Assert.AreEqual("-2", vm.DisplayValue);

            // =
            vm.EqualButtonExecute();
            Assert.AreEqual("-1 + -2 =", vm.CalculateProcess);
            Assert.AreEqual("-3", vm.DisplayValue);
        }
    }
}
