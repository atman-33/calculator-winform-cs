namespace Calculator.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// ログ
        /// </summary>
        private static log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // NOTE: 出力テスト用
            //_logger.Debug("デバッグのログ");
            //_logger.Info("インフォのログ");
            //_logger.Warn("警告のログ");
            //_logger.Error("エラーのログ");
            //_logger.Fatal("致命的なログ");

            Application.Run(new DefaultCalcView());
        }
    }
}