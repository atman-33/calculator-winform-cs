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
        }
    }
}
