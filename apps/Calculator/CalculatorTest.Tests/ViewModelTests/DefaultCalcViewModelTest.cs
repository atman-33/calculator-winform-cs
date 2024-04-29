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

            vm.ZeroButtonExecute();
            Assert.AreEqual("0", vm.CalculateProcess);
            Assert.AreEqual("0", vm.DisplayValue);

            vm.OneButtonExecute();
            Assert.AreEqual("1", vm.CalculateProcess);
            Assert.AreEqual("1", vm.DisplayValue);

            vm.TwoButtonExecute();
            Assert.AreEqual("12", vm.CalculateProcess);
            Assert.AreEqual("12", vm.DisplayValue);

            vm.PointButtonExecute();
            Assert.AreEqual("12", vm.CalculateProcess);
            Assert.AreEqual("12.", vm.DisplayValue);

            // 2回目の小数点追加は、何もしない
            vm.PointButtonExecute();
            Assert.AreEqual("12", vm.CalculateProcess);
            Assert.AreEqual("12.", vm.DisplayValue);
        }
    }
}
