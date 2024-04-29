namespace Calculator.Domain.Modules.Helpers
{
    /// <summary>
    /// 小数点数値ヘルパー
    /// </summary>
    public static class DecimalHelper
    {
        /// <summary>
        /// 文字列の数値の小数点桁数を返す。
        /// </summary>
        /// <param name="numberString"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int GetDecimalPlaces(string numberString)
        {
            // 数字の文字列をdoubleに変換して小数点以下の部分を取得
            double number;
            if (!double.TryParse(numberString, out number))
            {
                throw new ArgumentException("不正な数値文字列です。", nameof(numberString));
            }

            // 文字列が小数点を含んでいるか確認し、含んでいる場合は小数点以下の桁数を取得
            int decimalIndex = numberString.IndexOf('.');
            if (decimalIndex != -1)
            {
                return numberString.Length - decimalIndex - 1;
            }

            // 小数点が含まれていない場合は0を返す
            return 0;
        }
    }
}
