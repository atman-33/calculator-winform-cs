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
        }
    }
}
